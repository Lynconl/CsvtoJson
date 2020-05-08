using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvtoJson
{
    public partial class Form1 : Form
    {
        int contadorBarra = 1;
        List<string> linhaJson = new List<string>();
        Queue<string> linhas;
        string[] cabecalho;
        string caminhoArquivo, diretorio;

        public Form1()
        {
            InitializeComponent();            
        }

        private async void bttnCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Selecione o Arquivo CSV para transformar em JSON";
            fileDialog.Filter = "csv files (*.csv)|*.csv";
            fileDialog.ShowDialog();

            var tempoTotal = new Stopwatch();
            tempoTotal.Start();

            caminhoArquivo = fileDialog.FileName;
            diretorio = Path.GetDirectoryName(caminhoArquivo);
            txtBxArquivo.Text = caminhoArquivo;
            
            IniciaProcesso();
            progressBarLendo.Value = 100;
            progressBarMontando.Value = 100;
            
            string nomeArquivo = fileDialog.SafeFileName;
            string caminhoJson = diretorio + "\\" + nomeArquivo.Split('.')[0] + ".json";
            StreamWriter gravar = new StreamWriter(caminhoJson);
            List<string> jsonFinal = new List<string>();           

            jsonFinal.Add("[");
            for (int i = 0; i < linhaJson.Count; i++)
            {
                if (i != linhaJson.Count - 1)
                {
                    jsonFinal.Add(linhaJson[i] + ",");
                }
                else
                {
                    jsonFinal.Add(linhaJson[i]);
                }
            }
            jsonFinal.Add("]");

            progressBarLoad.Maximum = jsonFinal.Count;

            foreach (string l in jsonFinal)
            {                
                gravar.WriteLine(l);
                progressBarLoad.Value = contadorBarra;
                contadorBarra++;                
            }
            gravar.Close();

            tempoTotal.Stop();
            Console.WriteLine("Tempo Total: " + tempoTotal.ElapsedMilliseconds);

            MessageBox.Show("Arquivo gerado com sucesso! salvo na pasta: " + caminhoJson,"Atenção");
            Thread.Sleep(1500);
            Close();
            
        }
        private void LerLinhas()
        {
            linhas = new Queue<string>();
            string linha = null;            
            StreamReader reader = new StreamReader(@caminhoArquivo, Encoding.Default);          
           
            cabecalho = reader.ReadLine().Split(',');
            while ((linha = reader.ReadLine()) != null)
            {
                linhas.Enqueue(linha);
            }
            reader.Close();           
        }
        private void IniciaProcesso()
        {
            Thread t = new Thread(LerLinhas);
            t.Start();
            t.Join();            

            int nTasks = 5;
            for (int i = 0; i < nTasks; i++)
            {
                Thread p = new Thread(ProcessaFila);
                p.Start();                
                p.Join();
            }
        }
        private void ProcessaFila()
        {            
            if (linhas != null)
            {
                while (linhas.Count > 0)
                {
                    string linha = linhas.Dequeue();

                    string montagemJson = "";
                    for (int i = 0; i < cabecalho.Length; i++)
                    {
                        if (i == 0) montagemJson += "\t{\n";
                        else if (i == cabecalho.Length - 1) montagemJson += "\n\t}";
                        else montagemJson += "\t\t\"" + cabecalho[i] + "\": \"" + linha.Split(',')[i] + "\",\n";
                    }

                    linhaJson.Add(montagemJson);
                }
            }
        }        
    }
}
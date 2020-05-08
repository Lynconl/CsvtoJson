namespace CsvtoJson
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMensagem2 = new System.Windows.Forms.Label();
            this.txtBxArquivo = new System.Windows.Forms.TextBox();
            this.progressBarLoad = new System.Windows.Forms.ProgressBar();
            this.bttnCarregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarMontando = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarLendo = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblMensagem2
            // 
            this.lblMensagem2.AutoSize = true;
            this.lblMensagem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem2.ForeColor = System.Drawing.Color.White;
            this.lblMensagem2.Location = new System.Drawing.Point(321, 339);
            this.lblMensagem2.Name = "lblMensagem2";
            this.lblMensagem2.Size = new System.Drawing.Size(170, 16);
            this.lblMensagem2.TabIndex = 9;
            this.lblMensagem2.Text = "Gravando Arquivo Json";
            // 
            // txtBxArquivo
            // 
            this.txtBxArquivo.Location = new System.Drawing.Point(12, 12);
            this.txtBxArquivo.Multiline = true;
            this.txtBxArquivo.Name = "txtBxArquivo";
            this.txtBxArquivo.Size = new System.Drawing.Size(655, 29);
            this.txtBxArquivo.TabIndex = 8;
            // 
            // progressBarLoad
            // 
            this.progressBarLoad.Location = new System.Drawing.Point(112, 358);
            this.progressBarLoad.Name = "progressBarLoad";
            this.progressBarLoad.Size = new System.Drawing.Size(577, 46);
            this.progressBarLoad.TabIndex = 7;
            // 
            // bttnCarregar
            // 
            this.bttnCarregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnCarregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnCarregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.bttnCarregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCarregar.ForeColor = System.Drawing.Color.White;
            this.bttnCarregar.Location = new System.Drawing.Point(673, 12);
            this.bttnCarregar.Name = "bttnCarregar";
            this.bttnCarregar.Size = new System.Drawing.Size(115, 29);
            this.bttnCarregar.TabIndex = 6;
            this.bttnCarregar.Text = "Carregar Arquivo";
            this.bttnCarregar.UseVisualStyleBackColor = false;
            this.bttnCarregar.Click += new System.EventHandler(this.bttnCarregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(321, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Montando Arquivo Json";
            // 
            // progressBarMontando
            // 
            this.progressBarMontando.Location = new System.Drawing.Point(112, 224);
            this.progressBarMontando.Name = "progressBarMontando";
            this.progressBarMontando.Size = new System.Drawing.Size(577, 46);
            this.progressBarMontando.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(332, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lendo Arquivo Csv";
            // 
            // progressBarLendo
            // 
            this.progressBarLendo.Location = new System.Drawing.Point(112, 102);
            this.progressBarLendo.Name = "progressBarLendo";
            this.progressBarLendo.Size = new System.Drawing.Size(577, 46);
            this.progressBarLendo.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarLendo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarMontando);
            this.Controls.Add(this.lblMensagem2);
            this.Controls.Add(this.txtBxArquivo);
            this.Controls.Add(this.progressBarLoad);
            this.Controls.Add(this.bttnCarregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem2;
        private System.Windows.Forms.TextBox txtBxArquivo;
        private System.Windows.Forms.ProgressBar progressBarLoad;
        private System.Windows.Forms.Button bttnCarregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarMontando;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBarLendo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


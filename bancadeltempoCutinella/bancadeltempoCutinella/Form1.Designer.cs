
namespace bancadeltempoCutinella
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOrdinaPrestazioni = new System.Windows.Forms.Button();
            this.btnSegreteria = new System.Windows.Forms.Button();
            this.btnDebito = new System.Windows.Forms.Button();
            this.lstPrestazioni = new System.Windows.Forms.ListBox();
            this.lstSegreteria = new System.Windows.Forms.ListBox();
            this.lstDebito = new System.Windows.Forms.ListBox();
            this.lstSoci = new System.Windows.Forms.ListBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrdinaPrestazioni
            // 
            this.btnOrdinaPrestazioni.Location = new System.Drawing.Point(19, 13);
            this.btnOrdinaPrestazioni.Name = "btnOrdinaPrestazioni";
            this.btnOrdinaPrestazioni.Size = new System.Drawing.Size(75, 23);
            this.btnOrdinaPrestazioni.TabIndex = 0;
            this.btnOrdinaPrestazioni.Text = "Prestazioni";
            this.btnOrdinaPrestazioni.UseVisualStyleBackColor = true;
            // 
            // btnSegreteria
            // 
            this.btnSegreteria.Location = new System.Drawing.Point(275, 13);
            this.btnSegreteria.Name = "btnSegreteria";
            this.btnSegreteria.Size = new System.Drawing.Size(75, 23);
            this.btnSegreteria.TabIndex = 1;
            this.btnSegreteria.Text = "Segreteria";
            this.btnSegreteria.UseVisualStyleBackColor = true;
            // 
            // btnDebito
            // 
            this.btnDebito.Location = new System.Drawing.Point(19, 176);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(75, 23);
            this.btnDebito.TabIndex = 2;
            this.btnDebito.Text = "Debito";
            this.btnDebito.UseVisualStyleBackColor = true;
            // 
            // lstPrestazioni
            // 
            this.lstPrestazioni.FormattingEnabled = true;
            this.lstPrestazioni.Location = new System.Drawing.Point(19, 54);
            this.lstPrestazioni.Name = "lstPrestazioni";
            this.lstPrestazioni.Size = new System.Drawing.Size(222, 95);
            this.lstPrestazioni.TabIndex = 4;
            this.lstPrestazioni.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lstSegreteria
            // 
            this.lstSegreteria.FormattingEnabled = true;
            this.lstSegreteria.Location = new System.Drawing.Point(275, 54);
            this.lstSegreteria.Name = "lstSegreteria";
            this.lstSegreteria.Size = new System.Drawing.Size(222, 95);
            this.lstSegreteria.TabIndex = 5;
            // 
            // lstDebito
            // 
            this.lstDebito.FormattingEnabled = true;
            this.lstDebito.Location = new System.Drawing.Point(19, 220);
            this.lstDebito.Name = "lstDebito";
            this.lstDebito.Size = new System.Drawing.Size(222, 95);
            this.lstDebito.TabIndex = 6;
            // 
            // lstSoci
            // 
            this.lstSoci.FormattingEnabled = true;
            this.lstSoci.Location = new System.Drawing.Point(275, 220);
            this.lstSoci.Name = "lstSoci";
            this.lstSoci.Size = new System.Drawing.Size(222, 95);
            this.lstSoci.TabIndex = 7;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(241, 170);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(32, 29);
            this.btnReload.TabIndex = 8;
            this.btnReload.Text = "R";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(521, 331);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lstSoci);
            this.Controls.Add(this.lstDebito);
            this.Controls.Add(this.lstSegreteria);
            this.Controls.Add(this.lstPrestazioni);
            this.Controls.Add(this.btnDebito);
            this.Controls.Add(this.btnSegreteria);
            this.Controls.Add(this.btnOrdinaPrestazioni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrdinaPrestazioni;
        private System.Windows.Forms.Button btnSegreteria;
        private System.Windows.Forms.Button btnDebito;
        private System.Windows.Forms.ListBox lstPrestazioni;
        private System.Windows.Forms.ListBox lstSegreteria;
        private System.Windows.Forms.ListBox lstDebito;
        private System.Windows.Forms.ListBox lstSoci;
        private System.Windows.Forms.Button btnReload;
    }
}


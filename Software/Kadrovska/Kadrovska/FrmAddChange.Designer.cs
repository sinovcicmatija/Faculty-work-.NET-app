namespace Kadrovska {
    partial class FrmAddChange {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnPosalji = new System.Windows.Forms.Button();
            this.cbmZahtjevi = new System.Windows.Forms.ComboBox();
            this.lbZahtjev = new System.Windows.Forms.Label();
            this.lbNapomena = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(489, 365);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(266, 44);
            this.btnPosalji.TabIndex = 4;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // cbmZahtjevi
            // 
            this.cbmZahtjevi.FormattingEnabled = true;
            this.cbmZahtjevi.Location = new System.Drawing.Point(26, 114);
            this.cbmZahtjevi.Name = "cbmZahtjevi";
            this.cbmZahtjevi.Size = new System.Drawing.Size(319, 24);
            this.cbmZahtjevi.TabIndex = 5;
            this.cbmZahtjevi.SelectedIndexChanged += new System.EventHandler(this.cbmZahtjevi_SelectedIndexChanged);
            // 
            // lbZahtjev
            // 
            this.lbZahtjev.AutoSize = true;
            this.lbZahtjev.Location = new System.Drawing.Point(23, 88);
            this.lbZahtjev.Name = "lbZahtjev";
            this.lbZahtjev.Size = new System.Drawing.Size(94, 16);
            this.lbZahtjev.TabIndex = 6;
            this.lbZahtjev.Text = "Vrsta zahtjeva:";
            // 
            // lbNapomena
            // 
            this.lbNapomena.AutoSize = true;
            this.lbNapomena.Location = new System.Drawing.Point(473, 88);
            this.lbNapomena.Name = "lbNapomena";
            this.lbNapomena.Size = new System.Drawing.Size(78, 16);
            this.lbNapomena.TabIndex = 7;
            this.lbNapomena.Text = "Napomena:";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(476, 127);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(296, 196);
            this.txtNapomena.TabIndex = 8;
            this.txtNapomena.TextChanged += new System.EventHandler(this.txtNapomena_TextChanged);
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(171, 33);
            this.btnNatrag.TabIndex = 9;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // FrmAddChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.lbNapomena);
            this.Controls.Add(this.lbZahtjev);
            this.Controls.Add(this.cbmZahtjevi);
            this.Controls.Add(this.btnPosalji);
            this.Name = "FrmAddChange";
            this.Text = "FrmAddChange";
            this.Load += new System.EventHandler(this.FrmAddChange_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.ComboBox cbmZahtjevi;
        private System.Windows.Forms.Label lbZahtjev;
        private System.Windows.Forms.Label lbNapomena;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Button btnNatrag;
    }
}
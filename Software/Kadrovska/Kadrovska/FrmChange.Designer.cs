namespace Kadrovska {
    partial class FrmChange {
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
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.btnSpremiPromjene = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVrstaZahtjeva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(474, 137);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(303, 218);
            this.txtNapomena.TabIndex = 0;
            this.txtNapomena.TextChanged += new System.EventHandler(this.txtNapomena_TextChanged);
            // 
            // btnSpremiPromjene
            // 
            this.btnSpremiPromjene.Location = new System.Drawing.Point(524, 392);
            this.btnSpremiPromjene.Name = "btnSpremiPromjene";
            this.btnSpremiPromjene.Size = new System.Drawing.Size(215, 35);
            this.btnSpremiPromjene.TabIndex = 1;
            this.btnSpremiPromjene.Text = "Spremi promjene";
            this.btnSpremiPromjene.UseVisualStyleBackColor = true;
            this.btnSpremiPromjene.Click += new System.EventHandler(this.btnSpremiPromjene_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Napomena:";
            // 
            // txtVrstaZahtjeva
            // 
            this.txtVrstaZahtjeva.Location = new System.Drawing.Point(25, 122);
            this.txtVrstaZahtjeva.Name = "txtVrstaZahtjeva";
            this.txtVrstaZahtjeva.Size = new System.Drawing.Size(208, 22);
            this.txtVrstaZahtjeva.TabIndex = 3;
            this.txtVrstaZahtjeva.TextChanged += new System.EventHandler(this.txtVrstaZahtjeva_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vrsta zahtjeva:";
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(159, 32);
            this.btnNatrag.TabIndex = 5;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // FrmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVrstaZahtjeva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpremiPromjene);
            this.Controls.Add(this.txtNapomena);
            this.Name = "FrmChange";
            this.Text = "FrmChange";
            this.Load += new System.EventHandler(this.FrmChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Button btnSpremiPromjene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVrstaZahtjeva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNatrag;
    }
}
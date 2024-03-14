namespace Kadrovska {
    partial class FrmOverview {
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
            this.btnNewRequest = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.Location = new System.Drawing.Point(646, 415);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Size = new System.Drawing.Size(159, 36);
            this.btnNewRequest.TabIndex = 0;
            this.btnNewRequest.Text = "Novi zahtjev";
            this.btnNewRequest.UseVisualStyleBackColor = true;
            this.btnNewRequest.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(58, 69);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(747, 323);
            this.DataGridView1.TabIndex = 3;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(302, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Izbriši zahtjev";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(58, 41);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(150, 22);
            this.txtPretrazi.TabIndex = 5;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(245, 16);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(145, 32);
            this.btnPretrazi.TabIndex = 6;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Location = new System.Drawing.Point(421, 16);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(150, 35);
            this.btnOsvjezi.TabIndex = 7;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(478, 414);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(151, 35);
            this.btnUredi.TabIndex = 8;
            this.btnUredi.Text = "Uredi zahtjev";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pretraži po vrsti zahtjeva:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(64, 414);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 37);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Izlaz iz aplikacije";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 514);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btnNewRequest);
            this.Name = "FrmOverview";
            this.Text = "Pregled zahtjeva";
            this.Load += new System.EventHandler(this.FrmOverview_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}


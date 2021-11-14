namespace arabalar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gecir = new System.Windows.Forms.Button();
            this.modeller = new System.Windows.Forms.ComboBox();
            this.sec = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.yil_baslangic = new System.Windows.Forms.TextBox();
            this.km_bitis = new System.Windows.Forms.TextBox();
            this.km_baslangic = new System.Windows.Forms.TextBox();
            this.yil_bitis = new System.Windows.Forms.TextBox();
            this.sec_2 = new System.Windows.Forms.Button();
            this.sec_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(843, 273);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gecir
            // 
            this.gecir.Location = new System.Drawing.Point(901, 12);
            this.gecir.Name = "gecir";
            this.gecir.Size = new System.Drawing.Size(75, 23);
            this.gecir.TabIndex = 1;
            this.gecir.Text = "Marka";
            this.gecir.UseVisualStyleBackColor = true;
            this.gecir.Click += new System.EventHandler(this.gecir_Click);
            // 
            // modeller
            // 
            this.modeller.FormattingEnabled = true;
            this.modeller.Location = new System.Drawing.Point(996, 11);
            this.modeller.Name = "modeller";
            this.modeller.Size = new System.Drawing.Size(121, 24);
            this.modeller.TabIndex = 2;
            this.modeller.SelectedIndexChanged += new System.EventHandler(this.modeller_SelectedIndexChanged);
            // 
            // sec
            // 
            this.sec.Location = new System.Drawing.Point(1134, 12);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(75, 23);
            this.sec.TabIndex = 3;
            this.sec.Text = "Listele";
            this.sec.UseVisualStyleBackColor = true;
            this.sec.Click += new System.EventHandler(this.sec_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 322);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(843, 273);
            this.dataGridView3.TabIndex = 5;
            // 
            // yil_baslangic
            // 
            this.yil_baslangic.Location = new System.Drawing.Point(901, 359);
            this.yil_baslangic.Name = "yil_baslangic";
            this.yil_baslangic.Size = new System.Drawing.Size(100, 22);
            this.yil_baslangic.TabIndex = 6;
            // 
            // km_bitis
            // 
            this.km_bitis.Location = new System.Drawing.Point(1134, 408);
            this.km_bitis.Name = "km_bitis";
            this.km_bitis.Size = new System.Drawing.Size(100, 22);
            this.km_bitis.TabIndex = 7;
            // 
            // km_baslangic
            // 
            this.km_baslangic.Location = new System.Drawing.Point(1134, 359);
            this.km_baslangic.Name = "km_baslangic";
            this.km_baslangic.Size = new System.Drawing.Size(100, 22);
            this.km_baslangic.TabIndex = 8;
            // 
            // yil_bitis
            // 
            this.yil_bitis.Location = new System.Drawing.Point(901, 409);
            this.yil_bitis.Name = "yil_bitis";
            this.yil_bitis.Size = new System.Drawing.Size(100, 22);
            this.yil_bitis.TabIndex = 9;
            // 
            // sec_2
            // 
            this.sec_2.Location = new System.Drawing.Point(1134, 454);
            this.sec_2.Name = "sec_2";
            this.sec_2.Size = new System.Drawing.Size(75, 23);
            this.sec_2.TabIndex = 10;
            this.sec_2.Text = "Seç";
            this.sec_2.UseVisualStyleBackColor = true;
            this.sec_2.Click += new System.EventHandler(this.sec_2_Click);
            // 
            // sec_1
            // 
            this.sec_1.Location = new System.Drawing.Point(901, 454);
            this.sec_1.Name = "sec_1";
            this.sec_1.Size = new System.Drawing.Size(75, 23);
            this.sec_1.TabIndex = 11;
            this.sec_1.Text = "Seç";
            this.sec_1.UseVisualStyleBackColor = true;
            this.sec_1.Click += new System.EventHandler(this.sec_1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(898, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Yıl aralığı seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1131, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Km aralığı seçiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 607);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sec_1);
            this.Controls.Add(this.sec_2);
            this.Controls.Add(this.yil_bitis);
            this.Controls.Add(this.km_baslangic);
            this.Controls.Add(this.km_bitis);
            this.Controls.Add(this.yil_baslangic);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.modeller);
            this.Controls.Add(this.gecir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button gecir;
        private System.Windows.Forms.ComboBox modeller;
        private System.Windows.Forms.Button sec;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox yil_baslangic;
        private System.Windows.Forms.TextBox km_bitis;
        private System.Windows.Forms.TextBox km_baslangic;
        private System.Windows.Forms.TextBox yil_bitis;
        private System.Windows.Forms.Button sec_2;
        private System.Windows.Forms.Button sec_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


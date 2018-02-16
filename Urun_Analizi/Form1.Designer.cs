namespace Urun_Analizi
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
            this.txtSicaklik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYagis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSetTrain = new System.Windows.Forms.Button();
            this.lblSetName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDeniz = new System.Windows.Forms.ComboBox();
            this.btnClassify = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUrun = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSicaklik
            // 
            this.txtSicaklik.Location = new System.Drawing.Point(141, 56);
            this.txtSicaklik.Name = "txtSicaklik";
            this.txtSicaklik.Size = new System.Drawing.Size(237, 22);
            this.txtSicaklik.TabIndex = 0;
            this.txtSicaklik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSicaklik_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sıcaklık ( C° ) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nem ( % ) :";
            // 
            // txtNem
            // 
            this.txtNem.Location = new System.Drawing.Point(141, 84);
            this.txtNem.Name = "txtNem";
            this.txtNem.Size = new System.Drawing.Size(237, 22);
            this.txtNem.TabIndex = 2;
            this.txtNem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNem_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yağış ( Yıllık ) :";
            // 
            // txtYagis
            // 
            this.txtYagis.Location = new System.Drawing.Point(141, 112);
            this.txtYagis.Name = "txtYagis";
            this.txtYagis.Size = new System.Drawing.Size(237, 22);
            this.txtYagis.TabIndex = 4;
            this.txtYagis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYagis_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Denize Kenarı :";
            // 
            // btnSetTrain
            // 
            this.btnSetTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSetTrain.ForeColor = System.Drawing.Color.Black;
            this.btnSetTrain.Location = new System.Drawing.Point(21, 23);
            this.btnSetTrain.Name = "btnSetTrain";
            this.btnSetTrain.Size = new System.Drawing.Size(357, 55);
            this.btnSetTrain.TabIndex = 8;
            this.btnSetTrain.Text = "SET TRAINING DATASET";
            this.btnSetTrain.UseVisualStyleBackColor = true;
            this.btnSetTrain.Click += new System.EventHandler(this.btnSetTrain_Click);
            // 
            // lblSetName
            // 
            this.lblSetName.AutoSize = true;
            this.lblSetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSetName.Location = new System.Drawing.Point(17, 93);
            this.lblSetName.Name = "lblSetName";
            this.lblSetName.Size = new System.Drawing.Size(15, 20);
            this.lblSetName.TabIndex = 9;
            this.lblSetName.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(16, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bölgenin istenen iklim koşulları:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetTrain);
            this.groupBox1.Controls.Add(this.lblSetName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 142);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training Dataset";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClassify);
            this.groupBox2.Controls.Add(this.cmbDeniz);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSicaklik);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtYagis);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 246);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Data";
            // 
            // cmbDeniz
            // 
            this.cmbDeniz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeniz.FormattingEnabled = true;
            this.cmbDeniz.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.cmbDeniz.Location = new System.Drawing.Point(141, 140);
            this.cmbDeniz.Name = "cmbDeniz";
            this.cmbDeniz.Size = new System.Drawing.Size(237, 24);
            this.cmbDeniz.TabIndex = 11;
            // 
            // btnClassify
            // 
            this.btnClassify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClassify.ForeColor = System.Drawing.Color.Black;
            this.btnClassify.Location = new System.Drawing.Point(21, 170);
            this.btnClassify.Name = "btnClassify";
            this.btnClassify.Size = new System.Drawing.Size(357, 55);
            this.btnClassify.TabIndex = 10;
            this.btnClassify.Text = "CLASSIFY !";
            this.btnClassify.UseVisualStyleBackColor = true;
            this.btnClassify.Click += new System.EventHandler(this.btnClassify_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblUrun);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(413, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 403);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrun.Location = new System.Drawing.Point(6, 327);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(16, 24);
            this.lblUrun.TabIndex = 1;
            this.lblUrun.Text = "-";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(846, 436);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Urun Yetistirme Analizi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSicaklik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYagis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSetTrain;
        private System.Windows.Forms.Label lblSetName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClassify;
        private System.Windows.Forms.ComboBox cmbDeniz;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


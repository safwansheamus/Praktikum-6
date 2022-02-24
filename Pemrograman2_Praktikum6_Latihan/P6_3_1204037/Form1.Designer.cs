namespace P6_3_1204044
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbProdi = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbNpm = new System.Windows.Forms.TextBox();
            this.tbNotelp = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.rbJk1 = new System.Windows.Forms.RadioButton();
            this.rbJk2 = new System.Windows.Forms.RadioButton();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.mcTgllahir = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM INPUT DATA MAHASISWA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NPM                       :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama                     :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Lahir      :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jenis Kelamin     :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alamat                  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "No Telepon         :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Program Studi     :";
            // 
            // cbProdi
            // 
            this.cbProdi.FormattingEnabled = true;
            this.cbProdi.Location = new System.Drawing.Point(179, 491);
            this.cbProdi.Name = "cbProdi";
            this.cbProdi.Size = new System.Drawing.Size(121, 21);
            this.cbProdi.TabIndex = 8;
            this.cbProdi.SelectedIndexChanged += new System.EventHandler(this.cbProdi_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tbNpm
            // 
            this.tbNpm.Location = new System.Drawing.Point(179, 89);
            this.tbNpm.Name = "tbNpm";
            this.tbNpm.Size = new System.Drawing.Size(100, 20);
            this.tbNpm.TabIndex = 15;
            // 
            // tbNotelp
            // 
            this.tbNotelp.Location = new System.Drawing.Point(179, 450);
            this.tbNotelp.Name = "tbNotelp";
            this.tbNotelp.Size = new System.Drawing.Size(121, 20);
            this.tbNotelp.TabIndex = 16;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(179, 380);
            this.tbAlamat.Multiline = true;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(227, 57);
            this.tbAlamat.TabIndex = 20;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(179, 125);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(227, 20);
            this.tbNama.TabIndex = 21;
            // 
            // rbJk1
            // 
            this.rbJk1.AutoSize = true;
            this.rbJk1.Location = new System.Drawing.Point(179, 342);
            this.rbJk1.Name = "rbJk1";
            this.rbJk1.Size = new System.Drawing.Size(74, 17);
            this.rbJk1.TabIndex = 23;
            this.rbJk1.TabStop = true;
            this.rbJk1.Text = "Laki - Laki";
            this.rbJk1.UseVisualStyleBackColor = true;
            // 
            // rbJk2
            // 
            this.rbJk2.AutoSize = true;
            this.rbJk2.Location = new System.Drawing.Point(284, 342);
            this.rbJk2.Name = "rbJk2";
            this.rbJk2.Size = new System.Drawing.Size(79, 17);
            this.rbJk2.TabIndex = 24;
            this.rbJk2.TabStop = true;
            this.rbJk2.Text = "Perempuan";
            this.rbJk2.UseVisualStyleBackColor = true;
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // mcTgllahir
            // 
            this.mcTgllahir.Location = new System.Drawing.Point(179, 167);
            this.mcTgllahir.Name = "mcTgllahir";
            this.mcTgllahir.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 606);
            this.Controls.Add(this.mcTgllahir);
            this.Controls.Add(this.rbJk2);
            this.Controls.Add(this.rbJk1);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbNotelp);
            this.Controls.Add(this.tbNpm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbProdi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbProdi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbNpm;
        private System.Windows.Forms.TextBox tbNotelp;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.RadioButton rbJk1;
        private System.Windows.Forms.RadioButton rbJk2;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.MonthCalendar mcTgllahir;
    }
}


namespace Assaiment1
{
    partial class Form11
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtanual = new System.Windows.Forms.TextBox();
            this.txtmonthly = new System.Windows.Forms.TextBox();
            this.txtmain = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttires = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtoil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtgas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtinsurance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtloan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Olive;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtanual);
            this.groupBox1.Controls.Add(this.txtmonthly);
            this.groupBox1.Controls.Add(this.txtmain);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txttires);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtoil);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtgas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtinsurance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtloan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 666);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AutoMobil Cost";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtanual
            // 
            this.txtanual.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanual.Location = new System.Drawing.Point(319, 603);
            this.txtanual.Name = "txtanual";
            this.txtanual.Size = new System.Drawing.Size(199, 40);
            this.txtanual.TabIndex = 13;
            // 
            // txtmonthly
            // 
            this.txtmonthly.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonthly.Location = new System.Drawing.Point(74, 603);
            this.txtmonthly.Name = "txtmonthly";
            this.txtmonthly.Size = new System.Drawing.Size(199, 40);
            this.txtmonthly.TabIndex = 12;
            // 
            // txtmain
            // 
            this.txtmain.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmain.Location = new System.Drawing.Point(188, 451);
            this.txtmain.Name = "txtmain";
            this.txtmain.Size = new System.Drawing.Size(199, 40);
            this.txtmain.TabIndex = 11;
            this.txtmain.TextChanged += new System.EventHandler(this.txtmain_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-2, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Maintenance";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txttires
            // 
            this.txttires.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttires.Location = new System.Drawing.Point(188, 389);
            this.txttires.Name = "txttires";
            this.txttires.Size = new System.Drawing.Size(199, 40);
            this.txttires.TabIndex = 9;
            this.txttires.TextChanged += new System.EventHandler(this.txttires_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tires";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtoil
            // 
            this.txtoil.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoil.Location = new System.Drawing.Point(188, 313);
            this.txtoil.Name = "txtoil";
            this.txtoil.Size = new System.Drawing.Size(199, 40);
            this.txtoil.TabIndex = 7;
            this.txtoil.TextChanged += new System.EventHandler(this.txtoil_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Oil";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtgas
            // 
            this.txtgas.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgas.Location = new System.Drawing.Point(188, 224);
            this.txtgas.Name = "txtgas";
            this.txtgas.Size = new System.Drawing.Size(199, 40);
            this.txtgas.TabIndex = 5;
            this.txtgas.TextChanged += new System.EventHandler(this.txtgas_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtinsurance
            // 
            this.txtinsurance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinsurance.Location = new System.Drawing.Point(188, 155);
            this.txtinsurance.Name = "txtinsurance";
            this.txtinsurance.Size = new System.Drawing.Size(199, 40);
            this.txtinsurance.TabIndex = 3;
            this.txtinsurance.TextChanged += new System.EventHandler(this.txtinsurance_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insurance";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtloan
            // 
            this.txtloan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloan.Location = new System.Drawing.Point(188, 77);
            this.txtloan.Name = "txtloan";
            this.txtloan.Size = new System.Drawing.Size(199, 40);
            this.txtloan.TabIndex = 1;
            this.txtloan.TextChanged += new System.EventHandler(this.txtloan_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan payment";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 660);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form11";
            this.Text = "Form11";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttires;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtoil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtgas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtinsurance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtloan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtanual;
        private System.Windows.Forms.TextBox txtmonthly;
    }
}
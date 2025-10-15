namespace Assaiment1
{
    partial class Form6
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
            this.BMI = new System.Windows.Forms.Button();
            this.txtres = new System.Windows.Forms.TextBox();
            this.txtheihgt = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Magenta;
            this.groupBox1.Controls.Add(this.BMI);
            this.groupBox1.Controls.Add(this.txtres);
            this.groupBox1.Controls.Add(this.txtheihgt);
            this.groupBox1.Controls.Add(this.txtweight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 477);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Body mass idex";
            // 
            // BMI
            // 
            this.BMI.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMI.Location = new System.Drawing.Point(36, 300);
            this.BMI.Name = "BMI";
            this.BMI.Size = new System.Drawing.Size(121, 54);
            this.BMI.TabIndex = 5;
            this.BMI.Text = "BMI";
            this.BMI.UseVisualStyleBackColor = true;
            this.BMI.Click += new System.EventHandler(this.BMI_Click);
            // 
            // txtres
            // 
            this.txtres.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtres.Location = new System.Drawing.Point(36, 389);
            this.txtres.Name = "txtres";
            this.txtres.Size = new System.Drawing.Size(478, 40);
            this.txtres.TabIndex = 4;
            // 
            // txtheihgt
            // 
            this.txtheihgt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtheihgt.Location = new System.Drawing.Point(201, 163);
            this.txtheihgt.Name = "txtheihgt";
            this.txtheihgt.Size = new System.Drawing.Size(201, 40);
            this.txtheihgt.TabIndex = 3;
            // 
            // txtweight
            // 
            this.txtweight.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtweight.Location = new System.Drawing.Point(201, 99);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(201, 40);
            this.txtweight.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter  Weight";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 477);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtheihgt;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtres;
        private System.Windows.Forms.Button BMI;
    }
}
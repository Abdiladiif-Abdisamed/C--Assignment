namespace Assaiment1
{
    partial class Form5
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
            this.txtresult = new System.Windows.Forms.TextBox();
            this.Celsius = new System.Windows.Forms.Button();
            this.Fahrenheit = new System.Windows.Forms.Button();
            this.txttem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.txtresult);
            this.groupBox1.Controls.Add(this.Celsius);
            this.groupBox1.Controls.Add(this.Fahrenheit);
            this.groupBox1.Controls.Add(this.txttem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tempreture";
            // 
            // txtresult
            // 
            this.txtresult.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(35, 331);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(286, 40);
            this.txtresult.TabIndex = 4;
            // 
            // Celsius
            // 
            this.Celsius.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Celsius.Location = new System.Drawing.Point(12, 220);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(145, 44);
            this.Celsius.TabIndex = 3;
            this.Celsius.Text = "Celsius";
            this.Celsius.UseVisualStyleBackColor = true;
            this.Celsius.Click += new System.EventHandler(this.Celsius_Click);
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fahrenheit.Location = new System.Drawing.Point(188, 220);
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.Size = new System.Drawing.Size(161, 44);
            this.Fahrenheit.TabIndex = 2;
            this.Fahrenheit.Text = "Fahrenheit";
            this.Fahrenheit.UseVisualStyleBackColor = true;
            this.Fahrenheit.Click += new System.EventHandler(this.Fahrenheit_Click);
            // 
            // txttem
            // 
            this.txttem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttem.Location = new System.Drawing.Point(245, 96);
            this.txttem.Name = "txttem";
            this.txttem.Size = new System.Drawing.Size(286, 40);
            this.txttem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Tempreture:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 440);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Celsius;
        private System.Windows.Forms.Button Fahrenheit;
        private System.Windows.Forms.TextBox txttem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtresult;
    }
}
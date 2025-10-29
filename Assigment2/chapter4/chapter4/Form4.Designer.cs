namespace chapter4
{
    partial class Form4
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
            this.Red1 = new System.Windows.Forms.RadioButton();
            this.btnMix = new System.Windows.Forms.Button();
            this.Blue1 = new System.Windows.Forms.RadioButton();
            this.yellow1 = new System.Windows.Forms.RadioButton();
            this.yellow2 = new System.Windows.Forms.RadioButton();
            this.Blue2 = new System.Windows.Forms.RadioButton();
            this.Red2 = new System.Windows.Forms.RadioButton();
            this.lblresult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Red1
            // 
            this.Red1.AutoSize = true;
            this.Red1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Red1.Location = new System.Drawing.Point(20, 36);
            this.Red1.Name = "Red1";
            this.Red1.Size = new System.Drawing.Size(87, 29);
            this.Red1.TabIndex = 0;
            this.Red1.TabStop = true;
            this.Red1.Text = "Red1";
            this.Red1.UseVisualStyleBackColor = true;
            // 
            // btnMix
            // 
            this.btnMix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMix.Location = new System.Drawing.Point(130, 318);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(163, 78);
            this.btnMix.TabIndex = 1;
            this.btnMix.Text = "mixColors";
            this.btnMix.UseVisualStyleBackColor = true;
            this.btnMix.Click += new System.EventHandler(this.btnMix_Click);
            // 
            // Blue1
            // 
            this.Blue1.AutoSize = true;
            this.Blue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blue1.Location = new System.Drawing.Point(15, 96);
            this.Blue1.Name = "Blue1";
            this.Blue1.Size = new System.Drawing.Size(92, 29);
            this.Blue1.TabIndex = 2;
            this.Blue1.TabStop = true;
            this.Blue1.Text = "Blue1";
            this.Blue1.UseVisualStyleBackColor = true;
            // 
            // yellow1
            // 
            this.yellow1.AutoSize = true;
            this.yellow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellow1.Location = new System.Drawing.Point(20, 156);
            this.yellow1.Name = "yellow1";
            this.yellow1.Size = new System.Drawing.Size(112, 29);
            this.yellow1.TabIndex = 3;
            this.yellow1.TabStop = true;
            this.yellow1.Text = "Yellow1";
            this.yellow1.UseVisualStyleBackColor = true;
            // 
            // yellow2
            // 
            this.yellow2.AutoSize = true;
            this.yellow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellow2.Location = new System.Drawing.Point(42, 164);
            this.yellow2.Name = "yellow2";
            this.yellow2.Size = new System.Drawing.Size(112, 29);
            this.yellow2.TabIndex = 6;
            this.yellow2.TabStop = true;
            this.yellow2.Text = "Yellow2";
            this.yellow2.UseVisualStyleBackColor = true;
            this.yellow2.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Blue2
            // 
            this.Blue2.AutoSize = true;
            this.Blue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blue2.Location = new System.Drawing.Point(37, 104);
            this.Blue2.Name = "Blue2";
            this.Blue2.Size = new System.Drawing.Size(92, 29);
            this.Blue2.TabIndex = 5;
            this.Blue2.TabStop = true;
            this.Blue2.Text = "Blue2";
            this.Blue2.UseVisualStyleBackColor = true;
            this.Blue2.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // Red2
            // 
            this.Red2.AutoSize = true;
            this.Red2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Red2.Location = new System.Drawing.Point(55, 49);
            this.Red2.Name = "Red2";
            this.Red2.Size = new System.Drawing.Size(87, 29);
            this.Red2.TabIndex = 4;
            this.Red2.TabStop = true;
            this.Red2.Text = "Red2";
            this.Red2.UseVisualStyleBackColor = true;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(470, 371);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(65, 25);
            this.lblresult.TabIndex = 7;
            this.lblresult.Text = "result";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Red2);
            this.groupBox1.Controls.Add(this.Blue2);
            this.groupBox1.Controls.Add(this.yellow2);
            this.groupBox1.Location = new System.Drawing.Point(607, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 252);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Red1);
            this.groupBox2.Controls.Add(this.Blue1);
            this.groupBox2.Controls.Add(this.yellow1);
            this.groupBox2.Location = new System.Drawing.Point(270, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 219);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnMix);
            this.Name = "Form4";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Red1;
        private System.Windows.Forms.Button btnMix;
        private System.Windows.Forms.RadioButton Blue1;
        private System.Windows.Forms.RadioButton yellow1;
        private System.Windows.Forms.RadioButton yellow2;
        private System.Windows.Forms.RadioButton Blue2;
        private System.Windows.Forms.RadioButton Red2;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
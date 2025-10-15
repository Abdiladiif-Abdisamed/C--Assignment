namespace Assaiment1
{
    partial class Form12
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtsquare = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgallons = new System.Windows.Forms.TextBox();
            this.txthours = new System.Windows.Forms.TextBox();
            this.txttotalcost = new System.Windows.Forms.TextBox();
            this.txtlabor = new System.Windows.Forms.TextBox();
            this.txtpaintcost = new System.Windows.Forms.TextBox();
            this.Display = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Display);
            this.groupBox1.Controls.Add(this.txtpaintcost);
            this.groupBox1.Controls.Add(this.txtlabor);
            this.groupBox1.Controls.Add(this.txttotalcost);
            this.groupBox1.Controls.Add(this.txthours);
            this.groupBox1.Controls.Add(this.txtgallons);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtsquare);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-2, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 632);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paint job Estimator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Square Feet:";
            // 
            // txtsquare
            // 
            this.txtsquare.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsquare.Location = new System.Drawing.Point(233, 76);
            this.txtsquare.Name = "txtsquare";
            this.txtsquare.Size = new System.Drawing.Size(292, 40);
            this.txtsquare.TabIndex = 1;
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(233, 151);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(292, 40);
            this.txtprice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price per gallon:";
            // 
            // txtgallons
            // 
            this.txtgallons.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgallons.Location = new System.Drawing.Point(32, 383);
            this.txtgallons.Name = "txtgallons";
            this.txtgallons.Size = new System.Drawing.Size(272, 40);
            this.txtgallons.TabIndex = 4;
            // 
            // txthours
            // 
            this.txthours.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthours.Location = new System.Drawing.Point(350, 383);
            this.txthours.Name = "txthours";
            this.txthours.Size = new System.Drawing.Size(302, 40);
            this.txthours.TabIndex = 5;
            // 
            // txttotalcost
            // 
            this.txttotalcost.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalcost.Location = new System.Drawing.Point(20, 550);
            this.txttotalcost.Name = "txttotalcost";
            this.txttotalcost.Size = new System.Drawing.Size(233, 40);
            this.txttotalcost.TabIndex = 6;
            this.txttotalcost.TextChanged += new System.EventHandler(this.txttotalcost_TextChanged);
            // 
            // txtlabor
            // 
            this.txtlabor.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlabor.Location = new System.Drawing.Point(350, 464);
            this.txtlabor.Name = "txtlabor";
            this.txtlabor.Size = new System.Drawing.Size(302, 40);
            this.txtlabor.TabIndex = 7;
            // 
            // txtpaintcost
            // 
            this.txtpaintcost.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaintcost.Location = new System.Drawing.Point(32, 474);
            this.txtpaintcost.Name = "txtpaintcost";
            this.txtpaintcost.Size = new System.Drawing.Size(272, 40);
            this.txtpaintcost.TabIndex = 8;
            // 
            // Display
            // 
            this.Display.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(72, 263);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(155, 46);
            this.Display.TabIndex = 9;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(284, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 624);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form12";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsquare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthours;
        private System.Windows.Forms.TextBox txtgallons;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.TextBox txtpaintcost;
        private System.Windows.Forms.TextBox txtlabor;
        private System.Windows.Forms.TextBox txttotalcost;
    }
}
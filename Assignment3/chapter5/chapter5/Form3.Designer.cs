namespace chapter5
{
    partial class Form3
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
            this.bntcalcolate = new System.Windows.Forms.Button();
            this.txtdisplayresult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bntcalcolate
            // 
            this.bntcalcolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntcalcolate.Location = new System.Drawing.Point(39, 159);
            this.bntcalcolate.Name = "bntcalcolate";
            this.bntcalcolate.Size = new System.Drawing.Size(232, 120);
            this.bntcalcolate.TabIndex = 0;
            this.bntcalcolate.Text = "calculate";
            this.bntcalcolate.UseVisualStyleBackColor = true;
            this.bntcalcolate.Click += new System.EventHandler(this.bntcalcolate_Click);
            // 
            // txtdisplayresult
            // 
            this.txtdisplayresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdisplayresult.FormattingEnabled = true;
            this.txtdisplayresult.ItemHeight = 29;
            this.txtdisplayresult.Location = new System.Drawing.Point(373, 150);
            this.txtdisplayresult.Name = "txtdisplayresult";
            this.txtdisplayresult.Size = new System.Drawing.Size(477, 265);
            this.txtdisplayresult.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 452);
            this.Controls.Add(this.txtdisplayresult);
            this.Controls.Add(this.bntcalcolate);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntcalcolate;
        private System.Windows.Forms.ListBox txtdisplayresult;
    }
}
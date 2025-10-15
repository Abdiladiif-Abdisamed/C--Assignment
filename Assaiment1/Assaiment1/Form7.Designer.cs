namespace Assaiment1
{
    partial class Form7
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
            this.txtsentence = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnspace = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btnfootball = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnto = new System.Windows.Forms.Button();
            this.btnlike = new System.Windows.Forms.Button();
            this.btni = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.txtsentence);
            this.groupBox1.Controls.Add(this.btnreset);
            this.groupBox1.Controls.Add(this.btnspace);
            this.groupBox1.Controls.Add(this.btndot);
            this.groupBox1.Controls.Add(this.btnfootball);
            this.groupBox1.Controls.Add(this.btnplay);
            this.groupBox1.Controls.Add(this.btnto);
            this.groupBox1.Controls.Add(this.btnlike);
            this.groupBox1.Controls.Add(this.btni);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 519);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sentense Builder";
            // 
            // txtsentence
            // 
            this.txtsentence.Location = new System.Drawing.Point(21, 388);
            this.txtsentence.Name = "txtsentence";
            this.txtsentence.Size = new System.Drawing.Size(565, 67);
            this.txtsentence.TabIndex = 8;
            this.txtsentence.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(224, 281);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(116, 40);
            this.btnreset.TabIndex = 7;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnspace
            // 
            this.btnspace.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspace.Location = new System.Drawing.Point(45, 265);
            this.btnspace.Name = "btnspace";
            this.btnspace.Size = new System.Drawing.Size(116, 40);
            this.btnspace.TabIndex = 6;
            this.btnspace.Text = "Space";
            this.btnspace.UseVisualStyleBackColor = true;
            this.btnspace.Click += new System.EventHandler(this.btnspace_Click);
            // 
            // btndot
            // 
            this.btndot.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndot.Location = new System.Drawing.Point(374, 192);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(116, 40);
            this.btndot.TabIndex = 5;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            this.btndot.Click += new System.EventHandler(this.btndot_Click);
            // 
            // btnfootball
            // 
            this.btnfootball.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfootball.Location = new System.Drawing.Point(224, 192);
            this.btnfootball.Name = "btnfootball";
            this.btnfootball.Size = new System.Drawing.Size(127, 40);
            this.btnfootball.TabIndex = 4;
            this.btnfootball.Text = "Football";
            this.btnfootball.UseVisualStyleBackColor = true;
            this.btnfootball.Click += new System.EventHandler(this.btnfootball_Click);
            // 
            // btnplay
            // 
            this.btnplay.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.Location = new System.Drawing.Point(45, 192);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(116, 40);
            this.btnplay.TabIndex = 3;
            this.btnplay.Text = "Play";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btnto
            // 
            this.btnto.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnto.Location = new System.Drawing.Point(374, 106);
            this.btnto.Name = "btnto";
            this.btnto.Size = new System.Drawing.Size(116, 40);
            this.btnto.TabIndex = 2;
            this.btnto.Text = "To";
            this.btnto.UseVisualStyleBackColor = true;
            this.btnto.Click += new System.EventHandler(this.btnto_Click);
            // 
            // btnlike
            // 
            this.btnlike.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlike.Location = new System.Drawing.Point(224, 106);
            this.btnlike.Name = "btnlike";
            this.btnlike.Size = new System.Drawing.Size(116, 40);
            this.btnlike.TabIndex = 1;
            this.btnlike.Text = "like";
            this.btnlike.UseVisualStyleBackColor = true;
            this.btnlike.Click += new System.EventHandler(this.btnlike_Click);
            // 
            // btni
            // 
            this.btni.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btni.Location = new System.Drawing.Point(45, 106);
            this.btni.Name = "btni";
            this.btni.Size = new System.Drawing.Size(116, 40);
            this.btni.TabIndex = 0;
            this.btni.Text = "i";
            this.btni.UseVisualStyleBackColor = true;
            this.btni.Click += new System.EventHandler(this.btni_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 517);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnspace;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btnfootball;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnto;
        private System.Windows.Forms.Button btnlike;
        private System.Windows.Forms.Button btni;
        private System.Windows.Forms.TextBox txtsentence;
    }
}
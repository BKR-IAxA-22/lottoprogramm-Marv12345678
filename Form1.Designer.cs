namespace Lotto
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
            this.Rng = new System.Windows.Forms.Button();
            this.Number1 = new System.Windows.Forms.TextBox();
            this.Number2 = new System.Windows.Forms.TextBox();
            this.Number3 = new System.Windows.Forms.TextBox();
            this.Number4 = new System.Windows.Forms.TextBox();
            this.Number5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Rng
            // 
            this.Rng.Location = new System.Drawing.Point(282, 113);
            this.Rng.Name = "Rng";
            this.Rng.Size = new System.Drawing.Size(238, 48);
            this.Rng.TabIndex = 0;
            this.Rng.Text = "Random";
            this.Rng.UseVisualStyleBackColor = true;
            this.Rng.Click += new System.EventHandler(this.button1_Click);
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(61, 349);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(100, 20);
            this.Number1.TabIndex = 1;
            this.Number1.TextChanged += new System.EventHandler(this.Number1_TextChanged);
            // 
            // Number2
            // 
            this.Number2.Location = new System.Drawing.Point(202, 349);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(100, 20);
            this.Number2.TabIndex = 2;
            this.Number2.TextChanged += new System.EventHandler(this.Number2_TextChanged);
            // 
            // Number3
            // 
            this.Number3.Location = new System.Drawing.Point(342, 349);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(100, 20);
            this.Number3.TabIndex = 3;
            this.Number3.TextChanged += new System.EventHandler(this.Number3_TextChanged);
            // 
            // Number4
            // 
            this.Number4.Location = new System.Drawing.Point(478, 349);
            this.Number4.Name = "Number4";
            this.Number4.Size = new System.Drawing.Size(100, 20);
            this.Number4.TabIndex = 4;
            this.Number4.TextChanged += new System.EventHandler(this.Number4_TextChanged);
            // 
            // Number5
            // 
            this.Number5.Location = new System.Drawing.Point(604, 349);
            this.Number5.Name = "Number5";
            this.Number5.Size = new System.Drawing.Size(100, 20);
            this.Number5.TabIndex = 5;
            this.Number5.TextChanged += new System.EventHandler(this.Number5_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Number5);
            this.Controls.Add(this.Number4);
            this.Controls.Add(this.Number3);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.Rng);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Rng;
        private System.Windows.Forms.TextBox Number1;
        private System.Windows.Forms.TextBox Number2;
        private System.Windows.Forms.TextBox Number3;
        private System.Windows.Forms.TextBox Number4;
        private System.Windows.Forms.TextBox Number5;
    }
}


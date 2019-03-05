namespace WindowsFormsApp3
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
            this.Width = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.Area = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(334, 125);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(87, 20);
            this.Width.TabIndex = 0;
            this.Width.TextChanged += new System.EventHandler(this.Width_TextChanged);
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(449, 126);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(100, 20);
            this.Height.TabIndex = 1;
            this.Height.TextChanged += new System.EventHandler(this.Height_TextChanged);
            // 
            // Area
            // 
            this.Area.Location = new System.Drawing.Point(582, 128);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(95, 20);
            this.Area.TabIndex = 2;
            this.Area.TextChanged += new System.EventHandler(this.Area_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Width);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.TextBox Area;
        private System.Windows.Forms.Button button1;
    }
}


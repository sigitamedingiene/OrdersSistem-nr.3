namespace OrdersSistem_nr._4_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrderPreviewButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PaimentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderPreviewButton
            // 
            this.OrderPreviewButton.BackColor = System.Drawing.Color.Peru;
            this.OrderPreviewButton.Location = new System.Drawing.Point(36, 28);
            this.OrderPreviewButton.Name = "OrderPreviewButton";
            this.OrderPreviewButton.Size = new System.Drawing.Size(213, 29);
            this.OrderPreviewButton.TabIndex = 0;
            this.OrderPreviewButton.Text = "Užsakymo peržiūra";
            this.OrderPreviewButton.UseVisualStyleBackColor = false;
            this.OrderPreviewButton.Click += new System.EventHandler(this.OrderPreviewButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 350);
            this.textBox1.TabIndex = 1;
            // 
            // PaimentButton
            // 
            this.PaimentButton.BackColor = System.Drawing.Color.Lime;
            this.PaimentButton.Location = new System.Drawing.Point(255, 386);
            this.PaimentButton.Name = "PaimentButton";
            this.PaimentButton.Size = new System.Drawing.Size(96, 29);
            this.PaimentButton.TabIndex = 2;
            this.PaimentButton.Text = "Pay";
            this.PaimentButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PaimentButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OrderPreviewButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrderPreviewButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button PaimentButton;
    }
}

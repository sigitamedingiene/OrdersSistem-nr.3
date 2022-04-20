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
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.PaimentButton = new System.Windows.Forms.Button();
            this.PrewieOrderbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.BackColor = System.Drawing.Color.Peru;
            this.GenerateReportButton.Location = new System.Drawing.Point(36, 28);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(213, 29);
            this.GenerateReportButton.TabIndex = 0;
            this.GenerateReportButton.Text = "Generuoti klientų ataskaitą";
            this.GenerateReportButton.UseVisualStyleBackColor = false;
            this.GenerateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(36, 65);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(213, 62);
            this.textBox.TabIndex = 1;
            // 
            // PaimentButton
            // 
            this.PaimentButton.BackColor = System.Drawing.Color.Lime;
            this.PaimentButton.Location = new System.Drawing.Point(467, 421);
            this.PaimentButton.Name = "PaimentButton";
            this.PaimentButton.Size = new System.Drawing.Size(321, 29);
            this.PaimentButton.TabIndex = 2;
            this.PaimentButton.Text = "Generuoti nemokių klinetų ataskaitą";
            this.PaimentButton.UseVisualStyleBackColor = false;
            this.PaimentButton.Click += new System.EventHandler(this.PaimentButton_Click);
            // 
            // PrewieOrderbutton
            // 
            this.PrewieOrderbutton.Location = new System.Drawing.Point(42, 143);
            this.PrewieOrderbutton.Name = "PrewieOrderbutton";
            this.PrewieOrderbutton.Size = new System.Drawing.Size(207, 29);
            this.PrewieOrderbutton.TabIndex = 3;
            this.PrewieOrderbutton.Text = "Peržiūrėti užsakymus";
            this.PrewieOrderbutton.UseVisualStyleBackColor = true;
            this.PrewieOrderbutton.Click += new System.EventHandler(this.PrewieOrderbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 190);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(613, 225);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PrewieOrderbutton);
            this.Controls.Add(this.PaimentButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.GenerateReportButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateReportButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button PaimentButton;
        private System.Windows.Forms.Button PrewieOrderbutton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

namespace MarkovForms
{
    partial class Form20
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(12, 41);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(776, 389);
            this.textBox3.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сгенерировать магический квадрат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Name = "Form20";
            this.Text = "Form20";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}
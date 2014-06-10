namespace Sierp
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
            this.label1 = new System.Windows.Forms.Label();
            this.liczbaZagniezdzen = new System.Windows.Forms.TextBox();
            this.btnGenerowania = new System.Windows.Forms.Button();
            this.btnCzyszczenia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liczba zagnieżdżeń:";
            // 
            // liczbaZagniezdzen
            // 
            this.liczbaZagniezdzen.Location = new System.Drawing.Point(121, 533);
            this.liczbaZagniezdzen.Name = "liczbaZagniezdzen";
            this.liczbaZagniezdzen.Size = new System.Drawing.Size(37, 20);
            this.liczbaZagniezdzen.TabIndex = 1;
            this.liczbaZagniezdzen.Text = "5";
            // 
            // btnGenerowania
            // 
            this.btnGenerowania.Location = new System.Drawing.Point(185, 531);
            this.btnGenerowania.Name = "btnGenerowania";
            this.btnGenerowania.Size = new System.Drawing.Size(75, 23);
            this.btnGenerowania.TabIndex = 2;
            this.btnGenerowania.Text = "Generuj";
            this.btnGenerowania.UseVisualStyleBackColor = true;
            this.btnGenerowania.Click += new System.EventHandler(this.btnGenerowania_Click);
            // 
            // btnCzyszczenia
            // 
            this.btnCzyszczenia.Location = new System.Drawing.Point(697, 530);
            this.btnCzyszczenia.Name = "btnCzyszczenia";
            this.btnCzyszczenia.Size = new System.Drawing.Size(75, 23);
            this.btnCzyszczenia.TabIndex = 3;
            this.btnCzyszczenia.Text = "Wyczyść";
            this.btnCzyszczenia.UseVisualStyleBackColor = true;
            this.btnCzyszczenia.Click += new System.EventHandler(this.btnCzyszczenia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnCzyszczenia);
            this.Controls.Add(this.btnGenerowania);
            this.Controls.Add(this.liczbaZagniezdzen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox liczbaZagniezdzen;
        private System.Windows.Forms.Button btnGenerowania;
        private System.Windows.Forms.Button btnCzyszczenia;
    }
}


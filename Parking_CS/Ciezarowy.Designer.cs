namespace Parking_CS
{
    partial class Ciezarowy
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
            this.zaladunekTB = new System.Windows.Forms.TextBox();
            this.zaladunekTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zaladunekTB
            // 
            this.zaladunekTB.Location = new System.Drawing.Point(12, 250);
            this.zaladunekTB.Name = "zaladunekTB";
            this.zaladunekTB.Size = new System.Drawing.Size(100, 20);
            this.zaladunekTB.TabIndex = 3;
            // 
            // zaladunekTxt
            // 
            this.zaladunekTxt.AutoSize = true;
            this.zaladunekTxt.Location = new System.Drawing.Point(9, 234);
            this.zaladunekTxt.Name = "zaladunekTxt";
            this.zaladunekTxt.Size = new System.Drawing.Size(58, 13);
            this.zaladunekTxt.TabIndex = 4;
            this.zaladunekTxt.Text = "Zaladunek";
            // 
            // Ciezarowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zaladunekTxt);
            this.Controls.Add(this.zaladunekTB);
            this.Name = "Ciezarowy";
            this.Text = "Ciezarowy";
            this.Load += new System.EventHandler(this.Ciezarowy_Load);
            this.Controls.SetChildIndex(this.zaladunekTB, 0);
            this.Controls.SetChildIndex(this.zaladunekTxt, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zaladunekTB;
        private System.Windows.Forms.Label zaladunekTxt;
    }
}
namespace Parking_CS
{
    partial class Samochod
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
            this.masaTB = new System.Windows.Forms.TextBox();
            this.masaTxt = new System.Windows.Forms.Label();
            this.predkoscTB = new System.Windows.Forms.TextBox();
            this.predkoscTxt = new System.Windows.Forms.Label();
            this.kmTB = new System.Windows.Forms.TextBox();
            this.kmTxt = new System.Windows.Forms.Label();
            this.zuzBenzTB = new System.Windows.Forms.TextBox();
            this.zuzBenzTxt = new System.Windows.Forms.Label();
            this.okBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // masaTB
            // 
            this.masaTB.Location = new System.Drawing.Point(12, 52);
            this.masaTB.Name = "masaTB";
            this.masaTB.Size = new System.Drawing.Size(100, 20);
            this.masaTB.TabIndex = 0;
            this.masaTB.Text = "100";
            // 
            // masaTxt
            // 
            this.masaTxt.AutoSize = true;
            this.masaTxt.Location = new System.Drawing.Point(9, 36);
            this.masaTxt.Name = "masaTxt";
            this.masaTxt.Size = new System.Drawing.Size(33, 13);
            this.masaTxt.TabIndex = 1;
            this.masaTxt.Text = "Masa";
            // 
            // predkoscTB
            // 
            this.predkoscTB.Location = new System.Drawing.Point(12, 100);
            this.predkoscTB.Name = "predkoscTB";
            this.predkoscTB.Size = new System.Drawing.Size(100, 20);
            this.predkoscTB.TabIndex = 0;
            this.predkoscTB.Text = "100";
            // 
            // predkoscTxt
            // 
            this.predkoscTxt.AutoSize = true;
            this.predkoscTxt.Location = new System.Drawing.Point(9, 84);
            this.predkoscTxt.Name = "predkoscTxt";
            this.predkoscTxt.Size = new System.Drawing.Size(52, 13);
            this.predkoscTxt.TabIndex = 1;
            this.predkoscTxt.Text = "Predkosc";
            // 
            // kmTB
            // 
            this.kmTB.Location = new System.Drawing.Point(12, 148);
            this.kmTB.Name = "kmTB";
            this.kmTB.Size = new System.Drawing.Size(100, 20);
            this.kmTB.TabIndex = 0;
            this.kmTB.Text = "100";
            // 
            // kmTxt
            // 
            this.kmTxt.AutoSize = true;
            this.kmTxt.Location = new System.Drawing.Point(9, 132);
            this.kmTxt.Name = "kmTxt";
            this.kmTxt.Size = new System.Drawing.Size(65, 13);
            this.kmTxt.TabIndex = 1;
            this.kmTxt.Text = "konie mech.";
            // 
            // zuzBenzTB
            // 
            this.zuzBenzTB.Location = new System.Drawing.Point(12, 199);
            this.zuzBenzTB.Name = "zuzBenzTB";
            this.zuzBenzTB.Size = new System.Drawing.Size(100, 20);
            this.zuzBenzTB.TabIndex = 0;
            this.zuzBenzTB.Text = "100";
            // 
            // zuzBenzTxt
            // 
            this.zuzBenzTxt.AutoSize = true;
            this.zuzBenzTxt.Location = new System.Drawing.Point(9, 183);
            this.zuzBenzTxt.Name = "zuzBenzTxt";
            this.zuzBenzTxt.Size = new System.Drawing.Size(57, 13);
            this.zuzBenzTxt.TabIndex = 1;
            this.zuzBenzTxt.Text = "Zuz. benz.";
            // 
            // okBTN
            // 
            this.okBTN.Location = new System.Drawing.Point(140, 52);
            this.okBTN.Name = "okBTN";
            this.okBTN.Size = new System.Drawing.Size(75, 23);
            this.okBTN.TabIndex = 2;
            this.okBTN.Text = "OK";
            this.okBTN.UseVisualStyleBackColor = true;
            this.okBTN.Click += new System.EventHandler(this.okBTN_Click);
            // 
            // Samochod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.okBTN);
            this.Controls.Add(this.zuzBenzTxt);
            this.Controls.Add(this.zuzBenzTB);
            this.Controls.Add(this.kmTxt);
            this.Controls.Add(this.kmTB);
            this.Controls.Add(this.predkoscTxt);
            this.Controls.Add(this.predkoscTB);
            this.Controls.Add(this.masaTxt);
            this.Controls.Add(this.masaTB);
            this.Name = "Samochod";
            this.Text = "Samochod";
            this.Load += new System.EventHandler(this.Samochod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox masaTB;
        private System.Windows.Forms.Label masaTxt;
        private System.Windows.Forms.TextBox predkoscTB;
        private System.Windows.Forms.Label predkoscTxt;
        private System.Windows.Forms.TextBox kmTB;
        private System.Windows.Forms.Label kmTxt;
        private System.Windows.Forms.TextBox zuzBenzTB;
        private System.Windows.Forms.Label zuzBenzTxt;
        private System.Windows.Forms.Button okBTN;
    }
}
namespace CodingFreak
{
    partial class xDailyCodingProblem_Easy
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
            this.TwoNumbersAddToK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TwoNumbersAddToK
            // 
            this.TwoNumbersAddToK.Location = new System.Drawing.Point(12, 12);
            this.TwoNumbersAddToK.Name = "TwoNumbersAddToK";
            this.TwoNumbersAddToK.Size = new System.Drawing.Size(209, 28);
            this.TwoNumbersAddToK.TabIndex = 0;
            this.TwoNumbersAddToK.Text = "Two Numbers in Array add to K";
            this.TwoNumbersAddToK.UseVisualStyleBackColor = true;
            this.TwoNumbersAddToK.Click += new System.EventHandler(this.TwoNumbersAddToK_Click);
            // 
            // xDailyCodingProblem_Easy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 498);
            this.Controls.Add(this.TwoNumbersAddToK);
            this.Name = "xDailyCodingProblem_Easy";
            this.Text = "xDailyCodingProblem_Easy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TwoNumbersAddToK;
    }
}
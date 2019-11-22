namespace CodingFreak
{
    partial class xDailyCodingProblem_Hard
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
            this.Product_Of_Numbers_Except_Self = new System.Windows.Forms.Button();
            this.First_Missing_Positive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Product_Of_Numbers_Except_Self
            // 
            this.Product_Of_Numbers_Except_Self.Location = new System.Drawing.Point(13, 13);
            this.Product_Of_Numbers_Except_Self.Name = "Product_Of_Numbers_Except_Self";
            this.Product_Of_Numbers_Except_Self.Size = new System.Drawing.Size(207, 31);
            this.Product_Of_Numbers_Except_Self.TabIndex = 0;
            this.Product_Of_Numbers_Except_Self.Text = "Product of Numbers Except Self";
            this.Product_Of_Numbers_Except_Self.UseVisualStyleBackColor = true;
            this.Product_Of_Numbers_Except_Self.Click += new System.EventHandler(this.Product_Of_Numbers_Except_Self_Click);
            // 
            // First_Missing_Positive
            // 
            this.First_Missing_Positive.Location = new System.Drawing.Point(264, 13);
            this.First_Missing_Positive.Name = "First_Missing_Positive";
            this.First_Missing_Positive.Size = new System.Drawing.Size(215, 31);
            this.First_Missing_Positive.TabIndex = 1;
            this.First_Missing_Positive.Text = "First Missing Positive";
            this.First_Missing_Positive.UseVisualStyleBackColor = true;
            this.First_Missing_Positive.Click += new System.EventHandler(this.First_Missing_Positive_Click);
            // 
            // xDailyCodingProblem_Hard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 505);
            this.Controls.Add(this.First_Missing_Positive);
            this.Controls.Add(this.Product_Of_Numbers_Except_Self);
            this.Name = "xDailyCodingProblem_Hard";
            this.Text = "xDailyCodingProblem_Hard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Product_Of_Numbers_Except_Self;
        private System.Windows.Forms.Button First_Missing_Positive;
    }
}
namespace CodingFreak
{
    partial class DynamicProgramming
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
            this.Subset_Sum_Present_In_Array_or_Not = new System.Windows.Forms.Button();
            this.Fibonacci_Number = new System.Windows.Forms.Button();
            this.Coin_Change_Problem = new System.Windows.Forms.Button();
            this.Stairs_Claim_1And2 = new System.Windows.Forms.Button();
            this.Square_Submatrix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Subset_Sum_Present_In_Array_or_Not
            // 
            this.Subset_Sum_Present_In_Array_or_Not.Location = new System.Drawing.Point(13, 13);
            this.Subset_Sum_Present_In_Array_or_Not.Name = "Subset_Sum_Present_In_Array_or_Not";
            this.Subset_Sum_Present_In_Array_or_Not.Size = new System.Drawing.Size(209, 29);
            this.Subset_Sum_Present_In_Array_or_Not.TabIndex = 0;
            this.Subset_Sum_Present_In_Array_or_Not.Text = "Subset Sum Problem # 1";
            this.Subset_Sum_Present_In_Array_or_Not.UseVisualStyleBackColor = true;
            this.Subset_Sum_Present_In_Array_or_Not.Click += new System.EventHandler(this.Subset_Sum_Present_In_Array_or_Not_Click);
            // 
            // Fibonacci_Number
            // 
            this.Fibonacci_Number.Location = new System.Drawing.Point(269, 13);
            this.Fibonacci_Number.Name = "Fibonacci_Number";
            this.Fibonacci_Number.Size = new System.Drawing.Size(224, 29);
            this.Fibonacci_Number.TabIndex = 1;
            this.Fibonacci_Number.Text = "Fibonacci Number";
            this.Fibonacci_Number.UseVisualStyleBackColor = true;
            this.Fibonacci_Number.Click += new System.EventHandler(this.Fibonacci_Number_Click);
            // 
            // Coin_Change_Problem
            // 
            this.Coin_Change_Problem.Location = new System.Drawing.Point(532, 13);
            this.Coin_Change_Problem.Name = "Coin_Change_Problem";
            this.Coin_Change_Problem.Size = new System.Drawing.Size(248, 29);
            this.Coin_Change_Problem.TabIndex = 2;
            this.Coin_Change_Problem.Text = "Coin Change Problem";
            this.Coin_Change_Problem.UseVisualStyleBackColor = true;
            this.Coin_Change_Problem.Click += new System.EventHandler(this.Coin_Change_Problem_Click);
            // 
            // Stairs_Claim_1And2
            // 
            this.Stairs_Claim_1And2.Location = new System.Drawing.Point(821, 13);
            this.Stairs_Claim_1And2.Name = "Stairs_Claim_1And2";
            this.Stairs_Claim_1And2.Size = new System.Drawing.Size(213, 29);
            this.Stairs_Claim_1And2.TabIndex = 3;
            this.Stairs_Claim_1And2.Text = "Stairs Claim {1,2}";
            this.Stairs_Claim_1And2.UseVisualStyleBackColor = true;
            this.Stairs_Claim_1And2.Click += new System.EventHandler(this.Stairs_Claim_1And2_Click);
            // 
            // Square_Submatrix
            // 
            this.Square_Submatrix.Location = new System.Drawing.Point(13, 59);
            this.Square_Submatrix.Name = "Square_Submatrix";
            this.Square_Submatrix.Size = new System.Drawing.Size(209, 32);
            this.Square_Submatrix.TabIndex = 4;
            this.Square_Submatrix.Text = "Square Sub Matrix";
            this.Square_Submatrix.UseVisualStyleBackColor = true;
            this.Square_Submatrix.Click += new System.EventHandler(this.Square_Submatrix_Click);
            // 
            // DynamicProgramming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 507);
            this.Controls.Add(this.Square_Submatrix);
            this.Controls.Add(this.Stairs_Claim_1And2);
            this.Controls.Add(this.Coin_Change_Problem);
            this.Controls.Add(this.Fibonacci_Number);
            this.Controls.Add(this.Subset_Sum_Present_In_Array_or_Not);
            this.Name = "DynamicProgramming";
            this.Text = "DynamicProgramming";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Subset_Sum_Present_In_Array_or_Not;
        private System.Windows.Forms.Button Fibonacci_Number;
        private System.Windows.Forms.Button Coin_Change_Problem;
        private System.Windows.Forms.Button Stairs_Claim_1And2;
        private System.Windows.Forms.Button Square_Submatrix;
    }
}
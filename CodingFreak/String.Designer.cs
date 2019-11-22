namespace CodingFreak
{
    partial class String
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
            this.Find_Longest_Palindrome = new System.Windows.Forms.Button();
            this.Is_Rotated_Palindrome_Or_Not = new System.Windows.Forms.Button();
            this.Check_For_Repeated_SubSequence = new System.Windows.Forms.Button();
            this.Is_Palindrome = new System.Windows.Forms.Button();
            this.Convert_Number_To_String_Like_Excel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Find_Longest_Palindrome
            // 
            this.Find_Longest_Palindrome.Location = new System.Drawing.Point(12, 12);
            this.Find_Longest_Palindrome.Name = "Find_Longest_Palindrome";
            this.Find_Longest_Palindrome.Size = new System.Drawing.Size(199, 30);
            this.Find_Longest_Palindrome.TabIndex = 0;
            this.Find_Longest_Palindrome.Text = "Find the Longest Palindrome";
            this.Find_Longest_Palindrome.UseVisualStyleBackColor = true;
            this.Find_Longest_Palindrome.Click += new System.EventHandler(this.Find_Longest_Palindrome_Click);
            // 
            // Is_Rotated_Palindrome_Or_Not
            // 
            this.Is_Rotated_Palindrome_Or_Not.Location = new System.Drawing.Point(230, 12);
            this.Is_Rotated_Palindrome_Or_Not.Name = "Is_Rotated_Palindrome_Or_Not";
            this.Is_Rotated_Palindrome_Or_Not.Size = new System.Drawing.Size(224, 30);
            this.Is_Rotated_Palindrome_Or_Not.TabIndex = 1;
            this.Is_Rotated_Palindrome_Or_Not.Text = "Rotated Palindrome or not";
            this.Is_Rotated_Palindrome_Or_Not.UseVisualStyleBackColor = true;
            this.Is_Rotated_Palindrome_Or_Not.Click += new System.EventHandler(this.Is_Rotated_Palindrome_Or_Not_Click);
            // 
            // Check_For_Repeated_SubSequence
            // 
            this.Check_For_Repeated_SubSequence.Location = new System.Drawing.Point(472, 13);
            this.Check_For_Repeated_SubSequence.Name = "Check_For_Repeated_SubSequence";
            this.Check_For_Repeated_SubSequence.Size = new System.Drawing.Size(235, 30);
            this.Check_For_Repeated_SubSequence.TabIndex = 2;
            this.Check_For_Repeated_SubSequence.Text = "Check if Repeated Subsequence is Present";
            this.Check_For_Repeated_SubSequence.UseVisualStyleBackColor = true;
            this.Check_For_Repeated_SubSequence.Click += new System.EventHandler(this.Check_For_Repeated_SubSequence_Click);
            // 
            // Is_Palindrome
            // 
            this.Is_Palindrome.Location = new System.Drawing.Point(713, 12);
            this.Is_Palindrome.Name = "Is_Palindrome";
            this.Is_Palindrome.Size = new System.Drawing.Size(227, 30);
            this.Is_Palindrome.TabIndex = 3;
            this.Is_Palindrome.Text = "Is Palindrome";
            this.Is_Palindrome.UseVisualStyleBackColor = true;
            this.Is_Palindrome.Click += new System.EventHandler(this.Is_Palindrome_Click);
            // 
            // Convert_Number_To_String_Like_Excel
            // 
            this.Convert_Number_To_String_Like_Excel.Location = new System.Drawing.Point(957, 13);
            this.Convert_Number_To_String_Like_Excel.Name = "Convert_Number_To_String_Like_Excel";
            this.Convert_Number_To_String_Like_Excel.Size = new System.Drawing.Size(221, 29);
            this.Convert_Number_To_String_Like_Excel.TabIndex = 4;
            this.Convert_Number_To_String_Like_Excel.Text = "Convert Number To String [Like Excel]";
            this.Convert_Number_To_String_Like_Excel.UseVisualStyleBackColor = true;
            this.Convert_Number_To_String_Like_Excel.Click += new System.EventHandler(this.Convert_Number_To_String_Like_Excel_Click);
            // 
            // String
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 483);
            this.Controls.Add(this.Convert_Number_To_String_Like_Excel);
            this.Controls.Add(this.Is_Palindrome);
            this.Controls.Add(this.Check_For_Repeated_SubSequence);
            this.Controls.Add(this.Is_Rotated_Palindrome_Or_Not);
            this.Controls.Add(this.Find_Longest_Palindrome);
            this.Name = "String";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Find_Longest_Palindrome;
        private System.Windows.Forms.Button Is_Rotated_Palindrome_Or_Not;
        private System.Windows.Forms.Button Check_For_Repeated_SubSequence;
        private System.Windows.Forms.Button Is_Palindrome;
        private System.Windows.Forms.Button Convert_Number_To_String_Like_Excel;
    }
}


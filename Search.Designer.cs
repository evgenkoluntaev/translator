namespace Glazariy
{
    partial class Search
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
            this.SearchLine = new System.Windows.Forms.TextBox();
            this.Words = new System.Windows.Forms.CheckedListBox();
            this.Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchLine
            // 
            this.SearchLine.Location = new System.Drawing.Point(58, 74);
            this.SearchLine.Margin = new System.Windows.Forms.Padding(2);
            this.SearchLine.Name = "SearchLine";
            this.SearchLine.Size = new System.Drawing.Size(624, 20);
            this.SearchLine.TabIndex = 0;
            this.SearchLine.Text = "Начи вводить слово...";
            this.SearchLine.TextChanged += new System.EventHandler(this.SearchLine_TextChanged);
            // 
            // Words
            // 
            this.Words.FormattingEnabled = true;
            this.Words.Location = new System.Drawing.Point(58, 116);
            this.Words.Margin = new System.Windows.Forms.Padding(2);
            this.Words.Name = "Words";
            this.Words.Size = new System.Drawing.Size(624, 364);
            this.Words.TabIndex = 1;
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(58, 543);
            this.Home.Margin = new System.Windows.Forms.Padding(2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(50, 50);
            this.Home.TabIndex = 13;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 624);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Words);
            this.Controls.Add(this.SearchLine);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Search";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchLine;
        private System.Windows.Forms.CheckedListBox Words;
        private System.Windows.Forms.Button Home;
    }
}
namespace Glazariy
{
    partial class Learn
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
            this.Dict = new System.Windows.Forms.Button();
            this.LearnWord = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dict
            // 
            this.Dict.Location = new System.Drawing.Point(459, 240);
            this.Dict.Name = "Dict";
            this.Dict.Size = new System.Drawing.Size(302, 54);
            this.Dict.TabIndex = 0;
            this.Dict.Text = "Словари";
            this.Dict.UseVisualStyleBackColor = true;
            this.Dict.Click += new System.EventHandler(this.Dict_Click);
            // 
            // LearnWord
            // 
            this.LearnWord.Location = new System.Drawing.Point(459, 331);
            this.LearnWord.Name = "LearnWord";
            this.LearnWord.Size = new System.Drawing.Size(302, 54);
            this.LearnWord.TabIndex = 1;
            this.LearnWord.Text = "Учить слова";
            this.LearnWord.UseVisualStyleBackColor = true;
            this.LearnWord.Click += new System.EventHandler(this.LearnWord_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(44, 676);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(67, 62);
            this.Home.TabIndex = 13;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 771);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.LearnWord);
            this.Controls.Add(this.Dict);
            this.Name = "Learn";
            this.Text = "Learn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Dict;
        private System.Windows.Forms.Button LearnWord;
        private System.Windows.Forms.Button Home;
    }
}
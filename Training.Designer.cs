namespace Glazariy
{
    partial class Training
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
            this.Word = new System.Windows.Forms.Label();
            this.Translate = new System.Windows.Forms.TextBox();
            this.Prev = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Finish = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Word
            // 
            this.Word.AutoSize = true;
            this.Word.Location = new System.Drawing.Point(127, 238);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(143, 17);
            this.Word.TabIndex = 0;
            this.Word.Text = "Слово для перевода";
            // 
            // Translate
            // 
            this.Translate.Location = new System.Drawing.Point(126, 317);
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(431, 22);
            this.Translate.TabIndex = 1;
            this.Translate.Text = "Перевод";
            // 
            // Prev
            // 
            this.Prev.Enabled = false;
            this.Prev.Location = new System.Drawing.Point(126, 480);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(173, 46);
            this.Prev.TabIndex = 2;
            this.Prev.Text = "Предудущее";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Next
            // 
            this.Next.Enabled = false;
            this.Next.Location = new System.Drawing.Point(324, 480);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(172, 46);
            this.Next.TabIndex = 3;
            this.Next.Text = "Следующее";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Finish
            // 
            this.Finish.Enabled = false;
            this.Finish.Location = new System.Drawing.Point(522, 480);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(172, 46);
            this.Finish.TabIndex = 4;
            this.Finish.Text = "Закончить";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(126, 681);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(67, 62);
            this.Home.TabIndex = 13;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(638, 704);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(44, 17);
            this.Count.TabIndex = 16;
            this.Count.Text = "10/10";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(127, 399);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(172, 46);
            this.start.TabIndex = 17;
            this.start.Text = "Начать";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Training
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 773);
            this.Controls.Add(this.start);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.Translate);
            this.Controls.Add(this.Word);
            this.Name = "Training";
            this.Text = "Training";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Word;
        private System.Windows.Forms.TextBox Translate;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Button start;
    }
}
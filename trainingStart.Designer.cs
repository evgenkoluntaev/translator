namespace Glazariy
{
    partial class TrainingStart
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
            this.Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Ing = new System.Windows.Forms.RadioButton();
            this.Rus = new System.Windows.Forms.RadioButton();
            this.Dict = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите свое имя:";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(54, 114);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(352, 22);
            this.Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите словари:";
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(54, 658);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(67, 62);
            this.Home.TabIndex = 16;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(53, 396);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(162, 40);
            this.Select.TabIndex = 19;
            this.Select.Text = "Выбрать";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(54, 577);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(162, 40);
            this.Start.TabIndex = 20;
            this.Start.Text = "Начать";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Выберите режим:";
            // 
            // Ing
            // 
            this.Ing.AutoSize = true;
            this.Ing.Location = new System.Drawing.Point(53, 500);
            this.Ing.Name = "Ing";
            this.Ing.Size = new System.Drawing.Size(122, 21);
            this.Ing.TabIndex = 24;
            this.Ing.Text = "С английского";
            this.Ing.UseVisualStyleBackColor = true;
            // 
            // Rus
            // 
            this.Rus.AutoSize = true;
            this.Rus.Checked = true;
            this.Rus.Location = new System.Drawing.Point(54, 527);
            this.Rus.Name = "Rus";
            this.Rus.Size = new System.Drawing.Size(99, 21);
            this.Rus.TabIndex = 25;
            this.Rus.TabStop = true;
            this.Rus.Text = "С русского";
            this.Rus.UseVisualStyleBackColor = true;
            // 
            // Dict
            // 
            this.Dict.Location = new System.Drawing.Point(53, 209);
            this.Dict.Name = "Dict";
            this.Dict.Size = new System.Drawing.Size(1050, 157);
            this.Dict.TabIndex = 26;
            // 
            // TrainingStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 769);
            this.Controls.Add(this.Dict);
            this.Controls.Add(this.Rus);
            this.Controls.Add(this.Ing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);

            this.Text = "trainingStart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Ing;
        private System.Windows.Forms.RadioButton Rus;
        private System.Windows.Forms.CheckedListBox Dict;
    }
}
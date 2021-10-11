namespace Glazariy
{
    partial class Add
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
            this.components = new System.ComponentModel.Container();
            this.File = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Download = new System.Windows.Forms.Button();
            this.Word = new System.Windows.Forms.TextBox();
            this.Translate = new System.Windows.Forms.TextBox();
            this.DownloadHandle = new System.Windows.Forms.Button();
            this.SelectDict = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.Meaning = new System.Windows.Forms.RichTextBox();
            this.Vocabulary = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // File
            // 
            this.File.Location = new System.Drawing.Point(35, 248);
            this.File.Margin = new System.Windows.Forms.Padding(2);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(683, 20);
            this.File.TabIndex = 0;
            this.File.Text = "Введите название файла или выберите ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Из файла:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 338);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ручной ввод:";
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(35, 291);
            this.Download.Margin = new System.Windows.Forms.Padding(2);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(154, 28);
            this.Download.TabIndex = 4;
            this.Download.Text = "Загрузить";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // Word
            // 
            this.Word.Location = new System.Drawing.Point(35, 353);
            this.Word.Margin = new System.Windows.Forms.Padding(2);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(218, 20);
            this.Word.TabIndex = 5;
            this.Word.Text = "Слово";
            this.Word.Click += new System.EventHandler(this.Word_Click);
            // 
            // Translate
            // 
            this.Translate.Location = new System.Drawing.Point(257, 353);
            this.Translate.Margin = new System.Windows.Forms.Padding(2);
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(461, 20);
            this.Translate.TabIndex = 6;
            this.Translate.Text = "Перевод";
            this.Translate.Click += new System.EventHandler(this.Translate_Click);
            // 
            // DownloadHandle
            // 
            this.DownloadHandle.Location = new System.Drawing.Point(35, 491);
            this.DownloadHandle.Margin = new System.Windows.Forms.Padding(2);
            this.DownloadHandle.Name = "DownloadHandle";
            this.DownloadHandle.Size = new System.Drawing.Size(154, 28);
            this.DownloadHandle.TabIndex = 8;
            this.DownloadHandle.Text = "Загрузить";
            this.DownloadHandle.UseVisualStyleBackColor = true;
            this.DownloadHandle.Click += new System.EventHandler(this.DownloadHandle_Click);
            // 
            // SelectDict
            // 
            this.SelectDict.Location = new System.Drawing.Point(35, 136);
            this.SelectDict.Margin = new System.Windows.Forms.Padding(2);
            this.SelectDict.Name = "SelectDict";
            this.SelectDict.Size = new System.Drawing.Size(152, 28);
            this.SelectDict.TabIndex = 9;
            this.SelectDict.Text = "Выбрать словарь";
            this.SelectDict.UseVisualStyleBackColor = true;
            this.SelectDict.Click += new System.EventHandler(this.SelectDict_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Загрузка новых слов";
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(39, 563);
            this.Home.Margin = new System.Windows.Forms.Padding(2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(50, 50);
            this.Home.TabIndex = 12;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Meaning
            // 
            this.Meaning.Location = new System.Drawing.Point(36, 378);
            this.Meaning.Name = "Meaning";
            this.Meaning.Size = new System.Drawing.Size(682, 108);
            this.Meaning.TabIndex = 13;
            this.Meaning.Text = "Толкование";
            this.Meaning.Click += new System.EventHandler(this.Meaning_Click);
            // 
            // Vocabulary
            // 
            this.Vocabulary.FormattingEnabled = true;
            this.Vocabulary.Location = new System.Drawing.Point(35, 65);
            this.Vocabulary.Name = "Vocabulary";
            this.Vocabulary.Size = new System.Drawing.Size(555, 21);
            this.Vocabulary.TabIndex = 14;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 627);
            this.Controls.Add(this.Vocabulary);
            this.Controls.Add(this.Meaning);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectDict);
            this.Controls.Add(this.DownloadHandle);
            this.Controls.Add(this.Translate);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.File);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Add";
            this.Text = "Add";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox File;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.TextBox Translate;
        private System.Windows.Forms.Button DownloadHandle;
        private System.Windows.Forms.Button SelectDict;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.RichTextBox Meaning;
        private System.Windows.Forms.ComboBox Vocabulary;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
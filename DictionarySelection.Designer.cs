namespace Glazariy
{
    partial class DictionarySelection
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
            this.Home = new System.Windows.Forms.Button();
            this.Dict = new System.Windows.Forms.CheckedListBox();
            this.select = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите словарь:";
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(47, 674);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(67, 62);
            this.Home.TabIndex = 13;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // Dict
            // 
            this.Dict.FormattingEnabled = true;
            this.Dict.Location = new System.Drawing.Point(47, 98);
            this.Dict.Name = "Dict";
            this.Dict.Size = new System.Drawing.Size(989, 446);
            this.Dict.TabIndex = 14;
            this.Dict.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(47, 582);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(221, 57);
            this.select.TabIndex = 15;
            this.select.Text = "Выбрать";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // DictionarySelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 769);
            this.Controls.Add(this.select);
            this.Controls.Add(this.Dict);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.label1);
            this.Name = "DictionarySelection";
            this.Text = "DictionarySelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.CheckedListBox Dict;
        private System.Windows.Forms.Button select;
    }
}
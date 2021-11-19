
namespace lb4_spz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.file_name = new System.Windows.Forms.TextBox();
            this.rewrite_file = new System.Windows.Forms.Button();
            this.open_file = new System.Windows.Forms.Button();
            this.create_file = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.file_fill = new System.Windows.Forms.TextBox();
            this.get_file_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.get_rewrite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // file_name
            // 
            this.file_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.file_name.Location = new System.Drawing.Point(34, 85);
            this.file_name.Name = "file_name";
            this.file_name.Size = new System.Drawing.Size(140, 23);
            this.file_name.TabIndex = 4;
            this.file_name.Text = "test";
            this.file_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rewrite_file
            // 
            this.rewrite_file.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rewrite_file.Location = new System.Drawing.Point(486, 164);
            this.rewrite_file.Name = "rewrite_file";
            this.rewrite_file.Size = new System.Drawing.Size(131, 41);
            this.rewrite_file.TabIndex = 2;
            this.rewrite_file.Text = "Перезаписать файл";
            this.rewrite_file.UseVisualStyleBackColor = true;
            this.rewrite_file.Click += new System.EventHandler(this.rewrite_file_Click);
            // 
            // open_file
            // 
            this.open_file.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.open_file.Location = new System.Drawing.Point(260, 164);
            this.open_file.Name = "open_file";
            this.open_file.Size = new System.Drawing.Size(131, 41);
            this.open_file.TabIndex = 1;
            this.open_file.Text = "Открыть файл";
            this.open_file.UseVisualStyleBackColor = true;
            this.open_file.Click += new System.EventHandler(this.open_file_Click);
            // 
            // create_file
            // 
            this.create_file.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create_file.Location = new System.Drawing.Point(34, 164);
            this.create_file.Name = "create_file";
            this.create_file.Size = new System.Drawing.Size(131, 41);
            this.create_file.TabIndex = 0;
            this.create_file.Text = "Создать файл";
            this.create_file.UseVisualStyleBackColor = true;
            this.create_file.Click += new System.EventHandler(this.create_file_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите имя файла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите содержимое файла";
            // 
            // file_fill
            // 
            this.file_fill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.file_fill.Location = new System.Drawing.Point(34, 266);
            this.file_fill.Name = "file_fill";
            this.file_fill.Size = new System.Drawing.Size(140, 23);
            this.file_fill.TabIndex = 7;
            this.file_fill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // get_file_text
            // 
            this.get_file_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.get_file_text.Location = new System.Drawing.Point(251, 266);
            this.get_file_text.Name = "get_file_text";
            this.get_file_text.ReadOnly = true;
            this.get_file_text.Size = new System.Drawing.Size(140, 23);
            this.get_file_text.TabIndex = 8;
            this.get_file_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cодержимое файла";
            // 
            // get_rewrite
            // 
            this.get_rewrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.get_rewrite.Location = new System.Drawing.Point(477, 266);
            this.get_rewrite.Name = "get_rewrite";
            this.get_rewrite.ReadOnly = true;
            this.get_rewrite.Size = new System.Drawing.Size(140, 23);
            this.get_rewrite.TabIndex = 10;
            this.get_rewrite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cодержимое файла";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(639, 355);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.get_rewrite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.get_file_text);
            this.Controls.Add(this.file_fill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rewrite_file);
            this.Controls.Add(this.open_file);
            this.Controls.Add(this.create_file);
            this.Controls.Add(this.file_name);
            this.Name = "Form1";
            this.Text = "lb4_spz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox file_name;
        private System.Windows.Forms.Button rewrite_file;
        private System.Windows.Forms.Button open_file;
        private System.Windows.Forms.Button create_file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox file_fill;
        private System.Windows.Forms.TextBox get_file_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox get_rewrite;
        private System.Windows.Forms.Label label4;
    }
}


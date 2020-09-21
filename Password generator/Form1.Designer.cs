namespace Password_generator
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.length = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.File_Save = new System.Windows.Forms.Button();
            this.qantity = new System.Windows.Forms.TextBox();
            this.file_position = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.Location = new System.Drawing.Point(112, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Generate
            // 
            this.Generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Generate.Location = new System.Drawing.Point(13, 13);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(93, 23);
            this.Generate.TabIndex = 2;
            this.Generate.Text = "Сгенерировать";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // copy
            // 
            this.copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copy.Location = new System.Drawing.Point(12, 43);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(289, 23);
            this.copy.TabIndex = 4;
            this.copy.Text = "Скопировать в буфер обмена";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(120, 72);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(59, 20);
            this.length.TabIndex = 1;
            this.length.Text = "10";
            this.length.TextChanged += new System.EventHandler(this.length_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длинна пароля:";
            // 
            // File_Save
            // 
            this.File_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.File_Save.Location = new System.Drawing.Point(229, 68);
            this.File_Save.Name = "File_Save";
            this.File_Save.Size = new System.Drawing.Size(72, 23);
            this.File_Save.TabIndex = 5;
            this.File_Save.Text = "Сохранить";
            this.File_Save.UseVisualStyleBackColor = true;
            this.File_Save.Click += new System.EventHandler(this.File_Save_Click);
            // 
            // qantity
            // 
            this.qantity.Location = new System.Drawing.Point(185, 70);
            this.qantity.Name = "qantity";
            this.qantity.Size = new System.Drawing.Size(38, 20);
            this.qantity.TabIndex = 6;
            this.qantity.Text = "1";
            // 
            // file_position
            // 
            this.file_position.Location = new System.Drawing.Point(57, 94);
            this.file_position.Name = "file_position";
            this.file_position.Size = new System.Drawing.Size(244, 20);
            this.file_position.TabIndex = 7;
            this.file_position.Text = "passwords.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Файл:";
            // 
            // Main
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 126);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.file_position);
            this.Controls.Add(this.qantity);
            this.Controls.Add(this.File_Save);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.length);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button File_Save;
        private System.Windows.Forms.TextBox qantity;
        private System.Windows.Forms.TextBox file_position;
        private System.Windows.Forms.Label label2;
    }
}


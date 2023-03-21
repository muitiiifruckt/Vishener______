namespace Первая_пара_тимп
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.encryption = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1267, 744);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.encryption);
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Controls.Add(this.richTextBox3);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1259, 715);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Шифровать";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1041, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Инструкция : вводить можно текст  только с буквами  русского языка , в качестве к" +
    "люча можно вписывать только русские слова без лишних символов и цифр";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ключ";
            // 
            // encryption
            // 
            this.encryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryption.Location = new System.Drawing.Point(430, 437);
            this.encryption.Name = "encryption";
            this.encryption.Size = new System.Drawing.Size(152, 29);
            this.encryption.TabIndex = 6;
            this.encryption.Text = "Зашифровать";
            this.encryption.UseVisualStyleBackColor = true;
            this.encryption.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(636, 6);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(572, 405);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(10, 437);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(171, 29);
            this.richTextBox3.TabIndex = 4;
            this.richTextBox3.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(572, 405);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.richTextBox5);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.richTextBox4);
            this.tabPage2.Controls.Add(this.richTextBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1259, 715);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дешифровать";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1010, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Взломанный ключ";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(1013, 435);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(171, 32);
            this.richTextBox5.TabIndex = 7;
            this.richTextBox5.Text = "";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(426, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Дешифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(636, 6);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(572, 405);
            this.richTextBox4.TabIndex = 3;
            this.richTextBox4.Text = "";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(6, 6);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(572, 405);
            this.richTextBox6.TabIndex = 5;
            this.richTextBox6.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.richTextBox9);
            this.tabPage3.Controls.Add(this.richTextBox8);
            this.tabPage3.Controls.Add(this.richTextBox7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1259, 715);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Расшифровать";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox7
            // 
            this.richTextBox7.Location = new System.Drawing.Point(10, 15);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(572, 405);
            this.richTextBox7.TabIndex = 6;
            this.richTextBox7.Text = "";
            // 
            // richTextBox8
            // 
            this.richTextBox8.Location = new System.Drawing.Point(670, 15);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(572, 405);
            this.richTextBox8.TabIndex = 6;
            this.richTextBox8.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1041, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Инструкция : вводить можно текст  только с буквами  русского языка , в качестве к" +
    "люча можно вписывать только русские слова без лишних символов и цифр";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ключ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(411, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Расшифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // richTextBox9
            // 
            this.richTextBox9.Location = new System.Drawing.Point(10, 445);
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.Size = new System.Drawing.Size(171, 29);
            this.richTextBox9.TabIndex = 9;
            this.richTextBox9.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 538);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button encryption;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox9;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.RichTextBox richTextBox7;
    }
}


namespace hw_esww_cryp
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
            this.Revers_btn = new System.Windows.Forms.Button();
            this.ENG_ALPHABET = new System.Windows.Forms.RadioButton();
            this.RUS_ALPHABET = new System.Windows.Forms.RadioButton();
            this.step_count_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Decrypt_btn = new System.Windows.Forms.Button();
            this.Encrypt_btn = new System.Windows.Forms.Button();
            this.Output_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Input_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Revers_btn
            // 
            this.Revers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Revers_btn.Location = new System.Drawing.Point(287, 189);
            this.Revers_btn.Name = "Revers_btn";
            this.Revers_btn.Size = new System.Drawing.Size(58, 62);
            this.Revers_btn.TabIndex = 19;
            this.Revers_btn.Text = "⇅";
            this.Revers_btn.UseVisualStyleBackColor = true;
            this.Revers_btn.Click += new System.EventHandler(this.Revers_btn_Click);
            // 
            // ENG_ALPHABET
            // 
            this.ENG_ALPHABET.AutoSize = true;
            this.ENG_ALPHABET.Location = new System.Drawing.Point(791, 67);
            this.ENG_ALPHABET.Name = "ENG_ALPHABET";
            this.ENG_ALPHABET.Size = new System.Drawing.Size(166, 21);
            this.ENG_ALPHABET.TabIndex = 18;
            this.ENG_ALPHABET.Text = "Английский алфавит";
            this.ENG_ALPHABET.UseVisualStyleBackColor = true;
            // 
            // RUS_ALPHABET
            // 
            this.RUS_ALPHABET.AutoSize = true;
            this.RUS_ALPHABET.Checked = true;
            this.RUS_ALPHABET.Location = new System.Drawing.Point(791, 30);
            this.RUS_ALPHABET.Name = "RUS_ALPHABET";
            this.RUS_ALPHABET.Size = new System.Drawing.Size(143, 21);
            this.RUS_ALPHABET.TabIndex = 17;
            this.RUS_ALPHABET.TabStop = true;
            this.RUS_ALPHABET.Text = "Русский алфавит";
            this.RUS_ALPHABET.UseVisualStyleBackColor = true;
            // 
            // step_count_tb
            // 
            this.step_count_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step_count_tb.Location = new System.Drawing.Point(791, 142);
            this.step_count_tb.Name = "step_count_tb";
            this.step_count_tb.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.step_count_tb.Size = new System.Drawing.Size(192, 34);
            this.step_count_tb.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(788, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Введите шаг ";
            // 
            // Decrypt_btn
            // 
            this.Decrypt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decrypt_btn.Location = new System.Drawing.Point(791, 237);
            this.Decrypt_btn.Name = "Decrypt_btn";
            this.Decrypt_btn.Size = new System.Drawing.Size(134, 38);
            this.Decrypt_btn.TabIndex = 14;
            this.Decrypt_btn.Text = "Расшифровать";
            this.Decrypt_btn.UseVisualStyleBackColor = true;
            this.Decrypt_btn.Click += new System.EventHandler(this.Decrypt_btn_Click);
            // 
            // Encrypt_btn
            // 
            this.Encrypt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encrypt_btn.Location = new System.Drawing.Point(791, 193);
            this.Encrypt_btn.Name = "Encrypt_btn";
            this.Encrypt_btn.Size = new System.Drawing.Size(134, 38);
            this.Encrypt_btn.TabIndex = 13;
            this.Encrypt_btn.Text = "Зашифровать";
            this.Encrypt_btn.UseVisualStyleBackColor = true;
            this.Encrypt_btn.Click += new System.EventHandler(this.Encrypt_btn_Click);
            // 
            // Output_tb
            // 
            this.Output_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Output_tb.Location = new System.Drawing.Point(15, 257);
            this.Output_tb.Multiline = true;
            this.Output_tb.Name = "Output_tb";
            this.Output_tb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Output_tb.Size = new System.Drawing.Size(732, 196);
            this.Output_tb.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите сообщение";
            // 
            // Input_TB
            // 
            this.Input_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input_TB.Location = new System.Drawing.Point(15, 30);
            this.Input_TB.Multiline = true;
            this.Input_TB.Name = "Input_TB";
            this.Input_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Input_TB.Size = new System.Drawing.Size(732, 146);
            this.Input_TB.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 484);
            this.Controls.Add(this.Revers_btn);
            this.Controls.Add(this.ENG_ALPHABET);
            this.Controls.Add(this.RUS_ALPHABET);
            this.Controls.Add(this.step_count_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Decrypt_btn);
            this.Controls.Add(this.Encrypt_btn);
            this.Controls.Add(this.Output_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input_TB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Revers_btn;
        private System.Windows.Forms.RadioButton ENG_ALPHABET;
        private System.Windows.Forms.RadioButton RUS_ALPHABET;
        private System.Windows.Forms.TextBox step_count_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Decrypt_btn;
        private System.Windows.Forms.Button Encrypt_btn;
        private System.Windows.Forms.TextBox Output_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Input_TB;
    }
}


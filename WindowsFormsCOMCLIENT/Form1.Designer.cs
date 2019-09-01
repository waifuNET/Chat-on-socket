namespace WindowsFormsCOMCLIENT
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
            this.history = new System.Windows.Forms.ListBox();
            this.say = new System.Windows.Forms.Button();
            this.RichText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CurretIp = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.SystemColors.Window;
            this.history.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.history.ForeColor = System.Drawing.SystemColors.MenuText;
            this.history.FormattingEnabled = true;
            this.history.ItemHeight = 20;
            this.history.Location = new System.Drawing.Point(12, 12);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(304, 264);
            this.history.TabIndex = 0;
            // 
            // say
            // 
            this.say.Location = new System.Drawing.Point(12, 409);
            this.say.Name = "say";
            this.say.Size = new System.Drawing.Size(305, 29);
            this.say.TabIndex = 1;
            this.say.Text = "Say";
            this.say.UseVisualStyleBackColor = true;
            this.say.Click += new System.EventHandler(this.Say_Click);
            // 
            // RichText
            // 
            this.RichText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichText.Location = new System.Drawing.Point(13, 304);
            this.RichText.Name = "RichText";
            this.RichText.Size = new System.Drawing.Size(304, 99);
            this.RichText.TabIndex = 2;
            this.RichText.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CurretIp
            // 
            this.CurretIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurretIp.Location = new System.Drawing.Point(322, 12);
            this.CurretIp.Name = "CurretIp";
            this.CurretIp.Size = new System.Drawing.Size(146, 22);
            this.CurretIp.TabIndex = 4;
            this.CurretIp.Text = "192.168.1.100";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Disconnet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CurretIp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RichText);
            this.Controls.Add(this.say);
            this.Controls.Add(this.history);
            this.MinimumSize = new System.Drawing.Size(346, 489);
            this.Name = "Form1";
            this.Text = "ComClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button say;
        private System.Windows.Forms.RichTextBox RichText;
        public System.Windows.Forms.ListBox history;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox CurretIp;
        private System.Windows.Forms.Button button2;
    }
}


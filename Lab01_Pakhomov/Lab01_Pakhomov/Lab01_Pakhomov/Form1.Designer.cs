namespace Lab01_Pakhomov
{
    partial class Form1
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
            this.label_Ok = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Ok
            // 
            this.label_Ok.AutoSize = true;
            this.label_Ok.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Ok.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_Ok.Location = new System.Drawing.Point(439, 263);
            this.label_Ok.Name = "label_Ok";
            this.label_Ok.Size = new System.Drawing.Size(25, 16);
            this.label_Ok.TabIndex = 5;
            this.label_Ok.Text = "OK";
            this.label_Ok.Click += new System.EventHandler(this.label_Ok_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(356, 260);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 4;
            this.button_OK.Text = "Пуск";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_password);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_login);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(312, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Авторизація";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(68, 58);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 22);
            this.textBox_password.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(68, 21);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.PasswordChar = '*';
            this.textBox_login.Size = new System.Drawing.Size(100, 22);
            this.textBox_login.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логін";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Ok);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Ok;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label1;
    }
}


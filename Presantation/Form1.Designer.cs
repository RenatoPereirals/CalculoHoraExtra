namespace WorkHourCalculator
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
            txt_username = new Label();
            txt_password = new Label();
            btn_confirm = new Button();
            input_username = new TextBox();
            input_password = new TextBox();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.AutoSize = true;
            txt_username.Location = new Point(408, 114);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(125, 20);
            txt_username.TabIndex = 0;
            txt_username.Text = "Nome de Usuário";
            txt_username.Click += label1_Click;
            // 
            // txt_password
            // 
            txt_password.AutoSize = true;
            txt_password.Location = new Point(452, 233);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(49, 20);
            txt_password.TabIndex = 1;
            txt_password.Text = "Senha";
            // 
            // btn_confirm
            // 
            btn_confirm.Location = new Point(439, 322);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(94, 29);
            btn_confirm.TabIndex = 2;
            btn_confirm.Text = "Confirmar";
            btn_confirm.UseVisualStyleBackColor = true;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // input_username
            // 
            input_username.Location = new Point(336, 151);
            input_username.Name = "input_username";
            input_username.Size = new Size(269, 27);
            input_username.TabIndex = 3;
            // 
            // input_password
            // 
            input_password.Location = new Point(336, 256);
            input_password.Name = "input_password";
            input_password.Size = new Size(269, 27);
            input_password.TabIndex = 4;
            input_password.TextChanged += input_password_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 514);
            Controls.Add(input_password);
            Controls.Add(input_username);
            Controls.Add(btn_confirm);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt_username;
        private Label txt_password;
        private Button btn_confirm;
        private TextBox input_username;
        private TextBox input_password;
    }
}
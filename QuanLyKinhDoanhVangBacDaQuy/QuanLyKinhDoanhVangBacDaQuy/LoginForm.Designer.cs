namespace QuanLyKinhDoanhVangBacDaQuy
{
    partial class LoginForm
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
            panel1 = new Panel();
            btnExit = new Button();
            btnLogin = new Button();
            panel3 = new Panel();
            txbPassWord = new TextBox();
            labelMatKhau = new Label();
            panel2 = new Panel();
            txbUserName = new TextBox();
            labelTaiKhoan = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(11, 11);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(628, 341);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(334, 261);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 27);
            btnExit.TabIndex = 3;
            btnExit.Text = "Đăng xuất";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(206, 261);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 27);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassWord);
            panel3.Controls.Add(labelMatKhau);
            panel3.Location = new Point(48, 166);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(542, 65);
            panel3.TabIndex = 1;
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(141, 20);
            txbPassWord.Margin = new Padding(2);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(276, 27);
            txbPassWord.TabIndex = 1;
            txbPassWord.UseSystemPasswordChar = true;
            // 
            // labelMatKhau
            // 
            labelMatKhau.AutoSize = true;
            labelMatKhau.Location = new Point(67, 22);
            labelMatKhau.Margin = new Padding(2, 0, 2, 0);
            labelMatKhau.Name = "labelMatKhau";
            labelMatKhau.Size = new Size(70, 20);
            labelMatKhau.TabIndex = 0;
            labelMatKhau.Text = "Mật khẩu";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUserName);
            panel2.Controls.Add(labelTaiKhoan);
            panel2.Location = new Point(48, 80);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(542, 65);
            panel2.TabIndex = 0;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(141, 20);
            txbUserName.Margin = new Padding(2);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(276, 27);
            txbUserName.TabIndex = 0;
            txbUserName.TextChanged += txbUserName_TextChanged;
            // 
            // labelTaiKhoan
            // 
            labelTaiKhoan.AutoSize = true;
            labelTaiKhoan.Location = new Point(67, 25);
            labelTaiKhoan.Margin = new Padding(2, 0, 2, 0);
            labelTaiKhoan.Name = "labelTaiKhoan";
            labelTaiKhoan.Size = new Size(71, 20);
            labelTaiKhoan.TabIndex = 0;
            labelTaiKhoan.Text = "Tài khoản";
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(645, 357);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += LoginForm_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label labelTaiKhoan;
        private Panel panel3;
        private TextBox txbPassWord;
        private Label labelMatKhau;
        private TextBox txbUserName;
        private Button btnLogin;
        private Button btnExit;
    }
}

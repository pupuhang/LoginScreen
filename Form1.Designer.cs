namespace LoginScreen
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
            btnLogin = new Button();
            lblTitle = new Label();
            txtUserId = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Tomato;
            btnLogin.Font = new Font("맑은 고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(230, 297);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(159, 49);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTitle.ForeColor = Color.Snow;
            lblTitle.Location = new Point(230, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(128, 54);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Login";
            // 
            // txtUserId
            // 
            txtUserId.ForeColor = Color.Gray;
            txtUserId.Location = new Point(230, 142);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(159, 27);
            txtUserId.TabIndex = 2;
            txtUserId.Text = "아이디";
            txtUserId.Enter += txtUserId_Enter;
            txtUserId.Leave += txtUserId_Leave;
            // 
            // txtPassword
            // 
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(230, 206);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(159, 27);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "비밀번호";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(591, 450);
            Controls.Add(txtPassword);
            Controls.Add(txtUserId);
            Controls.Add(lblTitle);
            Controls.Add(btnLogin);
            KeyPreview = true;
            Name = "Form1";
            Text = "로그인";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblTitle;
        private TextBox txtUserId;
        private TextBox txtPassword;
    }
}

namespace ToolFaceBook
{
    partial class fLogin
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
            groupBox1 = new GroupBox();
            btnLogOut = new Button();
            btnLogin = new Button();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Menu;
            groupBox1.Controls.Add(btnLogOut);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 207);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            btnLogOut.Image = Properties.Resources._4115230_cancel_close_cross_delete_114048;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(321, 162);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(107, 33);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "Thoát";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnLogin
            // 
            btnLogin.Image = Properties.Resources.in_door_communication_enter_log_in_login_icon_191647;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(187, 162);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 33);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Đăng nhập";
            btnLogin.TextAlign = ContentAlignment.MiddleRight;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(18, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 49);
            panel2.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(169, 9);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(241, 32);
            textBox2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Image = Properties.Resources.lock_outlined_padlock_symbol_for_security_interface_icon_icons_com_57803;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(36, 3);
            label2.Name = "label2";
            label2.Size = new Size(127, 41);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.UseMnemonic = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(17, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 49);
            panel1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 9);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 33);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Image = Properties.Resources._4092564_about_mobile_ui_profile_ui_user_website_1140331;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 33);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 231);
            Controls.Add(groupBox1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLogOut;
        private Button btnLogin;
        private Panel panel2;
        private TextBox textBox2;
        private Label label2;
        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
    }
}
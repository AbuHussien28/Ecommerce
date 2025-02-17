namespace Ecommerce.Presentation
{
    partial class WelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            lb_closeApp = new Label();
            btn_SignUp = new Button();
            lb_WelcomeScreen = new Label();
            btn_Login = new Button();
            pcbox_WelcomeScreen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbox_WelcomeScreen).BeginInit();
            SuspendLayout();
            // 
            // lb_closeApp
            // 
            lb_closeApp.AutoSize = true;
            lb_closeApp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_closeApp.ForeColor = Color.FromArgb(78, 96, 124);
            lb_closeApp.Location = new Point(783, 503);
            lb_closeApp.Name = "lb_closeApp";
            lb_closeApp.Size = new Size(106, 28);
            lb_closeApp.TabIndex = 9;
            lb_closeApp.Text = "Close App";
            lb_closeApp.Click += lb_closeApp_Click;
            // 
            // btn_SignUp
            // 
            btn_SignUp.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            btn_SignUp.ForeColor = Color.FromArgb(78, 96, 124);
            btn_SignUp.Location = new Point(520, 344);
            btn_SignUp.Margin = new Padding(3, 4, 3, 4);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(234, 137);
            btn_SignUp.TabIndex = 8;
            btn_SignUp.Text = "SignUp";
            btn_SignUp.UseVisualStyleBackColor = true;
            btn_SignUp.Click += btn_SignUp_Click;
            // 
            // lb_WelcomeScreen
            // 
            lb_WelcomeScreen.AutoSize = true;
            lb_WelcomeScreen.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lb_WelcomeScreen.ForeColor = Color.FromArgb(24, 63, 118);
            lb_WelcomeScreen.Location = new Point(434, 71);
            lb_WelcomeScreen.Name = "lb_WelcomeScreen";
            lb_WelcomeScreen.Size = new Size(499, 46);
            lb_WelcomeScreen.TabIndex = 7;
            lb_WelcomeScreen.Text = "Welcome To Our E Commerce ";
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            btn_Login.ForeColor = Color.FromArgb(78, 96, 124);
            btn_Login.Location = new Point(520, 165);
            btn_Login.Margin = new Padding(3, 4, 3, 4);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(234, 137);
            btn_Login.TabIndex = 6;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // pcbox_WelcomeScreen
            // 
            pcbox_WelcomeScreen.Image = (Image)resources.GetObject("pcbox_WelcomeScreen.Image");
            pcbox_WelcomeScreen.Location = new Point(23, 109);
            pcbox_WelcomeScreen.Margin = new Padding(3, 4, 3, 4);
            pcbox_WelcomeScreen.Name = "pcbox_WelcomeScreen";
            pcbox_WelcomeScreen.Size = new Size(361, 315);
            pcbox_WelcomeScreen.SizeMode = PictureBoxSizeMode.Zoom;
            pcbox_WelcomeScreen.TabIndex = 5;
            pcbox_WelcomeScreen.TabStop = false;
            // 
            // WelcomeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 600);
            ControlBox = false;
            Controls.Add(lb_closeApp);
            Controls.Add(btn_SignUp);
            Controls.Add(lb_WelcomeScreen);
            Controls.Add(btn_Login);
            Controls.Add(pcbox_WelcomeScreen);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "WelcomeScreen";
            Text = "Ecommerce";
            ((System.ComponentModel.ISupportInitialize)pcbox_WelcomeScreen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_closeApp;
        private Button btn_SignUp;
        private Label lb_WelcomeScreen;
        private Button btn_Login;
        private PictureBox pcbox_WelcomeScreen;
    }
}

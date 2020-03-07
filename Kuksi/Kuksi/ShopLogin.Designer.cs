using System.ComponentModel;

namespace Kuksi
{
    partial class ShopLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.tlpData = new System.Windows.Forms.TableLayoutPanel();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.tlpLogin = new System.Windows.Forms.TableLayoutPanel();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerLabel = new System.Windows.Forms.Label();
            this.succLabel = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.tlpData.SuspendLayout();
            this.tlpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.loginLabel, 0, 0);
            this.tlpMain.Controls.Add(this.tlpData, 0, 1);
            this.tlpMain.Controls.Add(this.tlpLogin, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlpMain.Size = new System.Drawing.Size(933, 519);
            this.tlpMain.TabIndex = 0;
            // 
            // loginLabel
            // 
            this.loginLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.loginLabel.Location = new System.Drawing.Point(3, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(927, 77);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Bejelentkezés";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpData
            // 
            this.tlpData.ColumnCount = 2;
            this.tlpData.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpData.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpData.Controls.Add(this.password, 1, 1);
            this.tlpData.Controls.Add(this.usernameLabel, 0, 0);
            this.tlpData.Controls.Add(this.username, 1, 0);
            this.tlpData.Controls.Add(this.passwordLabel, 0, 1);
            this.tlpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpData.Location = new System.Drawing.Point(3, 80);
            this.tlpData.Name = "tlpData";
            this.tlpData.RowCount = 2;
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpData.Size = new System.Drawing.Size(927, 263);
            this.tlpData.TabIndex = 1;
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.username.Location = new System.Drawing.Point(466, 54);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(283, 23);
            this.username.TabIndex = 0;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.password.Location = new System.Drawing.Point(466, 185);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(283, 23);
            this.password.TabIndex = 1;
            this.password.UseSystemPasswordChar = true;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.usernameLabel.Location = new System.Drawing.Point(3, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(457, 131);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Felhasználónév";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.passwordLabel.Location = new System.Drawing.Point(3, 131);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(457, 132);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Jelszó";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlpLogin
            // 
            this.tlpLogin.ColumnCount = 2;
            this.tlpLogin.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLogin.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLogin.Controls.Add(this.loginButton, 1, 1);
            this.tlpLogin.Controls.Add(this.registerButton, 0, 1);
            this.tlpLogin.Controls.Add(this.registerLabel, 0, 0);
            this.tlpLogin.Controls.Add(this.succLabel, 1, 0);
            this.tlpLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLogin.Location = new System.Drawing.Point(3, 349);
            this.tlpLogin.Name = "tlpLogin";
            this.tlpLogin.RowCount = 2;
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLogin.Size = new System.Drawing.Size(927, 167);
            this.tlpLogin.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.loginButton.Location = new System.Drawing.Point(466, 86);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(458, 78);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Belépés";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.registerButton.Location = new System.Drawing.Point(3, 86);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(457, 78);
            this.registerButton.TabIndex = 1;
            this.registerButton.Text = "Regisztráció";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registerLabel
            // 
            this.registerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.registerLabel.Location = new System.Drawing.Point(3, 0);
            this.registerLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(457, 78);
            this.registerLabel.TabIndex = 2;
            this.registerLabel.Text = "Nincs fiókja? Regisztráljon most!";
            this.registerLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // succLabel
            // 
            this.succLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.succLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.succLabel.Location = new System.Drawing.Point(466, 0);
            this.succLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.succLabel.Name = "succLabel";
            this.succLabel.Size = new System.Drawing.Size(458, 78);
            this.succLabel.TabIndex = 3;
            this.succLabel.Text = "(Sikeres / sikertelen belépés)";
            this.succLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ShopLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tlpMain);
            this.Name = "ShopLogin";
            this.Text = "ShopLogin";
            this.tlpMain.ResumeLayout(false);
            this.tlpData.ResumeLayout(false);
            this.tlpData.PerformLayout();
            this.tlpLogin.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpData;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TableLayoutPanel tlpLogin;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label succLabel;
    }
}
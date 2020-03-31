namespace Beadandó_200417
{
    partial class Login
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
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.dataPanel = new System.Windows.Forms.TableLayoutPanel();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.buttonPanel, 0, 1);
            this.mainPanel.Controls.Add(this.dataPanel, 0, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 2;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainPanel.Size = new System.Drawing.Size(933, 519);
            this.mainPanel.TabIndex = 0;
            // 
            // buttonPanel
            // 
            this.buttonPanel.ColumnCount = 2;
            this.buttonPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.Controls.Add(this.loginButton, 1, 0);
            this.buttonPanel.Controls.Add(this.registerButton, 0, 0);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(3, 392);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.RowCount = 1;
            this.buttonPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonPanel.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.buttonPanel.Size = new System.Drawing.Size(927, 124);
            this.buttonPanel.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.loginButton.Location = new System.Drawing.Point(466, 3);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(458, 118);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Belépés";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.registerButton.Location = new System.Drawing.Point(3, 3);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(457, 118);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Regisztráció";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // dataPanel
            // 
            this.dataPanel.ColumnCount = 2;
            this.dataPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dataPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dataPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataPanel.Controls.Add(this.passwordBox, 1, 1);
            this.dataPanel.Controls.Add(this.usernameBox, 1, 0);
            this.dataPanel.Controls.Add(this.passwordLabel, 0, 1);
            this.dataPanel.Controls.Add(this.usernameLabel, 0, 0);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(3, 3);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.RowCount = 2;
            this.dataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dataPanel.Size = new System.Drawing.Size(927, 383);
            this.dataPanel.TabIndex = 1;
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.passwordBox.Location = new System.Drawing.Point(466, 272);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(455, 29);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // usernameBox
            // 
            this.usernameBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.usernameBox.Location = new System.Drawing.Point(466, 81);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(455, 29);
            this.usernameBox.TabIndex = 0;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.passwordLabel.Location = new System.Drawing.Point(360, 275);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(100, 23);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Jelszó";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.usernameLabel.Location = new System.Drawing.Point(289, 84);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(171, 23);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Felhasználónév";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.mainPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "2018 májusi emelt feladat";
            this.mainPanel.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TableLayoutPanel buttonPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TableLayoutPanel dataPanel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
    }
}
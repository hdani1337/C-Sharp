using System.ComponentModel;

namespace Beadandó_200417
{
    partial class Register
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.registerButton = new System.Windows.Forms.Button();
            this.dataPanel = new System.Windows.Forms.TableLayoutPanel();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.emailPanel = new System.Windows.Forms.Panel();
            this.usernamePanel = new System.Windows.Forms.Panel();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.namePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.registerButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // registerButton
            // 
            this.registerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.registerButton.Location = new System.Drawing.Point(3, 392);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(927, 124);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Regisztráció";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // dataPanel
            // 
            this.dataPanel.ColumnCount = 3;
            this.dataPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.dataPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.dataPanel.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.dataPanel.Controls.Add(this.passwordPanel, 2, 3);
            this.dataPanel.Controls.Add(this.emailPanel, 2, 2);
            this.dataPanel.Controls.Add(this.usernamePanel, 2, 1);
            this.dataPanel.Controls.Add(this.passwordLabel, 0, 3);
            this.dataPanel.Controls.Add(this.nameBox, 1, 0);
            this.dataPanel.Controls.Add(this.nameLabel, 0, 0);
            this.dataPanel.Controls.Add(this.usernameBox, 1, 1);
            this.dataPanel.Controls.Add(this.emailBox, 1, 2);
            this.dataPanel.Controls.Add(this.passwordBox, 1, 3);
            this.dataPanel.Controls.Add(this.emailLabel, 0, 2);
            this.dataPanel.Controls.Add(this.usernameLabel, 0, 1);
            this.dataPanel.Controls.Add(this.namePanel, 2, 0);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(3, 3);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.RowCount = 4;
            this.dataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.dataPanel.Size = new System.Drawing.Size(927, 383);
            this.dataPanel.TabIndex = 1;
            // 
            // passwordPanel
            // 
            this.passwordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordPanel.Location = new System.Drawing.Point(883, 288);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(41, 92);
            this.passwordPanel.TabIndex = 12;
            // 
            // emailPanel
            // 
            this.emailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailPanel.Location = new System.Drawing.Point(883, 193);
            this.emailPanel.Name = "emailPanel";
            this.emailPanel.Size = new System.Drawing.Size(41, 89);
            this.emailPanel.TabIndex = 11;
            // 
            // usernamePanel
            // 
            this.usernamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernamePanel.Location = new System.Drawing.Point(883, 98);
            this.usernamePanel.Name = "usernamePanel";
            this.usernamePanel.Size = new System.Drawing.Size(41, 89);
            this.usernamePanel.TabIndex = 10;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.passwordLabel.Location = new System.Drawing.Point(78, 320);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(197, 28);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Jelszó:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameBox
            // 
            this.nameBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.nameBox.Location = new System.Drawing.Point(281, 31);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(594, 33);
            this.nameBox.TabIndex = 0;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.nameLabel.Location = new System.Drawing.Point(78, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(197, 28);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Teljes neve:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usernameBox
            // 
            this.usernameBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.usernameBox.Location = new System.Drawing.Point(281, 126);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(594, 33);
            this.usernameBox.TabIndex = 3;
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // emailBox
            // 
            this.emailBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.emailBox.Location = new System.Drawing.Point(281, 221);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(594, 33);
            this.emailBox.TabIndex = 4;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.passwordBox.Location = new System.Drawing.Point(281, 317);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(594, 33);
            this.passwordBox.TabIndex = 5;
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.emailLabel.Location = new System.Drawing.Point(78, 223);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(197, 28);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "E-mail cím:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.usernameLabel.Location = new System.Drawing.Point(3, 119);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(272, 47);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "Új felhasználónév:";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // namePanel
            // 
            this.namePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namePanel.Location = new System.Drawing.Point(883, 3);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(41, 89);
            this.namePanel.TabIndex = 9;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.Text = "Regisztráció";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TableLayoutPanel dataPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Panel usernamePanel;
        private System.Windows.Forms.Panel emailPanel;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox nameBox;
    }
}
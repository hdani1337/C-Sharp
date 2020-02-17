namespace Kuksi
{
    partial class frmMain
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.button3, 0, 1);
            this.tlpMain.Controls.Add(this.button2, 1, 0);
            this.tlpMain.Controls.Add(this.button1, 0, 0);
            this.tlpMain.Controls.Add(this.tlpInfo, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(284, 261);
            this.tlpMain.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(3, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 125);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Fuchsia;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(145, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 124);
            this.button2.TabIndex = 1;
            this.button2.Text = "Shop";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 124);
            this.button1.TabIndex = 0;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tlpInfo
            // 
            this.tlpInfo.ColumnCount = 2;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfo.Location = new System.Drawing.Point(145, 133);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 2;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo.Size = new System.Drawing.Size(136, 125);
            this.tlpInfo.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tlpMain);
            this.Name = "frmMain";
            this.Text = "Lajo\'S Computer Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.tlpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
    }
}


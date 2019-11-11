namespace ListUI
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
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tlpTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpTop, 0, 0);
            this.tlpMain.Controls.Add(this.rtbText, 0, 1);
            this.tlpMain.Controls.Add(this.button5, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpMain.Size = new System.Drawing.Size(844, 404);
            this.tlpMain.TabIndex = 0;
            this.tlpMain.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpMain_Paint);
            // 
            // tlpTop
            // 
            this.tlpTop.ColumnCount = 2;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTop.Controls.Add(this.button1, 0, 0);
            this.tlpTop.Controls.Add(this.button2, 1, 0);
            this.tlpTop.Controls.Add(this.button3, 0, 1);
            this.tlpTop.Controls.Add(this.button4, 1, 1);
            this.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTop.Location = new System.Drawing.Point(3, 3);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.RowCount = 2;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTop.Size = new System.Drawing.Size(838, 135);
            this.tlpTop.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(413, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(422, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(413, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(3, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(413, 62);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(422, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(413, 62);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // rtbText
            // 
            this.rtbText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbText.Location = new System.Drawing.Point(3, 144);
            this.rtbText.Name = "rtbText";
            this.rtbText.ReadOnly = true;
            this.rtbText.Size = new System.Drawing.Size(838, 224);
            this.rtbText.TabIndex = 1;
            this.rtbText.Text = "";
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(3, 374);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(838, 27);
            this.button5.TabIndex = 2;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 404);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMain";
            this.Text = "Listák";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Button button5;
    }
}


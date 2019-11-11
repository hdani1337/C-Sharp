namespace GUI
{
    partial class formMain
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.vscRed = new System.Windows.Forms.VScrollBar();
            this.vscBlue = new System.Windows.Forms.VScrollBar();
            this.vscGreen = new System.Windows.Forms.VScrollBar();
            this.lRed = new System.Windows.Forms.Label();
            this.lGreen = new System.Windows.Forms.Label();
            this.lBlue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Maroon;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExit.Location = new System.Drawing.Point(0, 223);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(624, 98);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // vscRed
            // 
            this.vscRed.Location = new System.Drawing.Point(321, -1);
            this.vscRed.Maximum = 264;
            this.vscRed.Name = "vscRed";
            this.vscRed.Size = new System.Drawing.Size(18, 221);
            this.vscRed.TabIndex = 1;
            this.vscRed.Value = 255;
            this.vscRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vscRed_Scroll_1);
            // 
            // vscBlue
            // 
            this.vscBlue.Location = new System.Drawing.Point(9, -1);
            this.vscBlue.Maximum = 264;
            this.vscBlue.Name = "vscBlue";
            this.vscBlue.Size = new System.Drawing.Size(17, 221);
            this.vscBlue.TabIndex = 2;
            this.vscBlue.Value = 255;
            this.vscBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vscRed_Scroll);
            // 
            // vscGreen
            // 
            this.vscGreen.Location = new System.Drawing.Point(163, -1);
            this.vscGreen.Maximum = 264;
            this.vscGreen.Name = "vscGreen";
            this.vscGreen.Size = new System.Drawing.Size(17, 221);
            this.vscGreen.TabIndex = 3;
            this.vscGreen.Value = 255;
            this.vscGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vscGreen_Scroll);
            // 
            // lRed
            // 
            this.lRed.AutoSize = true;
            this.lRed.BackColor = System.Drawing.Color.Black;
            this.lRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lRed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lRed.Location = new System.Drawing.Point(29, 103);
            this.lRed.Name = "lRed";
            this.lRed.Size = new System.Drawing.Size(58, 29);
            this.lRed.TabIndex = 4;
            this.lRed.Text = "Red";
            // 
            // lGreen
            // 
            this.lGreen.AutoSize = true;
            this.lGreen.BackColor = System.Drawing.Color.Black;
            this.lGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lGreen.ForeColor = System.Drawing.SystemColors.Control;
            this.lGreen.Location = new System.Drawing.Point(183, 103);
            this.lGreen.Name = "lGreen";
            this.lGreen.Size = new System.Drawing.Size(80, 29);
            this.lGreen.TabIndex = 5;
            this.lGreen.Text = "Green";
            // 
            // lBlue
            // 
            this.lBlue.AutoSize = true;
            this.lBlue.BackColor = System.Drawing.Color.Black;
            this.lBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lBlue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lBlue.Location = new System.Drawing.Point(342, 103);
            this.lBlue.Name = "lBlue";
            this.lBlue.Size = new System.Drawing.Size(62, 29);
            this.lBlue.TabIndex = 6;
            this.lBlue.Text = "Blue";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.lBlue);
            this.Controls.Add(this.lGreen);
            this.Controls.Add(this.lRed);
            this.Controls.Add(this.vscGreen);
            this.Controls.Add(this.vscBlue);
            this.Controls.Add(this.vscRed);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "formMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.VScrollBar vscRed;
        private System.Windows.Forms.VScrollBar vscBlue;
        private System.Windows.Forms.VScrollBar vscGreen;
        private System.Windows.Forms.Label lRed;
        private System.Windows.Forms.Label lGreen;
        private System.Windows.Forms.Label lBlue;
    }
}


namespace Tavoktatas_200323
{
    partial class Form1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.dgwFilmek = new System.Windows.Forms.DataGridView();
            this.lbMovie = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize) (this.dgwFilmek)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 455);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(909, 52);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "button1";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // dgwFilmek
            // 
            this.dgwFilmek.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilmek.Location = new System.Drawing.Point(12, 12);
            this.dgwFilmek.Name = "dgwFilmek";
            this.dgwFilmek.Size = new System.Drawing.Size(449, 394);
            this.dgwFilmek.TabIndex = 1;
            // 
            // lbMovie
            // 
            this.lbMovie.FormattingEnabled = true;
            this.lbMovie.ItemHeight = 15;
            this.lbMovie.Location = new System.Drawing.Point(479, 12);
            this.lbMovie.Name = "lbMovie";
            this.lbMovie.Size = new System.Drawing.Size(450, 394);
            this.lbMovie.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.lbMovie);
            this.Controls.Add(this.dgwFilmek);
            this.Controls.Add(this.btnExit);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.dgwFilmek)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFilmek;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lbMovie;
    }
}
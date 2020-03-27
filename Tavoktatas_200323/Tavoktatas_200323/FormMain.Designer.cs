namespace Tavoktatas_200323
{
    partial class FormMain
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
            this.btnKolcsonzes = new System.Windows.Forms.Button();
            this.listaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dgwFilmek)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.btnExit.Location = new System.Drawing.Point(12, 455);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(909, 52);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Kilépés";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgwFilmek
            // 
            this.dgwFilmek.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFilmek.Location = new System.Drawing.Point(12, 57);
            this.dgwFilmek.Name = "dgwFilmek";
            this.dgwFilmek.Size = new System.Drawing.Size(727, 393);
            this.dgwFilmek.TabIndex = 1;
            // 
            // btnKolcsonzes
            // 
            this.btnKolcsonzes.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.btnKolcsonzes.Location = new System.Drawing.Point(745, 57);
            this.btnKolcsonzes.Name = "btnKolcsonzes";
            this.btnKolcsonzes.Size = new System.Drawing.Size(176, 84);
            this.btnKolcsonzes.TabIndex = 2;
            this.btnKolcsonzes.Text = "Kölcsönzés";
            this.btnKolcsonzes.UseVisualStyleBackColor = true;
            this.btnKolcsonzes.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaLabel
            // 
            this.listaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.listaLabel.Location = new System.Drawing.Point(12, 20);
            this.listaLabel.Name = "listaLabel";
            this.listaLabel.Size = new System.Drawing.Size(216, 33);
            this.listaLabel.TabIndex = 3;
            this.listaLabel.Text = "Elérhető filmek listája";
            this.listaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.listaLabel);
            this.Controls.Add(this.btnKolcsonzes);
            this.Controls.Add(this.dgwFilmek);
            this.Controls.Add(this.btnExit);
            this.Name = "FormMain";
            this.Text = "Filmek";
            ((System.ComponentModel.ISupportInitialize) (this.dgwFilmek)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgwFilmek;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnKolcsonzes;
        private System.Windows.Forms.Label listaLabel;
    }
}
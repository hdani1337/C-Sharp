namespace Kuksi
{
    partial class Add
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
            this.tlpAddMain = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTipus = new System.Windows.Forms.ComboBox();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.mtAr = new System.Windows.Forms.MaskedTextBox();
            this.mtRaktar = new System.Windows.Forms.MaskedTextBox();
            this.mtDatum = new System.Windows.Forms.MaskedTextBox();
            this.btnFelvetel = new System.Windows.Forms.Button();
            this.tlpAddMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpAddMain
            // 
            this.tlpAddMain.ColumnCount = 5;
            this.tlpAddMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpAddMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpAddMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpAddMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpAddMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpAddMain.Controls.Add(this.label1, 0, 0);
            this.tlpAddMain.Controls.Add(this.label2, 0, 1);
            this.tlpAddMain.Controls.Add(this.label3, 0, 2);
            this.tlpAddMain.Controls.Add(this.label4, 0, 3);
            this.tlpAddMain.Controls.Add(this.label5, 0, 4);
            this.tlpAddMain.Controls.Add(this.cboTipus, 1, 0);
            this.tlpAddMain.Controls.Add(this.txtNev, 1, 1);
            this.tlpAddMain.Controls.Add(this.mtAr, 1, 2);
            this.tlpAddMain.Controls.Add(this.mtRaktar, 1, 3);
            this.tlpAddMain.Controls.Add(this.mtDatum, 1, 4);
            this.tlpAddMain.Controls.Add(this.btnFelvetel, 4, 4);
            this.tlpAddMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddMain.Location = new System.Drawing.Point(0, 0);
            this.tlpAddMain.Name = "tlpAddMain";
            this.tlpAddMain.RowCount = 5;
            this.tlpAddMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAddMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAddMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAddMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAddMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAddMain.Size = new System.Drawing.Size(619, 331);
            this.tlpAddMain.TabIndex = 1;
            this.tlpAddMain.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpAddMain_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Típus";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 66);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 66);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ár";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 66);
            this.label4.TabIndex = 3;
            this.label4.Text = "Darab";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 67);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dátum";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboTipus
            // 
            this.cboTipus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTipus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboTipus.FormattingEnabled = true;
            this.cboTipus.Location = new System.Drawing.Point(100, 19);
            this.cboTipus.Name = "cboTipus";
            this.cboTipus.Size = new System.Drawing.Size(200, 28);
            this.cboTipus.TabIndex = 5;
            // 
            // txtNev
            // 
            this.txtNev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNev.Location = new System.Drawing.Point(100, 86);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(200, 26);
            this.txtNev.TabIndex = 6;
            // 
            // mtAr
            // 
            this.mtAr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtAr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtAr.Location = new System.Drawing.Point(100, 152);
            this.mtAr.Mask = "000000 Ft";
            this.mtAr.Name = "mtAr";
            this.mtAr.Size = new System.Drawing.Size(200, 26);
            this.mtAr.TabIndex = 7;
            this.mtAr.ValidatingType = typeof(int);
            // 
            // mtRaktar
            // 
            this.mtRaktar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtRaktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtRaktar.Location = new System.Drawing.Point(100, 218);
            this.mtRaktar.Mask = "0000 db";
            this.mtRaktar.Name = "mtRaktar";
            this.mtRaktar.Size = new System.Drawing.Size(200, 26);
            this.mtRaktar.TabIndex = 8;
            // 
            // mtDatum
            // 
            this.mtDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtDatum.Location = new System.Drawing.Point(100, 284);
            this.mtDatum.Mask = "0000-00-00";
            this.mtDatum.Name = "mtDatum";
            this.mtDatum.Size = new System.Drawing.Size(200, 26);
            this.mtDatum.TabIndex = 9;
            this.mtDatum.ValidatingType = typeof(System.DateTime);
            // 
            // btnFelvetel
            // 
            this.btnFelvetel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFelvetel.Location = new System.Drawing.Point(433, 267);
            this.btnFelvetel.Name = "btnFelvetel";
            this.btnFelvetel.Size = new System.Drawing.Size(183, 61);
            this.btnFelvetel.TabIndex = 10;
            this.btnFelvetel.Text = "Felvétel";
            this.btnFelvetel.UseVisualStyleBackColor = true;
            this.btnFelvetel.Click += new System.EventHandler(this.btnFelvetel_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 331);
            this.Controls.Add(this.tlpAddMain);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.tlpAddMain.ResumeLayout(false);
            this.tlpAddMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAddMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTipus;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.MaskedTextBox mtAr;
        private System.Windows.Forms.MaskedTextBox mtRaktar;
        private System.Windows.Forms.MaskedTextBox mtDatum;
        private System.Windows.Forms.Button btnFelvetel;
    }
}
using System.ComponentModel;

namespace Beadandó_200417
{
    partial class Erettsegi
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
            this.outBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.hetedikFeladat = new System.Windows.Forms.Button();
            this.hatodikFeladat = new System.Windows.Forms.Button();
            this.otodikFeladat = new System.Windows.Forms.Button();
            this.negyedikFeladat = new System.Windows.Forms.Button();
            this.harmadikFeladat = new System.Windows.Forms.Button();
            this.masodikFeladat = new System.Windows.Forms.Button();
            this.elsoFeladat = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.outBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 519F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // outBox
            // 
            this.outBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outBox.Location = new System.Drawing.Point(282, 3);
            this.outBox.Name = "outBox";
            this.outBox.ReadOnly = true;
            this.outBox.Size = new System.Drawing.Size(648, 513);
            this.outBox.TabIndex = 0;
            this.outBox.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.hetedikFeladat, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.hatodikFeladat, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.otodikFeladat, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.negyedikFeladat, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.harmadikFeladat, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.masodikFeladat, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.elsoFeladat, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(273, 513);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // hetedikFeladat
            // 
            this.hetedikFeladat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hetedikFeladat.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.hetedikFeladat.Location = new System.Drawing.Point(3, 441);
            this.hetedikFeladat.Name = "hetedikFeladat";
            this.hetedikFeladat.Size = new System.Drawing.Size(267, 69);
            this.hetedikFeladat.TabIndex = 6;
            this.hetedikFeladat.Text = "Hetedik feladat";
            this.hetedikFeladat.UseVisualStyleBackColor = true;
            this.hetedikFeladat.Click += new System.EventHandler(this.hetedikFeladat_Click);
            // 
            // hatodikFeladat
            // 
            this.hatodikFeladat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hatodikFeladat.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.hatodikFeladat.Location = new System.Drawing.Point(3, 368);
            this.hatodikFeladat.Name = "hatodikFeladat";
            this.hatodikFeladat.Size = new System.Drawing.Size(267, 67);
            this.hatodikFeladat.TabIndex = 5;
            this.hatodikFeladat.Text = "Hatodik feladat";
            this.hatodikFeladat.UseVisualStyleBackColor = true;
            this.hatodikFeladat.Click += new System.EventHandler(this.hatodikFeladat_Click);
            // 
            // otodikFeladat
            // 
            this.otodikFeladat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otodikFeladat.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.otodikFeladat.Location = new System.Drawing.Point(3, 295);
            this.otodikFeladat.Name = "otodikFeladat";
            this.otodikFeladat.Size = new System.Drawing.Size(267, 67);
            this.otodikFeladat.TabIndex = 4;
            this.otodikFeladat.Text = "Ötödik feladat";
            this.otodikFeladat.UseVisualStyleBackColor = true;
            this.otodikFeladat.Click += new System.EventHandler(this.otodikFeladat_Click);
            // 
            // negyedikFeladat
            // 
            this.negyedikFeladat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.negyedikFeladat.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.negyedikFeladat.Location = new System.Drawing.Point(3, 222);
            this.negyedikFeladat.Name = "negyedikFeladat";
            this.negyedikFeladat.Size = new System.Drawing.Size(267, 67);
            this.negyedikFeladat.TabIndex = 3;
            this.negyedikFeladat.Text = "Negyedik feladat";
            this.negyedikFeladat.UseVisualStyleBackColor = true;
            this.negyedikFeladat.Click += new System.EventHandler(this.negyedikFeladat_Click);
            // 
            // harmadikFeladat
            // 
            this.harmadikFeladat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.harmadikFeladat.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.harmadikFeladat.Location = new System.Drawing.Point(3, 149);
            this.harmadikFeladat.Name = "harmadikFeladat";
            this.harmadikFeladat.Size = new System.Drawing.Size(267, 67);
            this.harmadikFeladat.TabIndex = 2;
            this.harmadikFeladat.Text = "Harmadik feladat";
            this.harmadikFeladat.UseVisualStyleBackColor = true;
            this.harmadikFeladat.Click += new System.EventHandler(this.harmadikFeladat_Click);
            // 
            // masodikFeladat
            // 
            this.masodikFeladat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masodikFeladat.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.masodikFeladat.Location = new System.Drawing.Point(3, 76);
            this.masodikFeladat.Name = "masodikFeladat";
            this.masodikFeladat.Size = new System.Drawing.Size(267, 67);
            this.masodikFeladat.TabIndex = 1;
            this.masodikFeladat.Text = "Második feladat";
            this.masodikFeladat.UseVisualStyleBackColor = true;
            this.masodikFeladat.Click += new System.EventHandler(this.masodikFeladat_Click);
            // 
            // elsoFeladat
            // 
            this.elsoFeladat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elsoFeladat.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.elsoFeladat.Location = new System.Drawing.Point(3, 3);
            this.elsoFeladat.Name = "elsoFeladat";
            this.elsoFeladat.Size = new System.Drawing.Size(267, 67);
            this.elsoFeladat.TabIndex = 0;
            this.elsoFeladat.Text = "Első feladat";
            this.elsoFeladat.UseVisualStyleBackColor = true;
            this.elsoFeladat.Click += new System.EventHandler(this.elsoFeladat_Click);
            // 
            // Erettsegi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Erettsegi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Érettségi - 2018. május, emelt szint";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button elsoFeladat;
        private System.Windows.Forms.RichTextBox outBox;
        private System.Windows.Forms.Button masodikFeladat;
        private System.Windows.Forms.Button harmadikFeladat;
        private System.Windows.Forms.Button negyedikFeladat;
        private System.Windows.Forms.Button otodikFeladat;
        private System.Windows.Forms.Button hetedikFeladat;
        private System.Windows.Forms.Button hatodikFeladat;
    }
}
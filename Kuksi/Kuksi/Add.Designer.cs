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
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 331);
            this.Controls.Add(this.tlpAddMain);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAddMain;
    }
}
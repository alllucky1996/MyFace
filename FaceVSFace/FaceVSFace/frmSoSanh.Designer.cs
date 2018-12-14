namespace FaceVSFace
{
    partial class frmSoSanh
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVS = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnCapture = new System.Windows.Forms.ToolStripButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgFromCammera = new System.Windows.Forms.PictureBox();
            this.imgCMT = new System.Windows.Forms.PictureBox();
            this.toolStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFromCammera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCMT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "So sánh click vào đây";
            // 
            // btnVS
            // 
            this.btnVS.Location = new System.Drawing.Point(387, 349);
            this.btnVS.Name = "btnVS";
            this.btnVS.Size = new System.Drawing.Size(110, 43);
            this.btnVS.TabIndex = 2;
            this.btnVS.Text = "So sánh";
            this.btnVS.UseVisualStyleBackColor = true;
            this.btnVS.Click += new System.EventHandler(this.btnVS_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Snow;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 82);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(885, 37);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Home";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCapture});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(885, 58);
            this.toolStrip.TabIndex = 6;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btnCapture
            // 
            this.btnCapture.AutoSize = false;
            this.btnCapture.Image = global::FaceVSFace.Properties.Resources.Photograph;
            this.btnCapture.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCapture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(152, 55);
            this.btnCapture.Text = "Chụp hình";
            this.btnCapture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(885, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // imgFromCammera
            // 
            this.imgFromCammera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgFromCammera.Location = new System.Drawing.Point(76, 216);
            this.imgFromCammera.Name = "imgFromCammera";
            this.imgFromCammera.Size = new System.Drawing.Size(256, 256);
            this.imgFromCammera.TabIndex = 0;
            this.imgFromCammera.TabStop = false;
            // 
            // imgCMT
            // 
            this.imgCMT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCMT.Location = new System.Drawing.Point(553, 216);
            this.imgCMT.Name = "imgCMT";
            this.imgCMT.Size = new System.Drawing.Size(256, 256);
            this.imgCMT.TabIndex = 0;
            this.imgCMT.TabStop = false;
            this.imgCMT.Click += new System.EventHandler(this.imgCMT_Click);
            // 
            // frmSoSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(885, 531);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.btnVS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgFromCammera);
            this.Controls.Add(this.imgCMT);
            this.Name = "frmSoSanh";
            this.Text = "So sánh 2 khuôn mặt";
            this.Load += new System.EventHandler(this.frmSoSanh_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFromCammera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCMT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgCMT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVS;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnCapture;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgFromCammera;
    }
}


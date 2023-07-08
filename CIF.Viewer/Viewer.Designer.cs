namespace CIF.Viewer
{
    partial class Viewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMS = new System.Windows.Forms.MenuStrip();
            this.FileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.NewTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.RecentTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TSS1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TSS2 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseFileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.EditTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TSS3 = new System.Windows.Forms.ToolStripSeparator();
            this.CopyTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolboxTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorSelectorTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.LayersTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowHelpTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolGB = new System.Windows.Forms.GroupBox();
            this.ToolPenBtn = new System.Windows.Forms.Button();
            this.ColorSelectorGB = new System.Windows.Forms.GroupBox();
            this.LayersGB = new System.Windows.Forms.GroupBox();
            this.MainPB = new System.Windows.Forms.PictureBox();
            this.ViewerPanel = new System.Windows.Forms.Panel();
            this.MainMS.SuspendLayout();
            this.ToolGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPB)).BeginInit();
            this.ViewerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMS
            // 
            this.MainMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTSMI,
            this.EditTSMI,
            this.ViewTSMI,
            this.HelpTSMI});
            this.MainMS.Location = new System.Drawing.Point(0, 0);
            this.MainMS.Name = "MainMS";
            this.MainMS.Size = new System.Drawing.Size(984, 24);
            this.MainMS.TabIndex = 0;
            this.MainMS.Text = "menuStrip1";
            // 
            // FileTSMI
            // 
            this.FileTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewTSMI,
            this.OpenTSMI,
            this.RecentTSMI,
            this.TSS1,
            this.SaveTSMI,
            this.SaveAsTSMI,
            this.TSS2,
            this.CloseFileTSMI,
            this.QuitTSMI});
            this.FileTSMI.Name = "FileTSMI";
            this.FileTSMI.Size = new System.Drawing.Size(37, 20);
            this.FileTSMI.Text = "&File";
            // 
            // NewTSMI
            // 
            this.NewTSMI.Name = "NewTSMI";
            this.NewTSMI.Size = new System.Drawing.Size(142, 22);
            this.NewTSMI.Text = "&New";
            // 
            // OpenTSMI
            // 
            this.OpenTSMI.Name = "OpenTSMI";
            this.OpenTSMI.Size = new System.Drawing.Size(142, 22);
            this.OpenTSMI.Text = "&Open";
            // 
            // RecentTSMI
            // 
            this.RecentTSMI.Name = "RecentTSMI";
            this.RecentTSMI.Size = new System.Drawing.Size(142, 22);
            this.RecentTSMI.Text = "Open &Recent";
            // 
            // TSS1
            // 
            this.TSS1.Name = "TSS1";
            this.TSS1.Size = new System.Drawing.Size(139, 6);
            // 
            // SaveTSMI
            // 
            this.SaveTSMI.Name = "SaveTSMI";
            this.SaveTSMI.Size = new System.Drawing.Size(142, 22);
            this.SaveTSMI.Text = "&Save";
            // 
            // SaveAsTSMI
            // 
            this.SaveAsTSMI.Name = "SaveAsTSMI";
            this.SaveAsTSMI.Size = new System.Drawing.Size(142, 22);
            this.SaveAsTSMI.Text = "Save &As";
            // 
            // TSS2
            // 
            this.TSS2.Name = "TSS2";
            this.TSS2.Size = new System.Drawing.Size(139, 6);
            // 
            // CloseFileTSMI
            // 
            this.CloseFileTSMI.Name = "CloseFileTSMI";
            this.CloseFileTSMI.Size = new System.Drawing.Size(142, 22);
            this.CloseFileTSMI.Text = "Close F&ile";
            // 
            // QuitTSMI
            // 
            this.QuitTSMI.Name = "QuitTSMI";
            this.QuitTSMI.Size = new System.Drawing.Size(142, 22);
            this.QuitTSMI.Text = "&Quit";
            // 
            // EditTSMI
            // 
            this.EditTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoTSMI,
            this.RedoTSMI,
            this.TSS3,
            this.CopyTSMI,
            this.CutTSMI,
            this.PasteTSMI,
            this.DeleteTSMI,
            this.SelectAllTSMI});
            this.EditTSMI.Name = "EditTSMI";
            this.EditTSMI.Size = new System.Drawing.Size(39, 20);
            this.EditTSMI.Text = "&Edit";
            // 
            // UndoTSMI
            // 
            this.UndoTSMI.Name = "UndoTSMI";
            this.UndoTSMI.Size = new System.Drawing.Size(122, 22);
            this.UndoTSMI.Text = "&Undo";
            // 
            // RedoTSMI
            // 
            this.RedoTSMI.Name = "RedoTSMI";
            this.RedoTSMI.Size = new System.Drawing.Size(122, 22);
            this.RedoTSMI.Text = "&Redo";
            // 
            // TSS3
            // 
            this.TSS3.Name = "TSS3";
            this.TSS3.Size = new System.Drawing.Size(119, 6);
            // 
            // CopyTSMI
            // 
            this.CopyTSMI.Name = "CopyTSMI";
            this.CopyTSMI.Size = new System.Drawing.Size(122, 22);
            this.CopyTSMI.Text = "&Copy";
            // 
            // CutTSMI
            // 
            this.CutTSMI.Name = "CutTSMI";
            this.CutTSMI.Size = new System.Drawing.Size(122, 22);
            this.CutTSMI.Text = "Cu&t";
            // 
            // PasteTSMI
            // 
            this.PasteTSMI.Name = "PasteTSMI";
            this.PasteTSMI.Size = new System.Drawing.Size(122, 22);
            this.PasteTSMI.Text = "&Paste";
            // 
            // DeleteTSMI
            // 
            this.DeleteTSMI.Name = "DeleteTSMI";
            this.DeleteTSMI.Size = new System.Drawing.Size(122, 22);
            this.DeleteTSMI.Text = "&Delete";
            // 
            // SelectAllTSMI
            // 
            this.SelectAllTSMI.Name = "SelectAllTSMI";
            this.SelectAllTSMI.Size = new System.Drawing.Size(122, 22);
            this.SelectAllTSMI.Text = "Select &All";
            // 
            // ViewTSMI
            // 
            this.ViewTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolboxTSMI,
            this.ColorSelectorTSMI,
            this.LayersTSMI});
            this.ViewTSMI.Name = "ViewTSMI";
            this.ViewTSMI.Size = new System.Drawing.Size(44, 20);
            this.ViewTSMI.Text = "&View";
            // 
            // ToolboxTSMI
            // 
            this.ToolboxTSMI.Name = "ToolboxTSMI";
            this.ToolboxTSMI.Size = new System.Drawing.Size(148, 22);
            this.ToolboxTSMI.Text = "&Toolbox";
            // 
            // ColorSelectorTSMI
            // 
            this.ColorSelectorTSMI.Name = "ColorSelectorTSMI";
            this.ColorSelectorTSMI.Size = new System.Drawing.Size(148, 22);
            this.ColorSelectorTSMI.Text = "&Color Selector";
            // 
            // LayersTSMI
            // 
            this.LayersTSMI.Name = "LayersTSMI";
            this.LayersTSMI.Size = new System.Drawing.Size(148, 22);
            this.LayersTSMI.Text = "&Layers";
            // 
            // HelpTSMI
            // 
            this.HelpTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowHelpTSMI,
            this.AboutTSMI});
            this.HelpTSMI.Name = "HelpTSMI";
            this.HelpTSMI.Size = new System.Drawing.Size(44, 20);
            this.HelpTSMI.Text = "&Help";
            // 
            // ShowHelpTSMI
            // 
            this.ShowHelpTSMI.Name = "ShowHelpTSMI";
            this.ShowHelpTSMI.Size = new System.Drawing.Size(131, 22);
            this.ShowHelpTSMI.Text = "&Show Help";
            // 
            // AboutTSMI
            // 
            this.AboutTSMI.Name = "AboutTSMI";
            this.AboutTSMI.Size = new System.Drawing.Size(131, 22);
            this.AboutTSMI.Text = "&About";
            // 
            // ToolGB
            // 
            this.ToolGB.Controls.Add(this.ToolPenBtn);
            this.ToolGB.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolGB.Location = new System.Drawing.Point(0, 24);
            this.ToolGB.Name = "ToolGB";
            this.ToolGB.Size = new System.Drawing.Size(150, 587);
            this.ToolGB.TabIndex = 1;
            this.ToolGB.TabStop = false;
            this.ToolGB.Text = "Toolbox";
            // 
            // ToolPenBtn
            // 
            this.ToolPenBtn.Image = global::CIF.Viewer.Resources.ToolPen;
            this.ToolPenBtn.Location = new System.Drawing.Point(12, 22);
            this.ToolPenBtn.Name = "ToolPenBtn";
            this.ToolPenBtn.Size = new System.Drawing.Size(30, 30);
            this.ToolPenBtn.TabIndex = 0;
            this.ToolPenBtn.UseVisualStyleBackColor = true;
            // 
            // ColorSelectorGB
            // 
            this.ColorSelectorGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorSelectorGB.Location = new System.Drawing.Point(784, 24);
            this.ColorSelectorGB.Name = "ColorSelectorGB";
            this.ColorSelectorGB.Size = new System.Drawing.Size(200, 331);
            this.ColorSelectorGB.TabIndex = 2;
            this.ColorSelectorGB.TabStop = false;
            this.ColorSelectorGB.Text = "Color Selector";
            // 
            // LayersGB
            // 
            this.LayersGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayersGB.Location = new System.Drawing.Point(784, 361);
            this.LayersGB.Name = "LayersGB";
            this.LayersGB.Size = new System.Drawing.Size(200, 250);
            this.LayersGB.TabIndex = 3;
            this.LayersGB.TabStop = false;
            this.LayersGB.Text = "Layers";
            // 
            // MainPB
            // 
            this.MainPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPB.BackColor = System.Drawing.Color.White;
            this.MainPB.Location = new System.Drawing.Point(3, 3);
            this.MainPB.Name = "MainPB";
            this.MainPB.Size = new System.Drawing.Size(622, 587);
            this.MainPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MainPB.TabIndex = 4;
            this.MainPB.TabStop = false;
            // 
            // ViewerPanel
            // 
            this.ViewerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewerPanel.AutoScroll = true;
            this.ViewerPanel.Controls.Add(this.MainPB);
            this.ViewerPanel.Location = new System.Drawing.Point(156, 27);
            this.ViewerPanel.Name = "ViewerPanel";
            this.ViewerPanel.Size = new System.Drawing.Size(622, 572);
            this.ViewerPanel.TabIndex = 5;
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.ViewerPanel);
            this.Controls.Add(this.LayersGB);
            this.Controls.Add(this.ColorSelectorGB);
            this.Controls.Add(this.ToolGB);
            this.Controls.Add(this.MainMS);
            this.MainMenuStrip = this.MainMS;
            this.Name = "Viewer";
            this.Text = "CIF Viewer";
            this.Load += new System.EventHandler(this.Viewer_Load);
            this.MainMS.ResumeLayout(false);
            this.MainMS.PerformLayout();
            this.ToolGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPB)).EndInit();
            this.ViewerPanel.ResumeLayout(false);
            this.ViewerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MainMS;
        private ToolStripMenuItem FileTSMI;
        private ToolStripMenuItem NewTSMI;
        private ToolStripMenuItem OpenTSMI;
        private ToolStripMenuItem RecentTSMI;
        private ToolStripSeparator TSS1;
        private ToolStripMenuItem SaveTSMI;
        private ToolStripMenuItem SaveAsTSMI;
        private ToolStripSeparator TSS2;
        private ToolStripMenuItem CloseFileTSMI;
        private ToolStripMenuItem QuitTSMI;
        private ToolStripMenuItem EditTSMI;
        private ToolStripMenuItem ViewTSMI;
        private ToolStripMenuItem HelpTSMI;
        private ToolStripMenuItem UndoTSMI;
        private ToolStripMenuItem RedoTSMI;
        private ToolStripSeparator TSS3;
        private ToolStripMenuItem CopyTSMI;
        private ToolStripMenuItem CutTSMI;
        private ToolStripMenuItem PasteTSMI;
        private ToolStripMenuItem DeleteTSMI;
        private ToolStripMenuItem SelectAllTSMI;
        private ToolStripMenuItem ToolboxTSMI;
        private ToolStripMenuItem ColorSelectorTSMI;
        private ToolStripMenuItem ShowHelpTSMI;
        private ToolStripMenuItem AboutTSMI;
        private GroupBox ToolGB;
        private ToolStripMenuItem LayersTSMI;
        private GroupBox ColorSelectorGB;
        private GroupBox LayersGB;
        public PictureBox MainPB;
        private Button ToolPenBtn;
        private Panel ViewerPanel;
    }
}
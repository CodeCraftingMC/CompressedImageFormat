namespace CIF.Viewer
{
    partial class NewFileDialog
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.WidthNUD = new System.Windows.Forms.NumericUpDown();
            this.HeightNUD = new System.Windows.Forms.NumericUpDown();
            this.BackColorDialog = new System.Windows.Forms.ColorDialog();
            this.ColorBtn = new System.Windows.Forms.Button();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.BackColorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(12, 136);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // OkBtn
            // 
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(105, 136);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // WidthNUD
            // 
            this.WidthNUD.Location = new System.Drawing.Point(105, 12);
            this.WidthNUD.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.WidthNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthNUD.Name = "WidthNUD";
            this.WidthNUD.Size = new System.Drawing.Size(75, 23);
            this.WidthNUD.TabIndex = 2;
            this.WidthNUD.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // HeightNUD
            // 
            this.HeightNUD.Location = new System.Drawing.Point(105, 41);
            this.HeightNUD.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.HeightNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightNUD.Name = "HeightNUD";
            this.HeightNUD.Size = new System.Drawing.Size(75, 23);
            this.HeightNUD.TabIndex = 3;
            this.HeightNUD.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // ColorBtn
            // 
            this.ColorBtn.BackColor = System.Drawing.Color.White;
            this.ColorBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ColorBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ColorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorBtn.Location = new System.Drawing.Point(105, 102);
            this.ColorBtn.Name = "ColorBtn";
            this.ColorBtn.Size = new System.Drawing.Size(75, 23);
            this.ColorBtn.TabIndex = 4;
            this.ColorBtn.UseVisualStyleBackColor = false;
            this.ColorBtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(12, 19);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(42, 15);
            this.WidthLabel.TabIndex = 5;
            this.WidthLabel.Text = "Width:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(12, 42);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(46, 15);
            this.HeightLabel.TabIndex = 5;
            this.HeightLabel.Text = "Height:";
            // 
            // BackColorLabel
            // 
            this.BackColorLabel.AutoSize = true;
            this.BackColorLabel.Location = new System.Drawing.Point(12, 105);
            this.BackColorLabel.Name = "BackColorLabel";
            this.BackColorLabel.Size = new System.Drawing.Size(67, 15);
            this.BackColorLabel.TabIndex = 5;
            this.BackColorLabel.Text = "Back Color:";
            // 
            // NewFileDialog
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(192, 171);
            this.Controls.Add(this.BackColorLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.ColorBtn);
            this.Controls.Add(this.HeightNUD);
            this.Controls.Add(this.WidthNUD);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.CancelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewFileDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New";
            ((System.ComponentModel.ISupportInitialize)(this.WidthNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CancelBtn;
        private Button OkBtn;
        private NumericUpDown WidthNUD;
        private NumericUpDown HeightNUD;
        private ColorDialog BackColorDialog;
        private Button ColorBtn;
        private Label WidthLabel;
        private Label HeightLabel;
        private Label BackColorLabel;
    }
}
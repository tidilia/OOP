
namespace laba06_selfmade
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShapeLabel = new System.Windows.Forms.Label();
            this.ShapeComboBox = new System.Windows.Forms.ComboBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.CreatingCheckBox = new System.Windows.Forms.CheckBox();
            this.SizeTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(28, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1060, 700);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            // 
            // ShapeLabel
            // 
            this.ShapeLabel.AutoSize = true;
            this.ShapeLabel.Location = new System.Drawing.Point(1122, 133);
            this.ShapeLabel.Name = "ShapeLabel";
            this.ShapeLabel.Size = new System.Drawing.Size(164, 32);
            this.ShapeLabel.TabIndex = 1;
            this.ShapeLabel.Text = "Choose shape";
            // 
            // ShapeComboBox
            // 
            this.ShapeComboBox.FormattingEnabled = true;
            this.ShapeComboBox.Items.AddRange(new object[] {
            "Triangle",
            "Rectangle",
            "Circle"});
            this.ShapeComboBox.Location = new System.Drawing.Point(1122, 199);
            this.ShapeComboBox.Name = "ShapeComboBox";
            this.ShapeComboBox.Size = new System.Drawing.Size(242, 40);
            this.ShapeComboBox.TabIndex = 2;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(1122, 264);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(141, 32);
            this.SizeLabel.TabIndex = 3;
            this.SizeLabel.Text = "Choose size";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(1122, 424);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(154, 32);
            this.ColorLabel.TabIndex = 5;
            this.ColorLabel.Text = "Choose color";
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Pink"});
            this.ColorComboBox.Location = new System.Drawing.Point(1122, 478);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(242, 40);
            this.ColorComboBox.TabIndex = 6;
            this.ColorComboBox.SelectedValueChanged += new System.EventHandler(this.ColorComboBox_SelectedValueChanged);
            // 
            // CreatingCheckBox
            // 
            this.CreatingCheckBox.AutoSize = true;
            this.CreatingCheckBox.Location = new System.Drawing.Point(1122, 62);
            this.CreatingCheckBox.Name = "CreatingCheckBox";
            this.CreatingCheckBox.Size = new System.Drawing.Size(255, 36);
            this.CreatingCheckBox.TabIndex = 7;
            this.CreatingCheckBox.Text = "Create a new shape";
            this.CreatingCheckBox.UseVisualStyleBackColor = true;
            // 
            // SizeTrackBar
            // 
            this.SizeTrackBar.Location = new System.Drawing.Point(1122, 331);
            this.SizeTrackBar.Maximum = 300;
            this.SizeTrackBar.Name = "SizeTrackBar";
            this.SizeTrackBar.Size = new System.Drawing.Size(242, 90);
            this.SizeTrackBar.TabIndex = 10;
            this.SizeTrackBar.ValueChanged += new System.EventHandler(this.SizeTrackBar_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1631, 850);
            this.Controls.Add(this.SizeTrackBar);
            this.Controls.Add(this.CreatingCheckBox);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.ShapeComboBox);
            this.Controls.Add(this.ShapeLabel);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ShapeLabel;
        private System.Windows.Forms.ComboBox ShapeComboBox;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.CheckBox CreatingCheckBox;
        private System.Windows.Forms.TrackBar SizeTrackBar;
    }
}


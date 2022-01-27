
namespace laba01
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OKnameB = new System.Windows.Forms.Button();
            this.greetBox = new System.Windows.Forms.TextBox();
            this.delBox = new System.Windows.Forms.TextBox();
            this.delB = new System.Windows.Forms.Button();
            this.LanguageCBox = new System.Windows.Forms.ComboBox();
            this.LanguageL = new System.Windows.Forms.Label();
            this.WorkCompleteChBox = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.UniversLBox = new System.Windows.Forms.ListBox();
            this.testL = new System.Windows.Forms.Label();
            this.colorP = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.newbbut = new System.Windows.Forms.Button();
            this.birthMaskTB = new System.Windows.Forms.MaskedTextBox();
            this.DateofBirthL = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerButton = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(224, 42);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 44);
            this.textBox1.TabIndex = 1;
            this.textBox1.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // OKnameB
            // 
            this.OKnameB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OKnameB.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKnameB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.OKnameB.Location = new System.Drawing.Point(494, 42);
            this.OKnameB.Margin = new System.Windows.Forms.Padding(4);
            this.OKnameB.Name = "OKnameB";
            this.OKnameB.Size = new System.Drawing.Size(124, 44);
            this.OKnameB.TabIndex = 2;
            this.OKnameB.Text = "OK";
            this.OKnameB.UseVisualStyleBackColor = false;
            this.OKnameB.Click += new System.EventHandler(this.OKnameB_Click);
            // 
            // greetBox
            // 
            this.greetBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greetBox.Location = new System.Drawing.Point(44, 117);
            this.greetBox.Margin = new System.Windows.Forms.Padding(4);
            this.greetBox.Name = "greetBox";
            this.greetBox.Size = new System.Drawing.Size(576, 47);
            this.greetBox.TabIndex = 3;
            this.greetBox.MouseLeave += new System.EventHandler(this.greetBox_MouseLeave);
            this.greetBox.MouseHover += new System.EventHandler(this.greetBox_MouseHover);
            // 
            // delBox
            // 
            this.delBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delBox.Location = new System.Drawing.Point(44, 185);
            this.delBox.Margin = new System.Windows.Forms.Padding(4);
            this.delBox.Name = "delBox";
            this.delBox.Size = new System.Drawing.Size(572, 47);
            this.delBox.TabIndex = 4;
            this.delBox.Click += new System.EventHandler(this.delB_Click);
            // 
            // delB
            // 
            this.delB.Location = new System.Drawing.Point(680, 185);
            this.delB.Margin = new System.Windows.Forms.Padding(4);
            this.delB.Name = "delB";
            this.delB.Size = new System.Drawing.Size(144, 46);
            this.delB.TabIndex = 5;
            this.delB.Text = "delete";
            this.delB.UseVisualStyleBackColor = true;
            this.delB.Click += new System.EventHandler(this.delB_Click);
            // 
            // LanguageCBox
            // 
            this.LanguageCBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LanguageCBox.FormattingEnabled = true;
            this.LanguageCBox.Items.AddRange(new object[] {
            "C#",
            "C++",
            "Swift",
            "Python",
            "Java Script",
            "Pascal ABC"});
            this.LanguageCBox.Location = new System.Drawing.Point(44, 265);
            this.LanguageCBox.Margin = new System.Windows.Forms.Padding(4);
            this.LanguageCBox.Name = "LanguageCBox";
            this.LanguageCBox.Size = new System.Drawing.Size(352, 47);
            this.LanguageCBox.TabIndex = 6;
            this.LanguageCBox.Text = "programming language";
            this.LanguageCBox.SelectedIndexChanged += new System.EventHandler(this.LanguageCBox_SelectedIndexChanged);
            // 
            // LanguageL
            // 
            this.LanguageL.AutoSize = true;
            this.LanguageL.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LanguageL.Location = new System.Drawing.Point(38, 346);
            this.LanguageL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LanguageL.Name = "LanguageL";
            this.LanguageL.Size = new System.Drawing.Size(245, 39);
            this.LanguageL.TabIndex = 7;
            this.LanguageL.Text = "Choose language";
            // 
            // WorkCompleteChBox
            // 
            this.WorkCompleteChBox.AutoSize = true;
            this.WorkCompleteChBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkCompleteChBox.Location = new System.Drawing.Point(758, 269);
            this.WorkCompleteChBox.Margin = new System.Windows.Forms.Padding(4);
            this.WorkCompleteChBox.Name = "WorkCompleteChBox";
            this.WorkCompleteChBox.Size = new System.Drawing.Size(427, 43);
            this.WorkCompleteChBox.TabIndex = 8;
            this.WorkCompleteChBox.Text = "Laboratory work is comleted";
            this.WorkCompleteChBox.UseVisualStyleBackColor = true;
            this.WorkCompleteChBox.CheckStateChanged += new System.EventHandler(this.WorkCompleteChBox_CheckStateChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(494, 277);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(165, 29);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // UniversLBox
            // 
            this.UniversLBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UniversLBox.FormattingEnabled = true;
            this.UniversLBox.ItemHeight = 39;
            this.UniversLBox.Items.AddRange(new object[] {
            "BSU",
            "BSPU",
            "BSAU",
            "USPTU",
            "USATU"});
            this.UniversLBox.Location = new System.Drawing.Point(70, 410);
            this.UniversLBox.Margin = new System.Windows.Forms.Padding(4);
            this.UniversLBox.Name = "UniversLBox";
            this.UniversLBox.Size = new System.Drawing.Size(158, 160);
            this.UniversLBox.TabIndex = 10;
            this.UniversLBox.SelectedIndexChanged += new System.EventHandler(this.UniversLBox_SelectedIndexChanged);
            // 
            // testL
            // 
            this.testL.AutoSize = true;
            this.testL.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testL.Location = new System.Drawing.Point(236, 483);
            this.testL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.testL.Name = "testL";
            this.testL.Size = new System.Drawing.Size(121, 39);
            this.testL.TabIndex = 11;
            this.testL.Text = "Bro test";
            // 
            // colorP
            // 
            this.colorP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colorP.Location = new System.Drawing.Point(466, 410);
            this.colorP.Margin = new System.Windows.Forms.Padding(4);
            this.colorP.Name = "colorP";
            this.colorP.Size = new System.Drawing.Size(172, 173);
            this.colorP.TabIndex = 12;
            this.colorP.Click += new System.EventHandler(this.colorP_Click);
            this.colorP.MouseLeave += new System.EventHandler(this.colorP_MouseLeave);
            this.colorP.MouseHover += new System.EventHandler(this.colorP_MouseHover);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(888, 468);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(226, 60);
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // newbbut
            // 
            this.newbbut.Location = new System.Drawing.Point(917, 615);
            this.newbbut.Name = "newbbut";
            this.newbbut.Size = new System.Drawing.Size(188, 72);
            this.newbbut.TabIndex = 14;
            this.newbbut.Text = "new button";
            this.newbbut.UseVisualStyleBackColor = true;
            this.newbbut.Click += new System.EventHandler(this.newbbut_Click);
            // 
            // birthMaskTB
            // 
            this.birthMaskTB.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthMaskTB.Location = new System.Drawing.Point(758, 354);
            this.birthMaskTB.Mask = "00/00/0000";
            this.birthMaskTB.Name = "birthMaskTB";
            this.birthMaskTB.Size = new System.Drawing.Size(145, 47);
            this.birthMaskTB.TabIndex = 15;
            this.birthMaskTB.ValidatingType = typeof(System.DateTime);
            this.birthMaskTB.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.birthMaskTB_MaskInputRejected);
            this.birthMaskTB.Validated += new System.EventHandler(this.birthMaskTB_Validated);
            // 
            // DateofBirthL
            // 
            this.DateofBirthL.AutoSize = true;
            this.DateofBirthL.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateofBirthL.Location = new System.Drawing.Point(939, 357);
            this.DateofBirthL.Name = "DateofBirthL";
            this.DateofBirthL.Size = new System.Drawing.Size(183, 39);
            this.DateofBirthL.TabIndex = 16;
            this.DateofBirthL.Text = "Date of birth";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(680, 117);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1.TabIndex = 17;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1188, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 18;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1201, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Selected Date";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(494, 314);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(165, 29);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(494, 346);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(165, 29);
            this.radioButton3.TabIndex = 21;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerButton
            // 
            this.TimerButton.Location = new System.Drawing.Point(917, 117);
            this.TimerButton.Name = "TimerButton";
            this.TimerButton.Size = new System.Drawing.Size(205, 99);
            this.TimerButton.TabIndex = 22;
            this.TimerButton.Text = "Timer on/off";
            this.TimerButton.UseVisualStyleBackColor = true;
            this.TimerButton.Click += new System.EventHandler(this.TimerButton_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(1000, 59);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(36, 37);
            this.timerLabel.TabIndex = 23;
            this.timerLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1220, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "tooltip example";
            this.toolTip1.SetToolTip(this.label3, "ToolTip example");
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "laboratory work №1",
            "laboratory work №2",
            "laboratory work №3",
            "laboratory work №4",
            "laboratory work №5"});
            this.checkedListBox1.Location = new System.Drawing.Point(1170, 553);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(266, 144);
            this.checkedListBox1.TabIndex = 26;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(224, 615);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 214);
            this.tabControl1.TabIndex = 27;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(623, 167);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(623, 167);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(623, 167);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(623, 167);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(8, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(623, 167);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(8, 39);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(623, 167);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 896);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.TimerButton);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.DateofBirthL);
            this.Controls.Add(this.birthMaskTB);
            this.Controls.Add(this.newbbut);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.colorP);
            this.Controls.Add(this.testL);
            this.Controls.Add(this.UniversLBox);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.WorkCompleteChBox);
            this.Controls.Add(this.LanguageL);
            this.Controls.Add(this.LanguageCBox);
            this.Controls.Add(this.delB);
            this.Controls.Add(this.delBox);
            this.Controls.Add(this.greetBox);
            this.Controls.Add(this.OKnameB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OKnameB;
        private System.Windows.Forms.TextBox greetBox;
        private System.Windows.Forms.TextBox delBox;
        private System.Windows.Forms.Button delB;
        private System.Windows.Forms.ComboBox LanguageCBox;
        private System.Windows.Forms.Label LanguageL;
        private System.Windows.Forms.CheckBox WorkCompleteChBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox UniversLBox;
        private System.Windows.Forms.Label testL;
        private System.Windows.Forms.Panel colorP;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button newbbut;
        private System.Windows.Forms.MaskedTextBox birthMaskTB;
        private System.Windows.Forms.Label DateofBirthL;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button TimerButton;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
    }
}


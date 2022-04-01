namespace Programming.View
{
    partial class MainForm
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
            this.ProgrammingTabControl = new System.Windows.Forms.TabControl();
            this.EnumsTabControl = new System.Windows.Forms.TabPage();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonGoButton = new System.Windows.Forms.Button();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.ParsingLabel = new System.Windows.Forms.Label();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.EnumerationLabel = new System.Windows.Forms.Label();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.ProgrammingTabControl.SuspendLayout();
            this.EnumsTabControl.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgrammingTabControl
            // 
            this.ProgrammingTabControl.Controls.Add(this.EnumsTabControl);
            this.ProgrammingTabControl.Controls.Add(this.ClassesTabPage);
            this.ProgrammingTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgrammingTabControl.Location = new System.Drawing.Point(0, 0);
            this.ProgrammingTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProgrammingTabControl.Name = "ProgrammingTabControl";
            this.ProgrammingTabControl.SelectedIndex = 0;
            this.ProgrammingTabControl.Size = new System.Drawing.Size(1143, 750);
            this.ProgrammingTabControl.TabIndex = 0;
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Controls.Add(this.SeasonGroupBox);
            this.EnumsTabControl.Controls.Add(this.WeekdayGroupBox);
            this.EnumsTabControl.Controls.Add(this.EnumerationsGroupBox);
            this.EnumsTabControl.Location = new System.Drawing.Point(4, 34);
            this.EnumsTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnumsTabControl.Size = new System.Drawing.Size(1135, 712);
            this.EnumsTabControl.TabIndex = 0;
            this.EnumsTabControl.Text = "Enums";
            this.EnumsTabControl.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonGroupBox.Controls.Add(this.SeasonGoButton);
            this.SeasonGroupBox.Controls.Add(this.SeasonLabel);
            this.SeasonGroupBox.Location = new System.Drawing.Point(580, 457);
            this.SeasonGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SeasonGroupBox.Size = new System.Drawing.Size(543, 233);
            this.SeasonGroupBox.TabIndex = 1;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(26, 82);
            this.SeasonComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(237, 33);
            this.SeasonComboBox.TabIndex = 4;
            // 
            // SeasonGoButton
            // 
            this.SeasonGoButton.Location = new System.Drawing.Point(273, 82);
            this.SeasonGoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SeasonGoButton.Name = "SeasonGoButton";
            this.SeasonGoButton.Size = new System.Drawing.Size(107, 38);
            this.SeasonGoButton.TabIndex = 3;
            this.SeasonGoButton.Text = "GO!";
            this.SeasonGoButton.UseVisualStyleBackColor = true;
            this.SeasonGoButton.Click += new System.EventHandler(this.SeasonGoButton_Click);
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(26, 53);
            this.SeasonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(136, 25);
            this.SeasonLabel.TabIndex = 2;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Controls.Add(this.OutputLabel);
            this.WeekdayGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayGroupBox.Controls.Add(this.WeekdayTextBox);
            this.WeekdayGroupBox.Controls.Add(this.ParsingLabel);
            this.WeekdayGroupBox.Location = new System.Drawing.Point(9, 457);
            this.WeekdayGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WeekdayGroupBox.Size = new System.Drawing.Size(543, 233);
            this.WeekdayGroupBox.TabIndex = 0;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(21, 145);
            this.OutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(57, 25);
            this.OutputLabel.TabIndex = 3;
            this.OutputLabel.Text = "         ";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(269, 82);
            this.ParseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(107, 38);
            this.ParseButton.TabIndex = 2;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(21, 82);
            this.WeekdayTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(237, 31);
            this.WeekdayTextBox.TabIndex = 0;
            // 
            // ParsingLabel
            // 
            this.ParsingLabel.AutoSize = true;
            this.ParsingLabel.Location = new System.Drawing.Point(21, 52);
            this.ParsingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ParsingLabel.Name = "ParsingLabel";
            this.ParsingLabel.Size = new System.Drawing.Size(191, 25);
            this.ParsingLabel.TabIndex = 1;
            this.ParsingLabel.Text = "Type value for parsing:";
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ChooseValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.EnumerationLabel);
            this.EnumerationsGroupBox.Controls.Add(this.IntTextBox);
            this.EnumerationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(9, 10);
            this.EnumerationsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(1114, 437);
            this.EnumerationsGroupBox.TabIndex = 2;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(584, 43);
            this.IntValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(83, 25);
            this.IntValueLabel.TabIndex = 5;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(304, 43);
            this.ChooseValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(122, 25);
            this.ChooseValueLabel.TabIndex = 4;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // EnumerationLabel
            // 
            this.EnumerationLabel.AutoSize = true;
            this.EnumerationLabel.Location = new System.Drawing.Point(21, 43);
            this.EnumerationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnumerationLabel.Name = "EnumerationLabel";
            this.EnumerationLabel.Size = new System.Drawing.Size(181, 25);
            this.EnumerationLabel.TabIndex = 3;
            this.EnumerationLabel.Text = "Choose enumeration:";
            // 
            // IntTextBox
            // 
            this.IntTextBox.Location = new System.Drawing.Point(584, 73);
            this.IntTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.Size = new System.Drawing.Size(237, 31);
            this.IntTextBox.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 25;
            this.ValuesListBox.Location = new System.Drawing.Point(304, 73);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(237, 329);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 25;
            this.EnumsListBox.Location = new System.Drawing.Point(21, 73);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(237, 329);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 34);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Size = new System.Drawing.Size(1135, 712);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.WidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.LengthLabel);
            this.RectanglesGroupBox.Controls.Add(this.FindButton);
            this.RectanglesGroupBox.Controls.Add(this.textBox3);
            this.RectanglesGroupBox.Controls.Add(this.textBox2);
            this.RectanglesGroupBox.Controls.Add(this.textBox1);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(493, 362);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(225, 154);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(59, 25);
            this.ColorLabel.TabIndex = 7;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(225, 92);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(64, 25);
            this.WidthLabel.TabIndex = 6;
            this.WidthLabel.Text = "Width:";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(225, 30);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(70, 25);
            this.LengthLabel.TabIndex = 5;
            this.LengthLabel.Text = "Length:";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(225, 250);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(150, 34);
            this.FindButton.TabIndex = 4;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(225, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 31);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(225, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 31);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 1;
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 25;
            this.RectanglesListBox.Location = new System.Drawing.Point(8, 30);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(202, 254);
            this.RectanglesListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.ProgrammingTabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming Demo";
            this.ProgrammingTabControl.ResumeLayout(false);
            this.EnumsTabControl.ResumeLayout(false);
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.WeekdayGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ProgrammingTabControl;
        private System.Windows.Forms.TabPage EnumsTabControl;
        private System.Windows.Forms.GroupBox WeekdayGroupBox;
        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.TextBox IntTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.Label ChooseValueLabel;
        private System.Windows.Forms.Label EnumerationLabel;
        private System.Windows.Forms.Button SeasonGoButton;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox WeekdayTextBox;
        private System.Windows.Forms.Label ParsingLabel;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox RectanglesListBox;
    }
}


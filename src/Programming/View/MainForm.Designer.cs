
namespace Programming
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
            this.Enums = new System.Windows.Forms.TabPage();
            this.SeasonBox = new System.Windows.Forms.GroupBox();
            this.WeekdayBox = new System.Windows.Forms.GroupBox();
            this.EnumerationsBox = new System.Windows.Forms.GroupBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.EnumerationLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ValueLable = new System.Windows.Forms.Label();
            this.ProgrammingTabControl.SuspendLayout();
            this.Enums.SuspendLayout();
            this.EnumerationsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgrammingTabControl
            // 
            this.ProgrammingTabControl.Controls.Add(this.Enums);
            this.ProgrammingTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgrammingTabControl.Location = new System.Drawing.Point(0, 0);
            this.ProgrammingTabControl.Name = "ProgrammingTabControl";
            this.ProgrammingTabControl.SelectedIndex = 0;
            this.ProgrammingTabControl.Size = new System.Drawing.Size(800, 450);
            this.ProgrammingTabControl.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.SeasonBox);
            this.Enums.Controls.Add(this.WeekdayBox);
            this.Enums.Controls.Add(this.EnumerationsBox);
            this.Enums.Location = new System.Drawing.Point(4, 24);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(792, 422);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // SeasonBox
            // 
            this.SeasonBox.Location = new System.Drawing.Point(406, 274);
            this.SeasonBox.Name = "SeasonBox";
            this.SeasonBox.Size = new System.Drawing.Size(380, 140);
            this.SeasonBox.TabIndex = 1;
            this.SeasonBox.TabStop = false;
            this.SeasonBox.Text = "Season Handle";
            // 
            // WeekdayBox
            // 
            this.WeekdayBox.Location = new System.Drawing.Point(6, 274);
            this.WeekdayBox.Name = "WeekdayBox";
            this.WeekdayBox.Size = new System.Drawing.Size(380, 140);
            this.WeekdayBox.TabIndex = 0;
            this.WeekdayBox.TabStop = false;
            this.WeekdayBox.Text = "Weekday Parsing";
            // 
            // EnumerationsBox
            // 
            this.EnumerationsBox.Controls.Add(this.ValueLable);
            this.EnumerationsBox.Controls.Add(this.ValueLabel);
            this.EnumerationsBox.Controls.Add(this.EnumerationLabel);
            this.EnumerationsBox.Controls.Add(this.IntTextBox);
            this.EnumerationsBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsBox.Location = new System.Drawing.Point(6, 6);
            this.EnumerationsBox.Name = "EnumerationsBox";
            this.EnumerationsBox.Size = new System.Drawing.Size(780, 262);
            this.EnumerationsBox.TabIndex = 2;
            this.EnumerationsBox.TabStop = false;
            this.EnumerationsBox.Text = "Enumerations";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 15;
            this.EnumsListBox.Location = new System.Drawing.Point(15, 32);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(167, 214);
            this.EnumsListBox.TabIndex = 0;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 15;
            this.ValuesListBox.Location = new System.Drawing.Point(213, 32);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(167, 214);
            this.ValuesListBox.TabIndex = 1;
            // 
            // IntTextBox
            // 
            this.IntTextBox.Location = new System.Drawing.Point(400, 32);
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.Size = new System.Drawing.Size(119, 23);
            this.IntTextBox.TabIndex = 2;
            // 
            // EnumerationLabel
            // 
            this.EnumerationLabel.AutoSize = true;
            this.EnumerationLabel.Location = new System.Drawing.Point(15, 14);
            this.EnumerationLabel.Name = "EnumerationLabel";
            this.EnumerationLabel.Size = new System.Drawing.Size(121, 15);
            this.EnumerationLabel.TabIndex = 3;
            this.EnumerationLabel.Text = "Choose enumeration:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(213, 14);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(81, 15);
            this.ValueLabel.TabIndex = 4;
            this.ValueLabel.Text = "Choose value:";
            // 
            // ValueLable
            // 
            this.ValueLable.AutoSize = true;
            this.ValueLable.Location = new System.Drawing.Point(400, 14);
            this.ValueLable.Name = "ValueLable";
            this.ValueLable.Size = new System.Drawing.Size(55, 15);
            this.ValueLable.TabIndex = 5;
            this.ValueLable.Text = "Int value:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProgrammingTabControl);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming Demo";
            this.ProgrammingTabControl.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.EnumerationsBox.ResumeLayout(false);
            this.EnumerationsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ProgrammingTabControl;
        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.GroupBox WeekdayBox;
        private System.Windows.Forms.GroupBox EnumerationsBox;
        private System.Windows.Forms.GroupBox SeasonBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.TextBox IntTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label ValueLable;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label EnumerationLabel;
    }
}


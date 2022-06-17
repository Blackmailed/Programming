
namespace Programming.View.Controls
{
    partial class RectanglesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.YtextBox = new System.Windows.Forms.TextBox();
            this.Ylabel = new System.Windows.Forms.Label();
            this.XtextBox = new System.Windows.Forms.TextBox();
            this.Xlabel = new System.Windows.Forms.Label();
            this.FindWidthButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.IdTextBox);
            this.RectanglesGroupBox.Controls.Add(this.IdLabel);
            this.RectanglesGroupBox.Controls.Add(this.YtextBox);
            this.RectanglesGroupBox.Controls.Add(this.Ylabel);
            this.RectanglesGroupBox.Controls.Add(this.XtextBox);
            this.RectanglesGroupBox.Controls.Add(this.Xlabel);
            this.RectanglesGroupBox.Controls.Add(this.FindWidthButton);
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.WidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.LengthLabel);
            this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.LengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.RectanglesGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.RectanglesGroupBox.Size = new System.Drawing.Size(816, 489);
            this.RectanglesGroupBox.TabIndex = 1;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(227, 251);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(104, 23);
            this.IdTextBox.TabIndex = 13;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(226, 232);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(20, 15);
            this.IdLabel.TabIndex = 12;
            this.IdLabel.Text = "Id:";
            // 
            // YtextBox
            // 
            this.YtextBox.Enabled = false;
            this.YtextBox.Location = new System.Drawing.Point(227, 207);
            this.YtextBox.Name = "YtextBox";
            this.YtextBox.ReadOnly = true;
            this.YtextBox.Size = new System.Drawing.Size(104, 23);
            this.YtextBox.TabIndex = 11;
            // 
            // Ylabel
            // 
            this.Ylabel.AutoSize = true;
            this.Ylabel.Location = new System.Drawing.Point(226, 188);
            this.Ylabel.Name = "Ylabel";
            this.Ylabel.Size = new System.Drawing.Size(17, 15);
            this.Ylabel.TabIndex = 10;
            this.Ylabel.Text = "Y:";
            // 
            // XtextBox
            // 
            this.XtextBox.Enabled = false;
            this.XtextBox.Location = new System.Drawing.Point(227, 163);
            this.XtextBox.Name = "XtextBox";
            this.XtextBox.ReadOnly = true;
            this.XtextBox.Size = new System.Drawing.Size(104, 23);
            this.XtextBox.TabIndex = 9;
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Location = new System.Drawing.Point(226, 144);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(17, 15);
            this.Xlabel.TabIndex = 8;
            this.Xlabel.Text = "X:";
            // 
            // FindWidthButton
            // 
            this.FindWidthButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FindWidthButton.Location = new System.Drawing.Point(227, 448);
            this.FindWidthButton.Name = "FindWidthButton";
            this.FindWidthButton.Size = new System.Drawing.Size(104, 23);
            this.FindWidthButton.TabIndex = 1;
            this.FindWidthButton.Text = "Find";
            this.FindWidthButton.UseVisualStyleBackColor = true;
            this.FindWidthButton.Click += new System.EventHandler(this.FindWidthButton_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(226, 102);
            this.ColorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(39, 15);
            this.ColorLabel.TabIndex = 7;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(226, 59);
            this.WidthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(42, 15);
            this.WidthLabel.TabIndex = 6;
            this.WidthLabel.Text = "Width:";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(226, 17);
            this.LengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(47, 15);
            this.LengthLabel.TabIndex = 5;
            this.LengthLabel.Text = "Length:";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(227, 120);
            this.ColorTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(104, 23);
            this.ColorTextBox.TabIndex = 3;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(225, 78);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(104, 23);
            this.WidthTextBox.TabIndex = 2;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(227, 35);
            this.LengthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(104, 23);
            this.LengthTextBox.TabIndex = 1;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 15;
            this.RectanglesListBox.Location = new System.Drawing.Point(7, 17);
            this.RectanglesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(211, 454);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesGroupBox);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(816, 489);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox YtextBox;
        private System.Windows.Forms.Label Ylabel;
        private System.Windows.Forms.TextBox XtextBox;
        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.Button FindWidthButton;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
    }
}

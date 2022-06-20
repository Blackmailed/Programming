
namespace Programming.View.Controls
{
    partial class RectanglesCollisionControl
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
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.LenghtLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.Ylable = new System.Windows.Forms.Label();
            this.Xlable = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SelectedRectanglesLabel = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.YtextBox = new System.Windows.Forms.TextBox();
            this.XtextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.RemoveRectangleButton = new System.Windows.Forms.Button();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Location = new System.Drawing.Point(293, 20);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(511, 445);
            this.CanvasPanel.TabIndex = 31;
            // 
            // LenghtLabel
            // 
            this.LenghtLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LenghtLabel.AutoSize = true;
            this.LenghtLabel.Location = new System.Drawing.Point(10, 445);
            this.LenghtLabel.Name = "LenghtLabel";
            this.LenghtLabel.Size = new System.Drawing.Size(47, 15);
            this.LenghtLabel.TabIndex = 30;
            this.LenghtLabel.Text = "Length:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(10, 416);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(42, 15);
            this.WidthLabel.TabIndex = 29;
            this.WidthLabel.Text = "Width:";
            // 
            // Ylable
            // 
            this.Ylable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ylable.AutoSize = true;
            this.Ylable.Location = new System.Drawing.Point(10, 387);
            this.Ylable.Name = "Ylable";
            this.Ylable.Size = new System.Drawing.Size(17, 15);
            this.Ylable.TabIndex = 28;
            this.Ylable.Text = "Y:";
            // 
            // Xlable
            // 
            this.Xlable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Xlable.AutoSize = true;
            this.Xlable.Location = new System.Drawing.Point(10, 358);
            this.Xlable.Name = "Xlable";
            this.Xlable.Size = new System.Drawing.Size(17, 15);
            this.Xlable.TabIndex = 27;
            this.Xlable.Text = "X:";
            // 
            // IdLabel
            // 
            this.IdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(10, 329);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(20, 15);
            this.IdLabel.TabIndex = 26;
            this.IdLabel.Text = "Id:";
            // 
            // SelectedRectanglesLabel
            // 
            this.SelectedRectanglesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedRectanglesLabel.AutoSize = true;
            this.SelectedRectanglesLabel.Location = new System.Drawing.Point(10, 308);
            this.SelectedRectanglesLabel.Name = "SelectedRectanglesLabel";
            this.SelectedRectanglesLabel.Size = new System.Drawing.Size(109, 15);
            this.SelectedRectanglesLabel.TabIndex = 25;
            this.SelectedRectanglesLabel.Text = "Selected Rectangle:";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LengthTextBox.Location = new System.Drawing.Point(57, 442);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(100, 23);
            this.LengthTextBox.TabIndex = 24;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WidthTextBox.Location = new System.Drawing.Point(57, 413);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 23);
            this.WidthTextBox.TabIndex = 23;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // YtextBox
            // 
            this.YtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YtextBox.Location = new System.Drawing.Point(57, 384);
            this.YtextBox.Name = "YtextBox";
            this.YtextBox.Size = new System.Drawing.Size(100, 23);
            this.YtextBox.TabIndex = 22;
            this.YtextBox.TextChanged += new System.EventHandler(this.YtextBox_TextChanged);
            // 
            // XtextBox
            // 
            this.XtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XtextBox.Location = new System.Drawing.Point(57, 355);
            this.XtextBox.Name = "XtextBox";
            this.XtextBox.Size = new System.Drawing.Size(100, 23);
            this.XtextBox.TabIndex = 21;
            this.XtextBox.TextChanged += new System.EventHandler(this.XtextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(57, 326);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(100, 23);
            this.IdTextBox.TabIndex = 20;
            // 
            // RemoveRectangleButton
            // 
            this.RemoveRectangleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveRectangleButton.FlatAppearance.BorderSize = 0;
            this.RemoveRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRectangleButton.Image = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.RemoveRectangleButton.Location = new System.Drawing.Point(200, 210);
            this.RemoveRectangleButton.Name = "RemoveRectangleButton";
            this.RemoveRectangleButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveRectangleButton.TabIndex = 19;
            this.RemoveRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveRectangleButton.Click += new System.EventHandler(this.RemoveRectangleButton_Click);
            this.RemoveRectangleButton.MouseEnter += new System.EventHandler(this.RemoveRectangleButton_MouseEnter);
            this.RemoveRectangleButton.MouseLeave += new System.EventHandler(this.RemoveRectangleButton_MouseLeave);
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddRectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddRectangleButton.FlatAppearance.BorderSize = 0;
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.Image = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.AddRectangleButton.Location = new System.Drawing.Point(10, 210);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(75, 23);
            this.AddRectangleButton.TabIndex = 18;
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            this.AddRectangleButton.MouseEnter += new System.EventHandler(this.AddRectangleButton_MouseEnter);
            this.AddRectangleButton.MouseLeave += new System.EventHandler(this.AddRectangleButton_MouseLeave);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 15;
            this.RectanglesListBox.Location = new System.Drawing.Point(10, 20);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.ScrollAlwaysVisible = true;
            this.RectanglesListBox.Size = new System.Drawing.Size(265, 184);
            this.RectanglesListBox.TabIndex = 16;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CanvasPanel);
            this.Controls.Add(this.LenghtLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.Ylable);
            this.Controls.Add(this.Xlable);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.SelectedRectanglesLabel);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.YtextBox);
            this.Controls.Add(this.XtextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.RemoveRectangleButton);
            this.Controls.Add(this.AddRectangleButton);
            this.Controls.Add(this.RectanglesListBox);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(816, 489);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.Label LenghtLabel2;
        private System.Windows.Forms.Label WidthLabel2;
        private System.Windows.Forms.Label Ylable2;
        private System.Windows.Forms.Label Xlable2;
        private System.Windows.Forms.Label IdLabel2;
        private System.Windows.Forms.Label SelectedRectanglesLabel;
        private System.Windows.Forms.TextBox LengthTextBox2;
        private System.Windows.Forms.TextBox WidthTextBox2;
        private System.Windows.Forms.TextBox YtextBox2;
        private System.Windows.Forms.TextBox XtextBox2;
        private System.Windows.Forms.TextBox IdTextBox2;
        private System.Windows.Forms.Button RemoveRectangleButton;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.Label LenghtLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label Ylable;
        private System.Windows.Forms.Label Xlable;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox YtextBox;
        private System.Windows.Forms.TextBox XtextBox;
        private System.Windows.Forms.TextBox IdTextBox;
    }
}

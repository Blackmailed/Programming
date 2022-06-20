
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
            this.LenghtLabel2 = new System.Windows.Forms.Label();
            this.WidthLabel2 = new System.Windows.Forms.Label();
            this.Ylable2 = new System.Windows.Forms.Label();
            this.Xlable2 = new System.Windows.Forms.Label();
            this.IdLabel2 = new System.Windows.Forms.Label();
            this.SelectedRectanglesLabel = new System.Windows.Forms.Label();
            this.LengthTextBox2 = new System.Windows.Forms.TextBox();
            this.WidthTextBox2 = new System.Windows.Forms.TextBox();
            this.YtextBox2 = new System.Windows.Forms.TextBox();
            this.XtextBox2 = new System.Windows.Forms.TextBox();
            this.IdTextBox2 = new System.Windows.Forms.TextBox();
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
            // LenghtLabel2
            // 
            this.LenghtLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LenghtLabel2.AutoSize = true;
            this.LenghtLabel2.Location = new System.Drawing.Point(10, 445);
            this.LenghtLabel2.Name = "LenghtLabel2";
            this.LenghtLabel2.Size = new System.Drawing.Size(47, 15);
            this.LenghtLabel2.TabIndex = 30;
            this.LenghtLabel2.Text = "Length:";
            // 
            // WidthLabel2
            // 
            this.WidthLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WidthLabel2.AutoSize = true;
            this.WidthLabel2.Location = new System.Drawing.Point(10, 416);
            this.WidthLabel2.Name = "WidthLabel2";
            this.WidthLabel2.Size = new System.Drawing.Size(42, 15);
            this.WidthLabel2.TabIndex = 29;
            this.WidthLabel2.Text = "Width:";
            // 
            // Ylable2
            // 
            this.Ylable2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ylable2.AutoSize = true;
            this.Ylable2.Location = new System.Drawing.Point(10, 387);
            this.Ylable2.Name = "Ylable2";
            this.Ylable2.Size = new System.Drawing.Size(17, 15);
            this.Ylable2.TabIndex = 28;
            this.Ylable2.Text = "Y:";
            // 
            // Xlable2
            // 
            this.Xlable2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Xlable2.AutoSize = true;
            this.Xlable2.Location = new System.Drawing.Point(13, 358);
            this.Xlable2.Name = "Xlable2";
            this.Xlable2.Size = new System.Drawing.Size(17, 15);
            this.Xlable2.TabIndex = 27;
            this.Xlable2.Text = "X:";
            // 
            // IdLabel2
            // 
            this.IdLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IdLabel2.AutoSize = true;
            this.IdLabel2.Location = new System.Drawing.Point(10, 329);
            this.IdLabel2.Name = "IdLabel2";
            this.IdLabel2.Size = new System.Drawing.Size(20, 15);
            this.IdLabel2.TabIndex = 26;
            this.IdLabel2.Text = "Id:";
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
            // LengthTextBox2
            // 
            this.LengthTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LengthTextBox2.Location = new System.Drawing.Point(57, 442);
            this.LengthTextBox2.Name = "LengthTextBox2";
            this.LengthTextBox2.Size = new System.Drawing.Size(100, 23);
            this.LengthTextBox2.TabIndex = 24;
            this.LengthTextBox2.TextChanged += new System.EventHandler(this.LengthTextBox2_TextChanged);
            // 
            // WidthTextBox2
            // 
            this.WidthTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WidthTextBox2.Location = new System.Drawing.Point(57, 413);
            this.WidthTextBox2.Name = "WidthTextBox2";
            this.WidthTextBox2.Size = new System.Drawing.Size(100, 23);
            this.WidthTextBox2.TabIndex = 23;
            this.WidthTextBox2.TextChanged += new System.EventHandler(this.WidthTextBox2_TextChanged);
            // 
            // YtextBox2
            // 
            this.YtextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YtextBox2.Location = new System.Drawing.Point(57, 384);
            this.YtextBox2.Name = "YtextBox2";
            this.YtextBox2.Size = new System.Drawing.Size(100, 23);
            this.YtextBox2.TabIndex = 22;
            this.YtextBox2.TextChanged += new System.EventHandler(this.YtextBox2_TextChanged);
            // 
            // XtextBox2
            // 
            this.XtextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XtextBox2.Location = new System.Drawing.Point(57, 355);
            this.XtextBox2.Name = "XtextBox2";
            this.XtextBox2.Size = new System.Drawing.Size(100, 23);
            this.XtextBox2.TabIndex = 21;
            this.XtextBox2.TextChanged += new System.EventHandler(this.XtextBox2_TextChanged);
            // 
            // IdTextBox2
            // 
            this.IdTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IdTextBox2.Enabled = false;
            this.IdTextBox2.Location = new System.Drawing.Point(57, 326);
            this.IdTextBox2.Name = "IdTextBox2";
            this.IdTextBox2.ReadOnly = true;
            this.IdTextBox2.Size = new System.Drawing.Size(100, 23);
            this.IdTextBox2.TabIndex = 20;
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
            this.Controls.Add(this.LenghtLabel2);
            this.Controls.Add(this.WidthLabel2);
            this.Controls.Add(this.Ylable2);
            this.Controls.Add(this.Xlable2);
            this.Controls.Add(this.IdLabel2);
            this.Controls.Add(this.SelectedRectanglesLabel);
            this.Controls.Add(this.LengthTextBox2);
            this.Controls.Add(this.WidthTextBox2);
            this.Controls.Add(this.YtextBox2);
            this.Controls.Add(this.XtextBox2);
            this.Controls.Add(this.IdTextBox2);
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
    }
}

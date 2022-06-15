
namespace SongManager.View
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
            this.SongListBox = new System.Windows.Forms.ListBox();
            this.AddSongButton = new System.Windows.Forms.Button();
            this.EditSongButton = new System.Windows.Forms.Button();
            this.DeleteSongButton = new System.Windows.Forms.Button();
            this.SelectedSongGroupBox = new System.Windows.Forms.GroupBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.DurationSecondsLabel = new System.Windows.Forms.Label();
            this.ArtistNameLabel = new System.Windows.Forms.Label();
            this.SongNameLabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.DurationSecondsTextBox = new System.Windows.Forms.TextBox();
            this.ArtistNameTextBox = new System.Windows.Forms.TextBox();
            this.SongNameTextBox = new System.Windows.Forms.TextBox();
            this.SelectedSongGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SongListBox
            // 
            this.SongListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SongListBox.FormattingEnabled = true;
            this.SongListBox.ItemHeight = 15;
            this.SongListBox.Location = new System.Drawing.Point(12, 12);
            this.SongListBox.Name = "SongListBox";
            this.SongListBox.Size = new System.Drawing.Size(237, 349);
            this.SongListBox.TabIndex = 0;
            this.SongListBox.SelectedIndexChanged += new System.EventHandler(this.SongListBox_SelectedIndexChanged);
            // 
            // AddSongButton
            // 
            this.AddSongButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSongButton.Image = global::SongManager.Properties.Resources.rectangle_add_24x24_uncolor;
            this.AddSongButton.Location = new System.Drawing.Point(12, 367);
            this.AddSongButton.Name = "AddSongButton";
            this.AddSongButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddSongButton.Size = new System.Drawing.Size(75, 23);
            this.AddSongButton.TabIndex = 1;
            this.AddSongButton.UseVisualStyleBackColor = true;
            this.AddSongButton.Click += new System.EventHandler(this.AddSongButton_Click);
            this.AddSongButton.MouseEnter += new System.EventHandler(this.AddSongButton_MouseEnter);
            this.AddSongButton.MouseLeave += new System.EventHandler(this.AddSongButton_MouseLeave);
            // 
            // EditSongButton
            // 
            this.EditSongButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditSongButton.Image = global::SongManager.Properties.Resources.rectangle_edit_24x24_uncolor;
            this.EditSongButton.Location = new System.Drawing.Point(93, 367);
            this.EditSongButton.Name = "EditSongButton";
            this.EditSongButton.Size = new System.Drawing.Size(75, 23);
            this.EditSongButton.TabIndex = 2;
            this.EditSongButton.UseVisualStyleBackColor = true;
            this.EditSongButton.Click += new System.EventHandler(this.EditSongButton_Click);
            this.EditSongButton.MouseEnter += new System.EventHandler(this.EditSongButton_MouseEnter);
            this.EditSongButton.MouseLeave += new System.EventHandler(this.EditSongButton_MouseLeave);
            // 
            // DeleteSongButton
            // 
            this.DeleteSongButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSongButton.Image = global::SongManager.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.DeleteSongButton.Location = new System.Drawing.Point(174, 367);
            this.DeleteSongButton.Name = "DeleteSongButton";
            this.DeleteSongButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteSongButton.TabIndex = 3;
            this.DeleteSongButton.UseVisualStyleBackColor = true;
            this.DeleteSongButton.Click += new System.EventHandler(this.DeleteSongButton_Click);
            this.DeleteSongButton.MouseEnter += new System.EventHandler(this.DeleteSongButton_MouseEnter);
            this.DeleteSongButton.MouseLeave += new System.EventHandler(this.DeleteSongButton_MouseLeave);
            // 
            // SelectedSongGroupBox
            // 
            this.SelectedSongGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedSongGroupBox.Controls.Add(this.GenreLabel);
            this.SelectedSongGroupBox.Controls.Add(this.DurationSecondsLabel);
            this.SelectedSongGroupBox.Controls.Add(this.ArtistNameLabel);
            this.SelectedSongGroupBox.Controls.Add(this.SongNameLabel);
            this.SelectedSongGroupBox.Controls.Add(this.GenreTextBox);
            this.SelectedSongGroupBox.Controls.Add(this.DurationSecondsTextBox);
            this.SelectedSongGroupBox.Controls.Add(this.ArtistNameTextBox);
            this.SelectedSongGroupBox.Controls.Add(this.SongNameTextBox);
            this.SelectedSongGroupBox.Location = new System.Drawing.Point(255, 12);
            this.SelectedSongGroupBox.Name = "SelectedSongGroupBox";
            this.SelectedSongGroupBox.Size = new System.Drawing.Size(533, 349);
            this.SelectedSongGroupBox.TabIndex = 4;
            this.SelectedSongGroupBox.TabStop = false;
            this.SelectedSongGroupBox.Text = "Selected Song";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(91, 118);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(41, 15);
            this.GenreLabel.TabIndex = 7;
            this.GenreLabel.Text = "Genre:";
            // 
            // DurationSecondsLabel
            // 
            this.DurationSecondsLabel.AutoSize = true;
            this.DurationSecondsLabel.Location = new System.Drawing.Point(16, 89);
            this.DurationSecondsLabel.Name = "DurationSecondsLabel";
            this.DurationSecondsLabel.Size = new System.Drawing.Size(116, 15);
            this.DurationSecondsLabel.TabIndex = 6;
            this.DurationSecondsLabel.Text = "Duration of seconds:";
            // 
            // ArtistNameLabel
            // 
            this.ArtistNameLabel.AutoSize = true;
            this.ArtistNameLabel.Location = new System.Drawing.Point(59, 60);
            this.ArtistNameLabel.Name = "ArtistNameLabel";
            this.ArtistNameLabel.Size = new System.Drawing.Size(73, 15);
            this.ArtistNameLabel.TabIndex = 5;
            this.ArtistNameLabel.Text = "Artist Name:";
            // 
            // SongNameLabel
            // 
            this.SongNameLabel.AutoSize = true;
            this.SongNameLabel.Location = new System.Drawing.Point(63, 31);
            this.SongNameLabel.Name = "SongNameLabel";
            this.SongNameLabel.Size = new System.Drawing.Size(69, 15);
            this.SongNameLabel.TabIndex = 4;
            this.SongNameLabel.Text = "Song Name";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(138, 115);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.ReadOnly = true;
            this.GenreTextBox.Size = new System.Drawing.Size(368, 23);
            this.GenreTextBox.TabIndex = 3;
            // 
            // DurationSecondsTextBox
            // 
            this.DurationSecondsTextBox.Location = new System.Drawing.Point(138, 86);
            this.DurationSecondsTextBox.Name = "DurationSecondsTextBox";
            this.DurationSecondsTextBox.ReadOnly = true;
            this.DurationSecondsTextBox.Size = new System.Drawing.Size(368, 23);
            this.DurationSecondsTextBox.TabIndex = 2;
            // 
            // ArtistNameTextBox
            // 
            this.ArtistNameTextBox.Location = new System.Drawing.Point(138, 57);
            this.ArtistNameTextBox.Name = "ArtistNameTextBox";
            this.ArtistNameTextBox.ReadOnly = true;
            this.ArtistNameTextBox.Size = new System.Drawing.Size(368, 23);
            this.ArtistNameTextBox.TabIndex = 1;
            // 
            // SongNameTextBox
            // 
            this.SongNameTextBox.HideSelection = false;
            this.SongNameTextBox.Location = new System.Drawing.Point(138, 28);
            this.SongNameTextBox.Name = "SongNameTextBox";
            this.SongNameTextBox.ReadOnly = true;
            this.SongNameTextBox.Size = new System.Drawing.Size(368, 23);
            this.SongNameTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.SelectedSongGroupBox);
            this.Controls.Add(this.DeleteSongButton);
            this.Controls.Add(this.EditSongButton);
            this.Controls.Add(this.AddSongButton);
            this.Controls.Add(this.SongListBox);
            this.MinimumSize = new System.Drawing.Size(816, 439);
            this.Name = "MainForm";
            this.Text = "Song Manager";
            this.SelectedSongGroupBox.ResumeLayout(false);
            this.SelectedSongGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SongListBox;
        private System.Windows.Forms.Button AddSongButton;
        private System.Windows.Forms.Button EditSongButton;
        private System.Windows.Forms.Button DeleteSongButton;
        private System.Windows.Forms.GroupBox SelectedSongGroupBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label DurationSecondsLabel;
        private System.Windows.Forms.Label ArtistNameLabel;
        private System.Windows.Forms.Label SongNameLabel;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox DurationSecondsTextBox;
        private System.Windows.Forms.TextBox ArtistNameTextBox;
        private System.Windows.Forms.TextBox SongNameTextBox;
    }
}


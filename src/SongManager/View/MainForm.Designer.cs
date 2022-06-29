
namespace SongManager.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SongsListBox = new System.Windows.Forms.ListBox();
            this.AddSongButton = new System.Windows.Forms.Button();
            this.RemoveSongButton = new System.Windows.Forms.Button();
            this.SelectedSongGroupBox = new System.Windows.Forms.GroupBox();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.DurationSecondsLabel = new System.Windows.Forms.Label();
            this.ArtistNameLable = new System.Windows.Forms.Label();
            this.SongNameLabel = new System.Windows.Forms.Label();
            this.DurationSecondsTextBox = new System.Windows.Forms.TextBox();
            this.ArtistNameTextBox = new System.Windows.Forms.TextBox();
            this.SongNameTextBox = new System.Windows.Forms.TextBox();
            this.SelectedSongGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SongsListBox
            // 
            this.SongsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SongsListBox.FormattingEnabled = true;
            this.SongsListBox.HorizontalScrollbar = true;
            this.SongsListBox.IntegralHeight = false;
            this.SongsListBox.Location = new System.Drawing.Point(12, 12);
            this.SongsListBox.Name = "SongsListBox";
            this.SongsListBox.Size = new System.Drawing.Size(223, 342);
            this.SongsListBox.TabIndex = 0;
            this.SongsListBox.SelectedIndexChanged += new System.EventHandler(this.SongsListBox_SelectedIndexChanged);
            // 
            // AddSongButton
            // 
            this.AddSongButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddSongButton.BackgroundImage = global::SongManager.Properties.Resources.addActually32x32;
            this.AddSongButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddSongButton.FlatAppearance.BorderSize = 0;
            this.AddSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSongButton.Location = new System.Drawing.Point(12, 360);
            this.AddSongButton.Name = "AddSongButton";
            this.AddSongButton.Size = new System.Drawing.Size(75, 23);
            this.AddSongButton.TabIndex = 1;
            this.AddSongButton.UseVisualStyleBackColor = true;
            this.AddSongButton.Click += new System.EventHandler(this.AddSongButton_Click);
            // 
            // RemoveSongButton
            // 
            this.RemoveSongButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveSongButton.BackgroundImage = global::SongManager.Properties.Resources.deleteActually32x32;
            this.RemoveSongButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveSongButton.FlatAppearance.BorderSize = 0;
            this.RemoveSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSongButton.Location = new System.Drawing.Point(160, 360);
            this.RemoveSongButton.Name = "RemoveSongButton";
            this.RemoveSongButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveSongButton.TabIndex = 2;
            this.RemoveSongButton.UseVisualStyleBackColor = true;
            this.RemoveSongButton.Click += new System.EventHandler(this.RemoveSongButton_Click);
            // 
            // SelectedSongGroupBox
            // 
            this.SelectedSongGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedSongGroupBox.Controls.Add(this.GenreComboBox);
            this.SelectedSongGroupBox.Controls.Add(this.GenreLabel);
            this.SelectedSongGroupBox.Controls.Add(this.DurationSecondsLabel);
            this.SelectedSongGroupBox.Controls.Add(this.ArtistNameLable);
            this.SelectedSongGroupBox.Controls.Add(this.SongNameLabel);
            this.SelectedSongGroupBox.Controls.Add(this.DurationSecondsTextBox);
            this.SelectedSongGroupBox.Controls.Add(this.ArtistNameTextBox);
            this.SelectedSongGroupBox.Controls.Add(this.SongNameTextBox);
            this.SelectedSongGroupBox.Location = new System.Drawing.Point(241, 12);
            this.SelectedSongGroupBox.Name = "SelectedSongGroupBox";
            this.SelectedSongGroupBox.Size = new System.Drawing.Size(547, 134);
            this.SelectedSongGroupBox.TabIndex = 3;
            this.SelectedSongGroupBox.TabStop = false;
            this.SelectedSongGroupBox.Text = "Selected Song";
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(152, 100);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(368, 21);
            this.GenreComboBox.TabIndex = 8;
            this.GenreComboBox.SelectedIndexChanged += new System.EventHandler(this.GenreComboBox_SelectedIndexChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(16, 103);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreLabel.TabIndex = 7;
            this.GenreLabel.Text = "Genre:";
            // 
            // DurationSecondsLabel
            // 
            this.DurationSecondsLabel.AutoSize = true;
            this.DurationSecondsLabel.Location = new System.Drawing.Point(16, 74);
            this.DurationSecondsLabel.Name = "DurationSecondsLabel";
            this.DurationSecondsLabel.Size = new System.Drawing.Size(105, 13);
            this.DurationSecondsLabel.TabIndex = 6;
            this.DurationSecondsLabel.Text = "Duration of seconds:";
            // 
            // ArtistNameLable
            // 
            this.ArtistNameLable.AutoSize = true;
            this.ArtistNameLable.Location = new System.Drawing.Point(16, 48);
            this.ArtistNameLable.Name = "ArtistNameLable";
            this.ArtistNameLable.Size = new System.Drawing.Size(64, 13);
            this.ArtistNameLable.TabIndex = 5;
            this.ArtistNameLable.Text = "Artist Name:";
            // 
            // SongNameLabel
            // 
            this.SongNameLabel.AutoSize = true;
            this.SongNameLabel.Location = new System.Drawing.Point(16, 22);
            this.SongNameLabel.Name = "SongNameLabel";
            this.SongNameLabel.Size = new System.Drawing.Size(66, 13);
            this.SongNameLabel.TabIndex = 4;
            this.SongNameLabel.Text = "Song Name:";
            // 
            // DurationSecondsTextBox
            // 
            this.DurationSecondsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DurationSecondsTextBox.Location = new System.Drawing.Point(152, 71);
            this.DurationSecondsTextBox.Name = "DurationSecondsTextBox";
            this.DurationSecondsTextBox.Size = new System.Drawing.Size(368, 20);
            this.DurationSecondsTextBox.TabIndex = 2;
            this.DurationSecondsTextBox.TextChanged += new System.EventHandler(this.DurationSecondsTextBox_TextChanged);
            // 
            // ArtistNameTextBox
            // 
            this.ArtistNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArtistNameTextBox.Location = new System.Drawing.Point(152, 45);
            this.ArtistNameTextBox.Name = "ArtistNameTextBox";
            this.ArtistNameTextBox.Size = new System.Drawing.Size(368, 20);
            this.ArtistNameTextBox.TabIndex = 1;
            this.ArtistNameTextBox.TextChanged += new System.EventHandler(this.ArtistNameTextBox_TextChanged);
            // 
            // SongNameTextBox
            // 
            this.SongNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SongNameTextBox.Location = new System.Drawing.Point(152, 19);
            this.SongNameTextBox.Name = "SongNameTextBox";
            this.SongNameTextBox.Size = new System.Drawing.Size(368, 20);
            this.SongNameTextBox.TabIndex = 0;
            this.SongNameTextBox.TextChanged += new System.EventHandler(this.SongNameTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 397);
            this.Controls.Add(this.SelectedSongGroupBox);
            this.Controls.Add(this.RemoveSongButton);
            this.Controls.Add(this.AddSongButton);
            this.Controls.Add(this.SongsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(817, 436);
            this.Name = "MainForm";
            this.Text = "Song Manager";
            this.SelectedSongGroupBox.ResumeLayout(false);
            this.SelectedSongGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SongsListBox;
        private System.Windows.Forms.Button AddSongButton;
        private System.Windows.Forms.Button RemoveSongButton;
        private System.Windows.Forms.GroupBox SelectedSongGroupBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label DurationSecondsLabel;
        private System.Windows.Forms.Label ArtistNameLable;
        private System.Windows.Forms.Label SongNameLabel;
        private System.Windows.Forms.TextBox DurationSecondsTextBox;
        private System.Windows.Forms.TextBox ArtistNameTextBox;
        private System.Windows.Forms.TextBox SongNameTextBox;
        private System.Windows.Forms.ComboBox GenreComboBox;
    }
}


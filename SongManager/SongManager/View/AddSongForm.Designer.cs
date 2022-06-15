
namespace SongManager.View
{
    partial class AddSongForm
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
            this.GenreLabel = new System.Windows.Forms.Label();
            this.DurationSecondsLabel = new System.Windows.Forms.Label();
            this.ArtistNameLabel = new System.Windows.Forms.Label();
            this.SongNameLabel = new System.Windows.Forms.Label();
            this.DurationSecondsTextBox = new System.Windows.Forms.TextBox();
            this.ArtistNameTextBox = new System.Windows.Forms.TextBox();
            this.SongNameTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(84, 102);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(41, 15);
            this.GenreLabel.TabIndex = 15;
            this.GenreLabel.Text = "Genre:";
            // 
            // DurationSecondsLabel
            // 
            this.DurationSecondsLabel.AutoSize = true;
            this.DurationSecondsLabel.Location = new System.Drawing.Point(9, 73);
            this.DurationSecondsLabel.Name = "DurationSecondsLabel";
            this.DurationSecondsLabel.Size = new System.Drawing.Size(116, 15);
            this.DurationSecondsLabel.TabIndex = 14;
            this.DurationSecondsLabel.Text = "Duration of seconds:";
            // 
            // ArtistNameLabel
            // 
            this.ArtistNameLabel.AutoSize = true;
            this.ArtistNameLabel.Location = new System.Drawing.Point(52, 44);
            this.ArtistNameLabel.Name = "ArtistNameLabel";
            this.ArtistNameLabel.Size = new System.Drawing.Size(73, 15);
            this.ArtistNameLabel.TabIndex = 13;
            this.ArtistNameLabel.Text = "Artist Name:";
            // 
            // SongNameLabel
            // 
            this.SongNameLabel.AutoSize = true;
            this.SongNameLabel.Location = new System.Drawing.Point(56, 15);
            this.SongNameLabel.Name = "SongNameLabel";
            this.SongNameLabel.Size = new System.Drawing.Size(69, 15);
            this.SongNameLabel.TabIndex = 12;
            this.SongNameLabel.Text = "Song Name";
            // 
            // DurationSecondsTextBox
            // 
            this.DurationSecondsTextBox.Location = new System.Drawing.Point(131, 70);
            this.DurationSecondsTextBox.Name = "DurationSecondsTextBox";
            this.DurationSecondsTextBox.Size = new System.Drawing.Size(277, 23);
            this.DurationSecondsTextBox.TabIndex = 10;
            this.DurationSecondsTextBox.TextChanged += new System.EventHandler(this.DurationSecondsTextBox_TextChanged);
            // 
            // ArtistNameTextBox
            // 
            this.ArtistNameTextBox.Location = new System.Drawing.Point(131, 41);
            this.ArtistNameTextBox.Name = "ArtistNameTextBox";
            this.ArtistNameTextBox.Size = new System.Drawing.Size(277, 23);
            this.ArtistNameTextBox.TabIndex = 9;
            this.ArtistNameTextBox.TextChanged += new System.EventHandler(this.ArtistNameTextBox_TextChanged);
            // 
            // SongNameTextBox
            // 
            this.SongNameTextBox.Location = new System.Drawing.Point(131, 12);
            this.SongNameTextBox.Name = "SongNameTextBox";
            this.SongNameTextBox.Size = new System.Drawing.Size(277, 23);
            this.SongNameTextBox.TabIndex = 8;
            this.SongNameTextBox.TextChanged += new System.EventHandler(this.SongNameTextBox_TextChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(333, 151);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(252, 151);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 16;
            this.OKButton.Text = "Ok";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(131, 99);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(277, 23);
            this.GenreComboBox.TabIndex = 18;
            this.GenreComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddSongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 187);
            this.Controls.Add(this.GenreComboBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.DurationSecondsLabel);
            this.Controls.Add(this.ArtistNameLabel);
            this.Controls.Add(this.SongNameLabel);
            this.Controls.Add(this.DurationSecondsTextBox);
            this.Controls.Add(this.ArtistNameTextBox);
            this.Controls.Add(this.SongNameTextBox);
            this.MaximumSize = new System.Drawing.Size(436, 226);
            this.MinimumSize = new System.Drawing.Size(436, 226);
            this.Name = "AddSongForm";
            this.Text = "Add Song";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label DurationSecondsLabel;
        private System.Windows.Forms.Label ArtistNameLabel;
        private System.Windows.Forms.Label SongNameLabel;
        private System.Windows.Forms.TextBox DurationSecondsTextBox;
        private System.Windows.Forms.TextBox ArtistNameTextBox;
        private System.Windows.Forms.TextBox SongNameTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.ComboBox GenreComboBox;
    }
}
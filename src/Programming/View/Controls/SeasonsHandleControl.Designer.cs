
namespace Programming.View.Controls
{
    partial class SeasonsHandleControl
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
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonGoButton = new System.Windows.Forms.Button();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.SeasonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonGroupBox.Controls.Add(this.SeasonGoButton);
            this.SeasonGroupBox.Controls.Add(this.SeasonLabel);
            this.SeasonGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(816, 489);
            this.SeasonGroupBox.TabIndex = 2;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(6, 49);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(167, 23);
            this.SeasonComboBox.TabIndex = 4;
            // 
            // SeasonGoButton
            // 
            this.SeasonGoButton.Location = new System.Drawing.Point(179, 49);
            this.SeasonGoButton.Name = "SeasonGoButton";
            this.SeasonGoButton.Size = new System.Drawing.Size(75, 23);
            this.SeasonGoButton.TabIndex = 3;
            this.SeasonGoButton.Text = "GO!";
            this.SeasonGoButton.UseVisualStyleBackColor = true;
            this.SeasonGoButton.Click += new System.EventHandler(this.SeasonGoButton_Click);
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(6, 32);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(89, 15);
            this.SeasonLabel.TabIndex = 2;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // SeasonsHandleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SeasonGroupBox);
            this.Name = "SeasonsHandleControl";
            this.Size = new System.Drawing.Size(816, 489);
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.Button SeasonGoButton;
        private System.Windows.Forms.Label SeasonLabel;
    }
}

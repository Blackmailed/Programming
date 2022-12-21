namespace ObjectOrientedPractics
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
            this.ItemsTab = new System.Windows.Forms.TabControl();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.ItemsTabControl = new ObjectOrientedPractics.View.Tabs.ItemsTabControl();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.CustomersTabControl = new ObjectOrientedPractics.View.Tabs.CustomersTabControl();
            this.CartsTabPage = new System.Windows.Forms.TabPage();
            this.ItemsTab.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.CustomersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsTab
            // 
            this.ItemsTab.Controls.Add(this.ItemsTabPage);
            this.ItemsTab.Controls.Add(this.CustomersTabPage);
            this.ItemsTab.Controls.Add(this.CartsTabPage);
            this.ItemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTab.Location = new System.Drawing.Point(0, 0);
            this.ItemsTab.MinimumSize = new System.Drawing.Size(869, 572);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.SelectedIndex = 0;
            this.ItemsTab.Size = new System.Drawing.Size(869, 572);
            this.ItemsTab.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.ItemsTabControl);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(861, 546);
            this.ItemsTabPage.TabIndex = 0;
            this.ItemsTabPage.Text = "Items Tab";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTabControl
            // 
            this.ItemsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTabControl.Location = new System.Drawing.Point(3, 3);
            this.ItemsTabControl.MinimumSize = new System.Drawing.Size(864, 546);
            this.ItemsTabControl.Name = "ItemsTabControl";
            this.ItemsTabControl.Size = new System.Drawing.Size(864, 546);
            this.ItemsTabControl.TabIndex = 0;
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Controls.Add(this.CustomersTabControl);
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 22);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTabPage.Size = new System.Drawing.Size(861, 546);
            this.CustomersTabPage.TabIndex = 1;
            this.CustomersTabPage.Text = "Customers Tab";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTabControl
            // 
            this.CustomersTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersTabControl.Location = new System.Drawing.Point(3, 3);
            this.CustomersTabControl.Name = "CustomersTabControl";
            this.CustomersTabControl.Size = new System.Drawing.Size(855, 540);
            this.CustomersTabControl.TabIndex = 0;
            // 
            // CartsTabPage
            // 
            this.CartsTabPage.Location = new System.Drawing.Point(4, 22);
            this.CartsTabPage.Name = "CartsTabPage";
            this.CartsTabPage.Size = new System.Drawing.Size(861, 546);
            this.CartsTabPage.TabIndex = 2;
            this.CartsTabPage.Text = "Carts Tab";
            this.CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 572);
            this.Controls.Add(this.ItemsTab);
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.ItemsTab.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.CustomersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ItemsTab;
        private System.Windows.Forms.TabPage ItemsTabPage;
        private System.Windows.Forms.TabPage CustomersTabPage;
        private View.Tabs.ItemsTabControl ItemsTabControl;
        private View.Tabs.CustomersTabControl CustomersTabControl;
        private System.Windows.Forms.TabPage CartsTabPage;
    }
}

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
            this.ItemsTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ItemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTabControl();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customersTabControl1 = new ObjectOrientedPractics.View.Tabs.CustomersTabControl();
            this.ItemsTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.CustomersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsTabControl
            // 
            this.ItemsTabControl.Controls.Add(this.tabPage1);
            this.ItemsTabControl.Controls.Add(this.CustomersTabPage);
            this.ItemsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTabControl.Location = new System.Drawing.Point(0, 0);
            this.ItemsTabControl.MinimumSize = new System.Drawing.Size(869, 572);
            this.ItemsTabControl.Name = "ItemsTabControl";
            this.ItemsTabControl.SelectedIndex = 0;
            this.ItemsTabControl.Size = new System.Drawing.Size(869, 572);
            this.ItemsTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ItemsTab);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(861, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Items Tab";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTab.Location = new System.Drawing.Point(3, 3);
            this.ItemsTab.MinimumSize = new System.Drawing.Size(864, 546);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Size = new System.Drawing.Size(864, 546);
            this.ItemsTab.TabIndex = 0;
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Controls.Add(this.panel1);
            this.CustomersTabPage.Controls.Add(this.customersTabControl1);
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 22);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTabPage.Size = new System.Drawing.Size(861, 546);
            this.CustomersTabPage.TabIndex = 1;
            this.CustomersTabPage.Text = "Customers Tab";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(360, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 324);
            this.panel1.TabIndex = 1;
            // 
            // customersTabControl1
            // 
            this.customersTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTabControl1.Location = new System.Drawing.Point(3, 3);
            this.customersTabControl1.MinimumSize = new System.Drawing.Size(864, 546);
            this.customersTabControl1.Name = "customersTabControl1";
            this.customersTabControl1.Size = new System.Drawing.Size(864, 546);
            this.customersTabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 572);
            this.Controls.Add(this.ItemsTabControl);
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.ItemsTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.CustomersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ItemsTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage CustomersTabPage;
        private View.Tabs.ItemsTabControl ItemsTab;
        private View.Tabs.CustomersTabControl customersTabControl1;
        private System.Windows.Forms.Panel panel1;
    }
}


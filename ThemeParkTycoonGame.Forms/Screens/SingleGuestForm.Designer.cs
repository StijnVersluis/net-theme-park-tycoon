namespace ThemeParkTycoonGame.Forms.Screens
{
    partial class SingleGuestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleGuestForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.desiresGroupBox = new System.Windows.Forms.GroupBox();
            this.desiresPanel = new System.Windows.Forms.Panel();
            this.statsGroupBox = new System.Windows.Forms.GroupBox();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.actionsListView = new System.Windows.Forms.ListView();
            this.rideColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rideEntryTimeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.financeListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.desiresGroupBox.SuspendLayout();
            this.statsGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.desiresGroupBox);
            this.panel1.Controls.Add(this.statsGroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 122);
            this.panel1.TabIndex = 0;
            // 
            // desiresGroupBox
            // 
            this.desiresGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.desiresGroupBox.Controls.Add(this.desiresPanel);
            this.desiresGroupBox.Location = new System.Drawing.Point(398, 3);
            this.desiresGroupBox.Name = "desiresGroupBox";
            this.desiresGroupBox.Size = new System.Drawing.Size(366, 116);
            this.desiresGroupBox.TabIndex = 6;
            this.desiresGroupBox.TabStop = false;
            this.desiresGroupBox.Text = "Desires";
            // 
            // desiresPanel
            // 
            this.desiresPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.desiresPanel.AutoScroll = true;
            this.desiresPanel.Location = new System.Drawing.Point(6, 19);
            this.desiresPanel.Name = "desiresPanel";
            this.desiresPanel.Size = new System.Drawing.Size(351, 91);
            this.desiresPanel.TabIndex = 1;
            // 
            // statsGroupBox
            // 
            this.statsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statsGroupBox.Controls.Add(this.statsPanel);
            this.statsGroupBox.Location = new System.Drawing.Point(6, 3);
            this.statsGroupBox.Name = "statsGroupBox";
            this.statsGroupBox.Size = new System.Drawing.Size(386, 116);
            this.statsGroupBox.TabIndex = 5;
            this.statsGroupBox.TabStop = false;
            this.statsGroupBox.Text = "Stats";
            // 
            // statsPanel
            // 
            this.statsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statsPanel.AutoScroll = true;
            this.statsPanel.Location = new System.Drawing.Point(6, 19);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(374, 91);
            this.statsPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.actionsListView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 150);
            this.panel2.TabIndex = 1;
            // 
            // actionsListView
            // 
            this.actionsListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.actionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rideColumnHeader,
            this.rideEntryTimeColumnHeader,
            this.statColumnHeader});
            this.actionsListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.actionsListView.Location = new System.Drawing.Point(0, 0);
            this.actionsListView.Name = "actionsListView";
            this.actionsListView.Size = new System.Drawing.Size(767, 150);
            this.actionsListView.TabIndex = 5;
            this.actionsListView.UseCompatibleStateImageBehavior = false;
            this.actionsListView.View = System.Windows.Forms.View.Details;
            // 
            // rideColumnHeader
            // 
            this.rideColumnHeader.Text = "Ride";
            this.rideColumnHeader.Width = 100;
            // 
            // rideEntryTimeColumnHeader
            // 
            this.rideEntryTimeColumnHeader.Text = "Time Of Ride";
            this.rideEntryTimeColumnHeader.Width = 135;
            // 
            // statColumnHeader
            // 
            this.statColumnHeader.Text = "Stats Changes";
            this.statColumnHeader.Width = 500;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.financeListView);
            this.panel3.Location = new System.Drawing.Point(0, 272);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(767, 125);
            this.panel3.TabIndex = 2;
            // 
            // financeListView
            // 
            this.financeListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.financeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.financeListView.Location = new System.Drawing.Point(0, 0);
            this.financeListView.Name = "financeListView";
            this.financeListView.Size = new System.Drawing.Size(767, 125);
            this.financeListView.TabIndex = 6;
            this.financeListView.UseCompatibleStateImageBehavior = false;
            this.financeListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Balance Changed";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time Of Transaction";
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 500;
            // 
            // SingleGuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 399);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SingleGuestForm";
            this.Text = "GuestForm";
            this.panel1.ResumeLayout(false);
            this.desiresGroupBox.ResumeLayout(false);
            this.statsGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox statsGroupBox;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.GroupBox desiresGroupBox;
        private System.Windows.Forms.Panel desiresPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView actionsListView;
        private System.Windows.Forms.ColumnHeader rideColumnHeader;
        private System.Windows.Forms.ColumnHeader rideEntryTimeColumnHeader;
        private System.Windows.Forms.ColumnHeader statColumnHeader;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView financeListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
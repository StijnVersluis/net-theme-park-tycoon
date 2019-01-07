namespace ThemeParkTycoonGame.UI
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
            this.actionsListView = new System.Windows.Forms.ListView();
            this.rideColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rideEntryTimeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // actionsListView
            // 
            this.actionsListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.actionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rideColumnHeader,
            this.rideEntryTimeColumnHeader});
            this.actionsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionsListView.Location = new System.Drawing.Point(0, 0);
            this.actionsListView.Name = "actionsListView";
            this.actionsListView.Size = new System.Drawing.Size(240, 197);
            this.actionsListView.TabIndex = 3;
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
            // SingleGuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 197);
            this.Controls.Add(this.actionsListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SingleGuestForm";
            this.Text = "GuestForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView actionsListView;
        private System.Windows.Forms.ColumnHeader rideColumnHeader;
        private System.Windows.Forms.ColumnHeader rideEntryTimeColumnHeader;
    }
}
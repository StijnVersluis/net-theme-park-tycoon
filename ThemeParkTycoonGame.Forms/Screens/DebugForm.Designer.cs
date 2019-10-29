namespace ThemeParkTycoonGame.Forms.Screens
{
    partial class DebugForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugForm));
            this.addGuestButton = new System.Windows.Forms.Button();
            this.changeWeatherButton = new System.Windows.Forms.Button();
            this.generateMoneyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addGuestButton
            // 
            this.addGuestButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addGuestButton.Location = new System.Drawing.Point(0, 0);
            this.addGuestButton.Name = "addGuestButton";
            this.addGuestButton.Size = new System.Drawing.Size(354, 29);
            this.addGuestButton.TabIndex = 0;
            this.addGuestButton.Text = "Add New Guest";
            this.addGuestButton.UseVisualStyleBackColor = true;
            this.addGuestButton.Click += new System.EventHandler(this.addGuestButton_Click);
            // 
            // changeWeatherButton
            // 
            this.changeWeatherButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.changeWeatherButton.Location = new System.Drawing.Point(0, 29);
            this.changeWeatherButton.Name = "changeWeatherButton";
            this.changeWeatherButton.Size = new System.Drawing.Size(354, 29);
            this.changeWeatherButton.TabIndex = 1;
            this.changeWeatherButton.Text = "Change Weather";
            this.changeWeatherButton.UseVisualStyleBackColor = true;
            this.changeWeatherButton.Click += new System.EventHandler(this.changeWeatherButton_Click);
            // 
            // generateMoneyButton
            // 
            this.generateMoneyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.generateMoneyButton.Location = new System.Drawing.Point(0, 58);
            this.generateMoneyButton.Name = "generateMoneyButton";
            this.generateMoneyButton.Size = new System.Drawing.Size(354, 29);
            this.generateMoneyButton.TabIndex = 2;
            this.generateMoneyButton.Text = "Generate $1,000";
            this.generateMoneyButton.UseVisualStyleBackColor = true;
            this.generateMoneyButton.Click += new System.EventHandler(this.generateMoneyButton_Click);
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 88);
            this.Controls.Add(this.generateMoneyButton);
            this.Controls.Add(this.changeWeatherButton);
            this.Controls.Add(this.addGuestButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DebugForm";
            this.Text = "Debugging";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addGuestButton;
        private System.Windows.Forms.Button changeWeatherButton;
        private System.Windows.Forms.Button generateMoneyButton;
    }
}
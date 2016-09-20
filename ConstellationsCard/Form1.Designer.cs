namespace ConstellationsCard
{
    partial class stars
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
            this.SuspendLayout();
            // 
            // stars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ConstellationsCard.Properties.Resources.night_sky_hd_wallpaper;
            this.ClientSize = new System.Drawing.Size(755, 479);
            this.Name = "stars";
            this.Text = "Constellations Card";
            this.Load += new System.EventHandler(this.stars_Load);
            this.Click += new System.EventHandler(this.stars_Click);
            this.ResumeLayout(false);

        }

        #endregion
    }
}


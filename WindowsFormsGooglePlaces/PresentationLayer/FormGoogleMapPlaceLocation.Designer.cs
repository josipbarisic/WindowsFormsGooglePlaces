namespace PresentationLayer
{
    partial class FormGoogleMapPlaceLocation
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
            this.webBrowserGoogleMap = new System.Windows.Forms.WebBrowser();
            this.labelMjesto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowserGoogleMap
            // 
            this.webBrowserGoogleMap.AllowWebBrowserDrop = false;
            this.webBrowserGoogleMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserGoogleMap.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserGoogleMap.Location = new System.Drawing.Point(0, 57);
            this.webBrowserGoogleMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserGoogleMap.Name = "webBrowserGoogleMap";
            this.webBrowserGoogleMap.Size = new System.Drawing.Size(1200, 601);
            this.webBrowserGoogleMap.TabIndex = 0;
            this.webBrowserGoogleMap.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // labelMjesto
            // 
            this.labelMjesto.AutoSize = true;
            this.labelMjesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMjesto.Location = new System.Drawing.Point(12, 9);
            this.labelMjesto.Name = "labelMjesto";
            this.labelMjesto.Size = new System.Drawing.Size(158, 29);
            this.labelMjesto.TabIndex = 1;
            this.labelMjesto.Text = "NaslovMjesta";
            // 
            // FormGoogleMapPlaceLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 657);
            this.Controls.Add(this.labelMjesto);
            this.Controls.Add(this.webBrowserGoogleMap);
            this.Name = "FormGoogleMapPlaceLocation";
            this.Text = "GoogleMaps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserGoogleMap;
        private System.Windows.Forms.Label labelMjesto;
    }
}
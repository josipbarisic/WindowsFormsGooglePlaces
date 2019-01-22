namespace PresentationLayer
{
    partial class FormAdded
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
            this.labelAddedTitle = new System.Windows.Forms.Label();
            this.buttonAddedUredu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddedTitle
            // 
            this.labelAddedTitle.AutoSize = true;
            this.labelAddedTitle.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddedTitle.Location = new System.Drawing.Point(56, 45);
            this.labelAddedTitle.Name = "labelAddedTitle";
            this.labelAddedTitle.Size = new System.Drawing.Size(396, 38);
            this.labelAddedTitle.TabIndex = 0;
            this.labelAddedTitle.Text = "Dodano u \'Moja mjesta\'";
            // 
            // buttonAddedUredu
            // 
            this.buttonAddedUredu.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddedUredu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddedUredu.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddedUredu.Location = new System.Drawing.Point(180, 147);
            this.buttonAddedUredu.Name = "buttonAddedUredu";
            this.buttonAddedUredu.Size = new System.Drawing.Size(121, 39);
            this.buttonAddedUredu.TabIndex = 1;
            this.buttonAddedUredu.Text = "U redu";
            this.buttonAddedUredu.UseVisualStyleBackColor = false;
            this.buttonAddedUredu.Click += new System.EventHandler(this.buttonAddedUredu_Click);
            // 
            // FormAdded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 229);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAddedUredu);
            this.Controls.Add(this.labelAddedTitle);
            this.Name = "FormAdded";
            this.Text = "FormAdded";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddedTitle;
        private System.Windows.Forms.Button buttonAddedUredu;
    }
}
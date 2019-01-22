namespace PresentationLayer
{
    partial class FormPlaceDeleted
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
            this.labelPlaceDeletedTitle = new System.Windows.Forms.Label();
            this.buttonPlaceDeletedUredu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPlaceDeletedTitle
            // 
            this.labelPlaceDeletedTitle.AutoSize = true;
            this.labelPlaceDeletedTitle.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaceDeletedTitle.Location = new System.Drawing.Point(109, 41);
            this.labelPlaceDeletedTitle.Name = "labelPlaceDeletedTitle";
            this.labelPlaceDeletedTitle.Size = new System.Drawing.Size(284, 38);
            this.labelPlaceDeletedTitle.TabIndex = 0;
            this.labelPlaceDeletedTitle.Text = "Mjesto obrisano!";
            // 
            // buttonPlaceDeletedUredu
            // 
            this.buttonPlaceDeletedUredu.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonPlaceDeletedUredu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlaceDeletedUredu.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPlaceDeletedUredu.Location = new System.Drawing.Point(180, 130);
            this.buttonPlaceDeletedUredu.Name = "buttonPlaceDeletedUredu";
            this.buttonPlaceDeletedUredu.Size = new System.Drawing.Size(119, 46);
            this.buttonPlaceDeletedUredu.TabIndex = 1;
            this.buttonPlaceDeletedUredu.Text = "U redu";
            this.buttonPlaceDeletedUredu.UseVisualStyleBackColor = false;
            this.buttonPlaceDeletedUredu.Click += new System.EventHandler(this.buttonPlaceDeletedUredu_Click);
            // 
            // FormPlaceDeleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 226);
            this.ControlBox = false;
            this.Controls.Add(this.buttonPlaceDeletedUredu);
            this.Controls.Add(this.labelPlaceDeletedTitle);
            this.Name = "FormPlaceDeleted";
            this.Text = "FormPlaceDeleted";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlaceDeletedTitle;
        private System.Windows.Forms.Button buttonPlaceDeletedUredu;
    }
}
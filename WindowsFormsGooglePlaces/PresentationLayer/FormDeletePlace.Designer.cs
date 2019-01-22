namespace PresentationLayer
{
    partial class FormDeletePlace
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
            this.buttonConfirmPlaceDelete = new System.Windows.Forms.Button();
            this.buttonCancelDelete = new System.Windows.Forms.Button();
            this.labelDeletePlace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConfirmPlaceDelete
            // 
            this.buttonConfirmPlaceDelete.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonConfirmPlaceDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmPlaceDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConfirmPlaceDelete.Location = new System.Drawing.Point(69, 138);
            this.buttonConfirmPlaceDelete.Name = "buttonConfirmPlaceDelete";
            this.buttonConfirmPlaceDelete.Size = new System.Drawing.Size(110, 34);
            this.buttonConfirmPlaceDelete.TabIndex = 0;
            this.buttonConfirmPlaceDelete.Text = "Obriši";
            this.buttonConfirmPlaceDelete.UseVisualStyleBackColor = false;
            this.buttonConfirmPlaceDelete.Click += new System.EventHandler(this.buttonConfirmPlaceDelete_Click);
            // 
            // buttonCancelDelete
            // 
            this.buttonCancelDelete.BackColor = System.Drawing.Color.DarkRed;
            this.buttonCancelDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCancelDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancelDelete.Location = new System.Drawing.Point(268, 138);
            this.buttonCancelDelete.Name = "buttonCancelDelete";
            this.buttonCancelDelete.Size = new System.Drawing.Size(110, 34);
            this.buttonCancelDelete.TabIndex = 1;
            this.buttonCancelDelete.Text = "Odustani";
            this.buttonCancelDelete.UseVisualStyleBackColor = false;
            this.buttonCancelDelete.Click += new System.EventHandler(this.buttonCancelDelete_Click);
            // 
            // labelDeletePlace
            // 
            this.labelDeletePlace.AutoSize = true;
            this.labelDeletePlace.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeletePlace.Location = new System.Drawing.Point(64, 42);
            this.labelDeletePlace.Name = "labelDeletePlace";
            this.labelDeletePlace.Size = new System.Drawing.Size(314, 29);
            this.labelDeletePlace.TabIndex = 2;
            this.labelDeletePlace.Text = "Želite obrisati mjesto?";
            // 
            // FormDeletePlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 209);
            this.ControlBox = false;
            this.Controls.Add(this.labelDeletePlace);
            this.Controls.Add(this.buttonCancelDelete);
            this.Controls.Add(this.buttonConfirmPlaceDelete);
            this.Name = "FormDeletePlace";
            this.Text = "FormDeletePlace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmPlaceDelete;
        private System.Windows.Forms.Button buttonCancelDelete;
        private System.Windows.Forms.Label labelDeletePlace;
    }
}
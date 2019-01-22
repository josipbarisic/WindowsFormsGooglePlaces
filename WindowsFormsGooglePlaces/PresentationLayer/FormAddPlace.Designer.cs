namespace PresentationLayer
{
    partial class FormAddPlace
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
            this.labelAddPlace = new System.Windows.Forms.Label();
            this.buttonConfirmAdd = new System.Windows.Forms.Button();
            this.buttonCancelAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddPlace
            // 
            this.labelAddPlace.AutoSize = true;
            this.labelAddPlace.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddPlace.Location = new System.Drawing.Point(81, 35);
            this.labelAddPlace.Name = "labelAddPlace";
            this.labelAddPlace.Size = new System.Drawing.Size(297, 29);
            this.labelAddPlace.TabIndex = 0;
            this.labelAddPlace.Text = "Želite dodati mjesto?";
            // 
            // buttonConfirmAdd
            // 
            this.buttonConfirmAdd.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonConfirmAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConfirmAdd.Location = new System.Drawing.Point(86, 135);
            this.buttonConfirmAdd.Name = "buttonConfirmAdd";
            this.buttonConfirmAdd.Size = new System.Drawing.Size(110, 34);
            this.buttonConfirmAdd.TabIndex = 1;
            this.buttonConfirmAdd.Text = "Dodaj";
            this.buttonConfirmAdd.UseVisualStyleBackColor = false;
            this.buttonConfirmAdd.Click += new System.EventHandler(this.buttonConfirmAdd_Click);
            // 
            // buttonCancelAdd
            // 
            this.buttonCancelAdd.BackColor = System.Drawing.Color.DarkRed;
            this.buttonCancelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancelAdd.Location = new System.Drawing.Point(268, 135);
            this.buttonCancelAdd.Name = "buttonCancelAdd";
            this.buttonCancelAdd.Size = new System.Drawing.Size(110, 34);
            this.buttonCancelAdd.TabIndex = 2;
            this.buttonCancelAdd.Text = "Odustani";
            this.buttonCancelAdd.UseVisualStyleBackColor = false;
            this.buttonCancelAdd.Click += new System.EventHandler(this.buttonCancelAdd_Click);
            // 
            // FormAddPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 240);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancelAdd);
            this.Controls.Add(this.buttonConfirmAdd);
            this.Controls.Add(this.labelAddPlace);
            this.Name = "FormAddPlace";
            this.Text = "FormAddPlace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddPlace;
        private System.Windows.Forms.Button buttonConfirmAdd;
        private System.Windows.Forms.Button buttonCancelAdd;
    }
}
namespace PresentationLayer
{
    partial class FormAlreadyAdded
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
            this.buttonUredu = new System.Windows.Forms.Button();
            this.labelDodano = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUredu
            // 
            this.buttonUredu.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonUredu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUredu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonUredu.Location = new System.Drawing.Point(184, 130);
            this.buttonUredu.Name = "buttonUredu";
            this.buttonUredu.Size = new System.Drawing.Size(105, 37);
            this.buttonUredu.TabIndex = 0;
            this.buttonUredu.Text = "U redu";
            this.buttonUredu.UseVisualStyleBackColor = false;
            this.buttonUredu.Click += new System.EventHandler(this.buttonUredu_Click);
            // 
            // labelDodano
            // 
            this.labelDodano.AutoSize = true;
            this.labelDodano.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDodano.Location = new System.Drawing.Point(78, 46);
            this.labelDodano.Name = "labelDodano";
            this.labelDodano.Size = new System.Drawing.Size(330, 38);
            this.labelDodano.TabIndex = 1;
            this.labelDodano.Text = "Mjesto već dodano!";
            // 
            // FormAlreadyAdded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 214);
            this.ControlBox = false;
            this.Controls.Add(this.labelDodano);
            this.Controls.Add(this.buttonUredu);
            this.Name = "FormAlreadyAdded";
            this.Text = "FormAlreadyAdded";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUredu;
        private System.Windows.Forms.Label labelDodano;
    }
}
namespace PresentationLayer
{
    partial class FormSearchedPlaces
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
            this.dataGridViewSearchedPlaces = new System.Windows.Forms.DataGridView();
            this.SearchedPlaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMjesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCityLabel = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchedPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSearchedPlaces
            // 
            this.dataGridViewSearchedPlaces.AllowUserToAddRows = false;
            this.dataGridViewSearchedPlaces.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchedPlaces.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSearchedPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchedPlaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SearchedPlaceName,
            this.IdMjesta});
            this.dataGridViewSearchedPlaces.Location = new System.Drawing.Point(12, 109);
            this.dataGridViewSearchedPlaces.Name = "dataGridViewSearchedPlaces";
            this.dataGridViewSearchedPlaces.RowHeadersVisible = false;
            this.dataGridViewSearchedPlaces.Size = new System.Drawing.Size(674, 277);
            this.dataGridViewSearchedPlaces.TabIndex = 0;
            this.dataGridViewSearchedPlaces.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchedPlaces_CellContentClick);
            // 
            // SearchedPlaceName
            // 
            this.SearchedPlaceName.DataPropertyName = "Name";
            this.SearchedPlaceName.HeaderText = "Name";
            this.SearchedPlaceName.Name = "SearchedPlaceName";
            // 
            // IdMjesta
            // 
            this.IdMjesta.DataPropertyName = "Id";
            this.IdMjesta.HeaderText = "IdMjesta";
            this.IdMjesta.Name = "IdMjesta";
            this.IdMjesta.Visible = false;
            // 
            // typeCityLabel
            // 
            this.typeCityLabel.AutoSize = true;
            this.typeCityLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCityLabel.Location = new System.Drawing.Point(12, 22);
            this.typeCityLabel.Name = "typeCityLabel";
            this.typeCityLabel.Size = new System.Drawing.Size(189, 32);
            this.typeCityLabel.TabIndex = 1;
            this.typeCityLabel.Text = "Type in city";
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBack.Image = global::PresentationLayer.Properties.Resources.rsz_left_arrow;
            this.buttonBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBack.Location = new System.Drawing.Point(560, 68);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(126, 35);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Povratak";
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormSearchedPlaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 398);
            this.ControlBox = false;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.typeCityLabel);
            this.Controls.Add(this.dataGridViewSearchedPlaces);
            this.Name = "FormSearchedPlaces";
            this.Text = "FormSearchedPlaces";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchedPlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSearchedPlaces;
        private System.Windows.Forms.Label typeCityLabel;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn SearchedPlaceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMjesta;
    }
}
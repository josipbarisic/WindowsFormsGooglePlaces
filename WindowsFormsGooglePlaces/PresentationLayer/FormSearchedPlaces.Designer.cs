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
            this.typeCityLabel = new System.Windows.Forms.Label();
            this.SearchedPlaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchedPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSearchedPlaces
            // 
            this.dataGridViewSearchedPlaces.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchedPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchedPlaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SearchedPlaceName});
            this.dataGridViewSearchedPlaces.Location = new System.Drawing.Point(12, 70);
            this.dataGridViewSearchedPlaces.Name = "dataGridViewSearchedPlaces";
            this.dataGridViewSearchedPlaces.Size = new System.Drawing.Size(674, 277);
            this.dataGridViewSearchedPlaces.TabIndex = 0;
            this.dataGridViewSearchedPlaces.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchedPlaces_CellContentClick);
            // 
            // typeCityLabel
            // 
            this.typeCityLabel.AutoSize = true;
            this.typeCityLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCityLabel.Location = new System.Drawing.Point(12, 9);
            this.typeCityLabel.Name = "typeCityLabel";
            this.typeCityLabel.Size = new System.Drawing.Size(168, 29);
            this.typeCityLabel.TabIndex = 1;
            this.typeCityLabel.Text = "Type in city";
            // 
            // SearchedPlaceName
            // 
            this.SearchedPlaceName.DataPropertyName = "Name";
            this.SearchedPlaceName.HeaderText = "Name";
            this.SearchedPlaceName.Name = "SearchedPlaceName";
            // 
            // FormSearchedPlaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 359);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn SearchedPlaceName;
    }
}
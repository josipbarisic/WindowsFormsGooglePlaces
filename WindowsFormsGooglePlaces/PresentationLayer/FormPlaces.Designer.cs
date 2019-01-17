namespace PresentationLayer
{
    partial class FormPlaces
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Pretraga = new System.Windows.Forms.TabPage();
            this.dataGridViewPretragaMjesta = new System.Windows.Forms.DataGridView();
            this.buttonPretragaMjesta = new System.Windows.Forms.Button();
            this.comboBoxTipovi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Naslov = new System.Windows.Forms.Label();
            this.comboBoxGradovi = new System.Windows.Forms.ComboBox();
            this.tabMojaMjesta = new System.Windows.Forms.TabPage();
            this.dataGridViewMojaMjesta = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.Pretraga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPretragaMjesta)).BeginInit();
            this.tabMojaMjesta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMojaMjesta)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Pretraga);
            this.tabControl.Controls.Add(this.tabMojaMjesta);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 426);
            this.tabControl.TabIndex = 1;
            // 
            // Pretraga
            // 
            this.Pretraga.Controls.Add(this.dataGridViewPretragaMjesta);
            this.Pretraga.Controls.Add(this.buttonPretragaMjesta);
            this.Pretraga.Controls.Add(this.comboBoxTipovi);
            this.Pretraga.Controls.Add(this.label2);
            this.Pretraga.Controls.Add(this.label1);
            this.Pretraga.Controls.Add(this.Naslov);
            this.Pretraga.Controls.Add(this.comboBoxGradovi);
            this.Pretraga.Location = new System.Drawing.Point(4, 22);
            this.Pretraga.Name = "Pretraga";
            this.Pretraga.Padding = new System.Windows.Forms.Padding(3);
            this.Pretraga.Size = new System.Drawing.Size(768, 400);
            this.Pretraga.TabIndex = 0;
            this.Pretraga.Text = "Pretraga";
            this.Pretraga.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPretragaMjesta
            // 
            this.dataGridViewPretragaMjesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPretragaMjesta.Location = new System.Drawing.Point(10, 111);
            this.dataGridViewPretragaMjesta.Name = "dataGridViewPretragaMjesta";
            this.dataGridViewPretragaMjesta.Size = new System.Drawing.Size(752, 283);
            this.dataGridViewPretragaMjesta.TabIndex = 6;
            // 
            // buttonPretragaMjesta
            // 
            this.buttonPretragaMjesta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPretragaMjesta.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPretragaMjesta.Location = new System.Drawing.Point(662, 50);
            this.buttonPretragaMjesta.Name = "buttonPretragaMjesta";
            this.buttonPretragaMjesta.Size = new System.Drawing.Size(103, 39);
            this.buttonPretragaMjesta.TabIndex = 5;
            this.buttonPretragaMjesta.Text = "Pretraga";
            this.buttonPretragaMjesta.UseVisualStyleBackColor = true;
            // 
            // comboBoxTipovi
            // 
            this.comboBoxTipovi.FormattingEnabled = true;
            this.comboBoxTipovi.Location = new System.Drawing.Point(488, 60);
            this.comboBoxTipovi.Name = "comboBoxTipovi";
            this.comboBoxTipovi.Size = new System.Drawing.Size(162, 21);
            this.comboBoxTipovi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odaberite tip mjesta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odaberite grad:";
            // 
            // Naslov
            // 
            this.Naslov.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Naslov.AutoSize = true;
            this.Naslov.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naslov.Location = new System.Drawing.Point(220, 3);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(283, 42);
            this.Naslov.TabIndex = 1;
            this.Naslov.Text = "Pretraži mjesta";
            // 
            // comboBoxGradovi
            // 
            this.comboBoxGradovi.FormattingEnabled = true;
            this.comboBoxGradovi.Location = new System.Drawing.Point(137, 60);
            this.comboBoxGradovi.Name = "comboBoxGradovi";
            this.comboBoxGradovi.Size = new System.Drawing.Size(162, 21);
            this.comboBoxGradovi.TabIndex = 0;
            // 
            // tabMojaMjesta
            // 
            this.tabMojaMjesta.Controls.Add(this.dataGridViewMojaMjesta);
            this.tabMojaMjesta.Location = new System.Drawing.Point(4, 22);
            this.tabMojaMjesta.Name = "tabMojaMjesta";
            this.tabMojaMjesta.Padding = new System.Windows.Forms.Padding(3);
            this.tabMojaMjesta.Size = new System.Drawing.Size(768, 400);
            this.tabMojaMjesta.TabIndex = 1;
            this.tabMojaMjesta.Text = "Moja mjesta";
            this.tabMojaMjesta.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMojaMjesta
            // 
            this.dataGridViewMojaMjesta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMojaMjesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMojaMjesta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Type,
            this.City});
            this.dataGridViewMojaMjesta.Location = new System.Drawing.Point(46, 6);
            this.dataGridViewMojaMjesta.Name = "dataGridViewMojaMjesta";
            this.dataGridViewMojaMjesta.Size = new System.Drawing.Size(672, 388);
            this.dataGridViewMojaMjesta.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // FormPlaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Text = "FormPlaces";
            this.tabControl.ResumeLayout(false);
            this.Pretraga.ResumeLayout(false);
            this.Pretraga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPretragaMjesta)).EndInit();
            this.tabMojaMjesta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMojaMjesta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Pretraga;
        private System.Windows.Forms.Button buttonPretragaMjesta;
        private System.Windows.Forms.ComboBox comboBoxTipovi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.ComboBox comboBoxGradovi;
        private System.Windows.Forms.TabPage tabMojaMjesta;
        private System.Windows.Forms.DataGridView dataGridViewMojaMjesta;
        private System.Windows.Forms.DataGridView dataGridViewPretragaMjesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
    }
}


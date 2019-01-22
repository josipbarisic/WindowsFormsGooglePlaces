using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormPlaceDeleted : Form
    {
        public FormPlaceDeleted()
        {
            InitializeComponent();
        }

        private void buttonPlaceDeletedUredu_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                f.Hide();
            }

            FormPlaces mainForm = new FormPlaces();
            mainForm.Show();

            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class FormAddPlace : Form
    {
        GooglePlace oPlace;

        GooglePlaceRepository _placesRepo = new GooglePlaceRepository();
        public FormAddPlace(GooglePlace place)
        {
            InitializeComponent();
            oPlace = place;
        }

        private void buttonConfirmAdd_Click(object sender, EventArgs e)
        {
            _placesRepo.AddPlace(oPlace);

            FormAdded addedFormMsg = new FormAdded();
            addedFormMsg.Show();

            this.Close();
        }

        private void buttonCancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

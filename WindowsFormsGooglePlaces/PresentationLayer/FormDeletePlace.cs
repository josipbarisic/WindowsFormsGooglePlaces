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
    public partial class FormDeletePlace : Form
    {
        public GooglePlaceRepository _placesRepository = new GooglePlaceRepository();

        string sPlaceId;
        public FormDeletePlace(string place)
        {
            sPlaceId = place;
            InitializeComponent();
        }

        private void buttonConfirmPlaceDelete_Click(object sender, EventArgs e)
        {
            _placesRepository.DeletePlace(sPlaceId);
            
            FormPlaceDeleted placeDeletedMsg = new FormPlaceDeleted();
            placeDeletedMsg.Show();

            this.Close();

        }

        private void buttonCancelDelete_Click(object sender, EventArgs e)
        {
            /*FormPlaces mainForm = new FormPlaces();
            mainForm.Show();*/

            this.Close();
        }
    }
}

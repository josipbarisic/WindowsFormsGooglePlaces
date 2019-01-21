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

        string sConfirmDelete;

        string sPlaceName;
        public FormDeletePlace(string place)
        {
            sPlaceName = place;
            InitializeComponent();
        }

        private void buttonConfirmPlaceDelete_Click(object sender, EventArgs e)
        {
            _placesRepository.DeletePlace(sPlaceName);

            sConfirmDelete = "true";
            this.Close();
        }

        private void buttonCancelDelete_Click(object sender, EventArgs e)
        {
            sConfirmDelete = "false";
            this.Close();
        }

        public string Confirmation()
        {
            return sConfirmDelete;
        }
    }
}

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
    public partial class FormPlaces : Form
    {
        private GooglePlaceRepository _placesRepository = new GooglePlaceRepository();
        public BindingSource _tableBindingSource = new BindingSource();
        public FormPlaces()
        {
            InitializeComponent();
            _tableBindingSource.DataSource = _placesRepository.GetPlaces();
            dataGridViewPlaces.DataSource = _tableBindingSource;
        }
    }
}

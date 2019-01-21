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
    public partial class FormSearchedPlaces : Form
    {
        public BindingSource _tableBindingSourceSearchedPlaces = new BindingSource();
        public GooglePlaceRepository _placeRepo = new GooglePlaceRepository();

        string sGrad;
        string sTip;
        public FormSearchedPlaces(string grad, string tip, string label)
        {
            InitializeComponent();

            typeCityLabel.Text = label;

            sGrad = grad;
            sTip = tip;

            dataGridViewSearchedPlaces.AutoGenerateColumns = false;

            _tableBindingSourceSearchedPlaces.DataSource = _placeRepo.GetCityPlaces(grad, tip);
            dataGridViewSearchedPlaces.DataSource = _tableBindingSourceSearchedPlaces;

            DataGridViewButtonColumn oAddPlaceButton = new DataGridViewButtonColumn();
            oAddPlaceButton.Text = "Dodaj mjesto";
            oAddPlaceButton.UseColumnTextForButtonValue = true;
            oAddPlaceButton.Width = 100;
            oAddPlaceButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewSearchedPlaces.Columns.Add(oAddPlaceButton);
        }

        private void dataGridViewSearchedPlaces_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSearchedPlaces.CurrentCell.ColumnIndex.Equals(1) && e.RowIndex != -1)
            {
                //add place
            }
        }
    }
}

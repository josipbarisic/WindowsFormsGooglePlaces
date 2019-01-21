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
        public List<GooglePlace> _searchedPlaces = new List<GooglePlace>();
        public FormSearchedPlaces(string grad, string tip, string label)
        {
            InitializeComponent();

            typeCityLabel.Text = label;

            sGrad = grad;
            sTip = tip;

            dataGridViewSearchedPlaces.AutoGenerateColumns = false;

            _searchedPlaces = _placeRepo.GetCityPlaces(grad, tip);

            _tableBindingSourceSearchedPlaces.DataSource = _searchedPlaces;
            dataGridViewSearchedPlaces.DataSource = _tableBindingSourceSearchedPlaces;

            DataGridViewButtonColumn oAddPlaceButton = new DataGridViewButtonColumn();
            oAddPlaceButton.Text = "Dodaj mjesto";
            oAddPlaceButton.UseColumnTextForButtonValue = true;
            oAddPlaceButton.Width = 100;
            oAddPlaceButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewSearchedPlaces.Columns.Add(oAddPlaceButton);
        }
        
        //DODAJ MJESTO U MOJA MJESTA
        private void dataGridViewSearchedPlaces_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSearchedPlaces.CurrentCell.ColumnIndex.Equals(1) && e.RowIndex != -1)
            {
                var rowPlaceName = Convert.ToString(dataGridViewSearchedPlaces.Rows[e.RowIndex].Cells[0].Value);

                foreach(var place in _searchedPlaces)
                {
                    if(place.Name == rowPlaceName)
                    {
                        _placeRepo.AddPlace(place);
                    }
                }
            }
        }

    }
}

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
        
        public List<City> lCities;
        private CityRepository _citiesRepository = new CityRepository();

        private GooglePlaceRepository _placesRepository = new GooglePlaceRepository();

        public List<GooglePlace> _myPlaces = new List<GooglePlace>();

        public List<DataAccessLayer.Type> lTypes;
        private TypeRepository _typeRepository = new TypeRepository();

        
        public BindingSource _tableBindingSourcePlaces = new BindingSource();
        public BindingSource _tableBindingSourceSearchedPlaces = new BindingSource();

        public FormPlaces()
        {
            InitializeComponent();

            dataGridViewMojaMjesta.AutoGenerateColumns = false;

            _myPlaces = _placesRepository.GetPlaces();

            //Popuni moja mjesta
            _tableBindingSourcePlaces.DataSource = _myPlaces;
            dataGridViewMojaMjesta.DataSource = _tableBindingSourcePlaces;
            
            DataGridViewImageColumn oShowPlaceButton = new DataGridViewImageColumn();
            oShowPlaceButton.Image = Image.FromFile("Resources/GoogleMap.ico");
            oShowPlaceButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMojaMjesta.Columns.Add(oShowPlaceButton);


            DataGridViewButtonColumn oDeletePlaceButton = new DataGridViewButtonColumn();
            oDeletePlaceButton.Text = "Obrisi mjesto";
            oDeletePlaceButton.UseColumnTextForButtonValue = true;
            oDeletePlaceButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewMojaMjesta.Columns.Add(oDeletePlaceButton);
            


            //Dohvati gradove u comboBoxGradovi
            lCities = _citiesRepository.GetCities();
            List<String> lGradovi = lCities.Select(x => x.Name).ToList();
            comboBoxGradovi.DataSource = lGradovi;

            //Dohvati tipove u comboBoxTipovi
            lTypes = _typeRepository.GetAllTypes();
            List<String> lTipovi = lTypes.Select(x => x.sTypeView).ToList();
            comboBoxTipovi.DataSource = lTipovi;

            //Prikazi moja mjesta tab pri pokretanju forme
            tabControl.SelectedTab = tabMojaMjesta;
        }

        private void buttonPretragaMjesta_Click(object sender, EventArgs e)
        {
            var comboGrad = comboBoxGradovi.Text.ToString();
            var comboTip = comboBoxTipovi.Text.ToString();

            var gradLabel = _placesRepository.SearchedCity(comboGrad);
            
            var labelText = comboTip + " u " + gradLabel;
            FormSearchedPlaces formPretraga = new FormSearchedPlaces(comboGrad, comboTip, labelText);
            formPretraga.Show();

            this.Hide();
        }

        private void dataGridViewMojaMjesta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Button mjesto na karti
            if (dataGridViewMojaMjesta.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                var rowPlaceId = Convert.ToString(dataGridViewMojaMjesta.Rows[e.RowIndex].Cells[3].Value);

                foreach (var place in _myPlaces)
                {
                    if (place.Id == rowPlaceId)
                    {

                        FormGoogleMapPlaceLocation formMap = new FormGoogleMapPlaceLocation(place.Name, (double)place.Lat, (double)place.Lng);
                        formMap.Show();
                    }
                }
            }
            //Button obrisi mjesto
            if (dataGridViewMojaMjesta.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                var rowPlaceId = Convert.ToString(dataGridViewMojaMjesta.Rows[e.RowIndex].Cells[3].Value);

                foreach (var place in _myPlaces)
                {
                    if (place.Id == rowPlaceId)
                    {

                        FormDeletePlace deletePlaceForma = new FormDeletePlace(rowPlaceId);
                        deletePlaceForma.Show();
                    }
                }
            }
        }

    }
}

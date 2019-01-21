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

        public List<GooglePlace> _placeRepo;

        public List<DataAccessLayer.Type> lTypes;
        private TypeRepository _typeRepository = new TypeRepository();

        
        public BindingSource _tableBindingSourcePlaces = new BindingSource();
        public BindingSource _tableBindingSourceSearchedPlaces = new BindingSource();

        public FormPlaces()
        {
            InitializeComponent();

            dataGridViewMojaMjesta.AutoGenerateColumns = false;

            //Popuni moja mjesta
            _tableBindingSourcePlaces.DataSource = _placesRepository.GetPlaces();
            dataGridViewMojaMjesta.DataSource = _tableBindingSourcePlaces;

            //Dohvati gradove u comboBoxGradovi
            lCities = _citiesRepository.GetCities();
            List<String> lGradovi = lCities.Select(x => x.Name).ToList();
            comboBoxGradovi.DataSource = lGradovi;

            //Dohvati tipove u comboBoxTipovi
            lTypes = _typeRepository.GetAllTypes();
            List<String> lTipovi = lTypes.Select(x => x.sTypeView).ToList();
            comboBoxTipovi.DataSource = lTipovi;
            
        }

        private void buttonPretragaMjesta_Click(object sender, EventArgs e)
        {
            var comboGrad = comboBoxGradovi.Text.ToString();
            var comboTip = comboBoxTipovi.Text.ToString();

            var gradLabel = _placesRepository.SearchedCity(comboGrad);
            
            var labelText = comboTip + " u " + gradLabel;
            FormSearchedPlaces formPretraga = new FormSearchedPlaces(comboGrad, comboTip, labelText);
            formPretraga.Show();
        }
    }
}

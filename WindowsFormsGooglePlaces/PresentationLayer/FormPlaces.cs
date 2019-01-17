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
        
        public FormPlaces()
        {
            InitializeComponent();
            _tableBindingSourcePlaces.DataSource = _placesRepository.GetPlaces();
            dataGridViewMojaMjesta.DataSource = _tableBindingSourcePlaces;

            //dohvati gradove u comboBoxGradovi
            lCities = _citiesRepository.GetCities();
            List<String> lGradovi = lCities.Select(x => x.Name).ToList();
            comboBoxGradovi.DataSource = lGradovi;

            //dohvati tipove u comboBoxTipovi
            lTypes = _typeRepository.GetAllTypes();
            List<String> lTipovi = lTypes.Select(x => x.sTypeView).ToList();
            comboBoxTipovi.DataSource = lTipovi;

            //dohvati moja mjesta iz bp
            _placeRepo = _placesRepository.GetPlaces();
        }
    }
}

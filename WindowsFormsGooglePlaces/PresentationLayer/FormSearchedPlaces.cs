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

            DataGridViewImageColumn oShowPlaceButton = new DataGridViewImageColumn();
            oShowPlaceButton.Image = Image.FromFile("Resources/GoogleMap.ico");
            oShowPlaceButton.Width = 50;
            oShowPlaceButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewSearchedPlaces.Columns.Add(oShowPlaceButton);

            DataGridViewButtonColumn oAddPlaceButton = new DataGridViewButtonColumn();
            oAddPlaceButton.Text = "Dodaj mjesto";
            oAddPlaceButton.UseColumnTextForButtonValue = true;
            oAddPlaceButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewSearchedPlaces.Columns.Add(oAddPlaceButton);
        }
        
        private void dataGridViewSearchedPlaces_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Button mjesto na karti
            if (dataGridViewSearchedPlaces.CurrentCell.ColumnIndex.Equals(2) && e.RowIndex != -1)
            {
                var rowPlaceId = Convert.ToString(dataGridViewSearchedPlaces.Rows[e.RowIndex].Cells[1].Value);

                foreach(var place in _searchedPlaces)
                {
                    if(place.Id == rowPlaceId)
                    {
                        FormGoogleMapPlaceLocation formMap = new FormGoogleMapPlaceLocation(place.Name, (double)place.Lat, (double)place.Lng);
                        formMap.Show();
                    }
                }
            }

            //Button dodaj mjesto
            if (dataGridViewSearchedPlaces.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                var rowPlaceId = Convert.ToString(dataGridViewSearchedPlaces.Rows[e.RowIndex].Cells[1].Value);

                foreach (var place in _searchedPlaces)
                {
                    if (place.Id == rowPlaceId)
                    {
                        FormAddPlace addPlaceForm = new FormAddPlace(place);
                        addPlaceForm.Show();

                        foreach (var mjesto in _placeRepo.GetPlaces())
                        {
                            if (rowPlaceId == mjesto.Id)
                            {
                                addPlaceForm.Close();
                                FormAlreadyAdded alreadyAddedForm = new FormAlreadyAdded();
                                alreadyAddedForm.Show();
                            }
                        }

                    }
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormPlaces mainForm = new FormPlaces();
            mainForm.Show();
            this.Close();
        }
    }
}

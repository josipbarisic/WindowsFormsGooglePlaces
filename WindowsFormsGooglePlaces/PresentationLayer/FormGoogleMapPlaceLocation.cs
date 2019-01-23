using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormGoogleMapPlaceLocation : Form
    {
        public FormGoogleMapPlaceLocation(string placeName, double lat, double lng)
        {
            InitializeComponent();

            this.labelMjesto.Text = placeName;
            webBrowserGoogleMap.Navigate("https://www.google.com/maps/?q=" + lat + "," + lng);
        }
    }
}

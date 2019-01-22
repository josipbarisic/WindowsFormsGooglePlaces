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
    public partial class FormAdded : Form
    {
        public FormAdded()
        {
            InitializeComponent();
        }

        private void buttonAddedUredu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

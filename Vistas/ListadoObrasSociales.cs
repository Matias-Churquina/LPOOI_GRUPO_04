using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase.Service;

namespace Vistas
{
    public partial class ListadoObrasSociales : Form
    {
        public ListadoObrasSociales()
        {
            InitializeComponent();
        }

        private void ListadoObrasSociales_Load(object sender, EventArgs e)
        {
            load_obrasSociales();
        }

        private void load_obrasSociales()
        {
            dgwObrasSociales.DataSource = ObraSocialService.list_ObrasSocialesTodo();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veterinaria
{
    public partial class mascota : Form
    {
        public mascota()
        {
            InitializeComponent();
        }

        private void mascotasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mascotasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.veterinariaDataSet);

        }

        private void mascota_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinariaDataSet.mascotas' Puede moverla o quitarla según sea necesario.
            this.mascotasTableAdapter.Fill(this.veterinariaDataSet.mascotas);

        }
    }
}

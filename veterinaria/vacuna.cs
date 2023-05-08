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
    public partial class vacuna : Form
    {
        public vacuna()
        {
            InitializeComponent();
        }

        private void vacunasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vacunasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.veterinariaDataSet);

        }

        private void vacuna_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinariaDataSet.vacunas' Puede moverla o quitarla según sea necesario.
            this.vacunasTableAdapter.Fill(this.veterinariaDataSet.vacunas);

        }
    }
}

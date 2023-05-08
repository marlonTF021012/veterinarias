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
    public partial class desp : Form
    {
        public desp()
        {
            InitializeComponent();
        }

        private void desparacitacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.desparacitacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.veterinariaDataSet);

        }

        private void desp_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinariaDataSet.Desparacitacion' Puede moverla o quitarla según sea necesario.
            this.desparacitacionTableAdapter.Fill(this.veterinariaDataSet.Desparacitacion);

        }
    }
}

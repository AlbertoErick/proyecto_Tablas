using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class Inventarios : Form
    {
        public Inventarios()
        {
            InitializeComponent();
        }

        private void inventariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);

        }

        private void Inventarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'postgresDataSet.inventarios' table. You can move, or remove it, as needed.
            this.inventariosTableAdapter.Fill(this.postgresDataSet.inventarios);

        }
    }
}

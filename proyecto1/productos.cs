﻿using System;
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
    public partial class productos : Form
    {
        public productos()
        {
            InitializeComponent();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);

        }

        private void productos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'postgresDataSet.productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter.Fill(this.postgresDataSet.productos);

        }
    }
}

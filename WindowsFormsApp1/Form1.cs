using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nORTHWINDDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'nORTHWINDDataSet.Products_Det' Puede moverla o quitarla según sea necesario.
            this.products_DetTableAdapter.Fill(this.nORTHWINDDataSet.Products_Det);
            // TODO: esta línea de código carga datos en la tabla 'nORTHWINDDataSet.Orders_Products' Puede moverla o quitarla según sea necesario.
            this.orders_ProductsTableAdapter.Fill(this.nORTHWINDDataSet.Orders_Products);
            // TODO: esta línea de código carga datos en la tabla 'nORTHWINDDataSet.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.nORTHWINDDataSet.Customers);

        }
    }
}

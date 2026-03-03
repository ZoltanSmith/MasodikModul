using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgyediKomponensek
{
    public partial class ADGVTestForm : Form
    {
        public ADGVTestForm()
        {
            InitializeComponent();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Value", typeof(double));
            dataTable.Columns.Add("Bool", typeof(bool));
            dataTable.Rows.Add(1, "Item 1", 10.5, true);
            dataTable.Rows.Add(2, "Item 2", 20.0, false);
            dataTable.Rows.Add(3, "Item 3", 15.75, true);
            advancedDataGridView1.DataSource = dataTable;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTCI
{
    public partial class FormMain : Form
    {
        public FormMain() => InitializeComponent();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView3.Rows.Add(comboBox1.Text);
        }
    }
}

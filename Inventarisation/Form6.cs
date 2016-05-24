using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventarisation
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mybaseDataSet.chkdate". При необходимости она может быть перемещена или удалена.
            this.chkdateTableAdapter.Fill(this.mybaseDataSet.chkdate,Form2.curint);
            this.Text = "История проверок объекта №" + Convert.ToString(Form2.curint);

        }
    }
}

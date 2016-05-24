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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mybaseDataSet.perem". При необходимости она может быть перемещена или удалена.
            this.peremTableAdapter.Fill(this.mybaseDataSet.perem, Form2.curint);
            this.Text = "История перемещений объекта №" + Convert.ToString(Form2.curint);

        }
    }
}

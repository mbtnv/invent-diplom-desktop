using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventarisation
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static DateTime data;
        int actind;
        string dact;
        
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mybaseDataSet.doc". При необходимости она может быть перемещена или удалена.
            this.docTableAdapter.Fill(this.mybaseDataSet.doc);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mybaseDataSet.user". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.mybaseDataSet.user);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mybaseDataSet.kabinet". При необходимости она может быть перемещена или удалена.
            this.kabinetTableAdapter.Fill(this.mybaseDataSet.kabinet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mybaseDataSet.mark". При необходимости она может быть перемещена или удалена.
            this.markTableAdapter.Fill(this.mybaseDataSet.mark);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mybaseDataSet.type". При необходимости она может быть перемещена или удалена.
            this.typeTableAdapter.Fill(this.mybaseDataSet.type);
            actind = Convert.ToInt32(actBox.SelectedValue);
            dact = Convert.ToString(this.docTableAdapter.ScalarQuery(actind));
            label1.Text = "от " + dact.Substring(0, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ty, pr, ka, ma, ak, inv, ei, st, sr, no;
            string op, sn, na;
            bool parseOK = Int32.TryParse(typeBox.SelectedValue.ToString(), out ty);
            bool parseOK1 = Int32.TryParse(proizvBox.SelectedValue.ToString(), out pr);
            bool parseOK2 = Int32.TryParse(kabBox.SelectedValue.ToString(), out ka);
            bool parseOK3 = Int32.TryParse(fioBox.SelectedValue.ToString(), out ma);
            bool parseOK4 = Int32.TryParse(actBox.SelectedValue.ToString(), out ak);
            inv = Convert.ToInt32(invnBox.Text);
            ei = Convert.ToInt32(einBox.Text);
            st = Convert.ToInt32(stoimBox.Text);
            sr = Convert.ToInt32(srokBox.Text);
            no = Convert.ToInt32(groupBox.Text);
            op = opisBox.Text;
            sn = snBox.Text;
            na = nazBox.Text;
            deviceTableAdapter.InsertQuery(inv,sn,ei,ty,pr,op,ma,ka,Convert.ToDateTime(dateTimePicker1.Value),st,sr,no,na,ak);
            this.Close();
        }

        private void actBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void actBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            actind = Convert.ToInt32(actBox.SelectedValue);
            dact = Convert.ToString(this.docTableAdapter.ScalarQuery(actind));
            label1.Text = "от " + dact.Substring(0, 10);
        }
    }
}

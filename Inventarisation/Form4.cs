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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int invn = Form2.curint;
        int actind;
        string dact;

        private void Form4_Load(object sender, EventArgs e)
        {
            int invn = Form2.curint;
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
            typeBox.SelectedIndex = Convert.ToInt32(deviceTableAdapter.GetType(invn))-1;
            proizvBox.SelectedIndex = Convert.ToInt32(deviceTableAdapter.GetMarka(invn))-1;
            kabBox.SelectedIndex = Convert.ToInt32(deviceTableAdapter.GetKab(invn)) - 1;
            fioBox.SelectedIndex = Convert.ToInt32(deviceTableAdapter.GetFio(invn)) - 1;
            actBox.SelectedIndex = Convert.ToInt32(deviceTableAdapter.GetAct(invn)) - 1;
            actind = Convert.ToInt32(actBox.SelectedValue);
            dact = Convert.ToString(this.docTableAdapter.ScalarQuery(actind));
            label1.Text = "от " + dact.Substring(0, 10);
            snBox.Text = this.deviceTableAdapter.GetSn(invn);
            invnBox.Text = Convert.ToString(invn);
            invnBox.ReadOnly = true;
            einBox.Text = Convert.ToString(this.deviceTableAdapter.GetEin(invn));
            opisBox.Text = this.deviceTableAdapter.GetOpis(invn);
            stoimBox.Text = Convert.ToString(this.deviceTableAdapter.GetStoim(invn));
            nazBox.Text = this.deviceTableAdapter.GetNazn(invn);
            srokBox.Text = Convert.ToString(this.deviceTableAdapter.GetSrok(invn));
            groupBox.Text = Convert.ToString(this.deviceTableAdapter.GetNomerGr(invn));
            dateTimePicker1.Value = Convert.ToDateTime(deviceTableAdapter.GetIzgot(invn));

        }

        private void actBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            deviceTableAdapter.UpdateQuery(sn, ei, ty, pr, op, ka, ma, Convert.ToDateTime(dateTimePicker1.Value), st, sr, no, na, ak,invn);
            this.Close();
        }
    }
}

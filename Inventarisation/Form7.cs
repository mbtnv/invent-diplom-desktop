using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Inventarisation
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        int invn = Form2.curint;


        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mybaseDataSet1.user". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.mybaseDataSet1.user);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mybaseDataSet.kabinet". При необходимости она может быть перемещена или удалена.
            this.kabinetTableAdapter.Fill(this.mybaseDataSet.kabinet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mybaseDataSet.perem". При необходимости она может быть перемещена или удалена.
            //this.peremTableAdapter.Fill(this.mybaseDataSet.perem);
            int otdind = Convert.ToInt32(comboBox1.SelectedValue);
            string otdd = Convert.ToString(this.kabinetTableAdapter.GetOtd(otdind));
            label1.Text = otdd;
            invBox.Text = Convert.ToString(invn);
            invBox.ReadOnly = true;
            comboBox1.SelectedIndex = Convert.ToInt32(deviceTableAdapter.GetKab(invn)) - 1;
            comboBox2.SelectedIndex = Convert.ToInt32(deviceTableAdapter.GetFio(invn)) - 1;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Exl = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb;

            XlReferenceStyle RefStyle = Exl.ReferenceStyle;
            Exl.Visible = true;

            String TemplatePath = System.Windows.Forms.Application.StartupPath + @"\os2.xls";
            try
            {
                wb = Exl.Workbooks.Add(TemplatePath); // !!! 
            }
            catch (System.Exception ex)
            {
                throw new Exception("Не удалось загрузить шаблон для экспорта " + TemplatePath + "\n" + ex.Message);
            }
            Worksheet ws1 = wb.Worksheets.get_Item(1) as Worksheet;
            string data = Convert.ToString(DateTime.Today);
            string naim = Form2.cur;
            (ws1.Cells[7, 1] as Range).Value = "Межрайонная инспекция  Федеральной налоговой службы №2 по г. Чите ";
            (ws1.Cells[16, 69] as Range).Value = data.Substring(0,10);
            (ws1.Cells[16, 57] as Range).Value = nomerBox.Text;
            (ws1.Cells[24, 58] as Range).Value = invn;
            (ws1.Cells[24, 70] as Range).Value = 1;
            (ws1.Cells[24, 1] as Range).Value = 1;
            (ws1.Cells[24, 80] as Range).Value = deviceTableAdapter.GetStoim(invn);
            (ws1.Cells[24, 90] as Range).Value = deviceTableAdapter.GetStoim(invn);
            (ws1.Cells[24, 48] as Range).Value = deviceTableAdapter.GetIzgot(invn);
            (ws1.Cells[24, 5] as Range).Value = naim;
            (ws1.Cells[9, 7] as Range).Value = Form2.otd;
            (ws1.Cells[11, 9] as Range).Value = label1.Text;
            
            Exl.ReferenceStyle = RefStyle;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int otdind = Convert.ToInt32(comboBox1.SelectedValue);
            string otdd = Convert.ToString(this.kabinetTableAdapter.GetOtd(otdind));
            label1.Text = otdd;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fio,kab;
            bool parseOK = Int32.TryParse(comboBox2.SelectedValue.ToString(), out fio);
            bool parseOK1 = Int32.TryParse(comboBox1.SelectedValue.ToString(), out kab);
            deviceTableAdapter.UpdateQueryPerem(fio, kab, invn);
            peremTableAdapter.InsertQuery1(invn, Convert.ToInt32(nomerBox.Text), DateTime.Today, comboBox2.Text, label1.Text);
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label7.Text = comboBox2.Text.ToString();
        }
    }
}

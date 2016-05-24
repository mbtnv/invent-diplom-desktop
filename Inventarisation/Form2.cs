using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using STROKESCRIBECLSLib;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Inventarisation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string sotrudnik = Auth.fio;
        public static int curint;
        public static string cur,otd;


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mybaseDataSet.chkdate". При необходимости она может быть перемещена или удалена.
            //this.chkdateTableAdapter.Fill(this.mybaseDataSet.chkdate);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mybaseDataSet1.device". При необходимости она может быть перемещена или удалена.
           // this.deviceTableAdapter.Fill(this.mybaseDataSet1.device);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mybaseDataSet.device". При необходимости она может быть перемещена или удалена.
            this.deviceTableAdapter.Fill(this.mybaseDataSet.device);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //textBox1.Text = sotrudnik;
            //this.Text = this.Text+" "+sotrudnik;
            label1.Text = "Текущий пользователь: " + sotrudnik;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deviceBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //report2 report = new Report();
            //report.Design();
            report1.Design();
            

            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    if (scanmode.Checked)
                    {
                        //MessageBox.Show("123"); // тут что надо то и делаешь

                        int itemFound = deviceBindingSource.Find("invn", textBox1.Text);
                        deviceBindingSource.Position = itemFound;
                        deviceTableAdapter.UpdateQueryChk(Convert.ToInt32(textBox1.Text));
                        this.deviceTableAdapter.Fill(this.mybaseDataSet.device);
                        this.chkdateTableAdapter.InsertQuery(Convert.ToInt32(textBox1.Text), Convert.ToDateTime(DateTime.Today), sotrudnik);
                        textBox1.Text = "";
                        // textBox1.Focus();
                        //deviceBindingSource.Position = itemFound;

                    }
                    else
                    {
                        int itemFound = deviceBindingSource.Find("invn", textBox1.Text);
                        deviceBindingSource.Position = itemFound;
                        textBox1.Text = "";
                    } 
                }
            }
       

        private void button2_Click(object sender, EventArgs e)
        {
            this.deviceTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value));
            this.deviceTableAdapter.Fill(this.mybaseDataSet.device);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            //form.Show();
            form.ShowDialog();
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            this.deviceTableAdapter.Fill(this.mybaseDataSet.device);
            curint = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            cur = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value)+" "+Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value)+" "+Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            otd = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StrokeScribeClass ss = new StrokeScribeClass();

            ss.Alphabet = enumAlphabet.CODE128B;
            ss.Text = dataGridView1.CurrentRow.Cells[3].Value;
            ss.FontColor = 0x000000; //0xff0000=синий, 0x00ff00=зеленый, 0x0000ff=красный

            int width = ss.BitmapW;
            int rc = ss.SavePicture((dataGridView1.CurrentRow.Cells[3].Value) + ".bmp", enumFormats.BMP, width * 2, width);
            Form5 form = new Form5();
            form.ShowDialog();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            curint = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            cur = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value) + " " + Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value) + " " + Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            otd = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            //form.Show();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            //form.Show();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            //form.Show();
            form.ShowDialog();
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void редактироватьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void сгенерироватьБаркодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button4_Click(sender, e);
        }

        private void перемещениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button6_Click(sender, e);
        }

        private void историяПроверокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button5_Click(sender, e);
        }

        private void историяПеремещенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            //form.Show();
            form.ShowDialog();
        }

        private void иНВ1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Exl = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb;

            XlReferenceStyle RefStyle = Exl.ReferenceStyle;
            Exl.Visible = true;

            String TemplatePath = System.Windows.Forms.Application.StartupPath + @"\inv1.xls";
            try
            {
                wb = Exl.Workbooks.Add(TemplatePath); // !!! 
            }
            catch (System.Exception ex)
            {
                throw new Exception("Не удалось загрузить шаблон для экспорта " + TemplatePath + "\n" + ex.Message);
            }
            string data = Convert.ToString(DateTime.Today);
            Worksheet ws1 = wb.Worksheets.get_Item(1) as Worksheet;
            (ws1.Cells[6, 1] as Range).Value = "Межрайонная инспекция  Федеральной налоговой службы России №2 по г. Чите ";
            (ws1.Cells[8, 1] as Range).Value = "Отдел информационных технологий ";
            (ws1.Cells[18, 81] as Range).Value = data.Substring(0, 10); ;

            Worksheet ws = wb.Worksheets.get_Item(2) as Worksheet;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                (ws.Cells[10 + i, 72] as Range).Value2 = 1;
                (ws.Cells[10 + i, 86] as Range).Value2 = 1;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                (ws.Cells[10 + i, 1] as Range).Value2 = i + 1;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                object Val = dataGridView1.Rows[i].Cells[3].Value;
                if (Val != null)
                    (ws.Cells[10 + i, 51] as Range).Value2 = Val.ToString();
            }

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                object Val = dataGridView1.Rows[i].Cells[4].Value;
                if (Val != null)
                    (ws.Cells[10 + i, 58] as Range).Value2 = Val.ToString();
            }

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                object Val = dataGridView1.Rows[i].Cells[9].Value;
                if (Val != null)
                {
                    (ws.Cells[10 + i, 79] as Range).Value2 = Val.ToString();
                    (ws.Cells[10 + i, 93] as Range).Value2 = Val.ToString();
                }
            }

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                object Val = dataGridView1.Rows[i].Cells[0].Value;
                object Val1 = dataGridView1.Rows[i].Cells[1].Value;
                object Val2 = dataGridView1.Rows[i].Cells[2].Value;
                object Val3 = dataGridView1.Rows[i].Cells[10].Value;
                    (ws.Cells[10 + i, 6] as Range).Value2 = Val.ToString()+" "+Val1.ToString()+" "+Val2.ToString()+" "+Val3.ToString();
            }

        }

        private void оС6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Exl = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb;

            XlReferenceStyle RefStyle = Exl.ReferenceStyle;
            Exl.Visible = true;

            String TemplatePath = System.Windows.Forms.Application.StartupPath + @"\os6.xls";
            try
            {
                wb = Exl.Workbooks.Add(TemplatePath); // !!! 
            }
            catch (System.Exception ex)
            {
                throw new Exception("Не удалось загрузить шаблон для экспорта " + TemplatePath + "\n" + ex.Message);
            }
            string data = Convert.ToString(DateTime.Today);
            string data2 = deviceTableAdapter.ScalarQuery1(curint).ToString();
            string ac = data2.Substring(0, 10) +" №" + deviceTableAdapter.ScalarQuery(curint).ToString();
            Worksheet ws1 = wb.Worksheets.get_Item(1) as Worksheet;
            (ws1.Cells[5, 2] as Range).Value = "Межрайонная инспекция  Федеральной налоговой службы России №2 по г. Чите ";
            (ws1.Cells[6, 3] as Range).Value = "Отдел информационных технологий ";
            (ws1.Cells[23, 1] as Range).Value = "Паспорт";
            (ws1.Cells[13, 17] as Range).Value = "КРБ 1 101 34 000";
            (ws1.Cells[4, 18] as Range).Value = data.Substring(0, 10); 
            (ws1.Cells[13, 3] as Range).Value = curint;
            (ws1.Cells[7, 4] as Range).Value = cur;
            (ws1.Cells[8, 2] as Range).Value = deviceTableAdapter.GetNazn(curint);
            (ws1.Cells[13, 10] as Range).Value = deviceTableAdapter.GetNomerGr(curint);
            (ws1.Cells[13, 14] as Range).Value = Convert.ToString(deviceTableAdapter.GetSrok(curint))+" года" ;
            (ws1.Cells[9, 3] as Range).Value = dataGridView1.CurrentRow.Cells[1].Value;
            (ws1.Cells[10, 3] as Range).Value = dataGridView1.CurrentRow.Cells[6].Value;
            (ws1.Cells[11, 4] as Range).Value = dataGridView1.CurrentRow.Cells[8].Value;
            (ws1.Cells[23, 2] as Range).Value = dataGridView1.CurrentRow.Cells[4].Value;
            (ws1.Cells[23, 6] as Range).Value = deviceTableAdapter.GetIzgot(curint);
            (ws1.Cells[23, 10] as Range).Value = deviceTableAdapter.GetStoim(curint);
            (ws1.Cells[23, 8] as Range).Value = ac;

            Form8 form = new Form8();
            form.Show();
            //form.dataGridView1
            

            Worksheet ws = wb.Worksheets.get_Item(2) as Worksheet;
            (ws.Cells[8, 1] as Range).Value = deviceTableAdapter.ScalarQuery1(curint).ToString().Substring(0,10);

            for (int i = 0; i < form.dataGridView1.Rows.Count; ++i)
            {
                object Val = form.dataGridView1.Rows[i].Cells[1].Value;
                if (Val != null)
                    (ws.Cells[8 + i,4] as Range).Value2 = Val.ToString();
            }

            for (int i = 0; i < form.dataGridView1.Rows.Count; ++i)
            {
                object Val = form.dataGridView1.Rows[i].Cells[2].Value;
                if (Val != null)
                    (ws.Cells[8 + i, 3] as Range).Value2 = Val.ToString().Substring(0,10);
            }

            for (int i = 0; i < form.dataGridView1.Rows.Count; ++i)
            {
                object Val = form.dataGridView1.Rows[i].Cells[3].Value;
                if (Val != null)
                    (ws.Cells[8 + i, 10] as Range).Value2 = Val.ToString();
            }

            for (int i = 0; i < form.dataGridView1.Rows.Count; ++i)
            {
                object Val = form.dataGridView1.Rows[i].Cells[4].Value;
                if (Val != null)
                    (ws.Cells[8 + i, 8] as Range).Value2 = Val.ToString();
            }
            
           /* for (int j = 1; j < form.dataGridView1.Columns.Count; ++j)
            {
                //(ws.Cells[1, j + 1] as Range).Value2 = dataGridView1.Columns[j].HeaderText;
                for (int i = 0; i < form.dataGridView1.Rows.Count; ++i)
                {
                    object Val = form.dataGridView1.Rows[i].Cells[j].Value;
                    if (Val != null)
                        (ws.Cells[8 + i, j + 3] as Range).Value2 = Val.ToString();
                }
            }*/
            form.Hide();
            //ws.Columns.EntireColumn.AutoFit();
            //Exl.ReferenceStyle = RefStyle;
        }

        private void отчет1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report2.Show();
        }

        private void отчет2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report3.Show();
        }
    }
}

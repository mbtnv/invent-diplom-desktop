namespace Inventarisation
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.deviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mybaseDataSet = new Inventarisation.mybaseDataSet();
            this.deviceTableAdapter = new Inventarisation.mybaseDataSetTableAdapters.deviceTableAdapter();
            this.mybaseDataSet1 = new Inventarisation.mybaseDataSet();
            this.deviceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeTableAdapter = new Inventarisation.mybaseDataSetTableAdapters.typeTableAdapter();
            this.proizvBox = new System.Windows.Forms.ComboBox();
            this.markBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.markTableAdapter = new Inventarisation.mybaseDataSetTableAdapters.markTableAdapter();
            this.invnBox = new System.Windows.Forms.TextBox();
            this.snBox = new System.Windows.Forms.TextBox();
            this.einBox = new System.Windows.Forms.TextBox();
            this.opisBox = new System.Windows.Forms.TextBox();
            this.kabBox = new System.Windows.Forms.ComboBox();
            this.kabinetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kabinetTableAdapter = new Inventarisation.mybaseDataSetTableAdapters.kabinetTableAdapter();
            this.fioBox = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Inventarisation.mybaseDataSetTableAdapters.userTableAdapter();
            this.stoimBox = new System.Windows.Forms.TextBox();
            this.nazBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.srokBox = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.TextBox();
            this.actBox = new System.Windows.Forms.ComboBox();
            this.docBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docTableAdapter = new Inventarisation.mybaseDataSetTableAdapters.docTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.peremBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peremTableAdapter = new Inventarisation.mybaseDataSetTableAdapters.peremTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mybaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mybaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kabinetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peremBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceBindingSource
            // 
            this.deviceBindingSource.DataMember = "device";
            this.deviceBindingSource.DataSource = this.mybaseDataSet;
            // 
            // mybaseDataSet
            // 
            this.mybaseDataSet.DataSetName = "mybaseDataSet";
            this.mybaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deviceTableAdapter
            // 
            this.deviceTableAdapter.ClearBeforeFill = true;
            // 
            // mybaseDataSet1
            // 
            this.mybaseDataSet1.DataSetName = "mybaseDataSet";
            this.mybaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deviceBindingSource1
            // 
            this.deviceBindingSource1.DataMember = "device";
            this.deviceBindingSource1.DataSource = this.mybaseDataSet1;
            // 
            // typeBox
            // 
            this.typeBox.DataSource = this.typeBindingSource;
            this.typeBox.DisplayMember = "name";
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(162, 23);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(160, 21);
            this.typeBox.TabIndex = 0;
            this.typeBox.ValueMember = "idtype";
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "type";
            this.typeBindingSource.DataSource = this.mybaseDataSet;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // proizvBox
            // 
            this.proizvBox.DataSource = this.markBindingSource;
            this.proizvBox.DisplayMember = "marka";
            this.proizvBox.FormattingEnabled = true;
            this.proizvBox.Location = new System.Drawing.Point(162, 51);
            this.proizvBox.Name = "proizvBox";
            this.proizvBox.Size = new System.Drawing.Size(160, 21);
            this.proizvBox.TabIndex = 1;
            this.proizvBox.ValueMember = "id";
            // 
            // markBindingSource
            // 
            this.markBindingSource.DataMember = "mark";
            this.markBindingSource.DataSource = this.mybaseDataSet;
            // 
            // markTableAdapter
            // 
            this.markTableAdapter.ClearBeforeFill = true;
            // 
            // invnBox
            // 
            this.invnBox.Location = new System.Drawing.Point(162, 79);
            this.invnBox.Name = "invnBox";
            this.invnBox.Size = new System.Drawing.Size(160, 20);
            this.invnBox.TabIndex = 2;
            // 
            // snBox
            // 
            this.snBox.Location = new System.Drawing.Point(162, 106);
            this.snBox.Name = "snBox";
            this.snBox.Size = new System.Drawing.Size(160, 20);
            this.snBox.TabIndex = 3;
            // 
            // einBox
            // 
            this.einBox.Location = new System.Drawing.Point(162, 133);
            this.einBox.Name = "einBox";
            this.einBox.Size = new System.Drawing.Size(160, 20);
            this.einBox.TabIndex = 4;
            // 
            // opisBox
            // 
            this.opisBox.Location = new System.Drawing.Point(162, 160);
            this.opisBox.Name = "opisBox";
            this.opisBox.Size = new System.Drawing.Size(160, 20);
            this.opisBox.TabIndex = 5;
            // 
            // kabBox
            // 
            this.kabBox.DataSource = this.kabinetBindingSource;
            this.kabBox.DisplayMember = "kab";
            this.kabBox.FormattingEnabled = true;
            this.kabBox.Location = new System.Drawing.Point(162, 187);
            this.kabBox.Name = "kabBox";
            this.kabBox.Size = new System.Drawing.Size(160, 21);
            this.kabBox.TabIndex = 6;
            this.kabBox.ValueMember = "idkab";
            // 
            // kabinetBindingSource
            // 
            this.kabinetBindingSource.DataMember = "kabinet";
            this.kabinetBindingSource.DataSource = this.mybaseDataSet;
            // 
            // kabinetTableAdapter
            // 
            this.kabinetTableAdapter.ClearBeforeFill = true;
            // 
            // fioBox
            // 
            this.fioBox.DataSource = this.userBindingSource;
            this.fioBox.DisplayMember = "fio";
            this.fioBox.FormattingEnabled = true;
            this.fioBox.Location = new System.Drawing.Point(162, 215);
            this.fioBox.Name = "fioBox";
            this.fioBox.Size = new System.Drawing.Size(160, 21);
            this.fioBox.TabIndex = 7;
            this.fioBox.ValueMember = "iduser";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.mybaseDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // stoimBox
            // 
            this.stoimBox.Location = new System.Drawing.Point(162, 243);
            this.stoimBox.Name = "stoimBox";
            this.stoimBox.Size = new System.Drawing.Size(160, 20);
            this.stoimBox.TabIndex = 8;
            // 
            // nazBox
            // 
            this.nazBox.Location = new System.Drawing.Point(162, 270);
            this.nazBox.Name = "nazBox";
            this.nazBox.Size = new System.Drawing.Size(160, 20);
            this.nazBox.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 297);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2014, 5, 28, 21, 25, 48, 0);
            // 
            // srokBox
            // 
            this.srokBox.Location = new System.Drawing.Point(162, 324);
            this.srokBox.Name = "srokBox";
            this.srokBox.Size = new System.Drawing.Size(160, 20);
            this.srokBox.TabIndex = 11;
            // 
            // groupBox
            // 
            this.groupBox.Location = new System.Drawing.Point(162, 351);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(160, 20);
            this.groupBox.TabIndex = 12;
            // 
            // actBox
            // 
            this.actBox.DataSource = this.docBindingSource;
            this.actBox.DisplayMember = "nomer";
            this.actBox.FormattingEnabled = true;
            this.actBox.Location = new System.Drawing.Point(162, 378);
            this.actBox.Name = "actBox";
            this.actBox.Size = new System.Drawing.Size(160, 21);
            this.actBox.TabIndex = 13;
            this.actBox.ValueMember = "id";
            this.actBox.SelectedIndexChanged += new System.EventHandler(this.actBox_SelectedIndexChanged);
            this.actBox.SelectedValueChanged += new System.EventHandler(this.actBox_SelectedValueChanged);
            // 
            // docBindingSource
            // 
            this.docBindingSource.DataMember = "doc";
            this.docBindingSource.DataSource = this.mybaseDataSet;
            // 
            // docTableAdapter
            // 
            this.docTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Тип устройства";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Производитель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Инвентарный №";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Серийный №";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "ЕИН";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Описание";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Кабинет";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Мат. ответсвенное лицо";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Стоимость";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Назначение";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Дата изготовления";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 327);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Срок пол. использования";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 354);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Номер амм. группы";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 381);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Номер акта";
            // 
            // peremBindingSource
            // 
            this.peremBindingSource.DataMember = "perem";
            this.peremBindingSource.DataSource = this.mybaseDataSet;
            // 
            // peremTableAdapter
            // 
            this.peremTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 501);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.actBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.srokBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.nazBox);
            this.Controls.Add(this.stoimBox);
            this.Controls.Add(this.fioBox);
            this.Controls.Add(this.kabBox);
            this.Controls.Add(this.opisBox);
            this.Controls.Add(this.einBox);
            this.Controls.Add(this.snBox);
            this.Controls.Add(this.invnBox);
            this.Controls.Add(this.proizvBox);
            this.Controls.Add(this.typeBox);
            this.Name = "Form3";
            this.Text = "Добавление устройства";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mybaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mybaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kabinetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peremBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource deviceBindingSource;
        private mybaseDataSet mybaseDataSet;
        private mybaseDataSetTableAdapters.deviceTableAdapter deviceTableAdapter;
        private mybaseDataSet mybaseDataSet1;
        private System.Windows.Forms.BindingSource deviceBindingSource1;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private mybaseDataSetTableAdapters.typeTableAdapter typeTableAdapter;
        private System.Windows.Forms.ComboBox proizvBox;
        private System.Windows.Forms.BindingSource markBindingSource;
        private mybaseDataSetTableAdapters.markTableAdapter markTableAdapter;
        private System.Windows.Forms.TextBox invnBox;
        private System.Windows.Forms.TextBox snBox;
        private System.Windows.Forms.TextBox einBox;
        private System.Windows.Forms.TextBox opisBox;
        private System.Windows.Forms.ComboBox kabBox;
        private System.Windows.Forms.BindingSource kabinetBindingSource;
        private mybaseDataSetTableAdapters.kabinetTableAdapter kabinetTableAdapter;
        private System.Windows.Forms.ComboBox fioBox;
        private System.Windows.Forms.BindingSource userBindingSource;
        private mybaseDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.TextBox stoimBox;
        private System.Windows.Forms.TextBox nazBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox srokBox;
        private System.Windows.Forms.TextBox groupBox;
        private System.Windows.Forms.ComboBox actBox;
        private System.Windows.Forms.BindingSource docBindingSource;
        private mybaseDataSetTableAdapters.docTableAdapter docTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource peremBindingSource;
        private mybaseDataSetTableAdapters.peremTableAdapter peremTableAdapter;
    }
}
namespace Inventarisation
{
    partial class Form7
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
            this.invBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kabinetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mybaseDataSet = new Inventarisation.mybaseDataSet();
            this.peremBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peremTableAdapter = new Inventarisation.mybaseDataSetTableAdapters.peremTableAdapter();
            this.kabinetTableAdapter = new Inventarisation.mybaseDataSetTableAdapters.kabinetTableAdapter();
            this.deviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceTableAdapter = new Inventarisation.mybaseDataSetTableAdapters.deviceTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nomerBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mybaseDataSet1 = new Inventarisation.mybaseDataSet();
            this.userTableAdapter = new Inventarisation.mybaseDataSetTableAdapters.userTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kabinetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mybaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peremBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mybaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // invBox
            // 
            this.invBox.Location = new System.Drawing.Point(117, 70);
            this.invBox.Name = "invBox";
            this.invBox.Size = new System.Drawing.Size(183, 20);
            this.invBox.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.kabinetBindingSource;
            this.comboBox1.DisplayMember = "kab";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "idkab";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // kabinetBindingSource
            // 
            this.kabinetBindingSource.DataMember = "kabinet";
            this.kabinetBindingSource.DataSource = this.mybaseDataSet;
            // 
            // mybaseDataSet
            // 
            this.mybaseDataSet.DataSetName = "mybaseDataSet";
            this.mybaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // kabinetTableAdapter
            // 
            this.kabinetTableAdapter.ClearBeforeFill = true;
            // 
            // deviceBindingSource
            // 
            this.deviceBindingSource.DataMember = "device";
            this.deviceBindingSource.DataSource = this.mybaseDataSet;
            // 
            // deviceTableAdapter
            // 
            this.deviceTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сформировать накладную";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Перемещение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nomerBox
            // 
            this.nomerBox.Location = new System.Drawing.Point(117, 31);
            this.nomerBox.Name = "nomerBox";
            this.nomerBox.Size = new System.Drawing.Size(183, 20);
            this.nomerBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Номер накладной";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Инвентарный №";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Подразделение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Номер кабинета";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.userBindingSource;
            this.comboBox2.DisplayMember = "fio";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(117, 185);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(183, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.ValueMember = "iduser";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.mybaseDataSet1;
            // 
            // mybaseDataSet1
            // 
            this.mybaseDataSet1.DataSetName = "mybaseDataSet";
            this.mybaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Мат. отв. лицо";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 341);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomerBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.invBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form7";
            this.Text = "Перемещение объекта";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kabinetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mybaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peremBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mybaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox invBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private mybaseDataSet mybaseDataSet;
        private System.Windows.Forms.BindingSource peremBindingSource;
        private mybaseDataSetTableAdapters.peremTableAdapter peremTableAdapter;
        private System.Windows.Forms.BindingSource kabinetBindingSource;
        private mybaseDataSetTableAdapters.kabinetTableAdapter kabinetTableAdapter;
        private System.Windows.Forms.BindingSource deviceBindingSource;
        private mybaseDataSetTableAdapters.deviceTableAdapter deviceTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nomerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private mybaseDataSet mybaseDataSet1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private mybaseDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
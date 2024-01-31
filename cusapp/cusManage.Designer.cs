namespace cusapp
{
    partial class cusManage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textNIC = new System.Windows.Forms.TextBox();
            this.textFN = new System.Windows.Forms.TextBox();
            this.textLN = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cusidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusNicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusDobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myappdpDataSet = new cusapp.myappdpDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textType = new System.Windows.Forms.ComboBox();
            this.custableTableAdapter = new cusapp.myappdpDataSetTableAdapters.custableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myappdpDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(130, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "NIC :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tel :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "DOB :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Type";
            // 
            // textNIC
            // 
            this.textNIC.Location = new System.Drawing.Point(224, 152);
            this.textNIC.Name = "textNIC";
            this.textNIC.Size = new System.Drawing.Size(234, 26);
            this.textNIC.TabIndex = 13;
            this.textNIC.TextChanged += new System.EventHandler(this.textNIC_TextChanged);
            // 
            // textFN
            // 
            this.textFN.Location = new System.Drawing.Point(231, 208);
            this.textFN.Name = "textFN";
            this.textFN.Size = new System.Drawing.Size(224, 26);
            this.textFN.TabIndex = 14;
            // 
            // textLN
            // 
            this.textLN.Location = new System.Drawing.Point(231, 249);
            this.textLN.Name = "textLN";
            this.textLN.Size = new System.Drawing.Size(224, 26);
            this.textLN.TabIndex = 15;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(231, 288);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(224, 26);
            this.textEmail.TabIndex = 16;
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(231, 326);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(224, 26);
            this.textTel.TabIndex = 17;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(231, 406);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(68, 24);
            this.radioButtonMale.TabIndex = 18;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(308, 408);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(82, 24);
            this.radioButtonFemale.TabIndex = 19;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dateTimePicker1.Location = new System.Drawing.Point(231, 365);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 32);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add New Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 32);
            this.button2.TabIndex = 23;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(434, 520);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 32);
            this.button3.TabIndex = 24;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(546, 520);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 32);
            this.button4.TabIndex = 25;
            this.button4.Text = "Clear All";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(658, 520);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 32);
            this.button5.TabIndex = 26;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cusidDataGridViewTextBoxColumn,
            this.cusfnameDataGridViewTextBoxColumn,
            this.cusTelDataGridViewTextBoxColumn,
            this.cusGenderDataGridViewTextBoxColumn,
            this.cusLnameDataGridViewTextBoxColumn,
            this.cusEmailDataGridViewTextBoxColumn,
            this.cusTypeDataGridViewTextBoxColumn,
            this.cusNicDataGridViewTextBoxColumn,
            this.cusDobDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.custableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(581, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(661, 314);
            this.dataGridView1.TabIndex = 27;
            // 
            // cusidDataGridViewTextBoxColumn
            // 
            this.cusidDataGridViewTextBoxColumn.DataPropertyName = "cusid";
            this.cusidDataGridViewTextBoxColumn.HeaderText = "cusid";
            this.cusidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cusidDataGridViewTextBoxColumn.Name = "cusidDataGridViewTextBoxColumn";
            this.cusidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusidDataGridViewTextBoxColumn.Width = 150;
            // 
            // cusfnameDataGridViewTextBoxColumn
            // 
            this.cusfnameDataGridViewTextBoxColumn.DataPropertyName = "cusfname";
            this.cusfnameDataGridViewTextBoxColumn.HeaderText = "cusfname";
            this.cusfnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cusfnameDataGridViewTextBoxColumn.Name = "cusfnameDataGridViewTextBoxColumn";
            this.cusfnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // cusTelDataGridViewTextBoxColumn
            // 
            this.cusTelDataGridViewTextBoxColumn.DataPropertyName = "cusTel";
            this.cusTelDataGridViewTextBoxColumn.HeaderText = "cusTel";
            this.cusTelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cusTelDataGridViewTextBoxColumn.Name = "cusTelDataGridViewTextBoxColumn";
            this.cusTelDataGridViewTextBoxColumn.Width = 150;
            // 
            // cusGenderDataGridViewTextBoxColumn
            // 
            this.cusGenderDataGridViewTextBoxColumn.DataPropertyName = "cusGender";
            this.cusGenderDataGridViewTextBoxColumn.HeaderText = "cusGender";
            this.cusGenderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cusGenderDataGridViewTextBoxColumn.Name = "cusGenderDataGridViewTextBoxColumn";
            this.cusGenderDataGridViewTextBoxColumn.Width = 150;
            // 
            // cusLnameDataGridViewTextBoxColumn
            // 
            this.cusLnameDataGridViewTextBoxColumn.DataPropertyName = "cusLname";
            this.cusLnameDataGridViewTextBoxColumn.HeaderText = "cusLname";
            this.cusLnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cusLnameDataGridViewTextBoxColumn.Name = "cusLnameDataGridViewTextBoxColumn";
            this.cusLnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // cusEmailDataGridViewTextBoxColumn
            // 
            this.cusEmailDataGridViewTextBoxColumn.DataPropertyName = "cusEmail";
            this.cusEmailDataGridViewTextBoxColumn.HeaderText = "cusEmail";
            this.cusEmailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cusEmailDataGridViewTextBoxColumn.Name = "cusEmailDataGridViewTextBoxColumn";
            this.cusEmailDataGridViewTextBoxColumn.Width = 150;
            // 
            // cusTypeDataGridViewTextBoxColumn
            // 
            this.cusTypeDataGridViewTextBoxColumn.DataPropertyName = "cusType";
            this.cusTypeDataGridViewTextBoxColumn.HeaderText = "cusType";
            this.cusTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cusTypeDataGridViewTextBoxColumn.Name = "cusTypeDataGridViewTextBoxColumn";
            this.cusTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // cusNicDataGridViewTextBoxColumn
            // 
            this.cusNicDataGridViewTextBoxColumn.DataPropertyName = "cusNic";
            this.cusNicDataGridViewTextBoxColumn.HeaderText = "cusNic";
            this.cusNicDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cusNicDataGridViewTextBoxColumn.Name = "cusNicDataGridViewTextBoxColumn";
            this.cusNicDataGridViewTextBoxColumn.Width = 150;
            // 
            // cusDobDataGridViewTextBoxColumn
            // 
            this.cusDobDataGridViewTextBoxColumn.DataPropertyName = "cusDob";
            this.cusDobDataGridViewTextBoxColumn.HeaderText = "cusDob";
            this.cusDobDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cusDobDataGridViewTextBoxColumn.Name = "cusDobDataGridViewTextBoxColumn";
            this.cusDobDataGridViewTextBoxColumn.Width = 150;
            // 
            // custableBindingSource
            // 
            this.custableBindingSource.DataMember = "custable";
            this.custableBindingSource.DataSource = this.myappdpDataSet;
            // 
            // myappdpDataSet
            // 
            this.myappdpDataSet.DataSetName = "myappdpDataSet";
            this.myappdpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Location = new System.Drawing.Point(70, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 69);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By NIC";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(392, 25);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(78, 32);
            this.button6.TabIndex = 29;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textType
            // 
            this.textType.FormattingEnabled = true;
            this.textType.Items.AddRange(new object[] {
            "Golden Customer",
            "Silver Customer",
            "Platinum Customer"});
            this.textType.Location = new System.Drawing.Point(224, 438);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(317, 28);
            this.textType.TabIndex = 29;
            // 
            // custableTableAdapter
            // 
            this.custableTableAdapter.ClearBeforeFill = true;
            // 
            // cusManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1274, 581);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textLN);
            this.Controls.Add(this.textFN);
            this.Controls.Add(this.textNIC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "cusManage";
            this.Text = "Customer Registration";
            this.Load += new System.EventHandler(this.cusManage_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myappdpDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textNIC;
        private System.Windows.Forms.TextBox textFN;
        private System.Windows.Forms.TextBox textLN;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox textType;
        private myappdpDataSet myappdpDataSet;
        private System.Windows.Forms.BindingSource custableBindingSource;
        private myappdpDataSetTableAdapters.custableTableAdapter custableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusNicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusDobDataGridViewTextBoxColumn;
    }
}
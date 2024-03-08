namespace курсовая_работа_Дзякун
{
    partial class Frmsotr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmsotr));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browserBtn = new System.Windows.Forms.Button();
            this.nomTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.Label();
            this.OtchTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IMTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.faTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.курсовая_работаDataSet1 = new курсовая_работа_Дзякун.курсовая_работаDataSet1();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnotchet = new System.Windows.Forms.Button();
            this.btngraf = new System.Windows.Forms.Button();
            this.btnsotr = new System.Windows.Forms.Button();
            this.btnyslyga = new System.Windows.Forms.Button();
            this.btnzakaz = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.сотрудникиTableAdapter = new курсовая_работа_Дзякун.курсовая_работаDataSetTableAdapters.СотрудникиTableAdapter();
            this.сотрудникиTableAdapter1 = new курсовая_работа_Дзякун.курсовая_работаDataSet1TableAdapters.СотрудникиTableAdapter();
            this.idсотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотоDataGridViewImageBoxColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.курсовая_работаDataSet2 = new курсовая_работа_Дзякун.курсовая_работаDataSet2();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникTableAdapter = new курсовая_работа_Дзякун.курсовая_работаDataSet2TableAdapters.СотрудникTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсовая_работаDataSet1)).BeginInit();
            this.panelTitlebar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.курсовая_работаDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.panelTitlebar);
            this.panel1.Location = new System.Drawing.Point(187, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 483);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.browserBtn);
            this.panel2.Controls.Add(this.nomTb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pic1);
            this.panel2.Controls.Add(this.OtchTb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.IMTb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.faTb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.deletebtn);
            this.panel2.Controls.Add(this.updatebtn);
            this.panel2.Controls.Add(this.addbtn);
            this.panel2.Location = new System.Drawing.Point(6, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 139);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::курсовая_работа_Дзякун.Properties.Resources.free_icon_profile_3106921;
            this.pictureBox1.Location = new System.Drawing.Point(441, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // browserBtn
            // 
            this.browserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browserBtn.Location = new System.Drawing.Point(431, 113);
            this.browserBtn.Name = "browserBtn";
            this.browserBtn.Size = new System.Drawing.Size(100, 23);
            this.browserBtn.TabIndex = 24;
            this.browserBtn.Text = "Добавить";
            this.browserBtn.UseVisualStyleBackColor = true;
            this.browserBtn.Click += new System.EventHandler(this.browserBtn_Click);
            // 
            // nomTb
            // 
            this.nomTb.Location = new System.Drawing.Point(38, 63);
            this.nomTb.Name = "nomTb";
            this.nomTb.Size = new System.Drawing.Size(53, 22);
            this.nomTb.TabIndex = 22;
            this.nomTb.TextChanged += new System.EventHandler(this.nomTb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "id_сотр";
            // 
            // pic1
            // 
            this.pic1.AutoSize = true;
            this.pic1.Location = new System.Drawing.Point(458, 9);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(41, 16);
            this.pic1.TabIndex = 20;
            this.pic1.Text = "Фото";
            // 
            // OtchTb
            // 
            this.OtchTb.Location = new System.Drawing.Point(309, 64);
            this.OtchTb.Name = "OtchTb";
            this.OtchTb.Size = new System.Drawing.Size(100, 22);
            this.OtchTb.TabIndex = 19;
            this.OtchTb.TextChanged += new System.EventHandler(this.OtchTb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Отчество";
            // 
            // IMTb
            // 
            this.IMTb.Location = new System.Drawing.Point(203, 64);
            this.IMTb.Name = "IMTb";
            this.IMTb.Size = new System.Drawing.Size(100, 22);
            this.IMTb.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Имя";
            // 
            // faTb
            // 
            this.faTb.Location = new System.Drawing.Point(97, 64);
            this.faTb.Name = "faTb";
            this.faTb.Size = new System.Drawing.Size(100, 22);
            this.faTb.TabIndex = 15;
            this.faTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Фамилия";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(591, 100);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(100, 23);
            this.deletebtn.TabIndex = 11;
            this.deletebtn.Text = "Удалить";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click_1);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(591, 63);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(100, 23);
            this.updatebtn.TabIndex = 10;
            this.updatebtn.Text = "Изменить";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click_1);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Ivory;
            this.addbtn.Location = new System.Drawing.Point(591, 24);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(100, 23);
            this.addbtn.TabIndex = 9;
            this.addbtn.Text = "Добавить";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click_1);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idсотрудникаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.фотоDataGridViewImageBoxColumn});
            this.dataGridView.DataSource = this.сотрудникBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(0, 190);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(757, 293);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.курсовая_работаDataSet1;
            // 
            // курсовая_работаDataSet1
            // 
            this.курсовая_работаDataSet1.DataSetName = "курсовая_работаDataSet1";
            this.курсовая_работаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitlebar.Controls.Add(this.lblTitle);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(0, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(760, 39);
            this.panelTitlebar.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(304, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ООО \"АБСОЛЮТ\"";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.panelMenu.Controls.Add(this.btnotchet);
            this.panelMenu.Controls.Add(this.btngraf);
            this.panelMenu.Controls.Add(this.btnsotr);
            this.panelMenu.Controls.Add(this.btnyslyga);
            this.panelMenu.Controls.Add(this.btnzakaz);
            this.panelMenu.Controls.Add(this.groupBox1);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(187, 483);
            this.panelMenu.TabIndex = 6;
            // 
            // btnotchet
            // 
            this.btnotchet.BackColor = System.Drawing.Color.SkyBlue;
            this.btnotchet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnotchet.FlatAppearance.BorderSize = 0;
            this.btnotchet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnotchet.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnotchet.ForeColor = System.Drawing.Color.Navy;
            this.btnotchet.Image = global::курсовая_работа_Дзякун.Properties.Resources.отчет1;
            this.btnotchet.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnotchet.Location = new System.Drawing.Point(0, 251);
            this.btnotchet.Name = "btnotchet";
            this.btnotchet.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnotchet.Size = new System.Drawing.Size(187, 53);
            this.btnotchet.TabIndex = 10;
            this.btnotchet.Text = "  Отчет";
            this.btnotchet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnotchet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnotchet.UseVisualStyleBackColor = false;
            this.btnotchet.Click += new System.EventHandler(this.btnotchet_Click);
            // 
            // btngraf
            // 
            this.btngraf.BackColor = System.Drawing.Color.SkyBlue;
            this.btngraf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngraf.FlatAppearance.BorderSize = 0;
            this.btngraf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngraf.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.btngraf.ForeColor = System.Drawing.Color.Navy;
            this.btngraf.Image = global::курсовая_работа_Дзякун.Properties.Resources.график;
            this.btngraf.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btngraf.Location = new System.Drawing.Point(0, 198);
            this.btngraf.Name = "btngraf";
            this.btngraf.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btngraf.Size = new System.Drawing.Size(187, 53);
            this.btngraf.TabIndex = 9;
            this.btngraf.Text = "  График";
            this.btngraf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngraf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngraf.UseVisualStyleBackColor = false;
            this.btngraf.Click += new System.EventHandler(this.btngraf_Click);
            // 
            // btnsotr
            // 
            this.btnsotr.BackColor = System.Drawing.Color.SkyBlue;
            this.btnsotr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsotr.FlatAppearance.BorderSize = 0;
            this.btnsotr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsotr.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnsotr.ForeColor = System.Drawing.Color.Navy;
            this.btnsotr.Image = global::курсовая_работа_Дзякун.Properties.Resources.сотрудник2;
            this.btnsotr.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnsotr.Location = new System.Drawing.Point(0, 145);
            this.btnsotr.Name = "btnsotr";
            this.btnsotr.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnsotr.Size = new System.Drawing.Size(187, 53);
            this.btnsotr.TabIndex = 8;
            this.btnsotr.Text = "  Сотрудник";
            this.btnsotr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsotr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsotr.UseVisualStyleBackColor = false;
            this.btnsotr.Click += new System.EventHandler(this.btnsotr_Click);
            // 
            // btnyslyga
            // 
            this.btnyslyga.BackColor = System.Drawing.Color.SkyBlue;
            this.btnyslyga.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnyslyga.FlatAppearance.BorderSize = 0;
            this.btnyslyga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyslyga.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnyslyga.ForeColor = System.Drawing.Color.Navy;
            this.btnyslyga.Image = global::курсовая_работа_Дзякун.Properties.Resources.услуга1;
            this.btnyslyga.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnyslyga.Location = new System.Drawing.Point(0, 92);
            this.btnyslyga.Name = "btnyslyga";
            this.btnyslyga.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnyslyga.Size = new System.Drawing.Size(187, 53);
            this.btnyslyga.TabIndex = 7;
            this.btnyslyga.Text = "  Услуга";
            this.btnyslyga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyslyga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnyslyga.UseVisualStyleBackColor = false;
            this.btnyslyga.Click += new System.EventHandler(this.btnyslyga_Click_1);
            // 
            // btnzakaz
            // 
            this.btnzakaz.BackColor = System.Drawing.Color.SkyBlue;
            this.btnzakaz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnzakaz.FlatAppearance.BorderSize = 0;
            this.btnzakaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnzakaz.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnzakaz.ForeColor = System.Drawing.Color.Navy;
            this.btnzakaz.Image = global::курсовая_работа_Дзякун.Properties.Resources.заказ3;
            this.btnzakaz.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnzakaz.Location = new System.Drawing.Point(0, 39);
            this.btnzakaz.Name = "btnzakaz";
            this.btnzakaz.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnzakaz.Size = new System.Drawing.Size(187, 53);
            this.btnzakaz.TabIndex = 6;
            this.btnzakaz.Text = "  Заказчик";
            this.btnzakaz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnzakaz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnzakaz.UseVisualStyleBackColor = false;
            this.btnzakaz.Click += new System.EventHandler(this.btnzakaz_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(187, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(187, 39);
            this.panelLogo.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter1
            // 
            this.сотрудникиTableAdapter1.ClearBeforeFill = true;
            // 
            // idсотрудникаDataGridViewTextBoxColumn
            // 
            this.idсотрудникаDataGridViewTextBoxColumn.DataPropertyName = "id_сотрудника";
            this.idсотрудникаDataGridViewTextBoxColumn.HeaderText = "id_сотрудника";
            this.idсотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idсотрудникаDataGridViewTextBoxColumn.Name = "idсотрудникаDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // фотоDataGridViewImageBoxColumn
            // 
            this.фотоDataGridViewImageBoxColumn.DataPropertyName = "Фото";
            this.фотоDataGridViewImageBoxColumn.HeaderText = "Фото";
            this.фотоDataGridViewImageBoxColumn.MinimumWidth = 6;
            this.фотоDataGridViewImageBoxColumn.Name = "фотоDataGridViewImageBoxColumn";
            this.фотоDataGridViewImageBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.фотоDataGridViewImageBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // курсовая_работаDataSet2
            // 
            this.курсовая_работаDataSet2.DataSetName = "курсовая_работаDataSet2";
            this.курсовая_работаDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.курсовая_работаDataSet2;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // Frmsotr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmsotr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"АБСОЛЮТ\"";
            this.Load += new System.EventHandler(this.Frmsotr_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсовая_работаDataSet1)).EndInit();
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.курсовая_работаDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnotchet;
        private System.Windows.Forms.Button btngraf;
        private System.Windows.Forms.Button btnsotr;
        private System.Windows.Forms.Button btnyslyga;
        private System.Windows.Forms.Button btnzakaz;
        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox OtchTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IMTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox faTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pic1;
        private System.Windows.Forms.TextBox nomTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button browserBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private курсовая_работаDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private курсовая_работаDataSet1 курсовая_работаDataSet1;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private курсовая_работаDataSet1TableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idсотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn фотоDataGridViewImageBoxColumn;
        private курсовая_работаDataSet2 курсовая_работаDataSet2;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private курсовая_работаDataSet2TableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
    }
}
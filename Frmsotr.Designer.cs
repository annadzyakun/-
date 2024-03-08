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
            this.btnotchet = new System.Windows.Forms.Button();
            this.btngraf = new System.Windows.Forms.Button();
            this.btnsotr = new System.Windows.Forms.Button();
            this.btnyslyga = new System.Windows.Forms.Button();
            this.btnzakaz = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OtchTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IMTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.faTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nomTb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idсотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотоDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.курсовая_работаDataSet = new курсовая_работа_Дзякун.курсовая_работаDataSet();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.сотрудникTableAdapter = new курсовая_работа_Дзякун.курсовая_работаDataSetTableAdapters.СотрудникTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсовая_работаDataSet)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelTitlebar.SuspendLayout();
            this.SuspendLayout();
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
            this.btnotchet.TabIndex = 5;
            this.btnotchet.Text = "Отчет ";
            this.btnotchet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnotchet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnotchet.UseVisualStyleBackColor = false;
            this.btnotchet.Click += new System.EventHandler(this.btnotchet_Click_1);
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
            this.btngraf.TabIndex = 4;
            this.btngraf.Text = " График ";
            this.btngraf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngraf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngraf.UseVisualStyleBackColor = false;
            this.btngraf.Click += new System.EventHandler(this.btngraf_Click_1);
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
            this.btnsotr.TabIndex = 3;
            this.btnsotr.Text = "Сотрудник ";
            this.btnsotr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsotr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsotr.UseVisualStyleBackColor = false;
            this.btnsotr.Click += new System.EventHandler(this.btnsotr_Click_1);
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
            this.btnyslyga.TabIndex = 2;
            this.btnyslyga.Text = " Услуга ";
            this.btnyslyga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnyslyga.UseVisualStyleBackColor = false;
            this.btnyslyga.Click += new System.EventHandler(this.btnyslyga_Click);
            // 
            // btnzakaz
            // 
            this.btnzakaz.BackColor = System.Drawing.Color.SkyBlue;
            this.btnzakaz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnzakaz.FlatAppearance.BorderSize = 0;
            this.btnzakaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnzakaz.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnzakaz.ForeColor = System.Drawing.Color.Navy;
            this.btnzakaz.Image = global::курсовая_работа_Дзякун.Properties.Resources.заказ3;
            this.btnzakaz.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnzakaz.Location = new System.Drawing.Point(0, 39);
            this.btnzakaz.Name = "btnzakaz";
            this.btnzakaz.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnzakaz.Size = new System.Drawing.Size(187, 53);
            this.btnzakaz.TabIndex = 1;
            this.btnzakaz.Text = " Заказчик";
            this.btnzakaz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnzakaz.UseVisualStyleBackColor = false;
            this.btnzakaz.Click += new System.EventHandler(this.btnzakaz_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.deletebtn);
            this.panel1.Controls.Add(this.updatebtn);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.OtchTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.IMTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.faTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nomTb);
            this.panel1.Location = new System.Drawing.Point(193, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 139);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::курсовая_работа_Дзякун.Properties.Resources.free_icon_profile_3106921;
            this.pictureBox1.Location = new System.Drawing.Point(478, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(627, 77);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(100, 23);
            this.deletebtn.TabIndex = 11;
            this.deletebtn.Text = "Удалить";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(627, 46);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(100, 23);
            this.updatebtn.TabIndex = 10;
            this.updatebtn.Text = "Изменить";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(627, 17);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(100, 23);
            this.addbtn.TabIndex = 9;
            this.addbtn.Text = "Добавить";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Отчество";
            // 
            // OtchTb
            // 
            this.OtchTb.Location = new System.Drawing.Point(333, 78);
            this.OtchTb.Name = "OtchTb";
            this.OtchTb.Size = new System.Drawing.Size(100, 22);
            this.OtchTb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Имя";
            // 
            // IMTB
            // 
            this.IMTB.Location = new System.Drawing.Point(227, 78);
            this.IMTB.Name = "IMTB";
            this.IMTB.Size = new System.Drawing.Size(100, 22);
            this.IMTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // faTb
            // 
            this.faTb.Location = new System.Drawing.Point(121, 77);
            this.faTb.Name = "faTb";
            this.faTb.Size = new System.Drawing.Size(100, 22);
            this.faTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "id_сотр";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nomTb
            // 
            this.nomTb.Location = new System.Drawing.Point(55, 78);
            this.nomTb.Name = "nomTb";
            this.nomTb.Size = new System.Drawing.Size(50, 22);
            this.nomTb.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idсотрудникаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.фотоDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.сотрудникBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(187, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 293);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idсотрудникаDataGridViewTextBoxColumn
            // 
            this.idсотрудникаDataGridViewTextBoxColumn.DataPropertyName = "id_сотрудника";
            this.idсотрудникаDataGridViewTextBoxColumn.HeaderText = "id_сотрудника";
            this.idсотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idсотрудникаDataGridViewTextBoxColumn.Name = "idсотрудникаDataGridViewTextBoxColumn";
            this.idсотрудникаDataGridViewTextBoxColumn.ReadOnly = true;
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
            // фотоDataGridViewImageColumn
            // 
            this.фотоDataGridViewImageColumn.DataPropertyName = "Фото";
            this.фотоDataGridViewImageColumn.HeaderText = "Фото";
            this.фотоDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.фотоDataGridViewImageColumn.MinimumWidth = 6;
            this.фотоDataGridViewImageColumn.Name = "фотоDataGridViewImageColumn";
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.курсовая_работаDataSet;
            // 
            // курсовая_работаDataSet
            // 
            this.курсовая_работаDataSet.DataSetName = "курсовая_работаDataSet";
            this.курсовая_работаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.panelMenu.Controls.Add(this.btnotchet);
            this.panelMenu.Controls.Add(this.btngraf);
            this.panelMenu.Controls.Add(this.btnsotr);
            this.panelMenu.Controls.Add(this.btnyslyga);
            this.panelMenu.Controls.Add(this.btnzakaz);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(187, 483);
            this.panelMenu.TabIndex = 4;
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
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitlebar.Controls.Add(this.lblTitle);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(187, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(761, 39);
            this.panelTitlebar.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(306, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ООО \"АБСОЛЮТ\"";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmsotr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"АБСОЛЮТ\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсовая_работаDataSet)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnotchet;
        private System.Windows.Forms.Button btngraf;
        private System.Windows.Forms.Button btnsotr;
        private System.Windows.Forms.Button btnyslyga;
        private System.Windows.Forms.Button btnzakaz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OtchTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IMTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox faTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomTb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private курсовая_работаDataSet курсовая_работаDataSet;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private курсовая_работаDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idсотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn фотоDataGridViewImageColumn;
    }
}
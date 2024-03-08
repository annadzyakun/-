namespace курсовая_работа_Дзякун
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

                    #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnotchet = new System.Windows.Forms.Button();
            this.btngraf = new System.Windows.Forms.Button();
            this.btnsotr = new System.Windows.Forms.Button();
            this.btnyslyga = new System.Windows.Forms.Button();
            this.btnzakaz = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Комментарийtb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ПлощадьTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.УслугаCb = new System.Windows.Forms.ComboBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.Дата_реализацииTb = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Номер_телефонаTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.АдресTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ФИОTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nomTb = new System.Windows.Forms.TextBox();
            this.panelMenu.SuspendLayout();
            this.panelTitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
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
            this.btngraf.TabIndex = 4;
            this.btngraf.Text = " График ";
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
            this.btnsotr.TabIndex = 3;
            this.btnsotr.Text = "Сотрудник ";
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
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(187, 39);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitlebar.Controls.Add(this.lblTitle);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(187, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(761, 39);
            this.panelTitlebar.TabIndex = 1;
            this.panelTitlebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitlebar_Paint);
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
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(187, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 293);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Комментарийtb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ПлощадьTb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.УслугаCb);
            this.panel1.Controls.Add(this.deletebtn);
            this.panel1.Controls.Add(this.updatebtn);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Controls.Add(this.Дата_реализацииTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Номер_телефонаTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.АдресTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ФИОTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nomTb);
            this.panel1.Location = new System.Drawing.Point(193, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 139);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(621, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Комментарий";
            // 
            // Комментарийtb
            // 
            this.Комментарийtb.Location = new System.Drawing.Point(624, 36);
            this.Комментарийtb.Name = "Комментарийtb";
            this.Комментарийtb.Size = new System.Drawing.Size(100, 22);
            this.Комментарийtb.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(534, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Площадь";
            // 
            // ПлощадьTb
            // 
            this.ПлощадьTb.Location = new System.Drawing.Point(518, 36);
            this.ПлощадьTb.Name = "ПлощадьTb";
            this.ПлощадьTb.Size = new System.Drawing.Size(100, 22);
            this.ПлощадьTb.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(678, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Дата";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Услуга";
            // 
            // УслугаCb
            // 
            this.УслугаCb.FormattingEnabled = true;
            this.УслугаCb.Items.AddRange(new object[] {
            "Генеральная уборка",
            "Поддерживающая уборка",
            "Мойка окон,зеркал,витражей (за одну плоскость)",
            "Окно двухстворчатое пластиковое с одной стороны ",
            "Окно двухстворчатое пластиковое с обеих сторон",
            "Окно трехстворчатое пластиковое с одной стороны",
            "Окно трехстворчатое пластиковое с обеих сторон ",
            "Мойка балкона",
            "Мойка лоджии",
            "Послеремонтная уборка",
            "Химчистка мягкой мебели(с текстильной обивкой)",
            "Химчистка коврового покрытия",
            "Химическая чистка пола"});
            this.УслугаCb.Location = new System.Drawing.Point(385, 34);
            this.УслугаCb.Name = "УслугаCb";
            this.УслугаCb.Size = new System.Drawing.Size(127, 24);
            this.УслугаCb.TabIndex = 12;
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(389, 89);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(79, 23);
            this.deletebtn.TabIndex = 11;
            this.deletebtn.Text = "Удалить";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(289, 88);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(94, 23);
            this.updatebtn.TabIndex = 10;
            this.updatebtn.Text = "Изменить";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(173, 88);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(100, 23);
            this.addbtn.TabIndex = 9;
            this.addbtn.Text = "Добавить";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // Дата_реализацииTb
            // 
            this.Дата_реализацииTb.Location = new System.Drawing.Point(580, 89);
            this.Дата_реализацииTb.Name = "Дата_реализацииTb";
            this.Дата_реализацииTb.Size = new System.Drawing.Size(144, 22);
            this.Дата_реализацииTb.TabIndex = 8;
            this.Дата_реализацииTb.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Телефон";
            // 
            // Номер_телефонаTb
            // 
            this.Номер_телефонаTb.Location = new System.Drawing.Point(279, 36);
            this.Номер_телефонаTb.Name = "Номер_телефонаTb";
            this.Номер_телефонаTb.Size = new System.Drawing.Size(100, 22);
            this.Номер_телефонаTb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Адрес";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // АдресTB
            // 
            this.АдресTB.Location = new System.Drawing.Point(173, 36);
            this.АдресTB.Name = "АдресTB";
            this.АдресTB.Size = new System.Drawing.Size(100, 22);
            this.АдресTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ФИО";
            // 
            // ФИОTb
            // 
            this.ФИОTb.Location = new System.Drawing.Point(67, 36);
            this.ФИОTb.Name = "ФИОTb";
            this.ФИОTb.Size = new System.Drawing.Size(100, 22);
            this.ФИОTb.TabIndex = 2;
            this.ФИОTb.TextChanged += new System.EventHandler(this.ФИОTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер";
            // 
            // nomTb
            // 
            this.nomTb.Location = new System.Drawing.Point(11, 36);
            this.nomTb.Name = "nomTb";
            this.nomTb.Size = new System.Drawing.Size(50, 22);
            this.nomTb.TabIndex = 0;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(948, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"АБСОЛЮТ\"";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnzakaz;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnotchet;
        private System.Windows.Forms.Button btngraf;
        private System.Windows.Forms.Button btnsotr;
        private System.Windows.Forms.Button btnyslyga;
        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox АдресTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ФИОTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomTb;
        private System.Windows.Forms.DateTimePicker Дата_реализацииTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Номер_телефонаTb;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.ComboBox УслугаCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Комментарийtb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ПлощадьTb;
    }
}


namespace курсовая_работа_Дзякун
{
    partial class Frmotchet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmotchet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTitlebar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panelTitlebar);
            this.panel1.Location = new System.Drawing.Point(187, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 483);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnCreateReport);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(6, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 143);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "по цене:";
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Location = new System.Drawing.Point(640, 100);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(75, 23);
            this.btnCreateReport.TabIndex = 3;
            this.btnCreateReport.Text = "Печать";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "ПОИСК";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0-2000",
            "2000-10000",
            "10000-∞"});
            this.comboBox1.Location = new System.Drawing.Point(463, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "по сотруднику:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "по дате:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(743, 290);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitlebar.Controls.Add(this.lblTitle);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(0, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(765, 39);
            this.panelTitlebar.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(292, 9);
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
            this.panelMenu.TabIndex = 9;
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
            this.btnsotr.TabIndex = 8;
            this.btnsotr.Text = "  Сотрудник";
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
            // Frmotchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmotchet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"АБСОЛЮТ\"";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}
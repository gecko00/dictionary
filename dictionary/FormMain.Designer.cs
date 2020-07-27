namespace Словарик
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBoxEng = new System.Windows.Forms.ComboBox();
            this.btn_test = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxEng = new System.Windows.Forms.TextBox();
            this.textBoxRus = new System.Windows.Forms.TextBox();
            this.comboBoxRus = new System.Windows.Forms.ComboBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordEngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordRusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.definitionEngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.definitionRusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_numberOfWords = new System.Windows.Forms.Label();
            this.wordsdataGridView = new System.Windows.Forms.DataGridView();
            this.dictionaryDataSet = new DictionaryKIT.dictionaryDataSet();
            this.wordsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wordsTableTableAdapter = new DictionaryKIT.dictionaryDataSetTableAdapters.WordsTableTableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordEngDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordRusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.definitionEngDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.definitionRusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaFileDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "164746.jpg");
            this.imageList1.Images.SetKeyName(1, "ddr2-ram.jpg");
            this.imageList1.Images.SetKeyName(2, "DLink-DFE534R3-Boot-ROM_800x600.jpg");
            this.imageList1.Images.SetKeyName(3, "windows-8-desktop-clock-08-700x437.jpg");
            this.imageList1.Images.SetKeyName(4, "smazka_kulera5.jpeg");
            this.imageList1.Images.SetKeyName(5, "736276872.jpg");
            this.imageList1.Images.SetKeyName(6, "logitech-freedom-2dot4-cordless-joystick-0.jpg");
            this.imageList1.Images.SetKeyName(7, "cm7.jpg");
            this.imageList1.Images.SetKeyName(8, "firewall.png");
            this.imageList1.Images.SetKeyName(9, "images.png");
            this.imageList1.Images.SetKeyName(10, "my_computer_window.gif");
            this.imageList1.Images.SetKeyName(11, "SaveFiles.jpg");
            this.imageList1.Images.SetKeyName(12, "steel-series.jpg");
            this.imageList1.Images.SetKeyName(13, "102716265p-03-03.jpg");
            this.imageList1.Images.SetKeyName(14, "13030015p3-app icons.jpg");
            this.imageList1.Images.SetKeyName(15, "24__LED_Monitor_4ce30578e2dc8.jpg");
            this.imageList1.Images.SetKeyName(16, "be18179efb304b40a00000e02bccc1b0.jpg");
            this.imageList1.Images.SetKeyName(17, "abiword.jpg");
            this.imageList1.Images.SetKeyName(18, "420px-OpenOffice.org_Calc.png");
            this.imageList1.Images.SetKeyName(19, "optical_disc_dvd_350.jpg");
            this.imageList1.Images.SetKeyName(20, "seagate_sshd_hybrid_hdd_1.jpg");
            this.imageList1.Images.SetKeyName(21, "DSL 2640B B2.png");
            this.imageList1.Images.SetKeyName(22, "Asus_CD-ROM_drive.jpg");
            this.imageList1.Images.SetKeyName(23, "fonts-08.jpg");
            this.imageList1.Images.SetKeyName(24, "camera.png");
            this.imageList1.Images.SetKeyName(25, "application-icon-set.jpg");
            this.imageList1.Images.SetKeyName(26, "pict--computer-peripheral-devices-design-elements-computer-peripheral-devices.png" +
        " ");
            // 
            // comboBoxEng
            // 
            this.comboBoxEng.FormattingEnabled = true;
            this.comboBoxEng.Location = new System.Drawing.Point(12, 12);
            this.comboBoxEng.Name = "comboBoxEng";
            this.comboBoxEng.Size = new System.Drawing.Size(159, 21);
            this.comboBoxEng.TabIndex = 7;
            this.comboBoxEng.SelectedIndexChanged += new System.EventHandler(this.comboBoxEng_SelectedIndexChanged);
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(357, 376);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(109, 23);
            this.btn_test.TabIndex = 9;
            this.btn_test.Text = "Проверь себя";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(357, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxEng
            // 
            this.textBoxEng.Location = new System.Drawing.Point(12, 52);
            this.textBoxEng.Multiline = true;
            this.textBoxEng.Name = "textBoxEng";
            this.textBoxEng.ReadOnly = true;
            this.textBoxEng.Size = new System.Drawing.Size(159, 347);
            this.textBoxEng.TabIndex = 10;
            // 
            // textBoxRus
            // 
            this.textBoxRus.Location = new System.Drawing.Point(180, 52);
            this.textBoxRus.Multiline = true;
            this.textBoxRus.Name = "textBoxRus";
            this.textBoxRus.ReadOnly = true;
            this.textBoxRus.Size = new System.Drawing.Size(159, 347);
            this.textBoxRus.TabIndex = 11;
            // 
            // comboBoxRus
            // 
            this.comboBoxRus.FormattingEnabled = true;
            this.comboBoxRus.Location = new System.Drawing.Point(180, 12);
            this.comboBoxRus.Name = "comboBoxRus";
            this.comboBoxRus.Size = new System.Drawing.Size(159, 21);
            this.comboBoxRus.TabIndex = 12;
            this.comboBoxRus.SelectedIndexChanged += new System.EventHandler(this.comboBoxRus_SelectedIndexChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // wordEngDataGridViewTextBoxColumn
            // 
            this.wordEngDataGridViewTextBoxColumn.Name = "wordEngDataGridViewTextBoxColumn";
            // 
            // wordRusDataGridViewTextBoxColumn
            // 
            this.wordRusDataGridViewTextBoxColumn.Name = "wordRusDataGridViewTextBoxColumn";
            // 
            // definitionEngDataGridViewTextBoxColumn
            // 
            this.definitionEngDataGridViewTextBoxColumn.Name = "definitionEngDataGridViewTextBoxColumn";
            // 
            // definitionRusDataGridViewTextBoxColumn
            // 
            this.definitionRusDataGridViewTextBoxColumn.Name = "definitionRusDataGridViewTextBoxColumn";
            // 
            // mediaFileDataGridViewTextBoxColumn
            // 
            this.mediaFileDataGridViewTextBoxColumn.Name = "mediaFileDataGridViewTextBoxColumn";
            // 
            // label_numberOfWords
            // 
            this.label_numberOfWords.AutoSize = true;
            this.label_numberOfWords.Location = new System.Drawing.Point(12, 409);
            this.label_numberOfWords.Name = "label_numberOfWords";
            this.label_numberOfWords.Size = new System.Drawing.Size(74, 13);
            this.label_numberOfWords.TabIndex = 14;
            this.label_numberOfWords.Text = "Слов в базе: ";
            // 
            // wordsdataGridView
            // 
            this.wordsdataGridView.AutoGenerateColumns = false;
            this.wordsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.wordEngDataGridViewTextBoxColumn1,
            this.wordRusDataGridViewTextBoxColumn1,
            this.definitionEngDataGridViewTextBoxColumn1,
            this.definitionRusDataGridViewTextBoxColumn1,
            this.mediaFileDataGridViewTextBoxColumn1});
            this.wordsdataGridView.DataSource = this.wordsTableBindingSource;
            this.wordsdataGridView.Location = new System.Drawing.Point(345, 12);
            this.wordsdataGridView.Name = "wordsdataGridView";
            this.wordsdataGridView.Size = new System.Drawing.Size(10, 386);
            this.wordsdataGridView.TabIndex = 0;
            this.wordsdataGridView.Visible = false;
            // 
            // dictionaryDataSet
            // 
            this.dictionaryDataSet.DataSetName = "dictionaryDataSet";
            this.dictionaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wordsTableBindingSource
            // 
            this.wordsTableBindingSource.DataMember = "WordsTable";
            this.wordsTableBindingSource.DataSource = this.dictionaryDataSet;
            // 
            // wordsTableTableAdapter
            // 
            this.wordsTableTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // wordEngDataGridViewTextBoxColumn1
            // 
            this.wordEngDataGridViewTextBoxColumn1.DataPropertyName = "WordEng";
            this.wordEngDataGridViewTextBoxColumn1.HeaderText = "WordEng";
            this.wordEngDataGridViewTextBoxColumn1.Name = "wordEngDataGridViewTextBoxColumn1";
            // 
            // wordRusDataGridViewTextBoxColumn1
            // 
            this.wordRusDataGridViewTextBoxColumn1.DataPropertyName = "WordRus";
            this.wordRusDataGridViewTextBoxColumn1.HeaderText = "WordRus";
            this.wordRusDataGridViewTextBoxColumn1.Name = "wordRusDataGridViewTextBoxColumn1";
            // 
            // definitionEngDataGridViewTextBoxColumn1
            // 
            this.definitionEngDataGridViewTextBoxColumn1.DataPropertyName = "DefinitionEng";
            this.definitionEngDataGridViewTextBoxColumn1.HeaderText = "DefinitionEng";
            this.definitionEngDataGridViewTextBoxColumn1.Name = "definitionEngDataGridViewTextBoxColumn1";
            // 
            // definitionRusDataGridViewTextBoxColumn1
            // 
            this.definitionRusDataGridViewTextBoxColumn1.DataPropertyName = "DefinitionRus";
            this.definitionRusDataGridViewTextBoxColumn1.HeaderText = "DefinitionRus";
            this.definitionRusDataGridViewTextBoxColumn1.Name = "definitionRusDataGridViewTextBoxColumn1";
            // 
            // mediaFileDataGridViewTextBoxColumn1
            // 
            this.mediaFileDataGridViewTextBoxColumn1.DataPropertyName = "MediaFile";
            this.mediaFileDataGridViewTextBoxColumn1.HeaderText = "MediaFile";
            this.mediaFileDataGridViewTextBoxColumn1.Name = "mediaFileDataGridViewTextBoxColumn1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 431);
            this.Controls.Add(this.wordsdataGridView);
            this.Controls.Add(this.label_numberOfWords);
            this.Controls.Add(this.comboBoxRus);
            this.Controls.Add(this.textBoxRus);
            this.Controls.Add(this.textBoxEng);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxEng);
            this.MaximumSize = new System.Drawing.Size(730, 470);
            this.MinimumSize = new System.Drawing.Size(730, 460);
            this.Name = "FormMain";
            this.Text = "Словарь";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox comboBoxEng;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxEng;
        private System.Windows.Forms.TextBox textBoxRus;
        private System.Windows.Forms.ComboBox comboBoxRus;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordEngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordRusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn definitionEngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn definitionRusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaFileDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label_numberOfWords;
        private System.Windows.Forms.DataGridView wordsdataGridView;
        private DictionaryKIT.dictionaryDataSet dictionaryDataSet;
        private System.Windows.Forms.BindingSource wordsTableBindingSource;
        private DictionaryKIT.dictionaryDataSetTableAdapters.WordsTableTableAdapter wordsTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordEngDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordRusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn definitionEngDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn definitionRusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaFileDataGridViewTextBoxColumn1;
    }
}


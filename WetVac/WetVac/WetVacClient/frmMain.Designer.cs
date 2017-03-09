namespace WetVacClient
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.checkboxAdditonalConditions = new System.Windows.Forms.CheckBox();
            this.groupboxAdditionalConditions = new System.Windows.Forms.GroupBox();
            this.textboxPressureDecrement = new System.Windows.Forms.TextBox();
            this.labelPressureDecrement = new System.Windows.Forms.Label();
            this.textboxSystemDriveLosses = new System.Windows.Forms.TextBox();
            this.comboboxDischargeSilencerPressureDrop = new System.Windows.Forms.ComboBox();
            this.labelSystemDriveLosses = new System.Windows.Forms.Label();
            this.comboboxInletFilterPressureDrop = new System.Windows.Forms.ComboBox();
            this.labelDischargeSilenverPressureDrop = new System.Windows.Forms.Label();
            this.textboxDischargeSilencePressureDrop = new System.Windows.Forms.TextBox();
            this.labelInletFilterPressureDrop = new System.Windows.Forms.Label();
            this.textboxInletFilterPressureDrop = new System.Windows.Forms.TextBox();
            this.groupboxInletConditions = new System.Windows.Forms.GroupBox();
            this.textboxBlower1RelativeHumitity = new System.Windows.Forms.TextBox();
            this.labelBlower1RelativeHumidity = new System.Windows.Forms.Label();
            this.comboboxBlower1InletPressureUnits = new System.Windows.Forms.ComboBox();
            this.textboxBlower1InletPressure = new System.Windows.Forms.TextBox();
            this.labelBlower1InletPressure = new System.Windows.Forms.Label();
            this.comboboxBlower1InletTempUnits = new System.Windows.Forms.ComboBox();
            this.textboxBlower1InletTemp = new System.Windows.Forms.TextBox();
            this.labelBlower1InletTemp = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupboxBlower1 = new System.Windows.Forms.GroupBox();
            this.comboboxBlower1Brand = new System.Windows.Forms.ComboBox();
            this.labelBlower1Brand = new System.Windows.Forms.Label();
            this.comboboxBlower1Model = new System.Windows.Forms.ComboBox();
            this.labelBlower1Model = new System.Windows.Forms.Label();
            this.comboboxBlower1Series = new System.Windows.Forms.ComboBox();
            this.labelBlower1Series = new System.Windows.Forms.Label();
            this.textboxBlower1RPM = new System.Windows.Forms.TextBox();
            this.labelBlower1RPM = new System.Windows.Forms.Label();
            this.buttonAddBlower1 = new System.Windows.Forms.Button();
            this.groupboxBlower2 = new System.Windows.Forms.GroupBox();
            this.comboboxBlower2Brand = new System.Windows.Forms.ComboBox();
            this.comboboxBlower2Model = new System.Windows.Forms.ComboBox();
            this.labelBlower2Brand = new System.Windows.Forms.Label();
            this.labelBlower2Model = new System.Windows.Forms.Label();
            this.comboboxBlower2Series = new System.Windows.Forms.ComboBox();
            this.labelBlower2Series = new System.Windows.Forms.Label();
            this.textboxBlower2RPM = new System.Windows.Forms.TextBox();
            this.labelBlower2RPM = new System.Windows.Forms.Label();
            this.buttonAddBlower2 = new System.Windows.Forms.Button();
            this.groupboxBlower3 = new System.Windows.Forms.GroupBox();
            this.comboboxBlower3Brand = new System.Windows.Forms.ComboBox();
            this.labelBlower3Brand = new System.Windows.Forms.Label();
            this.comboboxBlower3Model = new System.Windows.Forms.ComboBox();
            this.comboboxBlower3Series = new System.Windows.Forms.ComboBox();
            this.labelBlower3Model = new System.Windows.Forms.Label();
            this.labelBlower3Series = new System.Windows.Forms.Label();
            this.textboxBlower3RPM = new System.Windows.Forms.TextBox();
            this.labelBlower3RPM = new System.Windows.Forms.Label();
            this.tabBlower1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabBlower2 = new System.Windows.Forms.TabPage();
            this.tabBlower3 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlDataSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.groupboxAdditionalConditions.SuspendLayout();
            this.groupboxInletConditions.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.groupboxBlower1.SuspendLayout();
            this.groupboxBlower2.SuspendLayout();
            this.groupboxBlower3.SuspendLayout();
            this.tabBlower1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xmlDataSourceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.tabBlower1);
            this.tabControl.Controls.Add(this.tabBlower2);
            this.tabControl.Controls.Add(this.tabBlower3);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(844, 644);
            this.tabControl.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.checkboxAdditonalConditions);
            this.tabHome.Controls.Add(this.groupboxAdditionalConditions);
            this.tabHome.Controls.Add(this.groupboxInletConditions);
            this.tabHome.Controls.Add(this.tableLayoutPanel);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(836, 618);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // checkboxAdditonalConditions
            // 
            this.checkboxAdditonalConditions.AutoSize = true;
            this.checkboxAdditonalConditions.Location = new System.Drawing.Point(3, 154);
            this.checkboxAdditonalConditions.Name = "checkboxAdditonalConditions";
            this.checkboxAdditonalConditions.Size = new System.Drawing.Size(143, 17);
            this.checkboxAdditonalConditions.TabIndex = 9;
            this.checkboxAdditonalConditions.Text = "Edit Addtional Conditions";
            this.checkboxAdditonalConditions.UseVisualStyleBackColor = true;
            this.checkboxAdditonalConditions.CheckedChanged += new System.EventHandler(this.checkBoxAdditonalConditions_CheckedChanged);
            // 
            // groupboxAdditionalConditions
            // 
            this.groupboxAdditionalConditions.Controls.Add(this.textboxPressureDecrement);
            this.groupboxAdditionalConditions.Controls.Add(this.labelPressureDecrement);
            this.groupboxAdditionalConditions.Controls.Add(this.textboxSystemDriveLosses);
            this.groupboxAdditionalConditions.Controls.Add(this.comboboxDischargeSilencerPressureDrop);
            this.groupboxAdditionalConditions.Controls.Add(this.labelSystemDriveLosses);
            this.groupboxAdditionalConditions.Controls.Add(this.comboboxInletFilterPressureDrop);
            this.groupboxAdditionalConditions.Controls.Add(this.labelDischargeSilenverPressureDrop);
            this.groupboxAdditionalConditions.Controls.Add(this.textboxDischargeSilencePressureDrop);
            this.groupboxAdditionalConditions.Controls.Add(this.labelInletFilterPressureDrop);
            this.groupboxAdditionalConditions.Controls.Add(this.textboxInletFilterPressureDrop);
            this.groupboxAdditionalConditions.Enabled = false;
            this.groupboxAdditionalConditions.Location = new System.Drawing.Point(3, 177);
            this.groupboxAdditionalConditions.Name = "groupboxAdditionalConditions";
            this.groupboxAdditionalConditions.Size = new System.Drawing.Size(368, 154);
            this.groupboxAdditionalConditions.TabIndex = 8;
            this.groupboxAdditionalConditions.TabStop = false;
            this.groupboxAdditionalConditions.Text = "Additional Conditions";
            // 
            // textboxPressureDecrement
            // 
            this.textboxPressureDecrement.Location = new System.Drawing.Point(190, 115);
            this.textboxPressureDecrement.Name = "textboxPressureDecrement";
            this.textboxPressureDecrement.Size = new System.Drawing.Size(71, 20);
            this.textboxPressureDecrement.TabIndex = 11;
            this.textboxPressureDecrement.Text = "3";
            // 
            // labelPressureDecrement
            // 
            this.labelPressureDecrement.AutoSize = true;
            this.labelPressureDecrement.Location = new System.Drawing.Point(22, 121);
            this.labelPressureDecrement.Name = "labelPressureDecrement";
            this.labelPressureDecrement.Size = new System.Drawing.Size(103, 13);
            this.labelPressureDecrement.TabIndex = 10;
            this.labelPressureDecrement.Text = "Pressure Decrement";
            // 
            // textboxSystemDriveLosses
            // 
            this.textboxSystemDriveLosses.Location = new System.Drawing.Point(191, 89);
            this.textboxSystemDriveLosses.Name = "textboxSystemDriveLosses";
            this.textboxSystemDriveLosses.Size = new System.Drawing.Size(71, 20);
            this.textboxSystemDriveLosses.TabIndex = 9;
            this.textboxSystemDriveLosses.Text = "0";
            // 
            // comboboxDischargeSilencerPressureDrop
            // 
            this.comboboxDischargeSilencerPressureDrop.FormattingEnabled = true;
            this.comboboxDischargeSilencerPressureDrop.Items.AddRange(new object[] {
            "psi ",
            "bar",
            "ft H20 Vac",
            "in H20 Vac",
            "in HG Vac",
            "kPa",
            "mbar",
            "mm Aq Vac",
            "mm HG Vac"});
            this.comboboxDischargeSilencerPressureDrop.Location = new System.Drawing.Point(268, 62);
            this.comboboxDischargeSilencerPressureDrop.Name = "comboboxDischargeSilencerPressureDrop";
            this.comboboxDischargeSilencerPressureDrop.Size = new System.Drawing.Size(74, 21);
            this.comboboxDischargeSilencerPressureDrop.TabIndex = 9;
            this.comboboxDischargeSilencerPressureDrop.Text = "psi";
            // 
            // labelSystemDriveLosses
            // 
            this.labelSystemDriveLosses.AutoSize = true;
            this.labelSystemDriveLosses.Location = new System.Drawing.Point(22, 92);
            this.labelSystemDriveLosses.Name = "labelSystemDriveLosses";
            this.labelSystemDriveLosses.Size = new System.Drawing.Size(105, 13);
            this.labelSystemDriveLosses.TabIndex = 8;
            this.labelSystemDriveLosses.Text = "System Drive Losses";
            // 
            // comboboxInletFilterPressureDrop
            // 
            this.comboboxInletFilterPressureDrop.FormattingEnabled = true;
            this.comboboxInletFilterPressureDrop.Items.AddRange(new object[] {
            "psi ",
            "bar",
            "ft H20 Vac",
            "in H20 Vac",
            "in HG Vac",
            "kPa",
            "mbar",
            "mm Aq Vac",
            "mm HG Vac",
            ""});
            this.comboboxInletFilterPressureDrop.Location = new System.Drawing.Point(268, 36);
            this.comboboxInletFilterPressureDrop.Name = "comboboxInletFilterPressureDrop";
            this.comboboxInletFilterPressureDrop.Size = new System.Drawing.Size(74, 21);
            this.comboboxInletFilterPressureDrop.TabIndex = 8;
            this.comboboxInletFilterPressureDrop.Text = "psi ";
            // 
            // labelDischargeSilenverPressureDrop
            // 
            this.labelDischargeSilenverPressureDrop.AutoSize = true;
            this.labelDischargeSilenverPressureDrop.Location = new System.Drawing.Point(22, 66);
            this.labelDischargeSilenverPressureDrop.Name = "labelDischargeSilenverPressureDrop";
            this.labelDischargeSilenverPressureDrop.Size = new System.Drawing.Size(166, 13);
            this.labelDischargeSilenverPressureDrop.TabIndex = 3;
            this.labelDischargeSilenverPressureDrop.Text = "Discharge Silencer Pressure Drop";
            // 
            // textboxDischargeSilencePressureDrop
            // 
            this.textboxDischargeSilencePressureDrop.Location = new System.Drawing.Point(190, 63);
            this.textboxDischargeSilencePressureDrop.Name = "textboxDischargeSilencePressureDrop";
            this.textboxDischargeSilencePressureDrop.Size = new System.Drawing.Size(72, 20);
            this.textboxDischargeSilencePressureDrop.TabIndex = 2;
            this.textboxDischargeSilencePressureDrop.Text = ".050";
            // 
            // labelInletFilterPressureDrop
            // 
            this.labelInletFilterPressureDrop.AutoSize = true;
            this.labelInletFilterPressureDrop.Location = new System.Drawing.Point(21, 40);
            this.labelInletFilterPressureDrop.Name = "labelInletFilterPressureDrop";
            this.labelInletFilterPressureDrop.Size = new System.Drawing.Size(122, 13);
            this.labelInletFilterPressureDrop.TabIndex = 1;
            this.labelInletFilterPressureDrop.Text = "Inlet Filter Pressure Drop";
            // 
            // textboxInletFilterPressureDrop
            // 
            this.textboxInletFilterPressureDrop.Location = new System.Drawing.Point(191, 37);
            this.textboxInletFilterPressureDrop.Name = "textboxInletFilterPressureDrop";
            this.textboxInletFilterPressureDrop.Size = new System.Drawing.Size(71, 20);
            this.textboxInletFilterPressureDrop.TabIndex = 0;
            this.textboxInletFilterPressureDrop.Text = ".20";
            // 
            // groupboxInletConditions
            // 
            this.groupboxInletConditions.Controls.Add(this.textboxBlower1RelativeHumitity);
            this.groupboxInletConditions.Controls.Add(this.labelBlower1RelativeHumidity);
            this.groupboxInletConditions.Controls.Add(this.comboboxBlower1InletPressureUnits);
            this.groupboxInletConditions.Controls.Add(this.textboxBlower1InletPressure);
            this.groupboxInletConditions.Controls.Add(this.labelBlower1InletPressure);
            this.groupboxInletConditions.Controls.Add(this.comboboxBlower1InletTempUnits);
            this.groupboxInletConditions.Controls.Add(this.textboxBlower1InletTemp);
            this.groupboxInletConditions.Controls.Add(this.labelBlower1InletTemp);
            this.groupboxInletConditions.Location = new System.Drawing.Point(3, 6);
            this.groupboxInletConditions.Name = "groupboxInletConditions";
            this.groupboxInletConditions.Size = new System.Drawing.Size(368, 123);
            this.groupboxInletConditions.TabIndex = 1;
            this.groupboxInletConditions.TabStop = false;
            this.groupboxInletConditions.Text = "Inlet Conditions";
            // 
            // textboxBlower1RelativeHumitity
            // 
            this.textboxBlower1RelativeHumitity.Location = new System.Drawing.Point(191, 79);
            this.textboxBlower1RelativeHumitity.Name = "textboxBlower1RelativeHumitity";
            this.textboxBlower1RelativeHumitity.Size = new System.Drawing.Size(71, 20);
            this.textboxBlower1RelativeHumitity.TabIndex = 7;
            this.textboxBlower1RelativeHumitity.Text = "95";
            // 
            // labelBlower1RelativeHumidity
            // 
            this.labelBlower1RelativeHumidity.AutoSize = true;
            this.labelBlower1RelativeHumidity.Location = new System.Drawing.Point(6, 82);
            this.labelBlower1RelativeHumidity.Name = "labelBlower1RelativeHumidity";
            this.labelBlower1RelativeHumidity.Size = new System.Drawing.Size(140, 13);
            this.labelBlower1RelativeHumidity.TabIndex = 6;
            this.labelBlower1RelativeHumidity.Text = "Blower #1 Relative Humidity";
            // 
            // comboboxBlower1InletPressureUnits
            // 
            this.comboboxBlower1InletPressureUnits.FormattingEnabled = true;
            this.comboboxBlower1InletPressureUnits.Items.AddRange(new object[] {
            "psi abs",
            "bar abs",
            "ft elevation",
            "m elevation",
            "kPa abs",
            "mbar abs"});
            this.comboboxBlower1InletPressureUnits.Location = new System.Drawing.Point(268, 53);
            this.comboboxBlower1InletPressureUnits.Name = "comboboxBlower1InletPressureUnits";
            this.comboboxBlower1InletPressureUnits.Size = new System.Drawing.Size(74, 21);
            this.comboboxBlower1InletPressureUnits.TabIndex = 5;
            this.comboboxBlower1InletPressureUnits.Text = "psi abs";
            // 
            // textboxBlower1InletPressure
            // 
            this.textboxBlower1InletPressure.Location = new System.Drawing.Point(191, 53);
            this.textboxBlower1InletPressure.Name = "textboxBlower1InletPressure";
            this.textboxBlower1InletPressure.Size = new System.Drawing.Size(71, 20);
            this.textboxBlower1InletPressure.TabIndex = 4;
            this.textboxBlower1InletPressure.Text = "14.69";
            this.textboxBlower1InletPressure.TextChanged += new System.EventHandler(this.textboxBlower1InletPressure_TextChanged);
            // 
            // labelBlower1InletPressure
            // 
            this.labelBlower1InletPressure.AutoSize = true;
            this.labelBlower1InletPressure.Location = new System.Drawing.Point(6, 56);
            this.labelBlower1InletPressure.Name = "labelBlower1InletPressure";
            this.labelBlower1InletPressure.Size = new System.Drawing.Size(122, 13);
            this.labelBlower1InletPressure.TabIndex = 3;
            this.labelBlower1InletPressure.Text = "Blower #1 Inlet Pressure";
            // 
            // comboboxBlower1InletTempUnits
            // 
            this.comboboxBlower1InletTempUnits.FormattingEnabled = true;
            this.comboboxBlower1InletTempUnits.Items.AddRange(new object[] {
            "°F",
            "°C",
            "°R",
            "°K"});
            this.comboboxBlower1InletTempUnits.Location = new System.Drawing.Point(268, 25);
            this.comboboxBlower1InletTempUnits.Name = "comboboxBlower1InletTempUnits";
            this.comboboxBlower1InletTempUnits.Size = new System.Drawing.Size(40, 21);
            this.comboboxBlower1InletTempUnits.TabIndex = 2;
            this.comboboxBlower1InletTempUnits.Text = "°F";
            // 
            // textboxBlower1InletTemp
            // 
            this.textboxBlower1InletTemp.Location = new System.Drawing.Point(191, 25);
            this.textboxBlower1InletTemp.Name = "textboxBlower1InletTemp";
            this.textboxBlower1InletTemp.Size = new System.Drawing.Size(71, 20);
            this.textboxBlower1InletTemp.TabIndex = 1;
            this.textboxBlower1InletTemp.Text = "80";
            // 
            // labelBlower1InletTemp
            // 
            this.labelBlower1InletTemp.AutoSize = true;
            this.labelBlower1InletTemp.Location = new System.Drawing.Point(6, 29);
            this.labelBlower1InletTemp.Name = "labelBlower1InletTemp";
            this.labelBlower1InletTemp.Size = new System.Drawing.Size(141, 13);
            this.labelBlower1InletTemp.TabIndex = 0;
            this.labelBlower1InletTemp.Text = "Blower #1 Inlet Temperature";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.groupboxBlower1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.groupboxBlower2, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.groupboxBlower3, 0, 2);
            this.tableLayoutPanel.Location = new System.Drawing.Point(377, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(439, 411);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // groupboxBlower1
            // 
            this.groupboxBlower1.Controls.Add(this.comboboxBlower1Brand);
            this.groupboxBlower1.Controls.Add(this.labelBlower1Brand);
            this.groupboxBlower1.Controls.Add(this.comboboxBlower1Model);
            this.groupboxBlower1.Controls.Add(this.labelBlower1Model);
            this.groupboxBlower1.Controls.Add(this.comboboxBlower1Series);
            this.groupboxBlower1.Controls.Add(this.labelBlower1Series);
            this.groupboxBlower1.Controls.Add(this.textboxBlower1RPM);
            this.groupboxBlower1.Controls.Add(this.labelBlower1RPM);
            this.groupboxBlower1.Controls.Add(this.buttonAddBlower1);
            this.groupboxBlower1.Location = new System.Drawing.Point(3, 3);
            this.groupboxBlower1.Name = "groupboxBlower1";
            this.groupboxBlower1.Size = new System.Drawing.Size(408, 131);
            this.groupboxBlower1.TabIndex = 0;
            this.groupboxBlower1.TabStop = false;
            this.groupboxBlower1.Text = "Blower 1 Inputs";
            // 
            // comboboxBlower1Brand
            // 
            this.comboboxBlower1Brand.FormattingEnabled = true;
            this.comboboxBlower1Brand.Items.AddRange(new object[] {
            "Q"});
            this.comboboxBlower1Brand.Location = new System.Drawing.Point(176, 79);
            this.comboboxBlower1Brand.Name = "comboboxBlower1Brand";
            this.comboboxBlower1Brand.Size = new System.Drawing.Size(62, 21);
            this.comboboxBlower1Brand.TabIndex = 8;
            this.comboboxBlower1Brand.Text = "Q";
            this.comboboxBlower1Brand.SelectedIndexChanged += new System.EventHandler(this.comboboxBlower1Brand_SelectedIndexChanged);
            // 
            // labelBlower1Brand
            // 
            this.labelBlower1Brand.AutoSize = true;
            this.labelBlower1Brand.Location = new System.Drawing.Point(7, 82);
            this.labelBlower1Brand.Name = "labelBlower1Brand";
            this.labelBlower1Brand.Size = new System.Drawing.Size(35, 13);
            this.labelBlower1Brand.TabIndex = 7;
            this.labelBlower1Brand.Text = "Brand";
            // 
            // comboboxBlower1Model
            // 
            this.comboboxBlower1Model.FormattingEnabled = true;
            this.comboboxBlower1Model.Location = new System.Drawing.Point(117, 106);
            this.comboboxBlower1Model.Name = "comboboxBlower1Model";
            this.comboboxBlower1Model.Size = new System.Drawing.Size(121, 21);
            this.comboboxBlower1Model.TabIndex = 6;
            // 
            // labelBlower1Model
            // 
            this.labelBlower1Model.AutoSize = true;
            this.labelBlower1Model.Location = new System.Drawing.Point(7, 109);
            this.labelBlower1Model.Name = "labelBlower1Model";
            this.labelBlower1Model.Size = new System.Drawing.Size(36, 13);
            this.labelBlower1Model.TabIndex = 5;
            this.labelBlower1Model.Text = "Model";
            // 
            // comboboxBlower1Series
            // 
            this.comboboxBlower1Series.FormattingEnabled = true;
            this.comboboxBlower1Series.Items.AddRange(new object[] {
            "6000",
            "8000"});
            this.comboboxBlower1Series.Location = new System.Drawing.Point(176, 52);
            this.comboboxBlower1Series.Name = "comboboxBlower1Series";
            this.comboboxBlower1Series.Size = new System.Drawing.Size(62, 21);
            this.comboboxBlower1Series.TabIndex = 4;
            this.comboboxBlower1Series.Text = "8000";
            this.comboboxBlower1Series.SelectedIndexChanged += new System.EventHandler(this.comboboxBlower1Series_SelectedIndexChanged_1);
            // 
            // labelBlower1Series
            // 
            this.labelBlower1Series.AutoSize = true;
            this.labelBlower1Series.Location = new System.Drawing.Point(6, 55);
            this.labelBlower1Series.Name = "labelBlower1Series";
            this.labelBlower1Series.Size = new System.Drawing.Size(36, 13);
            this.labelBlower1Series.TabIndex = 3;
            this.labelBlower1Series.Text = "Series";
            // 
            // textboxBlower1RPM
            // 
            this.textboxBlower1RPM.Location = new System.Drawing.Point(164, 26);
            this.textboxBlower1RPM.Name = "textboxBlower1RPM";
            this.textboxBlower1RPM.Size = new System.Drawing.Size(74, 20);
            this.textboxBlower1RPM.TabIndex = 2;
            this.textboxBlower1RPM.Text = "0";
            this.textboxBlower1RPM.TextChanged += new System.EventHandler(this.textboxBlower1RPM_TextChanged);
            // 
            // labelBlower1RPM
            // 
            this.labelBlower1RPM.AutoSize = true;
            this.labelBlower1RPM.Location = new System.Drawing.Point(6, 28);
            this.labelBlower1RPM.Name = "labelBlower1RPM";
            this.labelBlower1RPM.Size = new System.Drawing.Size(31, 13);
            this.labelBlower1RPM.TabIndex = 1;
            this.labelBlower1RPM.Text = "RPM";
            // 
            // buttonAddBlower1
            // 
            this.buttonAddBlower1.Location = new System.Drawing.Point(263, 106);
            this.buttonAddBlower1.Name = "buttonAddBlower1";
            this.buttonAddBlower1.Size = new System.Drawing.Size(139, 23);
            this.buttonAddBlower1.TabIndex = 0;
            this.buttonAddBlower1.Text = "Add/Remove Blower #2";
            this.buttonAddBlower1.UseVisualStyleBackColor = true;
            this.buttonAddBlower1.Click += new System.EventHandler(this.buttonAddBlower1_Click);
            // 
            // groupboxBlower2
            // 
            this.groupboxBlower2.Controls.Add(this.comboboxBlower2Brand);
            this.groupboxBlower2.Controls.Add(this.comboboxBlower2Model);
            this.groupboxBlower2.Controls.Add(this.labelBlower2Brand);
            this.groupboxBlower2.Controls.Add(this.labelBlower2Model);
            this.groupboxBlower2.Controls.Add(this.comboboxBlower2Series);
            this.groupboxBlower2.Controls.Add(this.labelBlower2Series);
            this.groupboxBlower2.Controls.Add(this.textboxBlower2RPM);
            this.groupboxBlower2.Controls.Add(this.labelBlower2RPM);
            this.groupboxBlower2.Controls.Add(this.buttonAddBlower2);
            this.groupboxBlower2.Location = new System.Drawing.Point(3, 140);
            this.groupboxBlower2.Name = "groupboxBlower2";
            this.groupboxBlower2.Size = new System.Drawing.Size(408, 131);
            this.groupboxBlower2.TabIndex = 1;
            this.groupboxBlower2.TabStop = false;
            this.groupboxBlower2.Text = "Blower 2 Inputs";
            this.groupboxBlower2.Visible = false;
            // 
            // comboboxBlower2Brand
            // 
            this.comboboxBlower2Brand.FormattingEnabled = true;
            this.comboboxBlower2Brand.Items.AddRange(new object[] {
            "Q"});
            this.comboboxBlower2Brand.Location = new System.Drawing.Point(176, 81);
            this.comboboxBlower2Brand.Name = "comboboxBlower2Brand";
            this.comboboxBlower2Brand.Size = new System.Drawing.Size(62, 21);
            this.comboboxBlower2Brand.TabIndex = 10;
            this.comboboxBlower2Brand.Text = "Q";
            this.comboboxBlower2Brand.SelectedIndexChanged += new System.EventHandler(this.comboboxBlower2Brand_SelectedIndexChanged);
            // 
            // comboboxBlower2Model
            // 
            this.comboboxBlower2Model.FormattingEnabled = true;
            this.comboboxBlower2Model.Location = new System.Drawing.Point(117, 108);
            this.comboboxBlower2Model.Name = "comboboxBlower2Model";
            this.comboboxBlower2Model.Size = new System.Drawing.Size(121, 21);
            this.comboboxBlower2Model.TabIndex = 8;
            // 
            // labelBlower2Brand
            // 
            this.labelBlower2Brand.AutoSize = true;
            this.labelBlower2Brand.Location = new System.Drawing.Point(7, 84);
            this.labelBlower2Brand.Name = "labelBlower2Brand";
            this.labelBlower2Brand.Size = new System.Drawing.Size(35, 13);
            this.labelBlower2Brand.TabIndex = 9;
            this.labelBlower2Brand.Text = "Brand";
            // 
            // labelBlower2Model
            // 
            this.labelBlower2Model.AutoSize = true;
            this.labelBlower2Model.Location = new System.Drawing.Point(6, 107);
            this.labelBlower2Model.Name = "labelBlower2Model";
            this.labelBlower2Model.Size = new System.Drawing.Size(36, 13);
            this.labelBlower2Model.TabIndex = 7;
            this.labelBlower2Model.Text = "Model";
            // 
            // comboboxBlower2Series
            // 
            this.comboboxBlower2Series.FormattingEnabled = true;
            this.comboboxBlower2Series.Items.AddRange(new object[] {
            "6000",
            "8000"});
            this.comboboxBlower2Series.Location = new System.Drawing.Point(176, 54);
            this.comboboxBlower2Series.Name = "comboboxBlower2Series";
            this.comboboxBlower2Series.Size = new System.Drawing.Size(62, 21);
            this.comboboxBlower2Series.TabIndex = 5;
            this.comboboxBlower2Series.Text = "8000";
            this.comboboxBlower2Series.SelectedIndexChanged += new System.EventHandler(this.comboboxBlower2Series_SelectedIndexChanged_1);
            // 
            // labelBlower2Series
            // 
            this.labelBlower2Series.AutoSize = true;
            this.labelBlower2Series.Location = new System.Drawing.Point(6, 57);
            this.labelBlower2Series.Name = "labelBlower2Series";
            this.labelBlower2Series.Size = new System.Drawing.Size(36, 13);
            this.labelBlower2Series.TabIndex = 4;
            this.labelBlower2Series.Text = "Series";
            // 
            // textboxBlower2RPM
            // 
            this.textboxBlower2RPM.Location = new System.Drawing.Point(164, 28);
            this.textboxBlower2RPM.Name = "textboxBlower2RPM";
            this.textboxBlower2RPM.Size = new System.Drawing.Size(74, 20);
            this.textboxBlower2RPM.TabIndex = 3;
            this.textboxBlower2RPM.Text = "0";
            // 
            // labelBlower2RPM
            // 
            this.labelBlower2RPM.AutoSize = true;
            this.labelBlower2RPM.Location = new System.Drawing.Point(6, 31);
            this.labelBlower2RPM.Name = "labelBlower2RPM";
            this.labelBlower2RPM.Size = new System.Drawing.Size(31, 13);
            this.labelBlower2RPM.TabIndex = 2;
            this.labelBlower2RPM.Text = "RPM";
            // 
            // buttonAddBlower2
            // 
            this.buttonAddBlower2.Location = new System.Drawing.Point(263, 106);
            this.buttonAddBlower2.Name = "buttonAddBlower2";
            this.buttonAddBlower2.Size = new System.Drawing.Size(139, 23);
            this.buttonAddBlower2.TabIndex = 1;
            this.buttonAddBlower2.Text = "Add/Remove Blower #3";
            this.buttonAddBlower2.UseVisualStyleBackColor = true;
            this.buttonAddBlower2.Click += new System.EventHandler(this.buttonAddBlower2_Click);
            // 
            // groupboxBlower3
            // 
            this.groupboxBlower3.Controls.Add(this.comboboxBlower3Brand);
            this.groupboxBlower3.Controls.Add(this.labelBlower3Brand);
            this.groupboxBlower3.Controls.Add(this.comboboxBlower3Model);
            this.groupboxBlower3.Controls.Add(this.comboboxBlower3Series);
            this.groupboxBlower3.Controls.Add(this.labelBlower3Model);
            this.groupboxBlower3.Controls.Add(this.labelBlower3Series);
            this.groupboxBlower3.Controls.Add(this.textboxBlower3RPM);
            this.groupboxBlower3.Controls.Add(this.labelBlower3RPM);
            this.groupboxBlower3.Location = new System.Drawing.Point(3, 277);
            this.groupboxBlower3.Name = "groupboxBlower3";
            this.groupboxBlower3.Size = new System.Drawing.Size(408, 131);
            this.groupboxBlower3.TabIndex = 2;
            this.groupboxBlower3.TabStop = false;
            this.groupboxBlower3.Text = "Blower 3 Inputs";
            this.groupboxBlower3.Visible = false;
            // 
            // comboboxBlower3Brand
            // 
            this.comboboxBlower3Brand.FormattingEnabled = true;
            this.comboboxBlower3Brand.Items.AddRange(new object[] {
            "Q"});
            this.comboboxBlower3Brand.Location = new System.Drawing.Point(176, 78);
            this.comboboxBlower3Brand.Name = "comboboxBlower3Brand";
            this.comboboxBlower3Brand.Size = new System.Drawing.Size(62, 21);
            this.comboboxBlower3Brand.TabIndex = 12;
            this.comboboxBlower3Brand.Text = "Q";
            this.comboboxBlower3Brand.SelectedIndexChanged += new System.EventHandler(this.comboboxBlower3Brand_SelectedIndexChanged);
            // 
            // labelBlower3Brand
            // 
            this.labelBlower3Brand.AutoSize = true;
            this.labelBlower3Brand.Location = new System.Drawing.Point(8, 81);
            this.labelBlower3Brand.Name = "labelBlower3Brand";
            this.labelBlower3Brand.Size = new System.Drawing.Size(35, 13);
            this.labelBlower3Brand.TabIndex = 11;
            this.labelBlower3Brand.Text = "Brand";
            // 
            // comboboxBlower3Model
            // 
            this.comboboxBlower3Model.FormattingEnabled = true;
            this.comboboxBlower3Model.Location = new System.Drawing.Point(117, 104);
            this.comboboxBlower3Model.Name = "comboboxBlower3Model";
            this.comboboxBlower3Model.Size = new System.Drawing.Size(121, 21);
            this.comboboxBlower3Model.TabIndex = 10;
            // 
            // comboboxBlower3Series
            // 
            this.comboboxBlower3Series.FormattingEnabled = true;
            this.comboboxBlower3Series.Items.AddRange(new object[] {
            "6000",
            "8000"});
            this.comboboxBlower3Series.Location = new System.Drawing.Point(176, 51);
            this.comboboxBlower3Series.Name = "comboboxBlower3Series";
            this.comboboxBlower3Series.Size = new System.Drawing.Size(62, 21);
            this.comboboxBlower3Series.TabIndex = 6;
            this.comboboxBlower3Series.Text = "8000";
            this.comboboxBlower3Series.SelectedIndexChanged += new System.EventHandler(this.comboboxBlower3Series_SelectedIndexChanged_1);
            // 
            // labelBlower3Model
            // 
            this.labelBlower3Model.AutoSize = true;
            this.labelBlower3Model.Location = new System.Drawing.Point(6, 107);
            this.labelBlower3Model.Name = "labelBlower3Model";
            this.labelBlower3Model.Size = new System.Drawing.Size(36, 13);
            this.labelBlower3Model.TabIndex = 9;
            this.labelBlower3Model.Text = "Model";
            // 
            // labelBlower3Series
            // 
            this.labelBlower3Series.AutoSize = true;
            this.labelBlower3Series.Location = new System.Drawing.Point(6, 54);
            this.labelBlower3Series.Name = "labelBlower3Series";
            this.labelBlower3Series.Size = new System.Drawing.Size(36, 13);
            this.labelBlower3Series.TabIndex = 5;
            this.labelBlower3Series.Text = "Series";
            // 
            // textboxBlower3RPM
            // 
            this.textboxBlower3RPM.Location = new System.Drawing.Point(164, 25);
            this.textboxBlower3RPM.Name = "textboxBlower3RPM";
            this.textboxBlower3RPM.Size = new System.Drawing.Size(74, 20);
            this.textboxBlower3RPM.TabIndex = 4;
            this.textboxBlower3RPM.Text = "0";
            // 
            // labelBlower3RPM
            // 
            this.labelBlower3RPM.AutoSize = true;
            this.labelBlower3RPM.Location = new System.Drawing.Point(6, 28);
            this.labelBlower3RPM.Name = "labelBlower3RPM";
            this.labelBlower3RPM.Size = new System.Drawing.Size(31, 13);
            this.labelBlower3RPM.TabIndex = 3;
            this.labelBlower3RPM.Text = "RPM";
            // 
            // tabBlower1
            // 
            this.tabBlower1.Controls.Add(this.dataGridView1);
            this.tabBlower1.Location = new System.Drawing.Point(4, 22);
            this.tabBlower1.Name = "tabBlower1";
            this.tabBlower1.Padding = new System.Windows.Forms.Padding(3);
            this.tabBlower1.Size = new System.Drawing.Size(836, 618);
            this.tabBlower1.TabIndex = 1;
            this.tabBlower1.Text = "Blower 1";
            this.tabBlower1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabBlower2
            // 
            this.tabBlower2.Location = new System.Drawing.Point(4, 22);
            this.tabBlower2.Name = "tabBlower2";
            this.tabBlower2.Padding = new System.Windows.Forms.Padding(3);
            this.tabBlower2.Size = new System.Drawing.Size(836, 618);
            this.tabBlower2.TabIndex = 2;
            this.tabBlower2.Text = "Blower 2";
            this.tabBlower2.UseVisualStyleBackColor = true;
            // 
            // tabBlower3
            // 
            this.tabBlower3.Location = new System.Drawing.Point(4, 22);
            this.tabBlower3.Name = "tabBlower3";
            this.tabBlower3.Padding = new System.Windows.Forms.Padding(3);
            this.tabBlower3.Size = new System.Drawing.Size(836, 618);
            this.tabBlower3.TabIndex = 3;
            this.tabBlower3.Text = "Blower 3";
            this.tabBlower3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // xmlDataSourceBindingSource
            // 
            this.xmlDataSourceBindingSource.DataSource = typeof(WetVacClient.XmlDataSource);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 657);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Wet Vac";
            this.tabControl.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.groupboxAdditionalConditions.ResumeLayout(false);
            this.groupboxAdditionalConditions.PerformLayout();
            this.groupboxInletConditions.ResumeLayout(false);
            this.groupboxInletConditions.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.groupboxBlower1.ResumeLayout(false);
            this.groupboxBlower1.PerformLayout();
            this.groupboxBlower2.ResumeLayout(false);
            this.groupboxBlower2.PerformLayout();
            this.groupboxBlower3.ResumeLayout(false);
            this.groupboxBlower3.PerformLayout();
            this.tabBlower1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xmlDataSourceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabBlower1;
        private System.Windows.Forms.TabPage tabBlower2;
        private System.Windows.Forms.TabPage tabBlower3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.GroupBox groupboxBlower1;
        private System.Windows.Forms.GroupBox groupboxBlower2;
        private System.Windows.Forms.GroupBox groupboxBlower3;
        private System.Windows.Forms.Button buttonAddBlower1;
        private System.Windows.Forms.Button buttonAddBlower2;
        private System.Windows.Forms.GroupBox groupboxInletConditions;
        private System.Windows.Forms.Label labelBlower1InletTemp;
        private System.Windows.Forms.TextBox textboxBlower1InletTemp;
        private System.Windows.Forms.TextBox textboxBlower1RPM;
        private System.Windows.Forms.Label labelBlower1RPM;
        private System.Windows.Forms.TextBox textboxBlower2RPM;
        private System.Windows.Forms.Label labelBlower2RPM;
        private System.Windows.Forms.TextBox textboxBlower3RPM;
        private System.Windows.Forms.Label labelBlower3RPM;
        private System.Windows.Forms.ComboBox comboboxBlower1InletTempUnits;
        private System.Windows.Forms.ComboBox comboboxBlower1Series;
        private System.Windows.Forms.Label labelBlower1Series;
        private System.Windows.Forms.Label labelBlower2Series;
        private System.Windows.Forms.Label labelBlower3Series;
        private System.Windows.Forms.ComboBox comboboxBlower2Series;
        private System.Windows.Forms.ComboBox comboboxBlower3Series;
        private System.Windows.Forms.ComboBox comboboxBlower1InletPressureUnits;
        private System.Windows.Forms.TextBox textboxBlower1InletPressure;
        private System.Windows.Forms.Label labelBlower1InletPressure;
        private System.Windows.Forms.ComboBox comboboxBlower1Model;
        private System.Windows.Forms.Label labelBlower1Model;
        private System.Windows.Forms.ComboBox comboboxBlower2Model;
        private System.Windows.Forms.Label labelBlower2Model;
        private System.Windows.Forms.ComboBox comboboxBlower3Model;
        private System.Windows.Forms.Label labelBlower3Model;
        private System.Windows.Forms.TextBox textboxBlower1RelativeHumitity;
        private System.Windows.Forms.Label labelBlower1RelativeHumidity;
        private System.Windows.Forms.CheckBox checkboxAdditonalConditions;
        private System.Windows.Forms.GroupBox groupboxAdditionalConditions;
        private System.Windows.Forms.ComboBox comboboxDischargeSilencerPressureDrop;
        private System.Windows.Forms.ComboBox comboboxInletFilterPressureDrop;
        private System.Windows.Forms.Label labelDischargeSilenverPressureDrop;
        private System.Windows.Forms.TextBox textboxDischargeSilencePressureDrop;
        private System.Windows.Forms.Label labelInletFilterPressureDrop;
        private System.Windows.Forms.TextBox textboxInletFilterPressureDrop;
        private System.Windows.Forms.TextBox textboxSystemDriveLosses;
        private System.Windows.Forms.Label labelSystemDriveLosses;
        private System.Windows.Forms.TextBox textboxPressureDecrement;
        private System.Windows.Forms.Label labelPressureDecrement;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label labelBlower1Brand;
        private System.Windows.Forms.ComboBox comboboxBlower1Brand;
        private System.Windows.Forms.ComboBox comboboxBlower2Brand;
        private System.Windows.Forms.Label labelBlower2Brand;
        private System.Windows.Forms.ComboBox comboboxBlower3Brand;
        private System.Windows.Forms.Label labelBlower3Brand;
        private System.Windows.Forms.BindingSource xmlDataSourceBindingSource;
       

    }
}


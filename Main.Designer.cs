
namespace SoftSensConfE
{
    partial class Main
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
            System.Windows.Forms.Label dAU_IDLabel;
            System.Windows.Forms.Label area_IDLabel;
            System.Windows.Forms.Label rDC_IDLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label communicationLabel;
            System.Windows.Forms.Label dAU_IDLabel1;
            System.Windows.Forms.Label tagLabel;
            System.Windows.Forms.Label lRVLabel;
            System.Windows.Forms.Label uRVLabel;
            System.Windows.Forms.Label alarm_LowLabel;
            System.Windows.Forms.Label alarm_HighLabel;
            System.Windows.Forms.Label area_IDLabel1;
            System.Windows.Forms.Label dAU_IDLabel2;
            System.Windows.Forms.Label descriptionLabel1;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label manufacturerLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDAU = new System.Windows.Forms.TabPage();
            this.buttonLog_aiSend = new System.Windows.Forms.Button();
            this.textBoxLog_ai_send = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDAUChooseRDCDisconnect = new System.Windows.Forms.Button();
            this.buttonDAUChooseRDCConnect = new System.Windows.Forms.Button();
            this.comboBoxDAUChooseRDC = new System.Windows.Forms.ComboBox();
            this.rDCChooseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softSensConfDBDataSet = new SoftSensConfE.SoftSensConfDBDataSet();
            this.labelChooseRDC = new System.Windows.Forms.Label();
            this.buttonDAUCancelData = new System.Windows.Forms.Button();
            this.TextBoxDAUDeviceName = new System.Windows.Forms.TextBox();
            this.dAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDAUNewData = new System.Windows.Forms.Button();
            this.buttonDAUSaveData = new System.Windows.Forms.Button();
            this.buttonDAUChangeData = new System.Windows.Forms.Button();
            this.comboBoxComm = new System.Windows.Forms.ComboBox();
            this.communicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxAREAID = new System.Windows.Forms.ComboBox();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxRDCID = new System.Windows.Forms.ComboBox();
            this.rDCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxFindDevice = new System.Windows.Forms.ComboBox();
            this.dAUFindDeviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dAUFindDeviceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TextBoxDAUDescription = new System.Windows.Forms.TextBox();
            this.tabPageInstrument = new System.Windows.Forms.TabPage();
            this.buttonInstCancel = new System.Windows.Forms.Button();
            this.buttonInstChange = new System.Windows.Forms.Button();
            this.labelFindinstrument = new System.Windows.Forms.Label();
            this.comboBoxFindInstrument = new System.Windows.Forms.ComboBox();
            this.TextBoxTag = new System.Windows.Forms.TextBox();
            this.instrumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TextBoxLRV = new System.Windows.Forms.TextBox();
            this.TextBoxURV = new System.Windows.Forms.TextBox();
            this.TextBoxAlarm_Low = new System.Windows.Forms.TextBox();
            this.TextBoxAlarm_High = new System.Windows.Forms.TextBox();
            this.TextBoxInstrumentAREAID = new System.Windows.Forms.TextBox();
            this.TextBoxInstrumentDAUID = new System.Windows.Forms.TextBox();
            this.TextBoxInstrumentDescription = new System.Windows.Forms.TextBox();
            this.TextBoxInstrumentUnit = new System.Windows.Forms.TextBox();
            this.TextBoxInstrumentType = new System.Windows.Forms.TextBox();
            this.TextBoxInstrumentManufacturer = new System.Windows.Forms.TextBox();
            this.tabPageGrid = new System.Windows.Forms.TabPage();
            this.buttonInstrumentGrid = new System.Windows.Forms.Button();
            this.buttonTypeGrid = new System.Windows.Forms.Button();
            this.buttonManufacturerGrid = new System.Windows.Forms.Button();
            this.buttonAreaGrid = new System.Windows.Forms.Button();
            this.dataGridViewGridTables = new System.Windows.Forms.DataGridView();
            this.labelViewtablesGrid = new System.Windows.Forms.Label();
            this.instrumentsToComboBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dAUTableAdapter = new SoftSensConfE.SoftSensConfDBDataSetTableAdapters.DAUTableAdapter();
            this.tableAdapterManager = new SoftSensConfE.SoftSensConfDBDataSetTableAdapters.TableAdapterManager();
            this.dAUFindDeviceTableAdapter = new SoftSensConfE.SoftSensConfDBDataSetTableAdapters.DAUFindDeviceTableAdapter();
            this.rDCTableAdapter = new SoftSensConfE.SoftSensConfDBDataSetTableAdapters.RDCTableAdapter();
            this.areaTableAdapter = new SoftSensConfE.SoftSensConfDBDataSetTableAdapters.AreaTableAdapter();
            this.communicationTableAdapter = new SoftSensConfE.SoftSensConfDBDataSetTableAdapters.CommunicationTableAdapter();
            this.instrumentTableAdapter = new SoftSensConfE.SoftSensConfDBDataSetTableAdapters.InstrumentTableAdapter();
            this.instrumentsToComboBoxTableAdapter = new SoftSensConfE.SoftSensConfDBDataSetTableAdapters.InstrumentsToComboBoxTableAdapter();
            this.rDCChooseTableAdapter = new SoftSensConfE.SoftSensConfDBDataSetTableAdapters.RDCChooseTableAdapter();
            dAU_IDLabel = new System.Windows.Forms.Label();
            area_IDLabel = new System.Windows.Forms.Label();
            rDC_IDLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            communicationLabel = new System.Windows.Forms.Label();
            dAU_IDLabel1 = new System.Windows.Forms.Label();
            tagLabel = new System.Windows.Forms.Label();
            lRVLabel = new System.Windows.Forms.Label();
            uRVLabel = new System.Windows.Forms.Label();
            alarm_LowLabel = new System.Windows.Forms.Label();
            alarm_HighLabel = new System.Windows.Forms.Label();
            area_IDLabel1 = new System.Windows.Forms.Label();
            dAU_IDLabel2 = new System.Windows.Forms.Label();
            descriptionLabel1 = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            manufacturerLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageDAU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rDCChooseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softSensConfDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUFindDeviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUFindDeviceBindingSource1)).BeginInit();
            this.tabPageInstrument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentBindingSource)).BeginInit();
            this.tabPageGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGridTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsToComboBoxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dAU_IDLabel
            // 
            dAU_IDLabel.AutoSize = true;
            dAU_IDLabel.Location = new System.Drawing.Point(284, 34);
            dAU_IDLabel.Name = "dAU_IDLabel";
            dAU_IDLabel.Size = new System.Drawing.Size(96, 20);
            dAU_IDLabel.TabIndex = 0;
            dAU_IDLabel.Text = "Find Device:";
            // 
            // area_IDLabel
            // 
            area_IDLabel.AutoSize = true;
            area_IDLabel.Location = new System.Drawing.Point(284, 274);
            area_IDLabel.Name = "area_IDLabel";
            area_IDLabel.Size = new System.Drawing.Size(68, 20);
            area_IDLabel.TabIndex = 2;
            area_IDLabel.Text = "Area ID:";
            // 
            // rDC_IDLabel
            // 
            rDC_IDLabel.AutoSize = true;
            rDC_IDLabel.Location = new System.Drawing.Point(284, 242);
            rDC_IDLabel.Name = "rDC_IDLabel";
            rDC_IDLabel.Size = new System.Drawing.Size(69, 20);
            rDC_IDLabel.TabIndex = 4;
            rDC_IDLabel.Text = "RDC ID:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(284, 338);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // communicationLabel
            // 
            communicationLabel.AutoSize = true;
            communicationLabel.Location = new System.Drawing.Point(284, 306);
            communicationLabel.Name = "communicationLabel";
            communicationLabel.Size = new System.Drawing.Size(123, 20);
            communicationLabel.TabIndex = 8;
            communicationLabel.Text = "Communication:";
            // 
            // dAU_IDLabel1
            // 
            dAU_IDLabel1.AutoSize = true;
            dAU_IDLabel1.Location = new System.Drawing.Point(283, 208);
            dAU_IDLabel1.Name = "dAU_IDLabel1";
            dAU_IDLabel1.Size = new System.Drawing.Size(107, 20);
            dAU_IDLabel1.TabIndex = 17;
            dAU_IDLabel1.Text = "Device Name:";
            // 
            // tagLabel
            // 
            tagLabel.AutoSize = true;
            tagLabel.Location = new System.Drawing.Point(28, 170);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new System.Drawing.Size(40, 20);
            tagLabel.TabIndex = 0;
            tagLabel.Text = "Tag:";
            // 
            // lRVLabel
            // 
            lRVLabel.AutoSize = true;
            lRVLabel.Location = new System.Drawing.Point(28, 202);
            lRVLabel.Name = "lRVLabel";
            lRVLabel.Size = new System.Drawing.Size(45, 20);
            lRVLabel.TabIndex = 2;
            lRVLabel.Text = "LRV:";
            // 
            // uRVLabel
            // 
            uRVLabel.AutoSize = true;
            uRVLabel.Location = new System.Drawing.Point(28, 234);
            uRVLabel.Name = "uRVLabel";
            uRVLabel.Size = new System.Drawing.Size(48, 20);
            uRVLabel.TabIndex = 4;
            uRVLabel.Text = "URV:";
            // 
            // alarm_LowLabel
            // 
            alarm_LowLabel.AutoSize = true;
            alarm_LowLabel.Location = new System.Drawing.Point(28, 266);
            alarm_LowLabel.Name = "alarm_LowLabel";
            alarm_LowLabel.Size = new System.Drawing.Size(87, 20);
            alarm_LowLabel.TabIndex = 6;
            alarm_LowLabel.Text = "Alarm Low:";
            // 
            // alarm_HighLabel
            // 
            alarm_HighLabel.AutoSize = true;
            alarm_HighLabel.Location = new System.Drawing.Point(28, 298);
            alarm_HighLabel.Name = "alarm_HighLabel";
            alarm_HighLabel.Size = new System.Drawing.Size(91, 20);
            alarm_HighLabel.TabIndex = 8;
            alarm_HighLabel.Text = "Alarm High:";
            // 
            // area_IDLabel1
            // 
            area_IDLabel1.AutoSize = true;
            area_IDLabel1.Location = new System.Drawing.Point(402, 139);
            area_IDLabel1.Name = "area_IDLabel1";
            area_IDLabel1.Size = new System.Drawing.Size(68, 20);
            area_IDLabel1.TabIndex = 10;
            area_IDLabel1.Text = "Area ID:";
            // 
            // dAU_IDLabel2
            // 
            dAU_IDLabel2.AutoSize = true;
            dAU_IDLabel2.Location = new System.Drawing.Point(402, 171);
            dAU_IDLabel2.Name = "dAU_IDLabel2";
            dAU_IDLabel2.Size = new System.Drawing.Size(69, 20);
            dAU_IDLabel2.TabIndex = 12;
            dAU_IDLabel2.Text = "DAU ID:";
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Location = new System.Drawing.Point(402, 203);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(93, 20);
            descriptionLabel1.TabIndex = 14;
            descriptionLabel1.Text = "Description:";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(402, 235);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(42, 20);
            unitLabel.TabIndex = 16;
            unitLabel.Text = "Unit:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(402, 266);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(47, 20);
            typeLabel.TabIndex = 18;
            typeLabel.Text = "Type:";
            // 
            // manufacturerLabel
            // 
            manufacturerLabel.AutoSize = true;
            manufacturerLabel.Location = new System.Drawing.Point(402, 298);
            manufacturerLabel.Name = "manufacturerLabel";
            manufacturerLabel.Size = new System.Drawing.Size(108, 20);
            manufacturerLabel.TabIndex = 20;
            manufacturerLabel.Text = "Manufacturer:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDAU);
            this.tabControl1.Controls.Add(this.tabPageInstrument);
            this.tabControl1.Controls.Add(this.tabPageGrid);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 423);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageDAU
            // 
            this.tabPageDAU.Controls.Add(this.buttonLog_aiSend);
            this.tabPageDAU.Controls.Add(this.textBoxLog_ai_send);
            this.tabPageDAU.Controls.Add(this.label1);
            this.tabPageDAU.Controls.Add(this.buttonDAUChooseRDCDisconnect);
            this.tabPageDAU.Controls.Add(this.buttonDAUChooseRDCConnect);
            this.tabPageDAU.Controls.Add(this.comboBoxDAUChooseRDC);
            this.tabPageDAU.Controls.Add(this.labelChooseRDC);
            this.tabPageDAU.Controls.Add(this.buttonDAUCancelData);
            this.tabPageDAU.Controls.Add(dAU_IDLabel1);
            this.tabPageDAU.Controls.Add(this.TextBoxDAUDeviceName);
            this.tabPageDAU.Controls.Add(this.buttonDAUNewData);
            this.tabPageDAU.Controls.Add(this.buttonDAUSaveData);
            this.tabPageDAU.Controls.Add(this.buttonDAUChangeData);
            this.tabPageDAU.Controls.Add(this.comboBoxComm);
            this.tabPageDAU.Controls.Add(this.comboBoxAREAID);
            this.tabPageDAU.Controls.Add(this.comboBoxRDCID);
            this.tabPageDAU.Controls.Add(this.comboBoxFindDevice);
            this.tabPageDAU.Controls.Add(dAU_IDLabel);
            this.tabPageDAU.Controls.Add(area_IDLabel);
            this.tabPageDAU.Controls.Add(rDC_IDLabel);
            this.tabPageDAU.Controls.Add(descriptionLabel);
            this.tabPageDAU.Controls.Add(this.TextBoxDAUDescription);
            this.tabPageDAU.Controls.Add(communicationLabel);
            this.tabPageDAU.Location = new System.Drawing.Point(4, 29);
            this.tabPageDAU.Name = "tabPageDAU";
            this.tabPageDAU.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDAU.Size = new System.Drawing.Size(924, 390);
            this.tabPageDAU.TabIndex = 0;
            this.tabPageDAU.Text = "DAU";
            this.tabPageDAU.UseVisualStyleBackColor = true;
            this.tabPageDAU.Enter += new System.EventHandler(this.tabPageDAU_Enter);
            // 
            // buttonLog_aiSend
            // 
            this.buttonLog_aiSend.Enabled = false;
            this.buttonLog_aiSend.Location = new System.Drawing.Point(652, 127);
            this.buttonLog_aiSend.Name = "buttonLog_aiSend";
            this.buttonLog_aiSend.Size = new System.Drawing.Size(89, 40);
            this.buttonLog_aiSend.TabIndex = 26;
            this.buttonLog_aiSend.Text = "Send";
            this.buttonLog_aiSend.UseVisualStyleBackColor = true;
            // 
            // textBoxLog_ai_send
            // 
            this.textBoxLog_ai_send.Enabled = false;
            this.textBoxLog_ai_send.Location = new System.Drawing.Point(652, 81);
            this.textBoxLog_ai_send.Name = "textBoxLog_ai_send";
            this.textBoxLog_ai_send.Size = new System.Drawing.Size(180, 26);
            this.textBoxLog_ai_send.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Save Log_AI data:";
            // 
            // buttonDAUChooseRDCDisconnect
            // 
            this.buttonDAUChooseRDCDisconnect.Enabled = false;
            this.buttonDAUChooseRDCDisconnect.Location = new System.Drawing.Point(158, 146);
            this.buttonDAUChooseRDCDisconnect.Name = "buttonDAUChooseRDCDisconnect";
            this.buttonDAUChooseRDCDisconnect.Size = new System.Drawing.Size(108, 48);
            this.buttonDAUChooseRDCDisconnect.TabIndex = 23;
            this.buttonDAUChooseRDCDisconnect.Text = "Disconnect";
            this.buttonDAUChooseRDCDisconnect.UseVisualStyleBackColor = true;
            this.buttonDAUChooseRDCDisconnect.Click += new System.EventHandler(this.buttonDAUChooseRDCDisconnect_Click);
            // 
            // buttonDAUChooseRDCConnect
            // 
            this.buttonDAUChooseRDCConnect.Location = new System.Drawing.Point(32, 146);
            this.buttonDAUChooseRDCConnect.Name = "buttonDAUChooseRDCConnect";
            this.buttonDAUChooseRDCConnect.Size = new System.Drawing.Size(108, 48);
            this.buttonDAUChooseRDCConnect.TabIndex = 22;
            this.buttonDAUChooseRDCConnect.Text = "Connect";
            this.buttonDAUChooseRDCConnect.UseVisualStyleBackColor = true;
            this.buttonDAUChooseRDCConnect.Click += new System.EventHandler(this.buttonDAUChooseRDCConnect_Click);
            // 
            // comboBoxDAUChooseRDC
            // 
            this.comboBoxDAUChooseRDC.DataSource = this.rDCChooseBindingSource;
            this.comboBoxDAUChooseRDC.DisplayMember = "RDC_ID";
            this.comboBoxDAUChooseRDC.FormattingEnabled = true;
            this.comboBoxDAUChooseRDC.Location = new System.Drawing.Point(32, 71);
            this.comboBoxDAUChooseRDC.Name = "comboBoxDAUChooseRDC";
            this.comboBoxDAUChooseRDC.Size = new System.Drawing.Size(234, 28);
            this.comboBoxDAUChooseRDC.TabIndex = 21;
            this.comboBoxDAUChooseRDC.ValueMember = "RDC_ID";
            this.comboBoxDAUChooseRDC.SelectedIndexChanged += new System.EventHandler(this.comboBoxDAUChooseRDC_SelectedIndexChanged);
            // 
            // rDCChooseBindingSource
            // 
            this.rDCChooseBindingSource.DataMember = "RDCChoose";
            this.rDCChooseBindingSource.DataSource = this.softSensConfDBDataSet;
            // 
            // softSensConfDBDataSet
            // 
            this.softSensConfDBDataSet.DataSetName = "SoftSensConfDBDataSet";
            this.softSensConfDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelChooseRDC
            // 
            this.labelChooseRDC.AutoSize = true;
            this.labelChooseRDC.Location = new System.Drawing.Point(28, 34);
            this.labelChooseRDC.Name = "labelChooseRDC";
            this.labelChooseRDC.Size = new System.Drawing.Size(107, 20);
            this.labelChooseRDC.TabIndex = 20;
            this.labelChooseRDC.Text = "Choose RDC:";
            // 
            // buttonDAUCancelData
            // 
            this.buttonDAUCancelData.Enabled = false;
            this.buttonDAUCancelData.Location = new System.Drawing.Point(512, 127);
            this.buttonDAUCancelData.Name = "buttonDAUCancelData";
            this.buttonDAUCancelData.Size = new System.Drawing.Size(87, 40);
            this.buttonDAUCancelData.TabIndex = 19;
            this.buttonDAUCancelData.Text = "Cancel";
            this.buttonDAUCancelData.UseVisualStyleBackColor = true;
            this.buttonDAUCancelData.Click += new System.EventHandler(this.buttonDAUCancelData_Click);
            // 
            // TextBoxDAUDeviceName
            // 
            this.TextBoxDAUDeviceName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "DAU_ID", true));
            this.TextBoxDAUDeviceName.Enabled = false;
            this.TextBoxDAUDeviceName.Location = new System.Drawing.Point(419, 205);
            this.TextBoxDAUDeviceName.Name = "TextBoxDAUDeviceName";
            this.TextBoxDAUDeviceName.Size = new System.Drawing.Size(180, 26);
            this.TextBoxDAUDeviceName.TabIndex = 18;
            // 
            // dAUBindingSource
            // 
            this.dAUBindingSource.DataMember = "DAU";
            this.dAUBindingSource.DataSource = this.softSensConfDBDataSet;
            // 
            // buttonDAUNewData
            // 
            this.buttonDAUNewData.Enabled = false;
            this.buttonDAUNewData.Location = new System.Drawing.Point(419, 81);
            this.buttonDAUNewData.Name = "buttonDAUNewData";
            this.buttonDAUNewData.Size = new System.Drawing.Size(87, 40);
            this.buttonDAUNewData.TabIndex = 17;
            this.buttonDAUNewData.Text = "New";
            this.buttonDAUNewData.UseVisualStyleBackColor = true;
            this.buttonDAUNewData.Click += new System.EventHandler(this.buttonNewData_Click);
            // 
            // buttonDAUSaveData
            // 
            this.buttonDAUSaveData.Enabled = false;
            this.buttonDAUSaveData.Location = new System.Drawing.Point(419, 127);
            this.buttonDAUSaveData.Name = "buttonDAUSaveData";
            this.buttonDAUSaveData.Size = new System.Drawing.Size(87, 40);
            this.buttonDAUSaveData.TabIndex = 16;
            this.buttonDAUSaveData.Text = "Save";
            this.buttonDAUSaveData.UseVisualStyleBackColor = true;
            this.buttonDAUSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // buttonDAUChangeData
            // 
            this.buttonDAUChangeData.Enabled = false;
            this.buttonDAUChangeData.Location = new System.Drawing.Point(512, 81);
            this.buttonDAUChangeData.Name = "buttonDAUChangeData";
            this.buttonDAUChangeData.Size = new System.Drawing.Size(87, 40);
            this.buttonDAUChangeData.TabIndex = 15;
            this.buttonDAUChangeData.Text = "Change";
            this.buttonDAUChangeData.UseVisualStyleBackColor = true;
            this.buttonDAUChangeData.Click += new System.EventHandler(this.buttonDAUChangeData_Click);
            // 
            // comboBoxComm
            // 
            this.comboBoxComm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Communication", true));
            this.comboBoxComm.DataSource = this.communicationBindingSource;
            this.comboBoxComm.DisplayMember = "Comminucation";
            this.comboBoxComm.Enabled = false;
            this.comboBoxComm.FormattingEnabled = true;
            this.comboBoxComm.Location = new System.Drawing.Point(419, 303);
            this.comboBoxComm.Name = "comboBoxComm";
            this.comboBoxComm.Size = new System.Drawing.Size(180, 28);
            this.comboBoxComm.TabIndex = 14;
            // 
            // communicationBindingSource
            // 
            this.communicationBindingSource.DataMember = "Communication";
            this.communicationBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.softSensConfDBDataSet;
            this.bindingSource1.Position = 0;
            // 
            // comboBoxAREAID
            // 
            this.comboBoxAREAID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Area_ID", true));
            this.comboBoxAREAID.DataSource = this.areaBindingSource;
            this.comboBoxAREAID.DisplayMember = "Area_ID";
            this.comboBoxAREAID.Enabled = false;
            this.comboBoxAREAID.FormattingEnabled = true;
            this.comboBoxAREAID.Location = new System.Drawing.Point(419, 269);
            this.comboBoxAREAID.Name = "comboBoxAREAID";
            this.comboBoxAREAID.Size = new System.Drawing.Size(180, 28);
            this.comboBoxAREAID.TabIndex = 13;
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.bindingSource1;
            // 
            // comboBoxRDCID
            // 
            this.comboBoxRDCID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "RDC_ID", true));
            this.comboBoxRDCID.DataSource = this.rDCBindingSource;
            this.comboBoxRDCID.DisplayMember = "RDC_ID";
            this.comboBoxRDCID.Enabled = false;
            this.comboBoxRDCID.FormattingEnabled = true;
            this.comboBoxRDCID.Location = new System.Drawing.Point(419, 237);
            this.comboBoxRDCID.Name = "comboBoxRDCID";
            this.comboBoxRDCID.Size = new System.Drawing.Size(180, 28);
            this.comboBoxRDCID.TabIndex = 12;
            // 
            // rDCBindingSource
            // 
            this.rDCBindingSource.DataMember = "RDC";
            this.rDCBindingSource.DataSource = this.bindingSource1;
            // 
            // comboBoxFindDevice
            // 
            this.comboBoxFindDevice.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUFindDeviceBindingSource, "DAU_ID", true));
            this.comboBoxFindDevice.DataSource = this.dAUFindDeviceBindingSource1;
            this.comboBoxFindDevice.DisplayMember = "DAU_ID";
            this.comboBoxFindDevice.Enabled = false;
            this.comboBoxFindDevice.FormattingEnabled = true;
            this.comboBoxFindDevice.Location = new System.Drawing.Point(419, 28);
            this.comboBoxFindDevice.Name = "comboBoxFindDevice";
            this.comboBoxFindDevice.Size = new System.Drawing.Size(180, 28);
            this.comboBoxFindDevice.TabIndex = 11;
            this.comboBoxFindDevice.ValueMember = "DAU_ID";
            this.comboBoxFindDevice.SelectedIndexChanged += new System.EventHandler(this.comboBoxFindDevice_SelectedIndexChanged);
            // 
            // dAUFindDeviceBindingSource
            // 
            this.dAUFindDeviceBindingSource.DataMember = "DAUFindDevice";
            this.dAUFindDeviceBindingSource.DataSource = this.softSensConfDBDataSet;
            // 
            // dAUFindDeviceBindingSource1
            // 
            this.dAUFindDeviceBindingSource1.DataMember = "DAUFindDevice";
            this.dAUFindDeviceBindingSource1.DataSource = this.softSensConfDBDataSet;
            // 
            // TextBoxDAUDescription
            // 
            this.TextBoxDAUDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Description", true));
            this.TextBoxDAUDescription.Enabled = false;
            this.TextBoxDAUDescription.Location = new System.Drawing.Point(419, 335);
            this.TextBoxDAUDescription.Name = "TextBoxDAUDescription";
            this.TextBoxDAUDescription.Size = new System.Drawing.Size(180, 26);
            this.TextBoxDAUDescription.TabIndex = 7;
            // 
            // tabPageInstrument
            // 
            this.tabPageInstrument.AutoScroll = true;
            this.tabPageInstrument.Controls.Add(this.buttonInstCancel);
            this.tabPageInstrument.Controls.Add(this.buttonInstChange);
            this.tabPageInstrument.Controls.Add(this.labelFindinstrument);
            this.tabPageInstrument.Controls.Add(this.comboBoxFindInstrument);
            this.tabPageInstrument.Controls.Add(tagLabel);
            this.tabPageInstrument.Controls.Add(this.TextBoxTag);
            this.tabPageInstrument.Controls.Add(lRVLabel);
            this.tabPageInstrument.Controls.Add(this.TextBoxLRV);
            this.tabPageInstrument.Controls.Add(uRVLabel);
            this.tabPageInstrument.Controls.Add(this.TextBoxURV);
            this.tabPageInstrument.Controls.Add(alarm_LowLabel);
            this.tabPageInstrument.Controls.Add(this.TextBoxAlarm_Low);
            this.tabPageInstrument.Controls.Add(alarm_HighLabel);
            this.tabPageInstrument.Controls.Add(this.TextBoxAlarm_High);
            this.tabPageInstrument.Controls.Add(area_IDLabel1);
            this.tabPageInstrument.Controls.Add(this.TextBoxInstrumentAREAID);
            this.tabPageInstrument.Controls.Add(dAU_IDLabel2);
            this.tabPageInstrument.Controls.Add(this.TextBoxInstrumentDAUID);
            this.tabPageInstrument.Controls.Add(descriptionLabel1);
            this.tabPageInstrument.Controls.Add(this.TextBoxInstrumentDescription);
            this.tabPageInstrument.Controls.Add(unitLabel);
            this.tabPageInstrument.Controls.Add(this.TextBoxInstrumentUnit);
            this.tabPageInstrument.Controls.Add(typeLabel);
            this.tabPageInstrument.Controls.Add(this.TextBoxInstrumentType);
            this.tabPageInstrument.Controls.Add(manufacturerLabel);
            this.tabPageInstrument.Controls.Add(this.TextBoxInstrumentManufacturer);
            this.tabPageInstrument.Location = new System.Drawing.Point(4, 29);
            this.tabPageInstrument.Name = "tabPageInstrument";
            this.tabPageInstrument.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInstrument.Size = new System.Drawing.Size(924, 390);
            this.tabPageInstrument.TabIndex = 1;
            this.tabPageInstrument.Text = "Instrument";
            this.tabPageInstrument.UseVisualStyleBackColor = true;
            this.tabPageInstrument.Enter += new System.EventHandler(this.tabPageInstrument_Enter);
            // 
            // buttonInstCancel
            // 
            this.buttonInstCancel.Enabled = false;
            this.buttonInstCancel.Location = new System.Drawing.Point(276, 78);
            this.buttonInstCancel.Name = "buttonInstCancel";
            this.buttonInstCancel.Size = new System.Drawing.Size(96, 41);
            this.buttonInstCancel.TabIndex = 25;
            this.buttonInstCancel.Text = "Cancel";
            this.buttonInstCancel.UseVisualStyleBackColor = true;
            this.buttonInstCancel.Click += new System.EventHandler(this.buttonInstChange_Click);
            // 
            // buttonInstChange
            // 
            this.buttonInstChange.Location = new System.Drawing.Point(174, 78);
            this.buttonInstChange.Name = "buttonInstChange";
            this.buttonInstChange.Size = new System.Drawing.Size(96, 41);
            this.buttonInstChange.TabIndex = 24;
            this.buttonInstChange.Text = "Change";
            this.buttonInstChange.UseVisualStyleBackColor = true;
            this.buttonInstChange.Click += new System.EventHandler(this.buttonInstSelect_Click);
            // 
            // labelFindinstrument
            // 
            this.labelFindinstrument.AutoSize = true;
            this.labelFindinstrument.Location = new System.Drawing.Point(28, 34);
            this.labelFindinstrument.Name = "labelFindinstrument";
            this.labelFindinstrument.Size = new System.Drawing.Size(125, 20);
            this.labelFindinstrument.TabIndex = 23;
            this.labelFindinstrument.Text = "Find Instrument:";
            // 
            // comboBoxFindInstrument
            // 
            this.comboBoxFindInstrument.FormattingEnabled = true;
            this.comboBoxFindInstrument.Location = new System.Drawing.Point(174, 31);
            this.comboBoxFindInstrument.Name = "comboBoxFindInstrument";
            this.comboBoxFindInstrument.Size = new System.Drawing.Size(198, 28);
            this.comboBoxFindInstrument.TabIndex = 22;
            this.comboBoxFindInstrument.SelectedIndexChanged += new System.EventHandler(this.comboBoxFindInstrument_SelectedIndexChanged);
            // 
            // TextBoxTag
            // 
            this.TextBoxTag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentBindingSource, "Tag", true));
            this.TextBoxTag.Enabled = false;
            this.TextBoxTag.Location = new System.Drawing.Point(174, 167);
            this.TextBoxTag.Name = "TextBoxTag";
            this.TextBoxTag.Size = new System.Drawing.Size(198, 26);
            this.TextBoxTag.TabIndex = 1;
            // 
            // instrumentBindingSource
            // 
            this.instrumentBindingSource.DataMember = "Instrument";
            this.instrumentBindingSource.DataSource = this.softSensConfDBDataSet;
            // 
            // TextBoxLRV
            // 
            this.TextBoxLRV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentBindingSource, "LRV", true));
            this.TextBoxLRV.Enabled = false;
            this.TextBoxLRV.Location = new System.Drawing.Point(174, 199);
            this.TextBoxLRV.Name = "TextBoxLRV";
            this.TextBoxLRV.Size = new System.Drawing.Size(198, 26);
            this.TextBoxLRV.TabIndex = 3;
            // 
            // TextBoxURV
            // 
            this.TextBoxURV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentBindingSource, "URV", true));
            this.TextBoxURV.Enabled = false;
            this.TextBoxURV.Location = new System.Drawing.Point(174, 231);
            this.TextBoxURV.Name = "TextBoxURV";
            this.TextBoxURV.Size = new System.Drawing.Size(198, 26);
            this.TextBoxURV.TabIndex = 5;
            // 
            // TextBoxAlarm_Low
            // 
            this.TextBoxAlarm_Low.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentBindingSource, "Alarm_Low", true));
            this.TextBoxAlarm_Low.Enabled = false;
            this.TextBoxAlarm_Low.Location = new System.Drawing.Point(174, 263);
            this.TextBoxAlarm_Low.Name = "TextBoxAlarm_Low";
            this.TextBoxAlarm_Low.Size = new System.Drawing.Size(198, 26);
            this.TextBoxAlarm_Low.TabIndex = 7;
            // 
            // TextBoxAlarm_High
            // 
            this.TextBoxAlarm_High.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentBindingSource, "Alarm_High", true));
            this.TextBoxAlarm_High.Enabled = false;
            this.TextBoxAlarm_High.Location = new System.Drawing.Point(174, 295);
            this.TextBoxAlarm_High.Name = "TextBoxAlarm_High";
            this.TextBoxAlarm_High.Size = new System.Drawing.Size(198, 26);
            this.TextBoxAlarm_High.TabIndex = 9;
            // 
            // TextBoxInstrumentAREAID
            // 
            this.TextBoxInstrumentAREAID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentBindingSource, "Area_ID", true));
            this.TextBoxInstrumentAREAID.Enabled = false;
            this.TextBoxInstrumentAREAID.Location = new System.Drawing.Point(549, 136);
            this.TextBoxInstrumentAREAID.Name = "TextBoxInstrumentAREAID";
            this.TextBoxInstrumentAREAID.Size = new System.Drawing.Size(181, 26);
            this.TextBoxInstrumentAREAID.TabIndex = 11;
            // 
            // TextBoxInstrumentDAUID
            // 
            this.TextBoxInstrumentDAUID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentBindingSource, "DAU_ID", true));
            this.TextBoxInstrumentDAUID.Enabled = false;
            this.TextBoxInstrumentDAUID.Location = new System.Drawing.Point(549, 168);
            this.TextBoxInstrumentDAUID.Name = "TextBoxInstrumentDAUID";
            this.TextBoxInstrumentDAUID.Size = new System.Drawing.Size(181, 26);
            this.TextBoxInstrumentDAUID.TabIndex = 13;
            // 
            // TextBoxInstrumentDescription
            // 
            this.TextBoxInstrumentDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentBindingSource, "Description", true));
            this.TextBoxInstrumentDescription.Enabled = false;
            this.TextBoxInstrumentDescription.Location = new System.Drawing.Point(549, 200);
            this.TextBoxInstrumentDescription.Name = "TextBoxInstrumentDescription";
            this.TextBoxInstrumentDescription.Size = new System.Drawing.Size(181, 26);
            this.TextBoxInstrumentDescription.TabIndex = 15;
            // 
            // TextBoxInstrumentUnit
            // 
            this.TextBoxInstrumentUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentBindingSource, "Unit", true));
            this.TextBoxInstrumentUnit.Enabled = false;
            this.TextBoxInstrumentUnit.Location = new System.Drawing.Point(549, 232);
            this.TextBoxInstrumentUnit.Name = "TextBoxInstrumentUnit";
            this.TextBoxInstrumentUnit.Size = new System.Drawing.Size(181, 26);
            this.TextBoxInstrumentUnit.TabIndex = 17;
            // 
            // TextBoxInstrumentType
            // 
            this.TextBoxInstrumentType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentBindingSource, "Type", true));
            this.TextBoxInstrumentType.Enabled = false;
            this.TextBoxInstrumentType.Location = new System.Drawing.Point(549, 263);
            this.TextBoxInstrumentType.Name = "TextBoxInstrumentType";
            this.TextBoxInstrumentType.Size = new System.Drawing.Size(181, 26);
            this.TextBoxInstrumentType.TabIndex = 19;
            // 
            // TextBoxInstrumentManufacturer
            // 
            this.TextBoxInstrumentManufacturer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentBindingSource, "Manufacturer", true));
            this.TextBoxInstrumentManufacturer.Enabled = false;
            this.TextBoxInstrumentManufacturer.Location = new System.Drawing.Point(549, 295);
            this.TextBoxInstrumentManufacturer.Name = "TextBoxInstrumentManufacturer";
            this.TextBoxInstrumentManufacturer.Size = new System.Drawing.Size(181, 26);
            this.TextBoxInstrumentManufacturer.TabIndex = 21;
            // 
            // tabPageGrid
            // 
            this.tabPageGrid.Controls.Add(this.buttonInstrumentGrid);
            this.tabPageGrid.Controls.Add(this.buttonTypeGrid);
            this.tabPageGrid.Controls.Add(this.buttonManufacturerGrid);
            this.tabPageGrid.Controls.Add(this.buttonAreaGrid);
            this.tabPageGrid.Controls.Add(this.dataGridViewGridTables);
            this.tabPageGrid.Controls.Add(this.labelViewtablesGrid);
            this.tabPageGrid.Location = new System.Drawing.Point(4, 29);
            this.tabPageGrid.Name = "tabPageGrid";
            this.tabPageGrid.Size = new System.Drawing.Size(924, 390);
            this.tabPageGrid.TabIndex = 2;
            this.tabPageGrid.Text = "Grid";
            this.tabPageGrid.UseVisualStyleBackColor = true;
            // 
            // buttonInstrumentGrid
            // 
            this.buttonInstrumentGrid.Location = new System.Drawing.Point(32, 84);
            this.buttonInstrumentGrid.Name = "buttonInstrumentGrid";
            this.buttonInstrumentGrid.Size = new System.Drawing.Size(132, 38);
            this.buttonInstrumentGrid.TabIndex = 6;
            this.buttonInstrumentGrid.Text = "Instrument";
            this.buttonInstrumentGrid.UseVisualStyleBackColor = true;
            this.buttonInstrumentGrid.Click += new System.EventHandler(this.buttonInstrumentGrid_Click);
            // 
            // buttonTypeGrid
            // 
            this.buttonTypeGrid.Location = new System.Drawing.Point(32, 190);
            this.buttonTypeGrid.Name = "buttonTypeGrid";
            this.buttonTypeGrid.Size = new System.Drawing.Size(132, 38);
            this.buttonTypeGrid.TabIndex = 5;
            this.buttonTypeGrid.Text = "Type";
            this.buttonTypeGrid.UseVisualStyleBackColor = true;
            this.buttonTypeGrid.Click += new System.EventHandler(this.buttonTypeGrid_Click);
            // 
            // buttonManufacturerGrid
            // 
            this.buttonManufacturerGrid.Location = new System.Drawing.Point(32, 245);
            this.buttonManufacturerGrid.Name = "buttonManufacturerGrid";
            this.buttonManufacturerGrid.Size = new System.Drawing.Size(132, 38);
            this.buttonManufacturerGrid.TabIndex = 4;
            this.buttonManufacturerGrid.Text = "Manufacturer";
            this.buttonManufacturerGrid.UseVisualStyleBackColor = true;
            this.buttonManufacturerGrid.Click += new System.EventHandler(this.buttonManufacturerGrid_Click);
            // 
            // buttonAreaGrid
            // 
            this.buttonAreaGrid.Location = new System.Drawing.Point(32, 137);
            this.buttonAreaGrid.Name = "buttonAreaGrid";
            this.buttonAreaGrid.Size = new System.Drawing.Size(132, 38);
            this.buttonAreaGrid.TabIndex = 2;
            this.buttonAreaGrid.Text = "Area";
            this.buttonAreaGrid.UseVisualStyleBackColor = true;
            this.buttonAreaGrid.Click += new System.EventHandler(this.buttonAreaGrid_Click);
            // 
            // dataGridViewGridTables
            // 
            this.dataGridViewGridTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGridTables.Location = new System.Drawing.Point(223, 34);
            this.dataGridViewGridTables.Name = "dataGridViewGridTables";
            this.dataGridViewGridTables.RowHeadersWidth = 62;
            this.dataGridViewGridTables.RowTemplate.Height = 28;
            this.dataGridViewGridTables.Size = new System.Drawing.Size(282, 249);
            this.dataGridViewGridTables.TabIndex = 1;
            // 
            // labelViewtablesGrid
            // 
            this.labelViewtablesGrid.AutoSize = true;
            this.labelViewtablesGrid.Location = new System.Drawing.Point(28, 34);
            this.labelViewtablesGrid.Name = "labelViewtablesGrid";
            this.labelViewtablesGrid.Size = new System.Drawing.Size(98, 20);
            this.labelViewtablesGrid.TabIndex = 0;
            this.labelViewtablesGrid.Text = "View Tables:";
            // 
            // instrumentsToComboBoxBindingSource
            // 
            this.instrumentsToComboBoxBindingSource.DataMember = "InstrumentsToComboBox";
            this.instrumentsToComboBoxBindingSource.DataSource = this.softSensConfDBDataSet;
            // 
            // dAUTableAdapter
            // 
            this.dAUTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CommunicationTableAdapter = null;
            this.tableAdapterManager.DAUFindDeviceTableAdapter = null;
            this.tableAdapterManager.DAUTableAdapter = this.dAUTableAdapter;
            this.tableAdapterManager.Instrument_ManufactureTableAdapter = null;
            this.tableAdapterManager.Instrument_typeTableAdapter = null;
            this.tableAdapterManager.InstrumentsToComboBoxTableAdapter = null;
            this.tableAdapterManager.InstrumentTableAdapter = null;
            this.tableAdapterManager.Log_AI1TableAdapter = null;
            this.tableAdapterManager.Log_AO1TableAdapter = null;
            this.tableAdapterManager.Log_DI1TableAdapter = null;
            this.tableAdapterManager.Log_DO1TableAdapter = null;
            this.tableAdapterManager.MCUTableAdapter = null;
            this.tableAdapterManager.RDCChooseTableAdapter = null;
            this.tableAdapterManager.RDCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SoftSensConfE.SoftSensConfDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dAUFindDeviceTableAdapter
            // 
            this.dAUFindDeviceTableAdapter.ClearBeforeFill = true;
            // 
            // rDCTableAdapter
            // 
            this.rDCTableAdapter.ClearBeforeFill = true;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // communicationTableAdapter
            // 
            this.communicationTableAdapter.ClearBeforeFill = true;
            // 
            // instrumentTableAdapter
            // 
            this.instrumentTableAdapter.ClearBeforeFill = true;
            // 
            // instrumentsToComboBoxTableAdapter
            // 
            this.instrumentsToComboBoxTableAdapter.ClearBeforeFill = true;
            // 
            // rDCChooseTableAdapter
            // 
            this.rDCChooseTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 423);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftSensConfDB";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageDAU.ResumeLayout(false);
            this.tabPageDAU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rDCChooseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softSensConfDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUFindDeviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUFindDeviceBindingSource1)).EndInit();
            this.tabPageInstrument.ResumeLayout(false);
            this.tabPageInstrument.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentBindingSource)).EndInit();
            this.tabPageGrid.ResumeLayout(false);
            this.tabPageGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGridTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsToComboBoxBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SoftSensConfDBDataSet softSensConfDBDataSet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDAU;
        private System.Windows.Forms.TabPage tabPageInstrument;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource dAUBindingSource;
        private SoftSensConfDBDataSetTableAdapters.DAUTableAdapter dAUTableAdapter;
        private SoftSensConfDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox TextBoxDAUDescription;
        private System.Windows.Forms.ComboBox comboBoxFindDevice;
        private System.Windows.Forms.BindingSource dAUFindDeviceBindingSource;
        private SoftSensConfDBDataSetTableAdapters.DAUFindDeviceTableAdapter dAUFindDeviceTableAdapter;
        private System.Windows.Forms.BindingSource dAUFindDeviceBindingSource1;
        private System.Windows.Forms.ComboBox comboBoxComm;
        private System.Windows.Forms.ComboBox comboBoxAREAID;
        private System.Windows.Forms.ComboBox comboBoxRDCID;
        private System.Windows.Forms.BindingSource rDCBindingSource;
        private SoftSensConfDBDataSetTableAdapters.RDCTableAdapter rDCTableAdapter;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private SoftSensConfDBDataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private System.Windows.Forms.BindingSource communicationBindingSource;
        private SoftSensConfDBDataSetTableAdapters.CommunicationTableAdapter communicationTableAdapter;
        private System.Windows.Forms.Button buttonDAUNewData;
        private System.Windows.Forms.Button buttonDAUSaveData;
        private System.Windows.Forms.Button buttonDAUChangeData;
        private System.Windows.Forms.TextBox TextBoxDAUDeviceName;
        private System.Windows.Forms.Button buttonDAUCancelData;
        private System.Windows.Forms.BindingSource instrumentBindingSource;
        private SoftSensConfDBDataSetTableAdapters.InstrumentTableAdapter instrumentTableAdapter;
        private System.Windows.Forms.TextBox TextBoxTag;
        private System.Windows.Forms.TextBox TextBoxLRV;
        private System.Windows.Forms.TextBox TextBoxURV;
        private System.Windows.Forms.TextBox TextBoxAlarm_Low;
        private System.Windows.Forms.TextBox TextBoxAlarm_High;
        private System.Windows.Forms.TextBox TextBoxInstrumentAREAID;
        private System.Windows.Forms.TextBox TextBoxInstrumentDAUID;
        private System.Windows.Forms.TextBox TextBoxInstrumentDescription;
        private System.Windows.Forms.TextBox TextBoxInstrumentUnit;
        private System.Windows.Forms.TextBox TextBoxInstrumentType;
        private System.Windows.Forms.TextBox TextBoxInstrumentManufacturer;
        private System.Windows.Forms.ComboBox comboBoxFindInstrument;
        private System.Windows.Forms.BindingSource instrumentsToComboBoxBindingSource;
        private SoftSensConfDBDataSetTableAdapters.InstrumentsToComboBoxTableAdapter instrumentsToComboBoxTableAdapter;
        private System.Windows.Forms.Label labelFindinstrument;
        private System.Windows.Forms.Button buttonDAUChooseRDCDisconnect;
        private System.Windows.Forms.Button buttonDAUChooseRDCConnect;
        private System.Windows.Forms.ComboBox comboBoxDAUChooseRDC;
        private System.Windows.Forms.Label labelChooseRDC;
        private System.Windows.Forms.BindingSource rDCChooseBindingSource;
        private SoftSensConfDBDataSetTableAdapters.RDCChooseTableAdapter rDCChooseTableAdapter;
        private System.Windows.Forms.Button buttonInstCancel;
        private System.Windows.Forms.Button buttonInstChange;
        private System.Windows.Forms.Button buttonLog_aiSend;
        private System.Windows.Forms.TextBox textBoxLog_ai_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageGrid;
        private System.Windows.Forms.DataGridView dataGridViewGridTables;
        private System.Windows.Forms.Label labelViewtablesGrid;
        private System.Windows.Forms.Button buttonAreaGrid;
        private System.Windows.Forms.Button buttonInstrumentGrid;
        private System.Windows.Forms.Button buttonTypeGrid;
        private System.Windows.Forms.Button buttonManufacturerGrid;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace SoftSensConfE
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        string connectSoftSensConfDBConnectionString = ConfigurationManager.ConnectionStrings["SoftSensConfDBConnectionString"].ConnectionString;


        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'softSensConfDBDataSet.RDCChoose' table. You can move, or remove it, as needed.
            this.rDCChooseTableAdapter.Fill(this.softSensConfDBDataSet.RDCChoose);
            // TODO: This line of code loads data into the 'softSensConfDBDataSet.Instrument' table. You can move, or remove it, as needed.
            this.instrumentTableAdapter.Fill(this.softSensConfDBDataSet.Instrument);
            // TODO: This line of code loads data into the 'softSensConfDBDataSet.Communication' table. You can move, or remove it, as needed.
            this.communicationTableAdapter.Fill(this.softSensConfDBDataSet.Communication);
            // TODO: This line of code loads data into the 'softSensConfDBDataSet.Area' table. You can move, or remove it, as needed.
            this.areaTableAdapter.Fill(this.softSensConfDBDataSet.Area);
            // TODO: This line of code loads data into the 'softSensConfDBDataSet.RDC' table. You can move, or remove it, as needed.
            this.rDCTableAdapter.Fill(this.softSensConfDBDataSet.RDC);
            // TODO: This line of code loads data into the 'softSensConfDBDataSet.DAUFindDevice' table. You can move, or remove it, as needed.
            this.dAUFindDeviceTableAdapter.Fill(this.softSensConfDBDataSet.DAUFindDevice);
            // TODO: This line of code loads data into the 'softSensConfDBDataSet.DAU' table. You can move, or remove it, as needed.
            this.dAUTableAdapter.Fill(this.softSensConfDBDataSet.DAU);
        }

        private void comboBoxFindDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFindDevice.SelectedIndex > -1)
            {
                try
                {
                    string DAUIDfilter = comboBoxFindDevice.SelectedValue.ToString();
                    dAUTableAdapter.FillByDAUID(this.softSensConfDBDataSet.DAU, DAUIDfilter);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!" + ex);
                }

            }
        }

        private void buttonDAUChangeData_Click(object sender, EventArgs e)
        {
            TextBoxDAUDeviceName.Enabled = true;
            comboBoxAREAID.Enabled = true;
            comboBoxComm.Enabled = true;
            comboBoxRDCID.Enabled = true;
            TextBoxDAUDescription.Enabled = true;
            textBoxLog_ai_send.Enabled = false;

            buttonDAUSaveData.Enabled = true;
            buttonDAUNewData.Enabled = false;
            buttonDAUCancelData.Enabled = true;
            buttonDAUChangeData.Enabled = false;
            buttonLog_aiSend.Enabled = false;

            comboBoxFindDevice.Text = "";
            comboBoxFindDevice.Enabled = false;


        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            TextBoxDAUDeviceName.Enabled = false;
            comboBoxAREAID.Enabled = false;
            comboBoxComm.Enabled = false;
            comboBoxRDCID.Enabled = false;
            TextBoxDAUDescription.Enabled = false;

            buttonDAUChangeData.Enabled = true;
            buttonDAUNewData.Enabled = true;
            buttonDAUCancelData.Enabled = false;
            buttonDAUSaveData.Enabled = false;

            buttonLog_aiSend.Enabled = true;
            textBoxLog_ai_send.Enabled = true;

            dAUBindingSource.EndEdit();
            this.dAUTableAdapter.Update(this.softSensConfDBDataSet.DAU);

            comboBoxFindDevice.Enabled = true;
            this.dAUFindDeviceTableAdapter.Fill(this.softSensConfDBDataSet.DAUFindDevice);
            comboBoxFindDevice.Text = TextBoxDAUDeviceName.Text;


        }

        private void buttonNewData_Click(object sender, EventArgs e)
        {
            TextBoxDAUDeviceName.Enabled = true;
            comboBoxAREAID.Enabled = true;
            comboBoxComm.Enabled = true;
            comboBoxRDCID.Enabled = true;
            TextBoxDAUDescription.Enabled = true;

            buttonDAUSaveData.Enabled = true;
            buttonDAUChangeData.Enabled = false;
            buttonDAUCancelData.Enabled = true;
            buttonDAUNewData.Enabled = false;

            buttonLog_aiSend.Enabled = false;
            textBoxLog_ai_send.Enabled = false;

            comboBoxFindDevice.Text = "";
            comboBoxFindDevice.Enabled = false;

            dAUBindingSource.AddNew();
            dAUBindingSource.MoveLast();

        }

        private void buttonDAUCancelData_Click(object sender, EventArgs e)
        {
            TextBoxDAUDeviceName.Enabled = false;
            comboBoxAREAID.Enabled = false;
            comboBoxComm.Enabled = false;
            comboBoxRDCID.Enabled = false;
            TextBoxDAUDescription.Enabled = false;
            comboBoxFindDevice.Enabled = true;

            buttonDAUSaveData.Enabled = false;
            buttonDAUChangeData.Enabled = true;
            buttonDAUCancelData.Enabled = false;
            buttonDAUNewData.Enabled = true;

            buttonLog_aiSend.Enabled = true;
            textBoxLog_ai_send.Enabled = true;

            dAUBindingSource.CancelEdit();
            comboBoxFindDevice.Text = TextBoxDAUDeviceName.Text;
        }

        private void tabPageDAU_Enter(object sender, EventArgs e)
        {



            this.dAUFindDeviceTableAdapter.Fill(this.softSensConfDBDataSet.DAUFindDevice);

            comboBoxFindDevice.DisplayMember = "DAU_ID";
            comboBoxFindDevice.ValueMember = "DAU_ID";
            comboBoxFindDevice.DataSource = softSensConfDBDataSet.DAUFindDevice;
        }

        private void tabPageInstrument_Enter(object sender, EventArgs e)
        {
            string filterDAU = comboBoxFindDevice.SelectedValue.ToString();
            this.instrumentsToComboBoxTableAdapter.Fill(this.softSensConfDBDataSet.InstrumentsToComboBox, filterDAU);

            comboBoxFindInstrument.DisplayMember = "Tag";
            comboBoxFindInstrument.ValueMember = "Tag";
            comboBoxFindInstrument.DataSource = softSensConfDBDataSet.InstrumentsToComboBox;

        }

        private void comboBoxFindInstrument_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFindInstrument.SelectedIndex > -1)
            {
                try
                {
                    string Tagfilter = comboBoxFindInstrument.SelectedValue.ToString();
                    instrumentTableAdapter.FillBy(this.softSensConfDBDataSet.Instrument, Tagfilter);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!" + ex);
                }

            }
        }

        private void comboBoxDAUChooseRDC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDAUChooseRDC.SelectedIndex > -1)
            {
                try
                {
                    string filterRDC = comboBoxDAUChooseRDC.SelectedValue.ToString();
                    dAUFindDeviceTableAdapter.FillBy(this.softSensConfDBDataSet.DAUFindDevice, filterRDC);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!" + ex);
                }

            }
        }

        private void buttonDAUChooseRDCConnect_Click(object sender, EventArgs e)
        {
            buttonDAUChooseRDCConnect.Enabled = false;
            buttonDAUChooseRDCDisconnect.Enabled = true;

            buttonDAUNewData.Enabled = true;
            buttonDAUChangeData.Enabled = true;

            buttonLog_aiSend.Enabled = true;
            textBoxLog_ai_send.Enabled = true;

            comboBoxDAUChooseRDC.Enabled = false;
            comboBoxFindDevice.Enabled = true;


        }

        private void buttonDAUChooseRDCDisconnect_Click(object sender, EventArgs e)
        {
            buttonDAUChooseRDCConnect.Enabled = true;
            buttonDAUChooseRDCDisconnect.Enabled = false;

            buttonDAUNewData.Enabled = false;
            buttonDAUChangeData.Enabled = false;

            buttonLog_aiSend.Enabled = false;
            textBoxLog_ai_send.Enabled = false;

            comboBoxDAUChooseRDC.Enabled = true;
            comboBoxFindDevice.Enabled = false;
        }

        private void buttonInstSelect_Click(object sender, EventArgs e)
        {
            comboBoxFindInstrument.Enabled = false;
            TextBoxTag.Enabled = true;
            TextBoxLRV.Enabled = true;
            TextBoxURV.Enabled = true;
            TextBoxAlarm_Low.Enabled = true;
            TextBoxAlarm_High.Enabled = true;
            TextBoxInstrumentAREAID.Enabled = true;
            TextBoxInstrumentDAUID.Enabled = true;
            TextBoxInstrumentDescription.Enabled = true;
            TextBoxInstrumentManufacturer.Enabled = true;
            TextBoxInstrumentType.Enabled = true;
            TextBoxInstrumentUnit.Enabled = true;

            buttonInstCancel.Enabled = true;
            buttonInstChange.Enabled = false;

        }

        private void buttonInstChange_Click(object sender, EventArgs e)
        {
            comboBoxFindInstrument.Enabled = true;
            TextBoxTag.Enabled = false;
            TextBoxLRV.Enabled = false;
            TextBoxURV.Enabled = false;
            TextBoxAlarm_Low.Enabled = false;
            TextBoxAlarm_High.Enabled = false;
            TextBoxInstrumentAREAID.Enabled = false;
            TextBoxInstrumentDAUID.Enabled = false;
            TextBoxInstrumentDescription.Enabled = false;
            TextBoxInstrumentManufacturer.Enabled = false;
            TextBoxInstrumentType.Enabled = false;
            TextBoxInstrumentUnit.Enabled = false;

            buttonInstCancel.Enabled = false;
            buttonInstChange.Enabled = true;
        }
        /*
        private void buttonLog_aisave_Click(object sender, EventArgs e)
        {
            if (textBoxLog_ai_send.Text.Length > 0)
            {
                try
                {
                    SqlConnection connection = new SqlConnection(connectSoftSensConfDBConnectionString);

                    string sqlinsertquery = "INSERT INTO LOG_AI1 (Value, Tag) VALUES (@Value, @Tag)";
                    SqlCommand command = new SqlCommand(sqlinsertquery, connection);
                    command.Parameters.AddWithValue("@Value", textBoxLog_ai_send.Text);
                    command.Parameters.AddWithValue("@Tag", TextBoxTag.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error!" + err);
                }
                

            }
        }
        */

        private void ViewSqlResaultInDataGridView(string sqlQuery)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectSoftSensConfDBConnectionString);
                SqlDataAdapter sqlDataAdapter;
                DataTable resultDataTable;

                connection.Open();
                sqlDataAdapter = new SqlDataAdapter(sqlQuery, connection);
                resultDataTable = new DataTable();
                sqlDataAdapter.Fill(resultDataTable);
                dataGridViewGridTables.DataSource = resultDataTable;
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error!" + err);
            }
        }

        private void buttonAreaGrid_Click(object sender, EventArgs e)
        {
            string sqlSelectQuery = "SELECT City FROM Area ORDER BY City ASC";
            ViewSqlResaultInDataGridView(sqlSelectQuery);

        }

        private void buttonTypeGrid_Click(object sender, EventArgs e)
        {
            string sqlSelectQuery = "SELECT Type FROM Instrument type ORDER BY Type ASC";
            ViewSqlResaultInDataGridView(sqlSelectQuery);
        }

        private void buttonManufacturerGrid_Click(object sender, EventArgs e)
        {
            string sqlSelectQuery = "SELECT Manufacturer FROM Instrument Manufacture ORDER BY Manufacturer ASC";
            ViewSqlResaultInDataGridView(sqlSelectQuery);
        }

        private void buttonInstrumentGrid_Click(object sender, EventArgs e)
        {
            string sqlSelectQuery = "SELECT Tag FROM Instrument ORDER BY Tag ASC";
            ViewSqlResaultInDataGridView(sqlSelectQuery);
        }
    }

    /*
    public class Log_AO
    {
        private double span = 0.0;

        public double LRV { get; set; } = 0.0;
        public double URV { get; set } = 0.0;
        public double RawSignal { get; set; } = 0.0;

        public bool Milliamps { get; set; } = false;
        public double ScaledSignal { get; private set; }

        public double Span()
        {
            span = URV - LRV;
            return span;
        }
        
        Dette skal i "private void formain_load":
        Log_AO Lysmåling = new Log_AO;
        lysmåling.LRV = combobox.text; (convert?)
        lysmålingurv = combobox.text; (convert?)
        textbox.text = lysmåling.Span().tostring();
         
    }
    
    

    public class Log_DO
    {
        public bool state { get; set; } = false;

        
        Dette skal i "private void formain_load":
        Log_DO Lysmåling = new Log_DO();
        Lysmåling.tagname = comboBox.text;
        lysmåling.analog = false;
        lysmåling.state = true;
         
    }
    */

}

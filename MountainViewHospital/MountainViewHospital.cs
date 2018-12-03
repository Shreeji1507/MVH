using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MountainViewHospital
{
    public partial class MountainViewHospital : Form
    {
        public MountainViewHospital()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectTab(tabPatient);

           

            
        }

       
        
        /// <summary>
        /// The form load event for the RoomUtilization tab 
        /// </summary>
        /// <param name="sender"> sender object</param>
        /// <param name="e">event aguments</param>

        

        private void tabHome_Click(object sender, EventArgs e)
        {

        }

        
        

        private void tabReports_Click(object sender, EventArgs e)
        {

        }

        // dataset object for the rooms table
        private MVHRoomUtilizationDataSet roomUtilizationDataset;

        // table adapter objects hilsif 
        private MVHRoomUtilizationDataSetTableAdapters.spRoomUtilizationReportTableAdapter roomTableAdapter;

        private void RoomUtilizationReportViewer_Load(object sender, EventArgs e)
        {
            RoomUtilizationReport aRoomUtilizationReport = new RoomUtilizationReport();
            try
            {
                // instatiate the dataset and the table adapters
                roomUtilizationDataset = new MVHRoomUtilizationDataSet();
                roomTableAdapter = new MVHRoomUtilizationDataSetTableAdapters.spRoomUtilizationReportTableAdapter();
                //physicianTableAdapter = new MVCHDataSetTableAdapters.PhysicianTableAdapter();

                // fill the dataset using via the two table adapters
                // fill with customers and invoices
                roomTableAdapter.Fill(roomUtilizationDataset.spRoomUtilizationReport);
                // physicianTableAdapter.Fill(patientPhysicianDataset.Physician);

                // assign the filled dataset as the data source for the report
                aRoomUtilizationReport.SetDataSource(roomUtilizationDataset);

                // set up the report viewer object on the form to show runtime report object
                RoomUtilizationReportViewer.ReportSource = aRoomUtilizationReport;
            }
            // catch any exception thrwon during data object instantiation or report generation
            // display the exception message
            catch (Exception dataException)
            {
                MessageBox.Show("Data Error encounterd: " + dataException.Message.ToString());
            }
        }
    }
}

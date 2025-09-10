using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kaioordinate
{
    public partial class DataModule : Form
    {
        // declare datatable objects variable
        public DataTable dtLocation;
        public DataTable dtEvent;
        public DataTable dtEventRegister;
        public DataTable dtWhanau;
        public DataTable dtKai;
        //declare dataview objects variable
        public DataView locationView;
        public DataView eventView;
        public DataView eventRegisterView;
        public DataView whanauView;
        public DataView kaiView;



        public DataModule() // constructor
        {
            InitializeComponent();
            dsKaioordinate.EnforceConstraints = false; // remove sonstraint
            // fill data adapter
            daEvent.Fill(dsKaioordinate);
            daEventRegister.Fill(dsKaioordinate);
            daKai.Fill(dsKaioordinate);
            daLocation.Fill(dsKaioordinate);
            daWhanau.Fill(dsKaioordinate);
            // assign data for data table
            dtEvent = dsKaioordinate.Tables["EVENT"];
            dtEventRegister = dsKaioordinate.Tables["EVENTREGISTER"];
            dtKai = dsKaioordinate.Tables["KAI"];
            dtLocation = dsKaioordinate.Tables["LOCATION"];
            dtWhanau = dsKaioordinate.Tables["WHANAU"];
            // assign data for data view
            locationView = new DataView(dtLocation);
            eventView = new DataView(dtEvent);
            eventRegisterView = new DataView(dtEventRegister);
            whanauView = new DataView(dtWhanau);
            kaiView = new DataView(dtKai);
            // sort order for data view
            locationView.Sort = "LocationID";
            eventView.Sort = "EventID";
            eventRegisterView.Sort = "WhanauID";
            whanauView.Sort = "WhanauID";
            kaiView.Sort = "KaiID";
            // enforce constraint
            dsKaioordinate.EnforceConstraints = true;


        }
        public void updateKai() // update Kai table
        {
            daKai.Update(dtKai);
        }

        private void daKai_RowUpdated(object sender, OleDbRowUpdatedEventArgs e) // add new row to kai
        {

            // Include a variable and a command to retrieve 
            // the identity value from the Access database. 
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", oleDbConnection1);
            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the KaiID column. 
                newID = (int)idCMD.ExecuteScalar();
                e.Row["KaiID"] = newID;
            }
        }
        public void updateEvent() // update event table
        {
            daEvent.Update(dtEvent);
        }

        private void daEvent_RowUpdated(object sender, OleDbRowUpdatedEventArgs e) // add new row to event table
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", oleDbConnection1);
            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the EventID column. 
                newID = (int)idCMD.ExecuteScalar();
                e.Row["EventID"] = newID;
            }
        }
        public void updateLocation() // update location table
        {
            daLocation.Update(dtLocation);
        }

        private void daLocation_RowUpdated(object sender, OleDbRowUpdatedEventArgs e) // add new row to table location
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", oleDbConnection1);
            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the LocationID column. 
                newID = (int)idCMD.ExecuteScalar();
                e.Row["LocationID"] = newID;
            }

        }
        public void updateWhanau() // update whanau table
        {
            daWhanau.Update(dtWhanau);
        }

        private void daWhanau_RowUpdated(object sender, OleDbRowUpdatedEventArgs e) // add new row to whananu table
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", oleDbConnection1);
            if (e.StatementType == StatementType.Insert)
            {
                 
                newID = (int)idCMD.ExecuteScalar();
                e.Row["WhanauID"] = newID;
            }
        }
        public void updateEventRegister() // update event register table
        {
            daEventRegister.Update(dtEventRegister);
        }

        private void daEventRegister_RowUpdated(object sender, OleDbRowUpdatedEventArgs e) // update new row to event register table
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", oleDbConnection1);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["RegistrationID"] = newID;
            }
        }
    }
}

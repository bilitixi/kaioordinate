using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaioordinate
{
    public partial class registerMaintenanceForm : Form
    {
        // declare forms objects and currency manager 
        private DataModule DM;
        private mainForm mainForm;
        private CurrencyManager cmEvent;
        private CurrencyManager cmRegistration;
        private CurrencyManager cmWhanau;
       

        public registerMaintenanceForm(DataModule dm , mainForm mnu) // constructor
        {
            InitializeComponent();
            DM= dm;
            mainForm = mnu;
            cmEvent = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "EVENT"]; // bind event table
            cmWhanau = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "WHANAU"]; // bind whanau table
            cmRegistration = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "EVENT.EVENT_EVENTREGISTER"]; // bind event.Event_eventregister relattionship
            BindControls();



        }
        public void BindControls() // bindcontrols function
        {
            // set up datasource
            dgvEvents.DataSource = DM.dsKaioordinate; 
            dgvEvents.DataMember = "EVENT";

            dgvRegistration.DataSource = DM.dsKaioordinate;
            dgvRegistration.DataMember = "EVENT.EVENT_EVENTREGISTER";

            dgvWhanau.DataSource = DM.dsKaioordinate;
            dgvWhanau.DataMember = "WHANAU";
        }

        private void btnReturn_Click(object sender, EventArgs e) // return function
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) // add function
        {
            try // no constraint in the database relation
            {
                DataRow newEventRegister = DM.dtEventRegister.NewRow(); // create new data row
                //get uds
                int whanauID = Convert.ToInt32(dgvWhanau["WhanauID", cmWhanau.Position].Value); 
                int eventID = Convert.ToInt32(dgvEvents["EventID", cmEvent.Position].Value);
                
                if (IsDuplicate(whanauID, eventID)) // check duplicate
                {
                    MessageBox.Show("Whanau is already participated in this event, Please choose another whanau", "Error");

                }
                else // no duplicate
                {
                    newEventRegister["WhanauID"] = whanauID;
                    newEventRegister["EventID"] = eventID;
                    newEventRegister["KaiPreparation"] = checkBox.Checked;

                    DM.dsKaioordinate.Tables["EVENTREGISTER"].Rows.Add(newEventRegister);
                    DM.updateEventRegister(); // update event register table
                    MessageBox.Show("Whanau is added.", "Successful");
                }
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Whanau is already participated in the event.", "Error");

            }

        }
        private bool IsDuplicate(int whanauID, int eventID) // check duplicate function
        {
            foreach (DataRow row in DM.dtEventRegister.Rows)
            {
                if (Convert.ToInt32(row["WhanauID"]) == whanauID &&
                    Convert.ToInt32(row["EventID"]) == eventID &&
                    row.RowState != DataRowState.Deleted)  // Ignore deleted rows
                {
                    return true;
                }
            }
            return false;
        }




        private void btnDelete_Click(object sender, EventArgs e) //delete function
        {
            if (cmRegistration.Position < 0) // if the user do not select a registration
            {
                MessageBox.Show("Please select a registration", "Error");
                return;
            }

            DataRowView drv = (DataRowView)cmRegistration.Current; // get the current registration
            DataRow deleteEventRegister = drv.Row; // convert to the datarow 

            if (MessageBox.Show("Are you sure you want to delete this registration?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteEventRegister.Delete(); // delete the data row from the table
                DM.updateEventRegister();
                MessageBox.Show("Registration deleted successfully", "Acknowledgement", MessageBoxButtons.OK);
            }
        }


    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Kaioordinate
{
    public partial class kaiEventMaintenanceForm : Form
    {
        
        private string status = "Add"; // variable for status
        // declare form object
        private DataModule DM;
        private mainForm mainForm;
        private CurrencyManager currencyManager; // declare currency manager
        public kaiEventMaintenanceForm(DataModule dm, mainForm mainFrm) // form constructor
        {
            InitializeComponent();
            DM = dm;
            mainForm = mainFrm;
            BindControls(); // call bindcontrol function

        }
        public void BindControls() 
        {
            // bind textfields 
            txtID.DataBindings.Add("Text", DM.dsKaioordinate, "EVENT.EventID");
            txtEventName.DataBindings.Add("Text", DM.dsKaioordinate, "EVENT.EventName");
            txtLocation.DataBindings.Add("Text", DM.dsKaioordinate, "EVENT.LocationID");
            dtpDate.DataBindings.Add("Value", DM.dsKaioordinate, "EVENT.EventDate");

            pCboLocation.DataSource = DM.dsKaioordinate.Tables["LOCATION"];
            pCboLocation.DisplayMember = "LocationName";   // what the user sees
            pCboLocation.ValueMember = "LocationID";
            // Bind the SelectedValue of ComboBox to KAI.EventID
            pCboLocation.DataBindings.Add("SelectedValue", DM.dsKaioordinate, "EVENT.LocationID");


            lstEvent.DataSource = DM.dsKaioordinate;
            lstEvent.DisplayMember = "EVENT.EventName";
            lstEvent.ValueMember = "EVENT.EventName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "EVENT"];
        }

        private void btnAdd_Click(object sender, EventArgs e) // trigger add panel
        {
            // change status, load panel, clear fields
            status = "Add";
            panel.Visible = true;
            disableButton(false);
            clearField();
        }

        private void btnUpdate_Click(object sender, EventArgs e) // trigger update panel
        {
            // change status, load panel, clear fields
            status = "Update";
            panel.Visible = true;
            disableButton(false);
            //load data
            pTxtEventName.Text = txtEventName.Text;
            pDtpTime.Value = dtpDate.Value;

            

        }

        private void pBtnSave_Click(object sender, EventArgs e) // save function
        {
            // save button if status is add
            if (status == "Add")
            {
                DataRow newEvent = DM.dtEvent.NewRow();
                if ((pTxtEventName.Text == ""))
                {
                    MessageBox.Show("Please enter the Event Name");
                }
                else
                {
                    newEvent["EventName"] = pTxtEventName.Text;
                    newEvent["EventDate"] = dtpDate.Value;
                    newEvent["LocationID"] = Convert.ToInt32(pCboLocation.SelectedValue);
                    DM.dtEvent.Rows.Add(newEvent);
                    DM.updateEvent();
                    MessageBox.Show("Event added successfully", "Success");

                }

            }
            // save button if status is update
            else
            {

                DataRow updateEventRow = DM.dtEvent.Rows[currencyManager.Position];
                if (pTxtEventName.Text == "")
                {
                    MessageBox.Show("Please enter the Event Name ", "Error");
                }
                else
                {
                    updateEventRow["EventName"] = pTxtEventName.Text;
                    updateEventRow["EventDate"] = dtpDate.Value;
                    updateEventRow["LocationID"] = Convert.ToInt32(pCboLocation.SelectedValue);

                    currencyManager.EndCurrentEdit();
                    DM.updateEvent();
                    MessageBox.Show("Event updated successfully", "Success");
                }
            }

        }

        private void pBtnCancel_Click(object sender, EventArgs e) // cancel button
        {
            panel.Visible = false; // hide panel
            disableButton(true);
        }

        private void btnUp_Click(object sender, EventArgs e) // up button
        {
          
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnDown_Click(object sender, EventArgs e) // down button
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e) // return button
        {
            Close();
        }
        private void clearField() // clear text field
        {
            pTxtEventName.Text = "";

        }
        private void disableButton (bool status) // disable button function
        {
            btnAdd.Enabled = status;
            btnUpdate.Enabled = status;
            btnUp.Enabled = status;
            btnDown.Enabled = status;
            btnReturn.Enabled = status;
            btnDelete.Enabled = status;
        }

        private void btnDelete_Click(object sender, EventArgs e) // delete function
        {
            DataRow deleteEventRow = DM.dtEvent.Rows[currencyManager.Position];
            DataRow[] eventKai = DM.dtKai.Select("EventID = " + deleteEventRow["EventID"].ToString()); // retrieve kai assign for the event
            if (eventKai.Length == 0) // if no kai assign for the event
            {
                if (MessageBox.Show("Are you sure you want to delete this event?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteEventRow.Delete();
                    DM.updateEvent();
                }
            }
            else // kai assigns for the event
            {
                MessageBox.Show("You may only delete an event that has no kai", "Error");
            }
        }
    }
}

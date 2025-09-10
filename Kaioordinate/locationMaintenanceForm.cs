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
    public partial class locationMaintenanceForm : Form
    {
        
        private string status = "Add"; // status variable
        // declare forms objects
        private DataModule DM;
        private mainForm mainForm;
        private CurrencyManager currencyManager; // declare currrency manager
        public locationMaintenanceForm(DataModule dm, mainForm mainFrm) // constructor
        {
            InitializeComponent();
            DM = dm;
            mainForm = mainFrm;

            BindControls();  // call bindcontrol function


        }

        public void BindControls()
        {
            // bind textfields with location
            txtID.DataBindings.Add("Text", DM.dsKaioordinate, "LOCATION.LocationID");
            txtName.DataBindings.Add("Text", DM.dsKaioordinate, "LOCATION.LocationName");
            txtAddress.DataBindings.Add("Text", DM.dsKaioordinate, "LOCATION.Address");

            

            //  bind listLocation
            lstLocation.DataSource = DM.dsKaioordinate;
            lstLocation.DisplayMember = "LOCATION.LocationName";
            lstLocation.ValueMember = "LOCATION.LocationName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "LOCATION"]; // currency manager for the selected item in the lst location

           
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

        private void btnUpdate_Click(object sender, EventArgs e) // trigger update panel
        {
            // change status, load panel, clear fields
            status = "Update";
            panel.Visible = true;
            disableButton(false);
            //show ID
            pTxtLocationID.Visible = true;
            lblLocationID.Visible = true;
            //load data
            pTxtAddress.Text = txtAddress.Text;
            pTxtLocationID.Text = txtID.Text;
            pTxtLocationName.Text = txtName.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e) // trigger add panel
        {
            // change status, load panel, clear fields
            status = "Add";
            panel.Visible = true;
            // hide location details
            pTxtLocationID.Visible = false;
            lblLocationID.Visible = false;
            disableButton(false);
            clearField();
        }
        private void clearField() // clear text field
        {
            pTxtAddress.Text = "";
            pTxtLocationName.Text = "";

        }
        private void disableButton(bool status) //disable buttons
        {
            btnAdd.Enabled = status;
            btnUpdate.Enabled = status;
            btnUp.Enabled = status;
            btnDown.Enabled = status;
            btnReturn.Enabled = status;
            btnDelete.Enabled = status;
        }

        private void pBtnCancel_Click(object sender, EventArgs e) // disable panel visibility
        {
            panel.Visible = false;
            disableButton(true);
        }

        private void pBtnSave_Click(object sender, EventArgs e) // save function
        {
            // save button if status is add
            if (status == "Add")
            {
                DataRow newLocation = DM.dtLocation.NewRow(); // get new row
                if ((pTxtLocationName.Text == "") || (pTxtAddress.Text == "")) // if the field is blank
                {
                    MessageBox.Show("Please enter the the address and location name");
                }
                else // if the field is not blank
                {
                    newLocation["LocationName"] = pTxtLocationName.Text;
                    newLocation["Address"] = pTxtAddress.Text;
                    DM.dtLocation.Rows.Add(newLocation);
                    DM.updateLocation();
                    MessageBox.Show("Event added successfully", "Success");

                }

            }
            // save button if status is update
            else
            {

                DataRow updateLocationRow = DM.dtLocation.Rows[currencyManager.Position];
                if ((pTxtLocationName.Text == "") || (pTxtAddress.Text == "")) // blank field
                {
                    MessageBox.Show("You must type in the location name and address  ", "Error");
                }
                else // field not blank
                {
                    updateLocationRow["LocationName"] = pTxtLocationName.Text;
                    updateLocationRow["Address"] = pTxtAddress.Text;
                    

                    currencyManager.EndCurrentEdit();
                    DM.updateEvent();
                    MessageBox.Show("Event updated successfully", "Success");
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e) // delete location
        {
            DataRow deleteLocationRow = DM.dtLocation.Rows[currencyManager.Position];
            DataRow[] locationEvent = DM.dtEvent.Select("LocationID =" + deleteLocationRow["locationID"].ToString()); // retrieve events assign to location
            if (locationEvent.Length == 0) // if no events
            {
                if (MessageBox.Show("Are you sure you want to delete this location?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteLocationRow.Delete();
                    DM.updateLocation();
                }
            }
            else // if there is event
            {
                MessageBox.Show("You may only delete locations that have no events", "Error");

            }
        }
    }
}

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
        private string status = "Add";
        private DataModule DM;
        private mainForm mainForm;
        private CurrencyManager currencyManager;
        public locationMaintenanceForm(DataModule dm, mainForm mainFrm)
        {
            InitializeComponent();
            DM = dm;
            mainForm = mainFrm;

            BindControls();


        }
        public void BindControls()
        {
            txtID.DataBindings.Add("Text", DM.dsKaioordinate, "LOCATION.LocationID");
            txtName.DataBindings.Add("Text", DM.dsKaioordinate, "LOCATION.LocationName");
            txtAddress.DataBindings.Add("Text", DM.dsKaioordinate, "LOCATION.Address");

            


            lstLocation.DataSource = DM.dsKaioordinate;
            lstLocation.DisplayMember = "LOCATION.LocationName";
            lstLocation.ValueMember = "LOCATION.LocationName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "LOCATION"];

           
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }

        }

        private void btnDown_Click(object sender, EventArgs e)
        {

            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
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
        private void clearField()
        {
            pTxtAddress.Text = "";
            pTxtLocationName.Text = "";

        }
        private void disableButton(bool status)
        {
            btnAdd.Enabled = status;
            btnUpdate.Enabled = status;
            btnUp.Enabled = status;
            btnDown.Enabled = status;
            btnReturn.Enabled = status;
            btnDelete.Enabled = status;
        }

        private void pBtnCancel_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            disableButton(true);
        }

        private void pBtnSave_Click(object sender, EventArgs e)
        {
            // save button if status is add
            if (status == "Add")
            {
                DataRow newLocation = DM.dtLocation.NewRow();
                if ((pTxtLocationName.Text == "") || (pTxtAddress.Text == ""))
                {
                    MessageBox.Show("Please enter the the address and location name");
                }
                else
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
                if ((pTxtLocationName.Text == "") || (pTxtAddress.Text == ""))
                {
                    MessageBox.Show("You must type in the location name and address  ", "Error");
                }
                else
                {
                    updateLocationRow["LocationName"] = pTxtLocationName.Text;
                    updateLocationRow["Address"] = pTxtAddress.Text;
                    

                    currencyManager.EndCurrentEdit();
                    DM.updateEvent();
                    MessageBox.Show("Event updated successfully", "Success");
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteLocationRow = DM.dtLocation.Rows[currencyManager.Position];
            if (MessageBox.Show("Are you sure you want to delete this location?", "Warning",
            MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteLocationRow.Delete();
                DM.updateLocation();
            }
        }
    }
}

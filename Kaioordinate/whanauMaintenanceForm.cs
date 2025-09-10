using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kaioordinate
{
    public partial class whanauMaintenanceForm : Form
    {
        private string status = "Add"; // status variable
        // declare forms objects and currency manager
        private DataModule DM;
        private mainForm mainForm;
        private CurrencyManager currencyManager;
        public whanauMaintenanceForm(DataModule dm, mainForm mainFrm) // constructor
        {
            InitializeComponent();
            DM = dm;
            mainForm = mainFrm;
            BindControls();

        }
        public void BindControls() // bindcontrols function
        {
            // bind data to textfields
            txtID.DataBindings.Add("Text", DM.dsKaioordinate.Tables["WHANAU"], "WhanauID");
            txtAddress.DataBindings.Add("Text", DM.dsKaioordinate.Tables["WHANAU"], "Address");
            txtEmail.DataBindings.Add("Text", DM.dsKaioordinate.Tables["WHANAU"], "Email");
            txtFirstname.DataBindings.Add("Text", DM.dsKaioordinate.Tables["WHANAU"], "Firstname");
            txtLastname.DataBindings.Add("Text", DM.dsKaioordinate.Tables["WHANAU"], "Lastname");
            txtPhone.DataBindings.Add("Text", DM.dsKaioordinate.Tables["WHANAU"], "Phone");

            // add full name column
            if (!DM.dsKaioordinate.Tables["WHANAU"].Columns.Contains("FullName"))
            {
                DM.dsKaioordinate.Tables["WHANAU"].Columns.Add("FullName", typeof(string), "Firstname + ' ' + Lastname");
            }
            // display full name in the list
            lstWhanau.DataSource = DM.dsKaioordinate.Tables["WHANAU"];
            lstWhanau.DisplayMember = "FullName";
            lstWhanau.ValueMember = "WhanauID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate.Tables["WHANAU"]]; // selected item in the list box


        }

        private void btnUp_Click(object sender, EventArgs e) // up button
        {
            if (currencyManager.Position > 0) // not the last item
            {
                --currencyManager.Position;
            }
        }

        private void btnDown_Click(object sender, EventArgs e) // down button
        {
            if (currencyManager.Position < currencyManager.Count - 1) // not the final item
            {
                ++currencyManager.Position;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e) // close function
        {
            Close();
        }

        private void pBtnSave_Click(object sender, EventArgs e) // save function
        {
            // save button if status is add
            if (status == "Add")
            {
                DataRow newWhanau = DM.dtWhanau.NewRow();
                if ((pTxtAddress.Text == "") || (pTxtFirstName.Text == "") || (pTxtLastname.Text == "") || (pTxtEmail.Text == "") || (pTxtPhone.Text == "")) // if blanks fields
                {
                    MessageBox.Show("Please complete the missing fields");
                }
                else // if fields are not blank
                {
                    newWhanau["Firstname"] = pTxtFirstName.Text;
                    newWhanau["Lastname"] = pTxtLastname.Text;
                    newWhanau["Address"] = pTxtAddress.Text;
                    newWhanau["Phone"] = pTxtPhone.Text;
                    newWhanau["Email"] = pTxtEmail.Text;

                    DM.dtWhanau.Rows.Add(newWhanau); // add new row
                    DM.updateWhanau(); // update table
                    MessageBox.Show("Whanau added successfully", "Success");

                }

            }
            // save button if status is update
            else
            {

                DataRow updateWhanauRow = DM.dtWhanau.Rows[currencyManager.Position];
                if ((pTxtAddress.Text == "") || (pTxtFirstName.Text == "") || (pTxtLastname.Text == "") || (pTxtEmail.Text == "") || (pTxtPhone.Text == "")) // fields are blank
                {
                    MessageBox.Show("You must complete all missing fields  ", "Error");
                }
                else // fields are not blank
                {
                    updateWhanauRow["Firstname"] = pTxtFirstName.Text;
                    updateWhanauRow["Lastname"] = pTxtLastname.Text;
                    updateWhanauRow["Address"] = pTxtAddress.Text;
                    updateWhanauRow["Phone"] = pTxtPhone.Text;
                    updateWhanauRow["Email"] = pTxtEmail.Text;


                    currencyManager.EndCurrentEdit();
                    DM.updateWhanau();
                    MessageBox.Show("Whanau updated successfully", "Success");
                }
            }
        }

        private void pBtnCancel_Click(object sender, EventArgs e) // cancel button
        {
            panel.Visible = false;
            disableButton(true);
        }

        private void btnAdd_Click(object sender, EventArgs e) // trigger the add panel
        {
            // change status, load panel, clear fields
            status = "Add";
            panel.Visible = true;
            disableButton(false);
            //empty fields
            clearField();

        }

        private void btnUpdate_Click(object sender, EventArgs e) // trigger the update panel
        {
            // change status, load panel, clear fields
            status = "Update";
            panel.Visible = true;
            disableButton(false);
          
            //load data
            pTxtAddress.Text = txtAddress.Text;
            pTxtEmail.Text = txtEmail.Text;
            pTxtFirstName.Text = txtFirstname.Text;
            pTxtLastname.Text = txtLastname.Text;
            pTxtPhone.Text = txtPhone.Text;
            

        }

        private void btnDelete_Click(object sender, EventArgs e) // delete function
        {

            DataRow deleteWhanauRow = DM.dtWhanau.Rows[currencyManager.Position];
            DataRow[] whannauRegistration = DM.dtEventRegister.Select("WhanauID =" + deleteWhanauRow["WhanauID"].ToString()); // find registrations of the whanau
            if (whannauRegistration.Length == 0) // no registration
            {
                if (MessageBox.Show("Are you sure you want to delete this whanau?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteWhanauRow.Delete();
                    DM.updateWhanau();
                }
              
            }
            else // there is registration
            {
                MessageBox.Show("You may only delete records that have no registration", "Error");
            }

        }
        private void disableButton(bool status) // disable button function
        {
            btnAdd.Enabled = status;
            btnUpdate.Enabled = status;
            btnUp.Enabled = status;
            btnDown.Enabled = status;
            btnReturn.Enabled = status;
            btnDelete.Enabled = status;
        }
        private void clearField() // clear fields function
        {
            pTxtAddress.Text = "";
            pTxtEmail.Text = "";
            pTxtFirstName.Text = "";
            pTxtLastname.Text = "";
            pTxtPhone.Text = "";

        }
    }
}

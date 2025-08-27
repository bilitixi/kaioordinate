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
        private string status = "Add";
        private DataModule DM;
        private mainForm mainForm;
        private CurrencyManager currencyManager;
        public whanauMaintenanceForm(DataModule dm, mainForm mainFrm)
        {
            InitializeComponent();
            DM = dm;
            mainForm = mainFrm;
            BindControls();

        }
        public void BindControls()
        {
            txtID.DataBindings.Add("Text", DM.dsKaioordinate.Tables["WHANAU"], "WhanauID");
            txtAddress.DataBindings.Add("Text", DM.dsKaioordinate.Tables["WHANAU"], "Address");
            txtEmail.DataBindings.Add("Text", DM.dsKaioordinate.Tables["WHANAU"], "Email");
            txtFirstname.DataBindings.Add("Text", DM.dsKaioordinate.Tables["WHANAU"], "Firstname");
            txtLastname.DataBindings.Add("Text", DM.dsKaioordinate.Tables["WHANAU"], "Lastname");
            txtPhone.DataBindings.Add("Text", DM.dsKaioordinate.Tables["WHANAU"], "Phone");


            if (!DM.dsKaioordinate.Tables["WHANAU"].Columns.Contains("FullName"))
            {
                DM.dsKaioordinate.Tables["WHANAU"].Columns.Add("FullName", typeof(string), "Firstname + ' ' + Lastname");
            }

            lstWhanau.DataSource = DM.dsKaioordinate.Tables["WHANAU"];
            lstWhanau.DisplayMember = "FullName";
            lstWhanau.ValueMember = "WhanauID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate.Tables["WHANAU"]];


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

        private void pBtnSave_Click(object sender, EventArgs e)
        {
            // save button if status is add
            if (status == "Add")
            {
                DataRow newWhanau = DM.dtWhanau.NewRow();
                if ((pTxtAddress.Text == "") || (pTxtFirstName.Text == "") || (pTxtLastname.Text == "") || (pTxtEmail.Text == "") || (pTxtPhone.Text == ""))
                {
                    MessageBox.Show("Please complete the missing fields");
                }
                else
                {
                    newWhanau["Firstname"] = pTxtFirstName.Text;
                    newWhanau["Lastname"] = pTxtLastname.Text;
                    newWhanau["Address"] = pTxtAddress.Text;
                    newWhanau["Phone"] = pTxtPhone.Text;
                    newWhanau["Email"] = pTxtEmail.Text;

                    DM.dtWhanau.Rows.Add(newWhanau);
                    DM.updateWhanau();
                    MessageBox.Show("Whanau added successfully", "Success");

                }

            }
            // save button if status is update
            else
            {

                DataRow updateWhanauRow = DM.dtWhanau.Rows[currencyManager.Position];
                if ((pTxtAddress.Text == "") || (pTxtFirstName.Text == "") || (pTxtLastname.Text == "") || (pTxtEmail.Text == "") || (pTxtPhone.Text == ""))
                {
                    MessageBox.Show("You must complete all missing fields  ", "Error");
                }
                else
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

        private void pBtnCancel_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            disableButton(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // change status, load panel, clear fields
            status = "Add";
            panel.Visible = true;
            disableButton(false);
            //empty fields
            clearField();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DataRow deleteWhanauRow = DM.dtWhanau.Rows[currencyManager.Position];
            if (MessageBox.Show("Are you sure you want to delete this whanau?", "Warning",
            MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteWhanauRow.Delete();
                DM.updateWhanau();
            }

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
        private void clearField()
        {
            pTxtAddress.Text = "";
            pTxtEmail.Text = "";
            pTxtFirstName.Text = "";
            pTxtLastname.Text = "";
            pTxtPhone.Text = "";

        }
    }
}

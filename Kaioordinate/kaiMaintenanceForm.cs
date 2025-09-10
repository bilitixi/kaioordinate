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
    public partial class kaiMaintenanceForm : Form
    {
        private string status = "Add"; // variable for status
        // declare forms variable
        private DataModule DM;
        private mainForm mainForm;
        // declare currency manager variable
        private CurrencyManager currencyManager;
        public kaiMaintenanceForm(DataModule dm, mainForm mainFrm) // constructor
        {

            InitializeComponent();
            DM = dm;
            mainForm = mainFrm;
            BindControls(); // call bindcontrol function

        }
        public void BindControls() // bind data to text field

        {
            txtID.DataBindings.Add("Text", DM.dsKaioordinate, "KAI.KaiID");
            txtFoodName.DataBindings.Add("Text", DM.dsKaioordinate, "KAI.KaiName");
            nudTime.DataBindings.Add("Text", DM.dsKaioordinate, "KAI.PreparationMinutes");
            nudQuantity.DataBindings.Add("Text", DM.dsKaioordinate, "KAI.ServeQuantity");
            txtStatus.DataBindings.Add("Text", DM.dsKaioordinate, "KAI.PreparationRequired");

            // Bind the SelectedValue of ComboBox to KAI.EventID
            cboEventName.DataBindings.Add("SelectedValue", DM.dsKaioordinate, "KAI.EventID");
            cboEventName.DisplayMember = "EventName";      // What user sees
            cboEventName.ValueMember = "EventID";          // The foreign key stored in KAI
            cboEventName.DataSource = DM.dsKaioordinate.Tables["EVENT"]; // Event table

           
          
           
            // data source for list box
            lstFood.DataSource = DM.dsKaioordinate;
            lstFood.DisplayMember = "KAI.KaiName";
            lstFood.ValueMember = "KAI.KaiName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "KAI"]; // currency manager for selected item in the list box
        }
        private void btnPrevious_Click(object sender, EventArgs e) // previous button
        {
            if (currencyManager.Position > 0) 
            {
                --currencyManager.Position; // decrease currency manager
            }
        }
        private void btnNext_Click(object sender, EventArgs e) // next button
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position; // increase currency manager
            }
        }
        private void btnReturn_Click(object sender, EventArgs e) // close form
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) // triigger add panel
        {
            // change status, load panel, clear fields
            status = "Add"; // set the status
            panel.Visible = true; // display panel
            // null event initialy
            pCboEvent.SelectedIndex = -1;
           
            pCboEvent.Text = " ";
            disableButton(false);
            clearField();

        }
        

        private void pBtnSave_Click(object sender, EventArgs e) // click save button
        {
            // save button if status is add
            if (status == "Add")
            {
                DataRow newKai = DM.dtKai.NewRow();
                if ((pTxtName.Text == "")) // if text field is blank
                {
                    MessageBox.Show("Please enter the Kai Name");
                }
                else if (pCboEvent.SelectedIndex == -1)  // combo box is not selected
                {
                    newKai["KaiName"] = pTxtName.Text;
                    newKai["PreparationRequired"] = pCheckBox.Checked;
                    newKai["PreparationMinutes"] = pNudTime.Value;
                    newKai["ServeQuantity"] = pNudQuantity.Value;
                    newKai["EventID"] = DBNull.Value;
                    DM.dtKai.Rows.Add(newKai); // add new row
                    DM.updateKai(); // call update function
                    MessageBox.Show("Kai maintenance added successfully", "Success"); // display message


                }
                
                else // combobox is selected
                {

                    newKai["KaiName"] = pTxtName.Text;
                    newKai["PreparationRequired"]=  pCheckBox.Checked;
                    newKai["PreparationMinutes"] = pNudTime.Value;
                    newKai["ServeQuantity"] = pNudQuantity.Value;
                    newKai["EventID"] = Convert.ToInt32(pCboEvent.SelectedValue);
                    DM.dtKai.Rows.Add(newKai);
                    DM.updateKai();
                    MessageBox.Show("Kai maintenance added successfully", "Success"); //display message

                }

            }
            // save button if status is update
            else
            {

                DataRow updateKaiRow = DM.dtKai.Rows[currencyManager.Position];
                if (pTxtName.Text == "") // if there is blank field
                {
                    MessageBox.Show("You must type in a kai name ", "Error");
                }
                else // there is no blank field
                {
                    // get data to update
                     updateKaiRow["KaiName"] = pTxtName.Text;
                     updateKaiRow["PreparationRequired"] = pCheckBox.Checked;
                     updateKaiRow["PreparationMinutes"] = pNudTime.Value;
                     updateKaiRow["ServeQuantity"] = pNudQuantity.Value;
                     updateKaiRow["EventID"] = Convert.ToInt32(pCboEvent.SelectedValue);

                    currencyManager.EndCurrentEdit(); // update datasource
                    DM.updateKai();
                    MessageBox.Show($"Kai maintenance updated successfully ", "Success");
                }
            }
            // clear bindings
            pCboEvent.DataBindings.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e) // trigger update panel
        {
            //show panel, change status
            status = "Update";
            panel.Visible = true;
            disableButton(false);

  
            //load data
            pTxtName.Text = txtFoodName.Text;
            pCboEvent.Text = cboEventName.Text;
            pNudQuantity.Value = nudQuantity.Value;
            pNudTime.Value = nudTime.Value;
            pCheckBox.Checked = Convert.ToBoolean(txtStatus.Text);
        }

        private void pBtnCancel_Click(object sender, EventArgs e) // cancel button
        {
            panel.Visible = false; // hides the visibility
            // clear bindings of combo box
            pCboEvent.DataBindings.Clear(); 
            cboEventName.DataBindings.Clear();
            disableButton(true);
        }
        private void clearField() // reset field
        {
            pTxtName.Text = "";
            pNudQuantity.Value = 0;
            pNudTime.Value = 0;
            pCheckBox.Checked = false;
        }
        private void disableButton(bool status) // function to disable button
        {
            btnAdd.Enabled = status;
            btnUpdate.Enabled = status;
            btnUp.Enabled = status;
            btnDown.Enabled = status;
            btnReturn.Enabled = status;
            btnDelete.Enabled = status;
        }

        private void btnDeleteKai_Click(object sender, EventArgs e) // delete kai
        {
            DataRow deleteKaiRow = DM.dtKai.Rows[currencyManager.Position];
            if (Convert.IsDBNull(deleteKaiRow["EventID"])) // if event id of the record is null
            {
               
                if (MessageBox.Show("Are you sure you want to delete this ?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteKaiRow.Delete();
                    DM.updateKai();
                }
            }
            else // if event id is not null
            {
                MessageBox.Show("You may only delete a kai that has no event relation","Error");
            }
          
        }

        private void pCboEvent_Click(object sender, EventArgs e) // load data for the combo box
        {
            // bind combo box to the table
            pCboEvent.DataBindings.Add("SelectedValue", DM.dsKaioordinate, "KAI.EventID");
            pCboEvent.DataSource = DM.dsKaioordinate.Tables["EVENT"];
            pCboEvent.DisplayMember = "EventName";   // what the user sees
            pCboEvent.ValueMember = "EventID";
           
        }
    }
}

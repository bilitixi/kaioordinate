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
        private string status = "Add";
        private DataModule DM;
        private mainForm mainForm;
        private CurrencyManager currencyManager;
        public kaiMaintenanceForm(DataModule dm, mainForm mainFrm)
        {

            InitializeComponent();
            DM = dm;
            mainForm = mainFrm;
            BindControls();

        }
        public void BindControls()

        {
            txtID.DataBindings.Add("Text", DM.dsKaioordinate, "KAI.KaiID");
            txtFoodName.DataBindings.Add("Text", DM.dsKaioordinate, "KAI.KaiName");
            nudTime.DataBindings.Add("Text", DM.dsKaioordinate, "KAI.PreparationMinutes");
            nudQuantity.DataBindings.Add("Text", DM.dsKaioordinate, "KAI.ServeQuantity");
            txtStatus.DataBindings.Add("Text", DM.dsKaioordinate, "KAI.PreparationRequired");
            cboEventName.DisplayMember = "EventName";      // What user sees
            cboEventName.ValueMember = "EventID";          // The foreign key stored in KAI
            cboEventName.DataSource = DM.dsKaioordinate.Tables["EVENT"]; // Event table

            // Bind the SelectedValue of ComboBox to KAI.EventID
            cboEventName.DataBindings.Add("SelectedValue", DM.dsKaioordinate, "KAI.EventID");

            pCboEvent.DataSource = DM.dsKaioordinate.Tables["EVENT"];
            pCboEvent.DisplayMember = "EventName";   // what the user sees
            pCboEvent.ValueMember = "EventID";

            lstFood.DataSource = DM.dsKaioordinate;
            lstFood.DisplayMember = "KAI.KaiName";
            lstFood.ValueMember = "KAI.KaiName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "KAI"];
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // change status, load panel, clear fields
            status = "Add";
            panel.Visible = true;
            clearField();

        }
        

        private void pBtnSave_Click(object sender, EventArgs e)
        {
            // save button if status is add
            if (status == "Add")
            {
                DataRow newKai = DM.dtKai.NewRow();
                if ((pTxtName.Text == ""))
                {
                    MessageBox.Show("Please enter the Kai Name");
                }
                else
                {
                    newKai["KaiName"] = pTxtName.Text;
                    newKai["PreparationRequired"]=  pCheckBox.Checked;
                    newKai["PreparationMinutes"] = pNudTime.Value;
                    newKai["ServeQuantity"] = pNudQuantity.Value;
                    newKai["EventID"] = Convert.ToInt32(pCboEvent.SelectedValue);
                    DM.dtKai.Rows.Add(newKai);
                    DM.updateKai();
                    MessageBox.Show("Kai maintenance added successfully", "Success");

                }

            }
            // save button if status is update
            else
            {

                DataRow updateKaiRow = DM.dtKai.Rows[currencyManager.Position];
                if (pTxtName.Text == "")
                {
                    MessageBox.Show("You must type in a kai name ", "Error");
                }
                else
                {
                     updateKaiRow["KaiName"] = pTxtName.Text;
                     updateKaiRow["PreparationRequired"] = pCheckBox.Checked;
                     updateKaiRow["PreparationMinutes"] = pNudTime.Value;
                     updateKaiRow["ServeQuantity"] = pNudQuantity.Value;
                     updateKaiRow["EventID"] = Convert.ToInt32(pCboEvent.SelectedValue);

                    currencyManager.EndCurrentEdit();
                    DM.updateKai();
                    MessageBox.Show("Kai maintenance updated successfully", "Success");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //show panel, change status
            status = "Update";
            panel.Visible = true;

  
            //load data
            pTxtName.Text = txtFoodName.Text;
            pCboEvent.Text = cboEventName.Text;
            pNudQuantity.Value = nudQuantity.Value;
            pNudTime.Value = nudTime.Value;
            pCheckBox.Checked = Convert.ToBoolean(txtStatus.Text);
        }

        private void pBtnCancel_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
        }
        private void clearField() // reset field
        {
            pTxtName.Text = "";
            pNudQuantity.Value = 0;
            pNudTime.Value = 0;
            pCheckBox.Checked = false;
        }
      
    }
}

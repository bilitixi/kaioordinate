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
            status = "Add";
            panel.Visible = true;
        }
        

        private void pBtnSave_Click(object sender, EventArgs e)
        {
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
                    newKai["EvenID"] = Convert.ToInt32(pCboEvent.SelectedValue);
                    DM.dtKai.Rows.Add(newKai);
                    
                }

            }
            else
            {
               
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            status = "Update";
            panel.Visible = true;

            pCboEvent.Enabled = false;
            pCheckBox.Enabled = false;

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
    }
}

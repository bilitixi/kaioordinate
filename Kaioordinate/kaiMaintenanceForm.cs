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
            txtEvent.DataBindings.Add("Text", DM.dsKaioordinate, "EVENT.EventName");
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

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow updateKaiRow = DM.dtKai.Rows[currencyManager.Position];
            if ((txtFoodName.Text == ""))
         
                {
                    MessageBox.Show("You must type in a Kai Name", "Error");
                }
            else
            {
                updateKaiRow["KaiName"] = txtFoodName.Text;
                updateKaiRow["PreparationRequired"] = txtStatus.tEXT;
                updateKaiRow["ServeQuantity"] = Convert.ToDouble(nudQuantity.Value);
            }
        }
    }
}

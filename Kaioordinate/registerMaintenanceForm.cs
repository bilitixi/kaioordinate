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
        private DataModule DM;
        private mainForm mainForm;
        private CurrencyManager cmEvent;
        private CurrencyManager cmRegistration;
        private CurrencyManager cmWhanau;
       

        public registerMaintenanceForm(DataModule dm , mainForm mnu)
        {
            InitializeComponent();
            DM= dm;
            mainForm = mnu;
            cmEvent = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "EVENT"];
            cmWhanau = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "WHANAU"];
            cmRegistration = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "EVENT.EVENT_EVENTREGISTER"];
            BindControls();



        }
        public void BindControls()
        {
            dgvEvents.DataSource = DM.dsKaioordinate;
            dgvEvents.DataMember = "EVENT";

            dgvRegistration.DataSource = DM.dsKaioordinate;
            dgvRegistration.DataMember = "EVENT.EVENT_EVENTREGISTER";

            dgvWhanau.DataSource = DM.dsKaioordinate;
            dgvWhanau.DataMember = "WHANAU";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newEventRegister = DM.dtEventRegister.NewRow();
                int whanauID = Convert.ToInt32(dgvWhanau["WhanauID", cmWhanau.Position].Value);
                int eventID = Convert.ToInt32(dgvEvents["EventID", cmEvent.Position].Value);
                
                if (IsDuplicate(whanauID, eventID))
                {
                    MessageBox.Show("Whanau is already participates in this event.", "Error");

                }
                else
                {
                    newEventRegister["WhanauID"] = whanauID;
                    newEventRegister["EventID"] = eventID;
                    newEventRegister["KaiPreparation"] = checkBox.Checked;

                    DM.dsKaioordinate.Tables["EVENTREGISTER"].Rows.Add(newEventRegister);
                    DM.updateEventRegister();
                    MessageBox.Show("Whanau is added.", "Successful");
                }
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Whanau is already participates in the event.", "Error");

            }

        }

        private void registerMaintenanceForm_Load(object sender, EventArgs e)
        {

        }
        private bool IsDuplicate(int whanauID, int eventID)
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




        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmRegistration.Position < 0)
            {
                MessageBox.Show("Please select a registration", "Error");
                return;
            }

            DataRowView drv = (DataRowView)cmRegistration.Current;
            DataRow deleteEventRegister = drv.Row;

            if (MessageBox.Show("Are you sure you want to delete this registration?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteEventRegister.Delete();
                DM.updateEventRegister();
                MessageBox.Show("Registration deleted successfully", "Acknowledgement", MessageBoxButtons.OK);
            }
        }


    }
}


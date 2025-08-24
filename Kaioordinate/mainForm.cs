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
    public partial class mainForm : Form
    {
        private DataModule DM;
        private kaiEventMaintenanceForm kaiEventMaintenanceFrm;
        private locationMaintenanceForm locationMaintenanceFrm;
        private registerMaintenanceForm registerMaintenanceFrm;
        private whanauMaintenanceForm whanauMaintenanceFrm;
        private competitorReportForm competitorReportFrm;
        private kaiMaintenanceForm kaiMaintenanceFrm;
        
       
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void btnKai_Click(object sender, EventArgs e)
        {
            if (kaiMaintenanceFrm == null) 
            { 
                kaiMaintenanceFrm = new kaiMaintenanceForm(DM, this);
            }
            kaiMaintenanceFrm.ShowDialog();
        }
    }
}

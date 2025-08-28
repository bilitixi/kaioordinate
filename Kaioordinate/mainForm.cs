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

        private void btnEvents_Click(object sender, EventArgs e)
        {
            if (kaiEventMaintenanceFrm == null)
            {
                kaiEventMaintenanceFrm = new kaiEventMaintenanceForm(DM, this);
            }
            kaiEventMaintenanceFrm.ShowDialog();

        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            if (locationMaintenanceFrm == null)
            {
                locationMaintenanceFrm = new locationMaintenanceForm(DM, this);
            }
            locationMaintenanceFrm.ShowDialog();
        }

        private void btnWhanau_Click(object sender, EventArgs e)
        {
            if (whanauMaintenanceFrm == null)
            {
                whanauMaintenanceFrm = new whanauMaintenanceForm(DM, this);
            }
            whanauMaintenanceFrm.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (competitorReportFrm == null)
            {
                competitorReportFrm = new competitorReportForm(DM, this);
            }
            competitorReportFrm.ShowDialog();
        }
    }
}

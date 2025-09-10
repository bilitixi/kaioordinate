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
        // declare forms objects
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

        private void mainForm_Load(object sender, EventArgs e) // create Data Module Object
        {
            DM = new DataModule();
        }
        private void btnExit_Click(object sender, EventArgs e) //close form
        {
           
            Close();
        }

        private void btnKai_Click(object sender, EventArgs e) // open kai form
        {
            if (kaiMaintenanceFrm == null) 
            { 
                kaiMaintenanceFrm = new kaiMaintenanceForm(DM, this); // create form object
            }
            kaiMaintenanceFrm.ShowDialog();
        }

        private void btnEvents_Click(object sender, EventArgs e) // open event form
        {
            if (kaiEventMaintenanceFrm == null)
            {
                kaiEventMaintenanceFrm = new kaiEventMaintenanceForm(DM, this); // create form object
            }
            kaiEventMaintenanceFrm.ShowDialog();

        }

        private void btnLocation_Click(object sender, EventArgs e) // open location form
        {
            if (locationMaintenanceFrm == null)
            {
                locationMaintenanceFrm = new locationMaintenanceForm(DM, this);  // create form object
            }
            locationMaintenanceFrm.ShowDialog();
        }

        private void btnWhanau_Click(object sender, EventArgs e) // open whanau form
        {
            if (whanauMaintenanceFrm == null)
            {
                whanauMaintenanceFrm = new whanauMaintenanceForm(DM, this);  // create form object
            }
            whanauMaintenanceFrm.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e) // open print form
        {
            if (competitorReportFrm == null)
            {
                competitorReportFrm = new competitorReportForm(DM, this);  // create form object
            }
            competitorReportFrm.ShowDialog();
        }

        private void btnRegistration_Click(object sender, EventArgs e) // open registration form
        {
            if (registerMaintenanceFrm == null)
            {
                registerMaintenanceFrm = new registerMaintenanceForm(DM, this);  // create form object
            }
            registerMaintenanceFrm.ShowDialog();
        }
    }
}

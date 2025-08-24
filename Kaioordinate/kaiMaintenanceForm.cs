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
        private CurrencyManager currencyManager
        public kaiMaintenanceForm(DataModule dm, mainForm mainFrm)
        {

            InitializeComponent();
            DM = dm;
            mainForm = mainFrm;
            
        }
    }
}

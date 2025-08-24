using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kaioordinate
{
    public partial class DataModule : Form
    {
        public DataTable dtLocation;
        public DataTable dtEvent;
        public DataTable dtEventRegister;
        public DataTable dtWhanau;
        public DataTable dtKai;

        public DataView locationView;
        public DataView eventView;
        public DataView eventRegisterView;
        public DataView whanauView;
        public DataView kaiView;



        public DataModule()
        {
            InitializeComponent();
            dsKaioordinate.EnforceConstraints = false;

            daEvent.Fill(dsKaioordinate);
            daEventRegister.Fill(dsKaioordinate);
            daKai.Fill(dsKaioordinate);
            daLocation.Fill(dsKaioordinate);
            daWhanau.Fill(dsKaioordinate);

            dtEvent = dsKaioordinate.Tables["EVENT"];
            dtEventRegister = dsKaioordinate.Tables["EVENTREGISTER"];
            dtKai = dsKaioordinate.Tables["KAI"];
            dtLocation = dsKaioordinate.Tables["LOCATION"];
            dtWhanau = dsKaioordinate.Tables["WHANAU"];

            dsKaioordinate.EnforceConstraints = true;


        }
    }
}

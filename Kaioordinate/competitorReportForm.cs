using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Kaioordinate
{
    public partial class competitorReportForm : Form
    {
        private DataModule DM;
        private mainForm mainForm;

        private int amountOfInvoicesPrinted, pagesAmountExpected;
        private DataRow[] invoicesForPrint;
        public competitorReportForm(DataModule dm, mainForm mainFrm)
        {
            InitializeComponent();
            DM = dm;
            mainForm = mainFrm;
          
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            amountOfInvoicesPrinted = 0;
            string strFilter = "";
            string strSort = "EventID";
            invoicesForPrint = DM.dsKaioordinate.Tables["EVENT"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = invoicesForPrint.Length;
            prvInvoices.Show();
        }

        private void printInvoices_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 12, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 12, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 12, FontStyle.Bold);
            Font headingFont = new Font("Arial", 12, FontStyle.Bold);
            DataRow drEvent = invoicesForPrint[amountOfInvoicesPrinted];

            CurrencyManager cmEvent;
            CurrencyManager cmWhanau;
            CurrencyManager cmLocation;
            CurrencyManager cmEventRegister;
            double EventTotal = 0;

            cmEvent = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "EVENT"];
            cmWhanau = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "WHANAU"];
            cmLocation = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "LOCATION"];
            cmEventRegister = (CurrencyManager)this.BindingContext[DM.dsKaioordinate, "EVENTREGISTER"];

            Brush brush = new SolidBrush(Color.Black);
            //margins 
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;

            //get the event record
             

            // Event ID
            g.DrawString("Event ID: " , headingFont, brush, leftMargin + headingLeftMargin,
topMargin + (linesSoFarHeading * textFont.Height));
            g.DrawString(drEvent["EventID"].ToString(), textFont, brush, leftMargin + headingLeftMargin+ 100,
topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
             //Event Date
            g.DrawString("Date: " , headingFont, brush, leftMargin + headingLeftMargin,
topMargin + (linesSoFarHeading * textFont.Height));
            g.DrawString(drEvent["EventDate"].ToString(), textFont, brush, leftMargin + headingLeftMargin+ 100,
topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            //Location
            int aLocationID = Convert.ToInt32(drEvent["LocationID"].ToString());
            cmLocation.Position = DM.locationView.Find(aLocationID);
            DataRow drLocation = DM.dtLocation.Rows[cmLocation.Position];
            g.DrawString("Location: ", headingFont, brush, leftMargin + headingLeftMargin,
topMargin + (linesSoFarHeading * textFont.Height));
            g.DrawString(drLocation["LocationName"].ToString(), textFont, brush, leftMargin + headingLeftMargin + 100,
topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            //address
            g.DrawString("Address: ", headingFont, brush, leftMargin + headingLeftMargin,
topMargin + (linesSoFarHeading * textFont.Height));
            g.DrawString(drLocation["Address"].ToString(), textFont, brush, leftMargin + headingLeftMargin + 100,
topMargin + (linesSoFarHeading * textFont.Height));
            // list of attendees
            linesSoFarHeading+=3;

            g.DrawString("Attendees: ", headingFont, brush, leftMargin + headingLeftMargin,
topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading+=3;
            // tables headings
            g.DrawString("First Name ", headingFont, brush, leftMargin + headingLeftMargin,
topMargin + (linesSoFarHeading * textFont.Height));
            g.DrawString("Last Name ", headingFont, brush, leftMargin + headingLeftMargin+ 100,
topMargin + (linesSoFarHeading * textFont.Height));
            g.DrawString("Phone No. ", headingFont, brush, leftMargin + headingLeftMargin+200,
topMargin + (linesSoFarHeading * textFont.Height));
            g.DrawString("Helper ", headingFont, brush, leftMargin + headingLeftMargin+300,
topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading +=3;
            // retireve data from other table

            DataRow[] drEventRegistration = drEvent.GetChildRows(DM.dtEvent.ChildRelations["EVENT_EVENTREGISTER"]);
            if(drEventRegistration.Length == 0)
            {
                g.DrawString("No attendees for this event", headingFont, brush, leftMargin + headingLeftMargin,
topMargin + (linesSoFarHeading * textFont.Height));

            }
            else
            {
                foreach(DataRow drEventRegister in drEventRegistration)

                {
                    // get whanau
                    int WhanauID = Convert.ToInt32(drEventRegister["WhanauID"].ToString());
                    cmWhanau.Position = DM.whanauView.Find(WhanauID);
                    DataRow drWhanau = DM.dtWhanau.Rows[cmWhanau.Position];
                  

                    //firstname
                    g.DrawString(drWhanau["Firstname"].ToString(), textFont, brush, leftMargin + headingLeftMargin,
topMargin + (linesSoFarHeading * textFont.Height));
                    //lastname
                    g.DrawString(drWhanau["Lastname"].ToString(), textFont, brush, leftMargin + headingLeftMargin+100,
topMargin + (linesSoFarHeading * textFont.Height));
                    // phone no
                    g.DrawString(drWhanau["Phone"].ToString(), textFont, brush, leftMargin + headingLeftMargin+ 200,
topMargin + (linesSoFarHeading * textFont.Height));
                    // helper
                    if (drEventRegister["KaiPreparation"].ToString() == "True")
                    {
                        g.DrawString("Yes", textFont, brush, leftMargin + headingLeftMargin + 300,
    topMargin + (linesSoFarHeading * textFont.Height));
                    }
                    else
                    {
                        g.DrawString(" No", textFont, brush, leftMargin + headingLeftMargin + 300,
 topMargin + (linesSoFarHeading * textFont.Height));
                    }

                    linesSoFarHeading++;
                }
            }






            amountOfInvoicesPrinted++;

            if (!(amountOfInvoicesPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
       
       

        private void btnPreviewWhanau_Click(object sender, EventArgs e)
        {
            whanauReportForm whanauReportFrm = new whanauReportForm(DM.dtWhanau);
            whanauReportFrm.ShowDialog();
        }

        private void competitorReportForm_Load(object sender, EventArgs e)
        {

        }

      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaioordinate
{
    public partial class whanauReportForm : Form
    {
        private PrintDocument printDoc;
        private DataTable table;
        int pageCount = 1;

        public whanauReportForm(DataTable dt)
        {
            InitializeComponent();
            table = dt;
            printDoc = new PrintDocument();
            printDoc.PrintPage += PrintDoc_PrintPage;
            printPreviewControl1.Document = printDoc;
            printPreviewControl1.Zoom = 0.5;
        }

        // class-level field
        private int currentRow = 0;

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font boldfont = new Font("Arial", 11, FontStyle.Bold);
            Font font = new Font("Arial", 10);
            int lineHeight = font.Height + 4;
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int y = topMargin;
            // draw footer before move to new page
            string footer = "Page " + pageCount;
            SizeF footerSize = e.Graphics.MeasureString(footer, font);
            e.Graphics.DrawString(footer, font, Brushes.Black,
                e.MarginBounds.Right - footerSize.Width,
                e.MarginBounds.Bottom + 10);


            // Title (only on first page)
            if (currentRow == 0)
            {
                string header = "List of Whanau";
                e.Graphics.DrawString(header, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, leftMargin, y);
                y += lineHeight + 10;
                
              
                e.Graphics.DrawLine(Pens.Black, leftMargin, y, e.MarginBounds.Right, y);
                y += 5;
            }
         


            // Print rows until bottom of page
            while (currentRow < table.Rows.Count)
            {
                DataRow row = table.Rows[currentRow];

                // Whanau ID
                e.Graphics.DrawString("Whanau ID:", boldfont, Brushes.Black, leftMargin, y);
                e.Graphics.DrawString(row["WhanauID"].ToString(), font, Brushes.Black, leftMargin + 100, y);
                y += lineHeight;

                // Name
                e.Graphics.DrawString("Name:", boldfont, Brushes.Black, leftMargin, y);
                e.Graphics.DrawString(row["FirstName"].ToString() + " " + row["LastName"].ToString(), font, Brushes.Black, leftMargin + 100, y);
                y += lineHeight;

                // Email
                e.Graphics.DrawString("Email:", boldfont, Brushes.Black, leftMargin, y);
                e.Graphics.DrawString(row["Email"].ToString(), font, Brushes.Black, leftMargin + 100, y);
                y += lineHeight;

                // Phone
                e.Graphics.DrawString("Phone:", boldfont, Brushes.Black, leftMargin, y);
                e.Graphics.DrawString(row["Phone"].ToString(), font, Brushes.Black, leftMargin + 100, y);
                y += lineHeight;

                // Address
                e.Graphics.DrawString("Address:", boldfont, Brushes.Black, leftMargin, y);
                e.Graphics.DrawString(row["Address"].ToString(), font, Brushes.Black, leftMargin + 100, y);
                y += lineHeight;

                // Separator line
                e.Graphics.DrawLine(Pens.Black, leftMargin, y, e.MarginBounds.Right, y);
                y += lineHeight;

                currentRow++; // move to next row

                // Check if page is full
                if (y + lineHeight > e.MarginBounds.Bottom)
                {
                   
                    // increae page
                    pageCount++;
                    e.HasMorePages = true;
                    return; // stop and continue on next page
                }
                
            }
            // draw footer for last page
            String lastPagefooter = "Page " + pageCount;
            SizeF footerlastPageSize = e.Graphics.MeasureString(lastPagefooter, font);
            e.Graphics.DrawString(lastPagefooter , font, Brushes.Black,
                e.MarginBounds.Right - footerlastPageSize.Width,
                e.MarginBounds.Bottom + 10);

            // If we reach here, no more rows left
            e.HasMorePages = false;

            currentRow = 0; // reset so preview works again if reopened
            pageCount = 1;
        }


        private void btnZin_Click(object sender, EventArgs e)
        {
            if (printPreviewControl1.Zoom < 2) // minimum zoom
            {
                printPreviewControl1.Zoom += 0.1;
            }
        }

        private void btnZout_Click(object sender, EventArgs e)
        {
            if (printPreviewControl1.Zoom > 0.1) // minimum zoom
            {
                printPreviewControl1.Zoom -= 0.1;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (printPreviewControl1.StartPage < printPreviewControl1.Document.PrinterSettings.MaximumPage - 1)
            {
                printPreviewControl1.StartPage++;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (printPreviewControl1.StartPage > 0)
            {
                printPreviewControl1.StartPage--;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            printDoc.Print();
        }
    }
}


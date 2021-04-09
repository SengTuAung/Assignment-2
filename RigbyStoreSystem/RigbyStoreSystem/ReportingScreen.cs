using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RigbyStoreSystem
{
    public partial class ReportingScreen : Form
    {
        //4-7-2021 Saung NEW 3L : Initializing List and variables
        private const string path = "sales.txt";
        private List<Sale> sales = null;
        private List<string> lines = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// 
         //4-8-2021 Saung NEW 1L : Constructor for reporting screen
        public ReportingScreen()
        {
            //4-7-2021 Saung NEW 3L : Read Text File
            InitializeComponent();
            txtSaleIDFrom.Text = "0";
            if (File.Exists(path))
            {
                lines = File.ReadAllLines(path).ToList();
                if (lines.Count > 0)
                {
                    //4-7-2021 Saung NEW 1L : Displaying ID
                    txtSaleIDFrom.Text = "1";
                }
            }
        }
        /// <summary>
        /// Search button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
         //4-8-2021 Saung NEW 6L : Search button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int IDTo;
                //4-7-2021 Saung NEW 5L : Formatting Search ID on for search bar
                if (int.TryParse(txtSaleIDTo.Text, out IDTo) == false || IDTo < 1 || IDTo > lines.Count)
                {
                    MessageBox.Show("The field ID is blank. Enter ID >1 and <=" + lines.Count.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSaleIDTo.Text = "";
                    txtSaleIDTo.Focus();
                    return;
                }
                //4-7-2021 Saung NEW 12L :After you submit your search, it will process the query using LINQ query and then it will output it to the output textbox.
                var salesFromFile = from line in File.ReadAllLines(path)
                                    let parts = line.Split('|')
                                    where int.Parse(parts[0]) >= 1 && int.Parse(parts[0]) <= IDTo
                                    select new Sale
                                    {
                                        SaleID = int.Parse(parts[0]),
                                        ProductsName = parts[1],
                                        Total = int.Parse(parts[2]),
                                        PaidWith = parts[3],
                                        Rate = int.Parse(parts[4]),
                                        Personally = parts[5]
                                    };

                sales = salesFromFile.ToList();
                if (sales.Count > 0)
                {
                    int totalSales = IDTo;
                    int totalRevenue = 0;

                    string allSales = string.Format("{0,-5} {1,-10} {2,-10} {3,-15} {4,-10} {5,-15}", "ID", "Name", "Total", "Paid With", "Rate", "Personally") + Environment.NewLine;
                    //4-7-2021 Saung NEW 4L : Displaying all sales
                    for (int i = 0; i < totalSales; i++)
                    {
                        allSales += string.Format("{0,-3} {1,-10} {2,-3} {3,-15} {4,-4} {5,-15}",
                            sales[i].SaleID, sales[i].ProductsName, sales[i].Total, sales[i].PaidWith, sales[i].Rate, sales[i].Personally) + Environment.NewLine;
                        totalRevenue += sales[i].Total;
                    }
                    //4-7-2021 Saung NEW 4L : Display total sales and total revenue
                    txtOutput.Text = "All sales:" + Environment.NewLine +
                        allSales +
                        "Total Sales: " + totalSales.ToString() + Environment.NewLine +
                        "Total revenue: " + totalRevenue.ToString() + Environment.NewLine;
                }
            }
            catch (Exception ex) { }
        }
        /// <summary>
        /// //4-7-2021 Saung NEW 4L Main Menu button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportingScreen_Load(object sender, EventArgs e)
        {

        }
    }
}

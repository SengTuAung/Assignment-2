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
    public partial class ModifySaleScreen : Form
    {
        private const string path = "sales.txt";
        private List<Sale> sales=null;
        private int currentRecord=0;
        /// <summary>
        ///
        /// </summary>
        ///  //4-8-2021 Saung NEW 1: Constructor for midfy sale 
        public ModifySaleScreen()
        {
            //4-8-2021 Saung NEW 6L : Reading text file to modify file
            InitializeComponent();
            if (File.Exists(path))
            {
                var salesFromFile = from line in File.ReadAllLines(path)
                               let parts = line.Split('|')
                            select new Sale{
                                SaleID = int.Parse(parts[0]),
                                ProductsName = parts[1],
                                Total = int.Parse(parts[2]),
                                PaidWith = parts[3],
                                Rate= int.Parse(parts[4]),
                                Personally= parts[5]
                            };

                sales= salesFromFile.ToList();
                displaySale();
                btnBack.Enabled = false;
                if (sales.Count == 1) {
                    btnNext.Enabled = false;
                }
            }
            else {
                btnBack.Enabled = false;
                btnNext.Enabled = false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// 
         //4-8-2021 Saung NEW 6L : Displaying current sale
        private void displaySale() {
            if (sales != null) {
                txtSaleID.Text = sales[currentRecord].SaleID.ToString();
                txtProductsName.Text = sales[currentRecord].ProductsName;
                txtTotal.Text = sales[currentRecord].Total.ToString();
                txtPaidWith.Text = sales[currentRecord].PaidWith;
                txtRate.Text = sales[currentRecord].Rate.ToString();
                txtPersonally.Text = sales[currentRecord].Personally;
            }
        }
        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
         //4-8-2021 Saung NEW 7L : Next button
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentRecord < sales.Count) {
                currentRecord++;
                displaySale();
                btnBack.Enabled = true;
                if (currentRecord == sales.Count-1)
                {
                    btnNext.Enabled = false;
                }
            }
        }
        /// <summary>
        /// Back button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        //4-8-2021 Saung NEW 6L : Back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentRecord >0)
            {
                currentRecord--;
                displaySale();
                
                if (currentRecord == 0)
                {
                    btnBack.Enabled = false;
                    btnNext.Enabled = true;
                }
            }
        }
        /// <summary>
        /// Main Menu button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifySaleScreen_Load(object sender, EventArgs e)
        {

        }
    }
}

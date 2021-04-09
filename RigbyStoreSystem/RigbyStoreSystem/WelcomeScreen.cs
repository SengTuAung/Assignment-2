using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RigbyStoreSystem
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Add Sale button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
         //4-8-2021 Saung NEW 3L : Leads to add sale
        private void btnAddSale_Click(object sender, EventArgs e)
        {
            var addSaleScreen = new AddSaleScreen();
            addSaleScreen.ShowDialog();
        }
        /// <summary>
        /// Modify Sale button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
         //4-8-2021 Saung NEW 6L : Leads to modify page
        private void btnModifySale_Click(object sender, EventArgs e)
        {
            var modifySaleScreen = new ModifySaleScreen();
            modifySaleScreen.ShowDialog();
        }
        /// <summary>
        /// Reporting button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
         //4-8-2021 Saung NEW 4L : Leads to reporting page
        private void btnReporting_Click(object sender, EventArgs e)
        {
            var reportingScreen = new ReportingScreen();
            reportingScreen.ShowDialog();
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {

        }
    }
}

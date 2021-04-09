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
    public partial class AddSaleScreen : Form
    {
        private const string path = "sales.txt";
        /// <summary>
        /// Constructor
        /// </summary>
        public AddSaleScreen()
        {
            InitializeComponent();
            txtSaleID.Text = "1";
            if (File.Exists(path))
            {
                //4-8-2021 Saung NEW 2L : Display ID
                List<string> lines = File.ReadAllLines(path).ToList();
                txtSaleID.Text = (lines.Count + 1).ToString();
            }
        }
        /// <summary>
        /// When you click save button, it should append it to the text file and then all the contents in 
        /// the textbox will wipe clean and then an alert button should pop up, saying that the information
        /// has been saved into our system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            ////4-8-2021 Saung NEW L : Check input values
            if (txtProductsName.Text == "") {
                MessageBox.Show("The field Products Name is blank.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductsName.Text = "";
                txtProductsName.Focus();
                return;
            }
            int total;
            //4-8-2021 Saung NEW L : Error message if Total is blank
            if (int.TryParse(txtTotal.Text,out total) == false || total<0)
            {
                MessageBox.Show("The field Total is blank or less than zero or is not a numeric.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTotal.Text = "";
                txtTotal.Focus();
                return;
            }
            //4-8-2021 Saung NEW 4L : Error message if paid is blank
            if (txtPaidWith.Text == "")
            {
                MessageBox.Show("The field Paid With is blank.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPaidWith.Text = "";
                txtPaidWith.Focus();
                return;
            }
            int rate;
            //4-8-2021 Saung NEW 4L : Error message if rate is blank
            if (int.TryParse(txtRate.Text, out rate) == false || rate < 1 || rate > 10)
            {
                MessageBox.Show("The field rate is blank, less than 1 or greater than 10 or is not a numeric.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Text = "";
                txtRate.Focus();
                return;
            }
            //4-8-2021 Saung NEW 4L : Error message if Personality is blank
            if (txtPersonally.Text == "")
            {
                MessageBox.Show("The field Personally is blank.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPersonally.Text = "";
                txtPersonally.Focus();
                return;
            }
            //4-8-2021 Saung NEW 4L : Register the sales
            var newSale = new Sale(int.Parse(txtSaleID.Text),txtProductsName.Text,int.Parse(txtTotal.Text),txtPaidWith.Text,int.Parse(txtRate.Text),txtPersonally.Text);
            using (StreamWriter streamWriter = File.AppendText(path))
            {
                streamWriter.WriteLine(newSale.ToString());
            }
            //4-7-2021 Saung NEW 6L : Clear all form
            txtSaleID.Text = "";
            txtProductsName.Text = "";
            txtTotal.Text = "";
            txtPaidWith.Text = "";
            txtRate.Text = "";
            txtPersonally.Text = "";
            //4-8-2021 Saung NEW 1L : Display Messagebox if saved
            MessageBox.Show("The information has been saved into our system.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
        /// <summary>
        /// Go to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSaleScreen_Load(object sender, EventArgs e)
        {

        }
    }
}

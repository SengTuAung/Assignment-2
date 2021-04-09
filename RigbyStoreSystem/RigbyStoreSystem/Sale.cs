using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RigbyStoreSystem
{
    public class Sale
    {
        private int saleID;
        private string productsName;
        private int total;
        private string paidWith;
        private int rate;
        private string personally;
        /// <summary>
        /// Constructor
        /// </summary>
        public Sale(){ }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="saleID"></param>
        /// <param name="productsName"></param>
        /// <param name="total"></param>
        /// <param name="paidWith"></param>
        /// <param name="rate"></param>
        /// <param name="personally"></param>
        public Sale(int saleID, string productsName, int total, string paidWith, int rate, string personally) {
            this.saleID = saleID;
            this.productsName = productsName;
            this.total = total;
            this.paidWith = paidWith;
            this.rate = rate;
            this.personally = personally;
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}|{5}", this.saleID, this.productsName, this.total, this.paidWith, this.rate, this.personally);
        }

        public int SaleID
        {
            get
            {
                return saleID;
            }

            set
            {
                saleID = value;
            }
        }

        public string ProductsName
        {
            get
            {
                return productsName;
            }

            set
            {
                productsName = value;
            }
        }

        public int Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public string PaidWith
        {
            get
            {
                return paidWith;
            }

            set
            {
                paidWith = value;
            }
        }

        public int Rate
        {
            get
            {
                return rate;
            }

            set
            {
                rate = value;
            }
        }

        public string Personally
        {
            get
            {
                return personally;
            }

            set
            {
                personally = value;
            }
        }
    }
}

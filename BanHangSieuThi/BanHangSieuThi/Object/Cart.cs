using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangSieuThi.Object
{
    class Cart
    {
        List<Product> _listItem = new List<Product>();
        public Cart()
        {
           
        }

        public Cart(List<Product> listItem)
        {
            this._listItem = listItem;
        }

        ~Cart()
        {

        }

        internal List<Product> ListItem { get => _listItem; set => _listItem = value; }

        public void Add(Product us)
        {
            this._listItem.Add(us);
        }
        public void Add(DataTable data)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
               
                Product temp = new Product();
                temp.Id = data.Rows[i]["MaSP"].ToString().Trim();
                temp.Name = data.Rows[i]["TenSP"].ToString().Trim();
                temp.Count = 1;
                temp.Price = data.Rows[i]["GiaBan"].ToString().Trim();
                this._listItem.Add(temp);
            }
        }
        private int CheckCount(Product us)
        {
            int i = 0;
            foreach (Product product in ListItem)
            {
                if (product.Id == us.Id) return i;
                i++;
            }
            return -1;
        }
        public void AddToList(Product us)
        {
            int check = CheckCount(us);
            if(check >= 0)
            {
                this._listItem[check].Count++;
            }
            else
            {
                this._listItem.Add(us);
            }
        }
        public void Clear()
        {
            this.ListItem.Clear();
        }
        public DataTable Get()
        {
            DataTable data = new DataTable("Product");
            data.Columns.Add("MaSP", typeof(string));
            data.Columns.Add("TenSP", typeof(string));
            data.Columns.Add("Count", typeof(string));
            data.Columns.Add("Price", typeof(string));
            foreach (Product product in ListItem)
            {
                data.Rows.Add(product.Id, product.Name, product.Count,product.Price);
            }

            return data;
        }
        public int GetPriceOfCart()
        {
            int sumPrice = 0;
            foreach(Product product in ListItem)
            {
                int temp_Price = Int32.Parse(product.Price);
                int temp_Count = product.Count;
                sumPrice +=  temp_Count * temp_Price;
            }
            return sumPrice;
        }

       
    }
}

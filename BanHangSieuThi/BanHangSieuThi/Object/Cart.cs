using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangSieuThi.Object
{
    class Cart
    {
        List<Product> _listItem;
        public Cart()
        {

        }

        public Cart(List<Product> listItem)
        {
            _listItem = listItem;
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
                temp.Count = 0;
                ListItem.Add(temp);
            }
          

        }
        public DataTable Get()
        {
            DataTable data = new DataTable("Product");
            data.Columns.Add("MaSP", typeof(string));
            data.Columns.Add("TenSP", typeof(string));
            data.Columns.Add("Cout", typeof(string));
            foreach (Product product in ListItem)
            {
                data.Rows.Add(product.Id, product.Name, product.Count);
            }

            return data;
        }
    }
}

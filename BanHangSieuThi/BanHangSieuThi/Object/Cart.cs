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
        public Cart (DataTable data)
        {
            for(int i = 0;i < data.Rows.Count; i++)
            {
                Product temp = new Product();
            }
        }
    }
}

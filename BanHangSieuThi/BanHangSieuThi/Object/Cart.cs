using System;
using System.Collections.Generic;
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
    }
}

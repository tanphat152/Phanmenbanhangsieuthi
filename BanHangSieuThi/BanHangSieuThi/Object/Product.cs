using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangSieuThi.Object
{
    class Product
    {
        string _id;
        string _name;
        string _count;

        public Product()
        {
        }

        public Product(string id, string name, string count)
        {
            _id = id;
            _name = name;
            _count = count;
        }
        ~Product()
        {

        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Count { get => _count; set => _count = value; }
    }
}

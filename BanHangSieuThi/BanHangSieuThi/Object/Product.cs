using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHangSieuThi.Object
{
    class Product
    {
        string _id;
        string _name;
        int _count;
        string _price;

        public Product()
        {
        }
        public Product(DataTable data)
        {
            this._id = data.Rows[0]["MaSP"].ToString().Trim();
            this._name = data.Rows[0]["TenSP"].ToString().Trim();
            this._count = 1;
            this._price = data.Rows[0]["GiaBan"].ToString().Trim();

        }
        public Product(string id, string name, int count,string price)
        {
            _id = id;
            _name = name;
            _count = count;
            _price = price;
        }
        ~Product()
        {

        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Count { get => _count; set => _count = value; }
        public string Price { get => _price; set => _price = value; }

        public Product GetProduct(DataTable data)
        {
            Product temp = new Product();
            temp.Id = data.Rows[0]["MaSP"].ToString().Trim();
            temp.Name = data.Rows[0]["TenSP"].ToString().Trim();
            temp.Count = 1;
            temp.Price = data.Rows[0]["GiaBan"].ToString().Trim();
            return temp;
        }
    }
}

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

        public Product()
        {
        }
        public Product(DataTable data)
        {
            this._id = data.Rows[0]["MaSP"].ToString().Trim();
            this._name = data.Rows[0]["TenSP"].ToString().Trim();
            this._count = 0;
           
        }
        public Product(string id, string name, int count)
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
        public int Count { get => _count; set => _count = value; }
        public Product GetProduct(DataTable data)
        {
            Product temp = new Product();
            temp.Id = data.Rows[0]["MaSP"].ToString().Trim();
            temp.Name = data.Rows[0]["TenSP"].ToString().Trim();
            temp.Count = 0;
            return temp;
        }
    }
}

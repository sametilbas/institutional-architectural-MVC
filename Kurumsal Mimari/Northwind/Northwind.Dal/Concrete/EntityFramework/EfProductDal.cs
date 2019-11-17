using Northwind.Dal.Abstract;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        private NortwindContext _context = new NortwindContext();
        public void Add(Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int productId)
        {
            _context.Product.Remove(_context.Product.FirstOrDefault(x=>x.ProductID==productId));
            _context.SaveChanges();
        }

        public Product Get(int productId)
        {
            return _context.Product.FirstOrDefault(x=>x.ProductID==productId);
        }

        public List<Product> GetAll()
        {
            return _context.Product.ToList();
        }

        public void Update(Product product)
        {
            Product update = _context.Product.FirstOrDefault(x => x.ProductID == product.ProductID);
            update.ProductName = product.ProductName;
            update.UnitPrice = product.UnitPrice;
            update.CategoryID = product.CategoryID;
            _context.SaveChanges();
        }
    }
}

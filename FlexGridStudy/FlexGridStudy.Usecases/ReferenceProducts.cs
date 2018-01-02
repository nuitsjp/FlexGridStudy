using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexGridStudy.Integrations.Entities;

namespace FlexGridStudy.Usecases
{
    public class ReferenceProducts : IReferenceProducts
    {
        public IEnumerable<Product> SearchProducts()
        {
            using (var model = new AdventureWorksModel())
            {
                return model.Products.OrderBy(x => x.ProductNumber).ToList();
            }
        }
    }
}

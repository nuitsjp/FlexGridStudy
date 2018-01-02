using FlexGridStudy.Integrations.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexGridStudy.Usecases
{
    public interface IReferenceProducts
    {
        IEnumerable<Product> SearchProducts();
    }
}

using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using FlexGridStudy.Integrations.Entities;
using FlexGridStudy.Usecases;

namespace FlexGridStudy.ViewModels
{
    public class ProductListViewModel : BindableBase
    {
        private readonly IReferenceProducts _referenceProducts;
        public ObservableCollection<Product> Products { get; } = new ObservableCollection<Product>();
        public ICommand SearchProductsCommand => new DelegateCommand(() =>
        {
            foreach (var product in _referenceProducts.SearchProducts())
            {
                Products.Add(product);
            }
        });
        public ProductListViewModel(IReferenceProducts referenceProducts)
        {
            _referenceProducts = referenceProducts;
        }
    }
}

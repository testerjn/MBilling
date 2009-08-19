using MBilling.Common.Interfaces;
using MBilling.Common.ViewModels;
using MBilling.Core;
using MBilling.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MBilling.Business.Presenters
{
    public class ProductPresenter
    {
        private IProductView m_view = null;
        private ProductDao m_ProductDao = new ProductDao();
        private ProductTypeDao m_productTypeDao = new ProductTypeDao();
        private ProductViewModel m_viewModel;
        private IEnumerable<ProductViewModel> m_ProductViewModellList;
        private IEnumerable<ProductTypeViewModel> m_ProductTypeViewModelList;

        public ProductPresenter(IProductView p_view)
        {
            m_view = p_view;
            PopulateData();
            Product productDataEntity = new Product();
            ProductViewModel productViewModel = new ProductViewModel(productDataEntity);
            m_view.MyModel = productViewModel;
            m_view.ShowModel(productViewModel);
        }
        public ProductPresenter(IProductView p_view, ProductDao p_ProductDao)
        {
            m_view = p_view;
            m_ProductDao = p_ProductDao;

        }
        private void PopulateData()
        {
            GetAllProduct();
            GetAllProductType();
        }
        private async void GetAllProduct()
        {
            IEnumerable<Product> ProductEntityList = await m_ProductDao.GetAll();

            IEnumerable<ProductViewModel> ProductViewModel =
                ResolveViewModelArray(ProductEntityList);

            m_ProductViewModellList = ProductViewModel;

            m_view.GetAll(m_ProductViewModellList);
        }
        private async void GetAllProductType()
        {
            IEnumerable<ProductType> productTypeEntityList = await m_productTypeDao.GetAll();
            IEnumerable<ProductTypeViewModel> productTypeViewModel =
                SResolveViewModelArray(productTypeEntityList);
            m_ProductTypeViewModelList = productTypeViewModel;
           
            m_view.ShowProductType(m_ProductTypeViewModelList);
        }
        private IEnumerable<ProductViewModel> ResolveViewModelArray(IEnumerable<Product> ProductEntityList)
        {
            foreach (Product ProductEntity in ProductEntityList)
            {
                yield return new ProductViewModel(ProductEntity);
            }
        }

        private IEnumerable<ProductTypeViewModel> SResolveViewModelArray(IEnumerable<ProductType> ProductEntityList)
        {
            foreach (ProductType ProductEntity in ProductEntityList)
            {
                yield return new ProductTypeViewModel(ProductEntity);
            }
        }


        public async void SearchProduct()
        {
            m_viewModel = m_view.MyModel;
            IEnumerable<Product> ProductEntityList = await m_ProductDao.GetAllBy(x => x.Name.Contains(m_viewModel.Name));

            IEnumerable<ProductViewModel> ProductViewModel =
                ResolveViewModelArray(ProductEntityList);

            m_ProductViewModellList = ProductViewModel;

            m_view.GetAll(m_ProductViewModellList);
        }

        public async void EditProductClicked()
        {
            Product ProductEntity = await m_ProductDao.GetById(m_view.ModelId);
            m_viewModel = new ProductViewModel(ProductEntity);
            m_view.ShowModel(m_viewModel);
        }
        public void AddProductClicked()
        {
            Product productDataEntity = new Product();
            m_viewModel = new ProductViewModel(productDataEntity);
            m_view.ShowModel(m_viewModel);
        }
        public void AddProduct()
        {
            Product productDataEntity = new Product();
            ProductViewModel ProductViewModel = new ProductViewModel(productDataEntity);
        }
        public void SaveClicked()
        {
            m_view.ReadUserInput();
            Product productDataEntity = m_viewModel.ProductData;
            List<string> lstMessages = new List<string>();
            bool isValid = m_ProductDao.Validate(productDataEntity, out lstMessages);
            if (isValid)
            {
                if (productDataEntity.ProductId == 0)
                {
                    m_ProductDao.Insert(productDataEntity);
                }
                else
                {
                    m_ProductDao.Update(productDataEntity);
                }
                GetAllProduct();
            }
            else
            {
                string strMessages = String.Join(Environment.NewLine, lstMessages.Select(a => a.ToString()));
                m_view.Message = strMessages;
                m_view.ShowError();
            }
        }

        public void CancellClicked()
        {
            m_view.Close();
        }
    }
}

using AutoMapper;
using Lipstick._Convergence.DataAccess;
using Lipstick.Areas.Admin.Models;

namespace Lipstick._Convergence.BusinessLogic.Helpers
{
    public class ProductHelper
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public ProductHelper(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }
        public async Task<IEnumerable<ProductViewModel>> GetProducts()
        {
            var listProduct = await _unitOfWork.ProductRepository.GetAll();
            if (listProduct == null)
            {
                return null;
            }
            listProduct = listProduct.OrderBy(s => s.ModifiedOn);
            IEnumerable<ProductViewModel> listProductUI = new List<ProductViewModel>();
            listProductUI = _mapper.Map<IEnumerable<ProductViewModel>>(listProduct);

            return listProductUI;
        }
        public async Task<ProductViewModel> GetProductByID(string ID)
        {
            if (!Guid.TryParse(ID, out var id))
            {
                return null;
            }
            var product = await _unitOfWork.ProductRepository.GetById(Guid.Parse(ID));
            ProductViewModel productUI = _mapper.Map<ProductViewModel>(product);
            return productUI;
        }
        public async Task AddProduct(ProductViewModel model)
        {
            try
            {
                Product entity = _mapper.Map<Product>(model);
                entity.ID = Guid.NewGuid();
                await _unitOfWork.ProductRepository.Create(entity);
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task UpdateProduct(ProductViewModel model)
        {
            try
            {
                Product product = await _unitOfWork.ProductRepository.GetById(model.ID);
                if (product == null)
                {
                    return;
                }
                product.NameEN = model.NameEN;
                product.NameVN = model.NameVN;
                product.DescriptionEN = model.DescriptionEN;
                product.DescriptionVN = model.DescriptionVN;
                product.ModifiedOn = DateTime.Now;
                product.IsActive = model.IsActive;
                product.IsDeleted = model.IsDeleted;
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<bool> DeleteProductByID(string ID)
        {
            Product product = await _unitOfWork.ProductRepository.GetById(Guid.Parse(ID));

            if (product == null)
            {
                return false;
            }
            await _unitOfWork.ProductRepository.Delete(Guid.Parse(ID));
            _unitOfWork.Save();
            return true;
        }
        public async Task<bool> SoftDeleteProductByID(string ID)
        {
            var product = await _unitOfWork.ProductRepository.GetById(Guid.Parse(ID));
            if (product == null)
            {
                return false;
            }
            product.IsDeleted = true;
            product.ModifiedOn = DateTime.Now;
            _unitOfWork.Save();
            return true;

        }
        //public async Task<bool> CheckPermissionToDelete(string ID)
        //{
        //    if (!Guid.TryParse(ID, out var id))
        //    {
        //        return false;
        //    }
        //    Product product = await _unitOfWork.ProductRepository.GetById(Guid.Parse(ID));

        //    if (product != null && product.Products.Count <= 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public async Task RestoreProductByID(string ID)
        {
            var product = await _unitOfWork.ProductRepository.GetById(Guid.Parse(ID));
            if (product != null)
            {
                product.IsDeleted = false;
                product.ModifiedOn = DateTime.Now;
                _unitOfWork.Save();
            }
        }
    }
}

﻿using AutoMapper;
using Lipstick._Convergence.DataAccess;
using Lipstick.Areas.Admin.Models;
namespace Lipstick._Convergence.BusinessLogic.Helpers
{
    public class BrandHelper
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public BrandHelper(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }
        public async Task<IEnumerable<BrandViewModel>> GetBrands()
        {
            var listBrand = await _unitOfWork.BrandRepository.GetAll();
            if (listBrand == null)
            {
                return null;
            }
            listBrand = listBrand.OrderBy(s => s.ModifiedOn);
            IEnumerable<BrandViewModel> listBrandUI = new List<BrandViewModel>();
            listBrandUI = _mapper.Map<IEnumerable<BrandViewModel>>(listBrand);

            return listBrandUI;
        }
        public async Task<BrandViewModel> GetBrandByID(string ID)
        {
            if (!Guid.TryParse(ID, out var id))
            {
                return null;
            }
            var brand = await _unitOfWork.BrandRepository.GetById(Guid.Parse(ID));
            BrandViewModel brandUI = _mapper.Map<BrandViewModel>(brand);
            return brandUI;
        }
        public async Task AddBrand(BrandViewModel model)
        {
            try
            {
                Brand entity = _mapper.Map<Brand>(model);
                entity.ID = Guid.NewGuid();
                await _unitOfWork.BrandRepository.Create(entity);
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task UpdateBrand(BrandViewModel model)
        {
            try
            {
                Brand brand = await _unitOfWork.BrandRepository.GetById(model.ID);
                if (brand == null)
                {
                    return;
                }
                brand.NameEN = model.NameEN;
                brand.NameVN = model.NameVN;
                brand.DescriptionEN = model.DescriptionEN;
                brand.DescriptionVN = model.DescriptionVN;
                brand.ModifiedOn = DateTime.Now;
                brand.IsActive = model.IsActive;
                brand.IsDeleted = model.IsDeleted;
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<bool> DeleteBrandByID(string ID)
        {
            Brand brand = await _unitOfWork.BrandRepository.GetById(Guid.Parse(ID));

            if (brand != null && brand.Products.Count <= 0)
            {
                await _unitOfWork.BrandRepository.Delete(Guid.Parse(ID));
                _unitOfWork.Save();
                return true;
            }
            return false;
        }
        public async Task<bool> SoftDeleteBrandByID(string ID)
        {
            var brand = await _unitOfWork.BrandRepository.GetById(Guid.Parse(ID));
            if (brand != null && brand.Products.Count <= 0)
            {
                brand.IsDeleted = true;
                brand.ModifiedOn = DateTime.Now;
                //await _unitOfWork.BrandRepository.Update(brand);
                _unitOfWork.Save();
                return true;
            }
            return false;
        }
        public async Task<bool> CheckPermissionToDelete(string ID)
        {
            if (!Guid.TryParse(ID, out var id))
            {
                return false;
            }
            Brand brand = await _unitOfWork.BrandRepository.GetById(Guid.Parse(ID));

            if (brand != null && brand.Products.Count <= 0)
            {
                return true;
            }
            return false;
        }
        public async Task RestoreBrandByID(string ID)
        {
            var brand = await _unitOfWork.BrandRepository.GetById(Guid.Parse(ID));
            if (brand != null)
            {
                brand.IsDeleted = false;
                brand.ModifiedOn = DateTime.Now;
                _unitOfWork.Save();
            }
        }
    }
}

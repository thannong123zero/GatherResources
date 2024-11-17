using AutoMapper;
using Lipstick._Convergence.DataAccess;
using Lipstick._Convergence.DataAccess.DTOs;
using Lipstick.Areas.Admin.Models;


namespace Lipstick._Convergence.BusinessLogic.Helpers
{
    public class UnitHelper
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public UnitHelper(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }
        public async Task<IEnumerable<UnitViewModel>> GetUnits()
        {
            var listUnit = await _unitOfWork.UnitRepository.GetAll();
            IEnumerable<UnitViewModel> listUnitUI = new List<UnitViewModel>();
            listUnitUI = _mapper.Map<IEnumerable<UnitViewModel>>(listUnit);

            return listUnitUI;
        }
        public async Task<UnitViewModel> GetUnitByID(string ID)
        {
            if (!Guid.TryParse(ID, out var id))
            {
                return null;
            }
            var unit = await _unitOfWork.UnitRepository.GetById(Guid.Parse(ID));
            UnitViewModel unitUI = _mapper.Map<UnitViewModel>(unit);
            return unitUI;
        }
        public async Task AddUnit(UnitViewModel model)
        {
            try
            {
                UnitDTO entity = _mapper.Map<UnitDTO>(model);
                entity.Id = Guid.NewGuid();
                await _unitOfWork.UnitRepository.Create(entity);
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task UpdateUnit(UnitViewModel model)
        {
            try
            {
                UnitDTO unit = await _unitOfWork.UnitRepository.GetById(model.ID);
                if (unit == null)
                {
                    return;
                }
                unit.NameEN = model.NameEN;
                unit.NameVN = model.NameVN;
                unit.DescriptionEN = model.DescriptionEN;
                unit.DescriptionVN = model.DescriptionVN;
                unit.ModifiedOn = DateTime.Now;
                unit.IsActive = model.IsActive;
                unit.IsDeleted = model.IsDeleted;
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<bool> DeleteUnitByID(string ID)
        {
            UnitDTO unit = await _unitOfWork.UnitRepository.GetById(Guid.Parse(ID));

            if (unit != null && unit.Products.Count <= 0)
            {
                await _unitOfWork.UnitRepository.Delete(Guid.Parse(ID));
                _unitOfWork.Save();
                return true;
            }
            return false;
        }
        public async Task SoftDeleteUnitByID(string ID)
        {
            var unit = await _unitOfWork.UnitRepository.GetById(Guid.Parse(ID));
            if (unit != null)
            {
                unit.IsDeleted = true;
                unit.ModifiedOn = DateTime.Now;
                //await _unitOfWork.UnitRepository.Update(unit);
                _unitOfWork.Save();
            }
        }
        public async Task<bool> RestoreUnitByID(string ID)
        {
            var unit = await _unitOfWork.UnitRepository.GetById(Guid.Parse(ID));
            if (unit != null && unit.Products.Count <= 0)
            {
                unit.IsDeleted = false;
                unit.ModifiedOn = DateTime.Now;
                //await _unitOfWork.UnitRepository.Update(unit);
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
            UnitDTO unit = await _unitOfWork.UnitRepository.GetById(Guid.Parse(ID));

            if (unit != null && unit.Products.Count <= 0)
            {
                return true;
            }
            return false;
        }
    }
}

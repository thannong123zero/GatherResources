﻿using Lipstick._Convergence.DataAccess;

namespace Lipstick._Convergence.BusinessLogic.Helpers
{
    public class LayoutHelper
    {
        private readonly IUnitOfWork _unitOfWork;
        public LayoutHelper(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //public async Task<LayoutUI> GetLayout(string language)
        //{

        //}
    }
}

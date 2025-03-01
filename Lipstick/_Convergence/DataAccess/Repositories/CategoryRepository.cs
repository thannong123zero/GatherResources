﻿using Lipstick._Convergence.DataAccess;
using Lipstick._Convergence.DataAccess.DTOs;
using Lipstick._Convergence.DataAccess.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Lipstick._Convergence.DataAccess.Repositories
{
    public class MenuGroupRepository : GenericRepository<CategoryDTO>, ICategoryRepository
    {
        public MenuGroupRepository(DatabaseContext dbContext) : base(dbContext) { }
    }
}

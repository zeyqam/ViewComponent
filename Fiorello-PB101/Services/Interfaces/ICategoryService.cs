﻿using Fiorello_PB101.Models;
using Fiorello_PB101.ViewModels.Categories;

namespace Fiorello_PB101.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<IEnumerable<CategoryProductVM>> GetAllWithProductAsync();
        Task<Category> GetByIdAsync(int id);
        Task<bool> ExistAsync(string name);
        Task CreateAsync(Category category);
        Task DeleteAsync(Category category);
        Task<CategoryDetailsVM> GetCategoryDetailsAsync(int id);
        Task<bool> ExistExceptByIdAsync(int id,string name);
    }
}

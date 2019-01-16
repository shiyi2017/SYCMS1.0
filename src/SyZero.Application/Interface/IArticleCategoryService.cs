using System;
using System.Collections.Generic;
using System.Text;
using SyZero.Domain.Model;

namespace SyZero.Application
{
    public interface IArticleCategoryService :IBaseService
    {
        IEnumerable<CategoryDto> GetCategorys();

        void AddCategory(CategoryDto categoryDto);

        void UpdateCategory(CategoryDto categoryDto);
        void DelCategory(long id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SyZero.Application;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SZCMS.Controllers.Admin
{
    public class AdminController : Controller
    {
        private readonly IArticleCategoryService _articleCategoryService;
        public AdminController( IArticleCategoryService articleCategoryService)
        {
            _articleCategoryService = articleCategoryService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ArticleList()
        {
            return View();
        }

        public IActionResult ArticleEdit()
        {
            return View();
        }

        public IActionResult ArticleCategoryList()
        {
            return View();
        }

        public IActionResult ArticleCategoryEdit(string name,string content)
        {
            if (!string.IsNullOrEmpty(name))
            {
                CategoryDto categoryDto = new CategoryDto();
                categoryDto.Name = name;
                categoryDto.Describe = content;
                categoryDto.Status = "发布";
                categoryDto.UpdateTime = DateTime.Now.ToString();
                _articleCategoryService.AddCategory(categoryDto);
                return Content("OK");
            }
            else
            {
                return View();
            }
           
        }
    }
}

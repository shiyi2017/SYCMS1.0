using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SyZero.Application;
using SyZero.Domain.Interface;
using SyZero.Domain.Model;
using SyZero.Common;
using SyZero.Infrastructure.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SZCMS.Controllers.Admin
{
    [Route("api/admin/[controller]/[action]")]
    public class AjaxController : BasePage
    {
        private readonly IBaseRepository<Article> _articleRep;
        private readonly IUnitOfWork _unitOfWork;

        private readonly IArticleService _articleService;
        private readonly IArticleCategoryService _articleCategoryService;
        public AjaxController(IBaseRepository<Article> articleRep,IUnitOfWork unitOfWork,IArticleService articleService,IArticleCategoryService articleCategoryService)
        {
            _articleRep = articleRep;
            _unitOfWork = unitOfWork;
            _articleService = articleService;
            _articleCategoryService = articleCategoryService;
        }
        /// <summary>
        /// 分页获取Article信息
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public string GetArticle(string page,string limit)
        {
            if (string.IsNullOrEmpty(page))
            {
                page = "1";
            }

            if (string.IsNullOrEmpty(limit))
            {
                limit = "10";
            }

            int count = 0;
            IEnumerable<ArticleDto> list =
               _articleService.GetArticles(out count, int.Parse(page), int.Parse(limit));
            return JsonHelper.toLayuiTable(0, "", count, list);
        }

        /// <summary>
        /// 删除一条Article信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public string DelArticle(string Id)
        {
            _articleService.DeleteArticle(long.Parse(Id));
            return JsonHelper.toLayuiMsg("ok");
        }

        /// <summary>
        /// 更新一条Article信息
        /// </summary>
        /// <param name="articleDto"></param>
        /// <returns></returns>
        public string UpdataArticle(ArticleDto articleDto)
        {
            _articleService.UpdataArticle(articleDto);
            return JsonHelper.toLayuiMsg("ok");
        }

        /// <summary>
        /// 添加梯调Article信息
        /// </summary>
        /// <param name="articleDto"></param>
        /// <returns></returns>
        public string AddArticle(ArticleDto articleDto)
        {
            _articleService.AddArticle(articleDto);
            return JsonHelper.toLayuiMsg("ok");
        }

        /// <summary>
        /// 获取Article分类列表
        /// </summary>
        /// <returns></returns>
        public string GetArticleCategory()
        {
            IEnumerable<CategoryDto> list = _articleCategoryService.GetCategorys();
            return JsonHelper.toLayuiTable(0, "", list.Count(), list);
        }

        /// <summary>
        /// 添加一条Article分类信息
        /// </summary>
        /// <param name="categoryDto"></param>
        /// <returns></returns>
        public string AddArticleCategory(CategoryDto categoryDto)
        {
            categoryDto.UpdateTime = DateTime.Now.ToString();
            _articleCategoryService.AddCategory(categoryDto);
            return JsonHelper.toLayuiMsg("ok");
        }

        /// <summary>
        /// 修改一条Article分类信息
        /// </summary>
        /// <param name="categoryDto"></param>
        /// <returns></returns>
        public string UpdataArticleCategory(CategoryDto categoryDto)
        {
            categoryDto.UpdateTime = DateTime.Now.ToString();
            _articleCategoryService.UpdateCategory(categoryDto);
            return JsonHelper.toLayuiMsg("ok");
        }

        /// <summary>
        /// /删除一条Article分类信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public string DelArticleCategory(string Id)
        {

            _articleCategoryService.DelCategory(long.Parse(Id));
            return JsonHelper.toLayuiMsg("ok");
        }



       
    }
}

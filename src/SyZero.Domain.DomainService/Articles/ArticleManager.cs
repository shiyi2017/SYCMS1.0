using System;
using System.Collections.Generic;
using System.Text;
using SyZero.Common;
using SyZero.Domain.Interface;
using SyZero.Domain.Model;
namespace SyZero.Domain.DomainService.Articles
{
    public class ArticleManager : IArticleManager
    {
        private readonly IBaseRepository<Article> _articleRep;

        public ArticleManager(IBaseRepository<Article> articleRep)
        {
            _articleRep = articleRep;
        }
        public IEnumerable<Article> GetArticles(out int count,int page,int size)
        {
            return _articleRep.GetAllByPage((p => p.Id), out count, page, size);
        }

       

        
    }
}

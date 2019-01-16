using System;
using System.Collections.Generic;
using System.Text;

namespace SyZero.Application
{
    public interface IArticleService:IBaseService
    {
        IEnumerable<ArticleDto> GetArticles(out int count, int page, int size);
        void AddArticle(ArticleDto articleDto);
        void UpdataArticle(ArticleDto articleDto);
        void DeleteArticle(long id);
    }
}

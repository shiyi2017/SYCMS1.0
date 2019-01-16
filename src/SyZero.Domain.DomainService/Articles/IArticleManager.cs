using System;
using System.Collections.Generic;
using System.Text;

namespace SyZero.Domain.DomainService.Articles
{

    public interface IArticleManager:IDependency
    {
        IEnumerable<Model.Article> GetArticles(out int count,int page,int size);
    }
}

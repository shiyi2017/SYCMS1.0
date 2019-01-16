using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using SyZero.Application;
using SyZero.Common;
using SyZero.Domain.DomainService.Articles;
using SyZero.Domain.Interface;
using SyZero.Domain.Model;
using SyZero.Infrastructure.Repository;

namespace SyZero.Application
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleManager _articleManager;
        private readonly IBaseRepository<Article> _articleRep;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ArticleService(IArticleManager articleManager, IBaseRepository<Article> articleRep,  IMapper mapper, IUnitOfWork unitOfWork)
        {
            _articleManager = articleManager;
            _articleRep = articleRep;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<ArticleDto> GetArticles(out int count,int page,int size)
        {
            IEnumerable<Article> articles = _articleRep.GetAllByPage((p => p.Id), out count, page, size);
            Logger.Info("--------------查询了Article表:总数-" + count + ";页码-" + page + ";页长-" + size);
            return _mapper.Map<List<ArticleDto>>(articles);
        }

        public void UpdataArticle(ArticleDto articleDto)
        {
            Article articles = _mapper.Map<Article>(articleDto);
            Article article = _articleRep.GetById(articles.Id);
            article.UpdateArticle(articles.Title, articles.Ctid, articles.Author, articles.Img,
                articles.Content,articles.Status);
            _articleRep.Update(article);
            _unitOfWork.Commit();
            Logger.Info("--------修改了一条Article信息:" + JsonHelper.ObjectToJSON(article));
        }

        public void DeleteArticle(long id)
        {
            _articleRep.Delete(p => p.Id == id);
            _unitOfWork.Commit();
            Logger.Info("--------删除了一条Article信息:" + id);
        }

        public void AddArticle(ArticleDto articleDto)
        {
            try
            {
                Article articles = _mapper.Map<Article>(articleDto);
                Logger.Info("--------转换了一条Article信息:" + JsonHelper.ObjectToJSON(articles));
                Article article =
                    new Article().CreateArticle(articles.Title, articles.Ctid, articles.Author, articles.Img, articles.Content, articles.Status);
                _articleRep.Add(article);
                _unitOfWork.Commit();
                Logger.Info("--------添加了一条Article信息:" + JsonHelper.ObjectToJSON(article));
            }
            catch (Exception e)
            {
                Logger.Error("--------添加了Article信息出错:" + e);
            } 
        }
    }
}

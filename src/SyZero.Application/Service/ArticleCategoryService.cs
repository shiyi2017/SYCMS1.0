using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using SyZero.Common;
using SyZero.Domain.Interface;
using SyZero.Domain.Model;
using SyZero.Infrastructure.Repository;

namespace SyZero.Application
{
    public class ArticleCategoryService : IArticleCategoryService
    {
        private readonly IBaseRepository<Categorys> _ctRep;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ArticleCategoryService(IBaseRepository<Categorys> ctRep, IMapper mapper,IUnitOfWork unitOfWork)
        {
            _ctRep = ctRep;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public void AddCategory(CategoryDto categoryDto)
        {
            Categorys categorys = _mapper.Map<Categorys>(categoryDto);
            Logger.Info("----------------" + JsonHelper.ObjectToJSON(categorys));
            Categorys category = new Categorys().CreateCategorys("Article", categorys.Name,categorys.Describe, 1);

            _ctRep.Add(category);
            _unitOfWork.Commit();
            Logger.Info("--------添加了一条Categorys信息:Tc = Article; obj = " + JsonHelper.ObjectToJSON(categoryDto));
        }

        public void DelCategory(long id)
        {
            _ctRep.Delete(p => p.Id == id);
            _unitOfWork.Commit();
            Logger.Info("--------删除了一条Categorys信息:Tc = Article; Id = " + id);
        }

        public IEnumerable<CategoryDto> GetCategorys()
        {
            IEnumerable<Categorys> categorys = _ctRep.GetMany(p => p.TypeCode == "Article");
            Logger.Info("--------------查询了Categorys表:Tc = Article; obj = "+ categorys);
            return _mapper.Map<List<CategoryDto>>(categorys);
        }

        public void UpdateCategory(CategoryDto categoryDto)
        {
            Categorys categorys = _mapper.Map<Categorys>(categoryDto);
            Logger.Info("----------------" + JsonHelper.ObjectToJSON(categorys));
            Categorys category = _ctRep.GetById(categorys.Id);
            category.UpdateCategorys("Article", categorys.Name, categorys.Describe, 1);
            _ctRep.Update(category);
            _unitOfWork.Commit();
            Logger.Info("--------更新了一条Categorys信息:Tc = Article; obj = " + JsonHelper.ObjectToJSON(categoryDto));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using SyZero.Domain.Model;

namespace SyZero.Application
{
    public class AutoMapperConfigs:Profile
    {
        //添加你的实体映射关系.
        public AutoMapperConfigs()
        {
            //GoodsEntity转GoodsDto.
            CreateMap<Article, ArticleDto>()
                //映射发生之前
                .BeforeMap((source, dto) => {
                    //可以较为精确的控制输出数据格式
                    dto.AddTime = Convert.ToDateTime(source.AddTime).ToString("yyyy-MM-dd");
                    dto.Id = source.Id.ToString();
                })
                //映射发生之后
                .AfterMap((source, dto) => {
                    //code ...
                });

            //GoodsDto转GoodsEntity.
            CreateMap<ArticleDto, Article>();
           // CreateMap<ArticleDto, Article>().ForMember(sou => sou.Status, dto => dto.MapFrom(p => p.Status == "发布" ? 1 : 0));

            //Categorys转CategoryDto.
            CreateMap<Categorys, CategoryDto>()
                //映射发生之前
                .BeforeMap((source, dto) => {
                    //可以较为精确的控制输出数据格式
                    dto.UpdateTime = Convert.ToDateTime(source.UpDateTime).ToString("yyyy-MM-dd");
                    dto.Id = source.Id.ToString();
                })
                //映射发生之后
                .AfterMap((source, dto) => {
                    //code ...
                });

            //GoodsDto转GoodsEntity.
            CreateMap<CategoryDto, Categorys>();
        }
    
    }
}

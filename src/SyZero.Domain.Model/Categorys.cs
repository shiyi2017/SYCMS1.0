
using System;
using System.ComponentModel.DataAnnotations;

namespace SyZero.Domain.Model
{
    public class Categorys: EntityRoot
    {
        [MaxLength(200), Required]
        public string TypeCode { get; set; }
        [MaxLength(200), Required]
        public string Name { get; set; }
        public string Describe { get; set; }
        public int Status { get; set; }
        public int IsDisplay { get; set; }
        public System.DateTime AddTime { get; set; }
        public System.DateTime UpDateTime { get; set; }
        public int Parentid { get; set; }

        /// <summary>
        /// 文章构造函数
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="ctid">类型</param>
        /// <param name="author">作者</param>
        /// <param name="img">图片</param>
        /// <param name="context">内容</param>
        public Categorys(string typecode, string name, string des, int status)
        {
            TypeCode = typecode;
            Name = name;
            Describe = des;
            Status = status;
            AddTime = DateTime.Now;
            UpDateTime = DateTime.Now;
        }

        public Categorys()
        {

        }

        /// <summary>
        /// 创建新文章
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="ctid">类型</param>
        /// <param name="author">作者</param>
        /// <param name="img">图片</param>
        /// <param name="context">内容</param>
        /// <returns></returns>
        public Categorys CreateCategorys(string typecode, string name, string des, int status)
        {
            return new Categorys(typecode, name, des, status);
        }

        /// <summary>
        /// 修改Article
        /// </summary>
        /// <param name="title"></param>
        /// <param name="ctid"></param>
        /// <param name="author"></param>
        /// <param name="img"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public Categorys UpdateCategorys(string typecode, string name, string des, int status)
        {
            TypeCode = typecode;
            Name = name;
            Describe = des;
            Status = status;
            return this;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SyZero.Application
{
    public class ArticleDto
    {
        public string Id { get; set; }

        //标题
        public string Title { get; set; }

        //类型
        public string Ctid { get; set; }

        //作者
        public string Author { get; set; }

        //图片
        public string Img { get; set; }

        //日期
        public string AddTime { get; set; }

        //内容
        public string Content { get; set; }

        //热度
        public string Hot { get; set; }

        //状态
        public string Status { get; set; }
    }
}


using System.ComponentModel.DataAnnotations;

namespace SyZero.Domain.Model
{
    public class ArticleCategory : EntityRoot
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
    }
}

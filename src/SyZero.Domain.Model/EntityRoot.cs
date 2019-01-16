using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using SyZero.Common;
namespace SyZero.Domain.Model
{
    public abstract class EntityRoot : IEntityRoot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual long Id { get; set; }

        public EntityRoot()
        {
            Id = SnowflakeId.GetID();
        }
    }
}

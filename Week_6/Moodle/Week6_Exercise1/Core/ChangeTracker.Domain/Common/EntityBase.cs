using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTracker.Domain.Common
{
    public class EntityBase<TKey>
    {
        public Guid Id { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}

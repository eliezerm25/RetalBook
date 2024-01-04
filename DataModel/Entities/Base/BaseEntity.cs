using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entities.Base
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }
        public string ByCreated { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; }
        public string? ByModified { get; set; } = string.Empty;
        public DateTime? DateModified { get; set; }
        public string? ByDeleted { get; set; } = string.Empty;
        public DateTime? DateDeleted { get; set; }

    }
}

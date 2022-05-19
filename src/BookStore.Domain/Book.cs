using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace BookStore
{
    // xác  định thực thể Book kế thừa từ AuditedAggregateRoot có nghĩa là thực thể Book có thể được truy vấn và làm việc trực tiếp
    public class Book: AuditedAggregateRoot<Guid> // Guid là khóa chính của thực thể Book
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }   
    }
}

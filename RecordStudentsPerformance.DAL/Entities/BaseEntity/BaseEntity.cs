using System;

namespace RecordStudentsPerformance.DAL.Entities.BaseEntity
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public bool IsActive { get; set; }
        
        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset ModifiedOn { get; set; }
    }
}
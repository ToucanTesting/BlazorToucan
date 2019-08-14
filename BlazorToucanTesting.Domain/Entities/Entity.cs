using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorToucanTesting.Domain.Entities
{
    public class Entity
    {
        protected Entity()
        {
            CreateDate = DateTime.UtcNow;
            ModifiedDate = DateTime.UtcNow;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
using System;

namespace BlazorToucanTesting.Domain.Entities
{
    public class Module : TenantEntity
    {
        public string Name { get; set; }
        public int Sequence { get; set; }
        public DateTime? DisabledAt { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorToucanTesting.Domain.Entities
{
    public class UserBase : TenantEntity
    {
        public string Email { get; set; }
        public bool IsAuthenticated { get; set; }
    }

}

using System;
using System.Collections.Generic;

namespace CRUD_ASPNET.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string? NameUser { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Clave { get; set; }
    }
}

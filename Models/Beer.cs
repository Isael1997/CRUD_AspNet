using System;
using System.Collections.Generic;

namespace CRUD_ASPNET.Models
{
    public partial class Beer
    {
        public string? Beerld { get; set; }
        public string? NameBe { get; set; }
        public string Brandld { get; set; } = null!;

        public virtual Brand BrandldNavigation { get; set; } = null!;
    }
}

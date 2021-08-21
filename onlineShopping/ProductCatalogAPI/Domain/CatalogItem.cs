using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI.Domain
{
    public class CatalogItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Decription { get; set; }
        public int Price { get; set; }
        public string  PicURL { get; set; }

        public int BrandId { get; set; }
        public int TypeId { get; set; }
        public CatalogBrand CatalogBrand  { get; set; }
        public CatalogType CatalogType  { get; set; }
    }
}

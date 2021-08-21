using Microsoft.EntityFrameworkCore;
using ProductCatalogAPI.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI.Data
{
    public  static class CatalogSeed 
    {
         public static void Seed( CatalogContext catalogContext)
        {
            catalogContext.Database.Migrate();
            if (!catalogContext.CatalogTypes.Any())
            {
               // catalogContext.CatalogTypes.AddRange(GetCatalogTypes());
                catalogContext.SaveChanges();
            }
            if (!catalogContext.CatalogBrands.Any())
            {
               // catalogContext.CatalogBrands.AddRange(GetCatalogBrands());
                catalogContext.SaveChanges();
            }
            if (!catalogContext.CatalogItems.Any())
            {
                //catalogContext.CatalogItems.AddRange(GetCatalogItems());
                catalogContext.SaveChanges();
            }
        }

        //private static IEnumerable<CatalogItem> GetCatalogItems()
        //{
        //    return new List<CatalogItem> 
        //    { 
        //        new CatalogItem { },
        //        new CatalogItem { },
        //        new CatalogItem { }
        //    };
        //}

        //private static IEnumerable<CatalogBrand> GetCatalogBrands()
        //{
        //    return new List<CatalogBrand>
        //    {
        //        new CatalogBrand
        //        {
        //            Brand = "puma"
        //        } ,
        //        new CatalogBrand
        //        {
        //            Brand = "Nike"
        //        } ,
        //        new CatalogBrand
        //        {
        //            Brand = "Adidas"
        //        } 
        //    };
        //}

        //private static IEnumerable< CatalogType> GetCatalogTypes()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

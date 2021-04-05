using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Extensions
{
    public static class IEnumerableExtensions
    {
       public static IEnumerable<SelectListItem> ToSelectListItem<T>(this IEnumerable<T> Items)
        {
            List<SelectListItem> List = new List<SelectListItem>();
            SelectListItem sli = new SelectListItem
            {
                Text = "----Select-----",
                Value = "0"
            };
            List.Add(sli);
            //now to pass the object at run time instead at compile time use variabke rather object
            foreach (var Item in Items)
            {
                sli = new SelectListItem
                {
                    Text = Item.GetPropertyValue("Name"),
                    Value = Item.GetPropertyValue("Id")
                };
                List.Add(sli);
            }
            return List;
        }
    }
}

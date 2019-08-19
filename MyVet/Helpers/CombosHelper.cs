using Microsoft.AspNetCore.Mvc.Rendering;
using MyVet.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyVet.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _dataContext;

        public CombosHelper(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IEnumerable<SelectListItem> GetComboPetTypes()
        {
            // Transformation a collection in another
            var list = _dataContext.PetTypes.Select(pt => new SelectListItem
            {
                Text = pt.Name,
                Value = $"{pt.Id}"

            })
                .OrderBy(pt => pt.Text)
                .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Select a pet type...]",
                Value = "0"
            });
            return list;
        }

    }
}

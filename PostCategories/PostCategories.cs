using Blogifier.Core.Data.Domain;
using Blogifier.Core.Data.Interfaces;
using Blogifier.Core.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PostCategories
{
    public class PostCategories : ViewComponent
    {
        IUnitOfWork _db;

        public PostCategories(IUnitOfWork db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {
            IEnumerable<Category> postCategories = _db.Categories.All() ;

            return View(postCategories);
        }
    }
}

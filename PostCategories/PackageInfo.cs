using System;
using System.Collections.Generic;
using System.Text;
using Blogifier.Core.Data.Models;

namespace PostCategories 
{
    public class PackageInfo : IPackageInfo
    {
        PackageListItem IPackageInfo.GetAttributes()
        {
            return new PackageListItem
            {
                Title = "PostCategories",
                Description = "PostCategories widget to display post categories",
                Icon = "https://avatars0.githubusercontent.com/u/19671571?v=4&amp;s=180",
                ProjectUrl = "https://github.com/blogifierdotnet/Blogifier",
                Tags = "widget,categories"
            };
        }
    }
}

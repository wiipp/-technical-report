﻿using System.Web;
using System.Web.Mvc;

namespace Digigraf.RAT.UI.WEB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

﻿using System.Web;
using System.Web.Mvc;

namespace New_Git_Experience
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

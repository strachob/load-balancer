﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LoadBalancer.Logs.Web.Controllers
{
    public class LogsController : Controller
    {
        public IActionResult Index()
        {
            return View(Logger.GetLogs());
        }
    }
}
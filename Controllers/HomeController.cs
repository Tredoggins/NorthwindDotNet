﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class HomeController : Controller
    {
        // this controller depends on the NorthwindRepository
        private INorthwindRepository repository;
        public HomeController(INorthwindRepository repo) => repository = repo;

        public ActionResult Index() => View(repository.Discounts
            .Where(d => d.StartTime <= DateTime.Now && d.EndTime > DateTime.Now)
            .Take(3));
    }
}
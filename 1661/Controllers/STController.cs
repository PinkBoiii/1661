using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using _1661.Models;
using _1661.Models.Data;

namespace _1661.Controllers
{
    public class STController : Controller
    {
        DataContext dbc = new DataContext();

        public ActionResult GetData()
        {
            var emplist = dbc.STs.AsNoTracking().ProjectTo<SubST>();
            return Json(new {data = emplist},JsonRequestBehavior.AllowGet);

        }
    }
}
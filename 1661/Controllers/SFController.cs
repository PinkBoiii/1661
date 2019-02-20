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
    public class SFController : Controller
    {
        DataContext db = new DataContext();
        // GET: SF
        public ActionResult GetData()
        {
            var empList = db.SFs.AsNoTracking().ProjectTo<SubSF>();
            return Json(new {data = empList},JsonRequestBehavior.AllowGet);
        }

        

    }
}
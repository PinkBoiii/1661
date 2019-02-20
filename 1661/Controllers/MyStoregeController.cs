using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using _1661.Models;
using _1661.Models.Data;

namespace _1661.Controllers
{
    public class MyStoregeController : Controller
    {
        // GET: MyStorege
       DataContext dbc = new DataContext();

        [HttpPost]
        public ActionResult Delete(int ID)
        {
            var model = dbc.MyStoreges.Find(ID);
            dbc.MyStoreges.Remove(model);
            dbc.SaveChanges();
            return Json(new {mess ="Delete Success"},JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(int ID)
        {
            var model = dbc.MyStoreges.Find(ID);
            var modelMapping = Mapper.Map<SubMyStorege>(model);
            return Json(new {data = modelMapping}, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Search(string keyword)// thuat toan tim kiem
        {
            var model = dbc.MyStoreges.Where(a => a.NameOfRP.Contains(keyword)).ToList();// linkq

            return Json(new {data =model},JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult AddOrUpdate(MyStorege model)
        {
            if (model.IDMS == 0)
            {
                dbc.MyStoreges.Add(model);
                dbc.SaveChanges();
                return Json(new {mess = "Create Success!"}, JsonRequestBehavior.AllowGet);
            }
            else
            {
                dbc.Entry(model).State = EntityState.Modified;
                dbc.SaveChanges();
                return Json(new {mess = "Edit Success"}, JsonRequestBehavior.AllowGet);
            }

        }

        public ActionResult GetData()
        {
            var emplist = dbc.MyStoreges.AsNoTracking().ProjectTo<SubMyStorege>();
            return Json(new {data = emplist},JsonRequestBehavior.AllowGet);
        }
    }
}
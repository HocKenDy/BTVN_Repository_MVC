using BTVeNha.Models;
using BTVeNha.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTVeNha.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private RepositoryBase<Customer> ctm = new CustomerRepository();
        public ActionResult Index()
        {
            //for(int i=1;i<=10;++i)
            //{
            //    ctm.Add(new Customer
            //    {

            //        Name = "Name" + i,
            //        Address="Address"+i,
            //        Date=DateTime.Now,
            //        Email="Nguyenthaihoc"+i+"@gmail.com"
            //    });
            //    ctm.Commit();
            //}
            return View(ctm.GetAll());
        }
        public ActionResult ViewDetailCustomer(int id)
        {
            Customer cus = ctm.GetById(id);
            
            if(cus!=null)
            {
                ViewBag.Customer = cus;
                 return View("ViewDetailCustomer");
                
            }
            return View("NotFound");
        }
    }
}
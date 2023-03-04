using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;

namespace AmsProject.Controllers
{
    public class MainMastersController : Controller
    {
        // GET: MainMasters
        public ActionResult Enquiry()
        {
            extraClass.autogenId();
            return View();
        }
        [HttpPost]
        public ActionResult EnquiryRegistration(VmInquery vmInquery)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool enqObj = MasterClass.enqRegistration(vmInquery);
                    if (enqObj)
                    {
                        return Json(true, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(false, JsonRequestBehavior.AllowGet);
                    }
                    
                }
                else
                {
                    return Json(false, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(ex,JsonRequestBehavior.AllowGet);

            }
           
            
        }

    }
}
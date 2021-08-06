using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVC.Models;
using WebAppMVC.Repository;

namespace WebAppMVC.Controllers
{
    public class RefrigeranteController : BaseController<Refrigerante,RefriRepository>
    {
        public RefrigeranteController():base(new RefriRepository())
        {

        }
    }
}
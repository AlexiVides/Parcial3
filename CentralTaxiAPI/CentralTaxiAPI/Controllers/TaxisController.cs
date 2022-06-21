using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;

namespace CentralTaxiAPI.Controllers
{
    public class TaxisController : ApiController
    {
        // GET: Taxis
        [System.Web.Http.HttpPost]
        public IHttpActionResult Add()
        {
            using(Models.centralTaxiEntities db = new Models.centralTaxiEntities())
            {
                var taxis = new Models.Taxis();

                taxis.nombreTaxista = "ALexi Vide";
                taxis.matricula = "d342422";
                taxis.numChasis = "dgd5s6ww6";
                taxis.numVIN = "7363684483";
                db.Taxis.Add(taxis);
                db.SaveChanges();
            }
            return Ok("Hecho");
        }
    }
}
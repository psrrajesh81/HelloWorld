﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloWorld.DAL;
using System.Web.Http.Cors;
namespace HelloWorldAPI.Controllers
{
    [EnableCors("*", "*", "*")]
    public class HelloController : ApiController
    {
        [Route("DisplayMessage")]
        public string Get()
        {
            DataAccessLayer _objDL = new DataAccessLayer();

            string _strMessage = "";
            _strMessage = _objDL.DisplayMessage();
            return _strMessage;
        }
    }
}

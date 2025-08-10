﻿using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public abstract class BaseApiController : ApiController
    {
        public HttpResponseMessage Found(object obj)
        {
            return ControllerContext.Request.CreateResponse(HttpStatusCode.OK, obj);
        }

        public HttpResponseMessage Found()
        {
            return ControllerContext.Request.CreateResponse(HttpStatusCode.OK);
        }

        public HttpResponseMessage DoesNotExist()
        {
            return ControllerContext.Request.CreateResponse(HttpStatusCode.NotFound);
        }

        public HttpResponseMessage AlreadyExists()
        {
            return ControllerContext.Request.CreateResponse(HttpStatusCode.Conflict,"Record with the same Id already exits.");
        }

        public HttpResponseMessage RequestBad(string message)
        {
            return ControllerContext.Request.CreateResponse(HttpStatusCode.BadRequest, message);
        }
    }
}
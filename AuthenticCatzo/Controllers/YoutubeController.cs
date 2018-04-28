using AuthenticCatzo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AuthenticCatzo.Controllers
{
    [RoutePrefix("api/Videos")]
    public class YoutubeController : ApiController
    {
        [Route("GetVideoById")]
        public IHttpActionResult GetVideoById(String videoId)
        {
          var videoContent=  new YoutubeVideoService().GetVideoById(videoId);
            return Ok(videoContent);
        }


        [Route("GetVideoBySearch")]
        public IHttpActionResult GetVideoBySearch(String searchTerm)
        {
            var videoContent = new YoutubeVideoService().GetVideosBySearch(searchTerm);
            return Ok(videoContent);
        }
    }
}

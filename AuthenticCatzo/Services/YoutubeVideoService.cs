using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace AuthenticCatzo.Services
{
    public class YoutubeVideoService
    {
        public VideoListResponse GetVideoById(String videoId)
        {
            var YOUTUBE_API_KEY = ConfigurationManager.AppSettings["YOUTUBE_API_KEY"];
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = YOUTUBE_API_KEY,
                ApplicationName = this.GetType().ToString()
            });
            var vedios = youtubeService.Videos.List("id,snippet");
            vedios.Id = videoId;
            return  vedios.Execute();
        }


        public SearchListResponse GetVideosBySearch(String searchTerm)
        {
            var YOUTUBE_API_KEY = ConfigurationManager.AppSettings["YOUTUBE_API_KEY"];
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = YOUTUBE_API_KEY,
                ApplicationName = this.GetType().ToString()
            });
            var searchListRequest = youtubeService.Search.List("id,snippet");

            searchListRequest.Q = searchTerm; // Replace with your search term.
            //searchListRequest.RelatedToVideoId = "zirWzpbsW2c";
            //searchListRequest.PrettyPrint = true;
            //searchListRequest.Type = "video";

            //searchListRequest.VideoType = SearchResource.ListRequest.VideoTypeEnum.Movie;
            //searchListRequest.VideoDuration = SearchResource.ListRequest.VideoDurationEnum.Long__;
            searchListRequest.MaxResults = 50;

          //  Call the search.list method to retrieve results matching the specified query term.
             return searchListRequest.Execute();
        }
    }
}
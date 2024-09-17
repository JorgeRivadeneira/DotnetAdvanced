using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class YouTubeAPI
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //Access youtube web service
                //Read the data
                //Create a list of video objects
                throw new Exception("Ooops");
            }
            catch (Exception ex)
            {
                //Log

                throw new YouTubeException("Could not fetch the videos from YouTube", ex);
            }
            return new List<Video>();
        }
    }
}

using Facebook;
using GuidanceFacebookAPI.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GuidanceFacebookAPI
{
    internal class FacebookApi
    {
        public string PageAccessToken;
        public string UserAccessToken;


        public async Task PostMessage(string userId, string message, DateTime uploadDate)
        {
            try
            {
                FacebookClient facebookClient = new FacebookClient();

                dynamic messagePost = new ExpandoObject();
                messagePost.access_token = PageAccessToken;
                messagePost.message = message;
                messagePost.scheduled_publish_time = (int)uploadDate.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
                messagePost.published = false;

                var result = await facebookClient.Post($"/{userId}/feed", messagePost);
                Console.WriteLine(result);
            }
            catch (FacebookOAuthException ex)
            {

            }
            catch (Exception ex)
            {

            }

        }

    }
}

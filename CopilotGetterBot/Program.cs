using System;
using Tweetinvi;
using Tweetinvi.Parameters;
using Tweetinvi.Models;
using System.Threading.Tasks;

namespace CopilotGetterBot
{
    internal class CopilotGetter
    {


        // fun fact if you generate AcessToken and AcessSecretToken before changing App permissions from Read to Read and Write
        // these tokens are still only for Read and to get Read and Write permissions you need to regenerate these tokens

        // add your tokens from https://developer.twitter.com
        private static readonly string ApiKey = "Q...z";
        private static readonly string ApiKeySecret = "1...H";
        private static readonly string AcessToken = "3...L";
        private static readonly string AcessSecretToken = "H...6";

        static async Task Main()
        {

            TwitterClient twitterClient = new TwitterClient(ApiKey, ApiKeySecret, AcessToken,AcessSecretToken);
            //                                                           set up your own text  
            ITweet tweet = await twitterClient.Tweets.PublishTweetAsync("@GitHub let me use copilot\nmy GitHub page:\n (url)");

        }
        
    }
}

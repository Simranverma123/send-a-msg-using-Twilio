using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace LearnTwilio
{    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            var accountSid=Secrets.AccoutSid;
            var authToken=Secrets.AuthToken;
            var Tonumber=Secrets.ToNumber;
            var Fromnumber=Secrets.FromNumber;
            
             TwilioClient.Init(accountSid,authToken);

              var message = MessageResource.Create(
                  to: new PhoneNumber(Tonumber),
                  from: new PhoneNumber(Fromnumber),
                  body:"Hi There Thanks for creating and joining LHD"
              ); 
              Console.WriteLine(message.Sid);  
        } 
    }
}
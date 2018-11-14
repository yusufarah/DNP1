using System;
using System.IO;
using System.Net.Mail;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Collections.Generic;
using System.Threading;

namespace database
{
    class Mail
    {
        
        public static void sendBookingConfirmationTo(Reservation reservation)
        {
            var msg = new AE.Net.Mail.MailMessage
            {
                Subject = "Thank you! Your booking details",
                Body = $"Movie title: {reservation.Schedule.Movie.name}"+ Environment.NewLine +
                $"date and time: {reservation.date_time}" + Environment.NewLine +
                $"Room: {reservation.room}" + Environment.NewLine +
                $"seat: {reservation.seat_no}" + Environment.NewLine +
                $"price: {reservation.Schedule.Movie.price}",
                From = new MailAddress("VIACINEMA2018@gmail.com")
            };

            msg.To.Add(new MailAddress(reservation.email));
            msg.ReplyTo.Add(msg.From); 
            var msgStr = new StringWriter();
            msg.Save(msgStr);

            
            var gmail = getGmailService();
            var result = gmail.Users.Messages.Send(new Message
            {
                Raw = Base64UrlEncode(msgStr.ToString())
            }, "me").Execute();
            Console.WriteLine("Message ID {0} sent.", result.Id);
        }

        private static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            // Special "url-safe" base64 encode.
            return Convert.ToBase64String(inputBytes)
              .Replace('+', '-')
              .Replace('/', '_')
              .Replace("=", "");
        }

        private static GmailService getGmailService()
        {
            // If modifying these scopes, delete your previously saved credentials
            // at ~/.credentials/gmail-dotnet-quickstart.json
            string[] Scopes = { GmailService.Scope.GmailCompose };
            string ApplicationName = "Gmail API .NET Quickstart";
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            // Create Gmail API service.
            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            return (GmailService)service;
        }
    }
}

using Castle.Core.Smtp;

namespace CastleEmailSender
{
  class Program
  {
    static void Main(string[] args)
    {
      var sender = new DefaultSmtpSender();

      // Things that get reset from the auto-configuring SmtpClient:
      // - Port (587 in config, 25 wehn debugging)
      // - Credentials (user/pass in config, default creds when debugging)
      sender.Send("you@googlemail.com", "example@example.com", "Subject", "Text");
    }
  }
}

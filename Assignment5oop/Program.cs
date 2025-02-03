using System.Net.Mail;

namespace Assignment5oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //ICircle circle = new Circle(5);
            //circle.DisplayShapeInfo();


            //IRectangle rectangle = new Rectangle(9, 10);
            //rectangle.DisplayShapeInfo();
            #endregion
            #region Q3
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsserivce = new SmsNotificationService();
            INotificationService pushserivce = new PushNotificationService();

            emailService.SendNotification("Mohamed@123.com", "This is an email notification.");
            smsserivce.SendNotification("01012457419", "This is an SMS notification.");
            pushserivce.SendNotification("userDeviceId", "This is a push notification.");

            #endregion

        }
    }
}

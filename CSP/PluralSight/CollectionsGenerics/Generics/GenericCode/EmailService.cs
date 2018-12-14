namespace CSP.PluralSight.CollectionsGenerics.Generics.GenericCode
{
    public class EmailService
    {
        public string SendMessage(string subject, string message, string recipient)
        {
            var confirmation = "Message sent: " + subject;
            LoggingService.LogAction(confirmation);
            return confirmation;
        }
    }
}

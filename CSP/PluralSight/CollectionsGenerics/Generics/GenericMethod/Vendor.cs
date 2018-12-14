using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using CSP.PluralSight.CollectionsGenerics.Arrays;
using CSP.PluralSight.CollectionsGenerics.Generics.GenericCode;

namespace CSP.PluralSight.CollectionsGenerics.Generics.GenericMethod
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }

        public OperationResult PlaceOrder(Product product, int quantity, DateTimeOffset? deliverBy = null,
            string instructions = "standard delivery")
        {
            if (product == null)
                throw new ArgumentNullException("product");
            if (quantity <= 0)
                throw new ArgumentOutOfRangeException("quantity");
            if (deliverBy <= DateTimeOffset.Now)
                throw new ArgumentOutOfRangeException("deliverBy");

            var success = false;

            var orderTextBuilder = new StringBuilder("Order from Acme, Inc" + 
                Environment.NewLine +
                "Product: " + product.ProductName +
                Environment.NewLine +
                "Quantity: " + quantity);

            if (deliverBy.HasValue)
            {
                orderTextBuilder.Append(Environment.NewLine +
                                        "Deliver By: " + deliverBy.Value.ToString("d"));
            }
            if (!String.IsNullOrWhiteSpace(instructions))
            {
                orderTextBuilder.Append(Environment.NewLine +
                                        "Instructions: " + instructions);
            }
            var orderText = orderTextBuilder.ToString();

            var emailService = new EmailService();
            var confirmation = emailService.SendMessage("New Order", orderText, Email);

            if (confirmation.StartsWith("Message sent:"))
                success = true;

            var operationResult = new OperationResult(success, orderText);

            return operationResult;
        }

        public string SendWelcomeEmail(string message)
        {
            var emailService = new EmailService();
            var subject = ("Hello " + this.CompanyName).Trim();
            var confirmation = emailService.SendMessage(subject, message, Email);

            return confirmation;
        }
    }
}

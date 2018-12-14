using System.Xml.Serialization;

namespace CSP.TeknowlogiAPIs.MercuryGate
{
    public class MercuryGateMockRawResponse
    {
        [XmlType(AnonymousType = true)]
        [XmlRootAttribute("service-response", Namespace = "", IsNullable = false)]
        public partial class Serviceresponse
        {
            [XmlElementAttribute("service-id")]
            public string Serviceid { get; set; }

            [XmlElementAttribute("request-id")]
            public string RequestId { get; set; }

            [XmlElementAttribute("status")]
            public Status Status { get; set; }

            [XmlElementAttribute("error")]
            public object Error { get; set; }

            [XmlElementAttribute("data")]
            public string Data { get; set; }

            public MercuryGateMockResponse.MercuryGate ShipmentObject { get; set; }

            public MercuryGateResponseDataLogs.Logs ErrorLog { get; set; }
        }

        [XmlTypeAttribute(AnonymousType = true)]
        public partial class Status
        {
            [XmlElementAttribute("code")]
            public string Code { get; set; }

            [XmlElementAttribute("message")]
            public string Message { get; set; }
        }
    }
}
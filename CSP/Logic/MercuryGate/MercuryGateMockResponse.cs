using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSP.TeknowlogiAPIs.MercuryGate
{
    public class MercuryGateMockResponse
    {
        [XmlRoot(ElementName = "Date")]
        public class Date
        {
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "ContactMethod")]
        public class ContactMethod
        {
            [XmlAttribute(AttributeName = "sequenceNum")]
            public string SequenceNum { get; set; }
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "ContactMethods")]
        public class ContactMethods
        {
            [XmlElement(ElementName = "ContactMethod")]
            public List<ContactMethod> ContactMethod { get; set; }
        }

        [XmlRoot(ElementName = "User")]
        public class User
        {
            [XmlElement(ElementName = "ContactMethods")]
            public ContactMethods ContactMethods { get; set; }
            [XmlAttribute(AttributeName = "UserId")]
            public string UserId { get; set; }
            [XmlAttribute(AttributeName = "FirstName")]
            public string FirstName { get; set; }
            [XmlAttribute(AttributeName = "LastName")]
            public string LastName { get; set; }
        }

        [XmlRoot(ElementName = "ExtractRequest")]
        public class ExtractRequest
        {
            [XmlElement(ElementName = "Date")]
            public string Date { get; set; }
            [XmlElement(ElementName = "Reason")]
            public string Reason { get; set; }
            [XmlElement(ElementName = "User")]
            public User User { get; set; }
        }

        [XmlRoot(ElementName = "Header")]
        public class Header
        {
            [XmlElement(ElementName = "SenderID")]
            public string SenderID { get; set; }
            [XmlElement(ElementName = "ReceiverID")]
            public string ReceiverID { get; set; }
            [XmlElement(ElementName = "DocTypeID")]
            public string DocTypeID { get; set; }
            [XmlElement(ElementName = "DocCount")]
            public string DocCount { get; set; }
            [XmlElement(ElementName = "Date")]
            public Date Date { get; set; }
            [XmlElement(ElementName = "ExtractRequest")]
            public ExtractRequest ExtractRequest { get; set; }
        }

        [XmlRoot(ElementName = "ReferenceNumber")]
        public class ReferenceNumber
        {
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
            [XmlAttribute(AttributeName = "isPrimary")]
            public string IsPrimary { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "ReferenceNumbers")]
        public class ReferenceNumbers
        {
            [XmlElement(ElementName = "ReferenceNumber")]
            public List<ReferenceNumber> ReferenceNumber { get; set; }
        }

        [XmlRoot(ElementName = "LetterOfCredit")]
        public class LetterOfCredit
        {
            [XmlElement(ElementName = "Number")]
            public string Number { get; set; }
            [XmlElement(ElementName = "IssuedDate")]
            public string IssuedDate { get; set; }
            [XmlElement(ElementName = "ExpirationDate")]
            public string ExpirationDate { get; set; }
        }

        [XmlRoot(ElementName = "GenericField")]
        public class GenericField
        {
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
            [XmlAttribute(AttributeName = "format")]
            public string Format { get; set; }
        }

        [XmlRoot(ElementName = "InternationalDetails")]
        public class InternationalDetails
        {
            [XmlElement(ElementName = "MoveType")]
            public string MoveType { get; set; }
            [XmlElement(ElementName = "VesselName")]
            public string VesselName { get; set; }
            [XmlElement(ElementName = "VoyageNumber")]
            public string VoyageNumber { get; set; }
            [XmlElement(ElementName = "LLoydsCode")]
            public string LLoydsCode { get; set; }
            [XmlElement(ElementName = "LetterOfCredit")]
            public LetterOfCredit LetterOfCredit { get; set; }
            [XmlElement(ElementName = "ImmediateTransportationNumber")]
            public string ImmediateTransportationNumber { get; set; }
            [XmlElement(ElementName = "ImmediateTransportationDate")]
            public string ImmediateTransportationDate { get; set; }
            [XmlElement(ElementName = "TransportationAndExportationNumber")]
            public string TransportationAndExportationNumber { get; set; }
            [XmlElement(ElementName = "ImmediateExportNumber")]
            public string ImmediateExportNumber { get; set; }
            [XmlElement(ElementName = "ExporterReferenceNumber")]
            public string ExporterReferenceNumber { get; set; }
            [XmlElement(ElementName = "ExporterLicenseNumber")]
            public string ExporterLicenseNumber { get; set; }
            [XmlElement(ElementName = "ExportLicenseDate")]
            public string ExportLicenseDate { get; set; }
            [XmlElement(ElementName = "FMCNumber")]
            public string FMCNumber { get; set; }
            [XmlElement(ElementName = "InternalTransactionNumber")]
            public string InternalTransactionNumber { get; set; }
            [XmlElement(ElementName = "ElectronicExportInformation")]
            public string ElectronicExportInformation { get; set; }
            [XmlElement(ElementName = "ExportDeclaration")]
            public string ExportDeclaration { get; set; }
            [XmlElement(ElementName = "USAMSNumber")]
            public string USAMSNumber { get; set; }
            [XmlElement(ElementName = "DestinationControlStatement")]
            public string DestinationControlStatement { get; set; }
            [XmlElement(ElementName = "ISFShipmentType")]
            public string ISFShipmentType { get; set; }
            [XmlElement(ElementName = "ISFBondHolder")]
            public string ISFBondHolder { get; set; }
            [XmlElement(ElementName = "ISFBondNumber")]
            public string ISFBondNumber { get; set; }
            [XmlElement(ElementName = "SuretyNumber")]
            public string SuretyNumber { get; set; }
            [XmlElement(ElementName = "PointOfOrigin")]
            public string PointOfOrigin { get; set; }
            [XmlElement(ElementName = "ContainerStuffingLocation")]
            public string ContainerStuffingLocation { get; set; }
            [XmlElement(ElementName = "ContainerStufferLocation")]
            public string ContainerStufferLocation { get; set; }
            [XmlElement(ElementName = "PortOfEntry")]
            public string PortOfEntry { get; set; }
            [XmlElement(ElementName = "PortOfExport")]
            public string PortOfExport { get; set; }
            [XmlElement(ElementName = "FirstPortOfUnlading")]
            public string FirstPortOfUnlading { get; set; }
            [XmlElement(ElementName = "FinalPortOfDestination")]
            public string FinalPortOfDestination { get; set; }
            [XmlElement(ElementName = "FinalCountryOfDestination")]
            public string FinalCountryOfDestination { get; set; }
            [XmlElement(ElementName = "GenericField")]
            public GenericField GenericField { get; set; }
            [XmlElement(ElementName = "AESVesselFlag")]
            public string AESVesselFlag { get; set; }
            [XmlElement(ElementName = "AESImportEntryNumber")]
            public string AESImportEntryNumber { get; set; }
            [XmlElement(ElementName = "AESInbondType")]
            public string AESInbondType { get; set; }
            [XmlElement(ElementName = "AESRelatedCompanies")]
            public string AESRelatedCompanies { get; set; }
            [XmlElement(ElementName = "AESRoutedTransaction")]
            public string AESRoutedTransaction { get; set; }
            [XmlElement(ElementName = "ReasonForExport")]
            public string ReasonForExport { get; set; }
            [XmlElement(ElementName = "ECCN")]
            public string ECCN { get; set; }
            [XmlElement(ElementName = "BlanketPeriodBeginDate")]
            public string BlanketPeriodBeginDate { get; set; }
            [XmlElement(ElementName = "BlanketPeriodEndDate")]
            public string BlanketPeriodEndDate { get; set; }
        }

        [XmlRoot(ElementName = "GeoLoc")]
        public class GeoLoc
        {
            [XmlAttribute(AttributeName = "latDegrees")]
            public string LatDegrees { get; set; }
            [XmlAttribute(AttributeName = "latDirection")]
            public string LatDirection { get; set; }
            [XmlAttribute(AttributeName = "longDegrees")]
            public string LongDegrees { get; set; }
            [XmlAttribute(AttributeName = "longDirection")]
            public string LongDirection { get; set; }
        }

        [XmlRoot(ElementName = "Contact")]
        public class Contact
        {
            [XmlElement(ElementName = "Name")]
            public string Name { get; set; }
            [XmlElement(ElementName = "ContactMethods")]
            public ContactMethods ContactMethods { get; set; }
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
            [XmlAttribute(AttributeName = "oid")]
            public string Oid { get; set; }
        }

        [XmlRoot(ElementName = "Contacts")]
        public class Contacts
        {
            [XmlElement(ElementName = "Contact")]
            public Contact Contact { get; set; }
        }

        [XmlRoot(ElementName = "Address")]
        public class Address
        {
            [XmlElement(ElementName = "Owner")]
            public string Owner { get; set; }
            [XmlElement(ElementName = "CustomerAcctNum")]
            public string CustomerAcctNum { get; set; }
            [XmlElement(ElementName = "LocationCode")]
            public string LocationCode { get; set; }
            [XmlElement(ElementName = "Name")]
            public string Name { get; set; }
            [XmlElement(ElementName = "AddrLine1")]
            public string AddrLine1 { get; set; }
            [XmlElement(ElementName = "AddrLine2")]
            public string AddrLine2 { get; set; }
            [XmlElement(ElementName = "City")]
            public string City { get; set; }
            [XmlElement(ElementName = "StateProvince")]
            public string StateProvince { get; set; }
            [XmlElement(ElementName = "PostalCode")]
            public string PostalCode { get; set; }
            [XmlElement(ElementName = "CountryCode")]
            public string CountryCode { get; set; }
            [XmlElement(ElementName = "GeoLoc")]
            public GeoLoc GeoLoc { get; set; }
            [XmlElement(ElementName = "Contacts")]
            public Contacts Contacts { get; set; }
            [XmlElement(ElementName = "Comments")]
            public string Comments { get; set; }
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
            [XmlAttribute(AttributeName = "isResidential")]
            public string IsResidential { get; set; }
            [XmlAttribute(AttributeName = "isPrimary")]
            public string IsPrimary { get; set; }
            [XmlElement(ElementName = "AppointmentTime")]
            public List<AppointmentTime> AppointmentTime { get; set; }
        }

        [XmlRoot(ElementName = "BillTo")]
        public class BillTo
        {
            [XmlElement(ElementName = "Address")]
            public Address Address { get; set; }
        }

        [XmlRoot(ElementName = "Payment")]
        public class Payment
        {
            [XmlElement(ElementName = "Method")]
            public string Method { get; set; }
            [XmlElement(ElementName = "BillTo")]
            public BillTo BillTo { get; set; }
        }

        [XmlRoot(ElementName = "Audit")]
        public class Audit
        {
            [XmlAttribute(AttributeName = "timestamp")]
            public string Timestamp { get; set; }
            [XmlAttribute(AttributeName = "user")]
            public string User { get; set; }
            [XmlAttribute(AttributeName = "action")]
            public string Action { get; set; }
        }

        [XmlRoot(ElementName = "Audits")]
        public class Audits
        {
            [XmlElement(ElementName = "Audit")]
            public Audit Audit { get; set; }
        }

        [XmlRoot(ElementName = "Insurance")]
        public class Insurance
        {
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
            [XmlAttribute(AttributeName = "amount")]
            public string Amount { get; set; }
            [XmlAttribute(AttributeName = "company")]
            public string Company { get; set; }
            [XmlAttribute(AttributeName = "expirationDate")]
            public string ExpirationDate { get; set; }
            [XmlAttribute(AttributeName = "contactName")]
            public string ContactName { get; set; }
            [XmlAttribute(AttributeName = "contactPhone")]
            public string ContactPhone { get; set; }
        }

        [XmlRoot(ElementName = "InsuranceTypes")]
        public class InsuranceTypes
        {
            [XmlElement(ElementName = "Insurance")]
            public List<Insurance> Insurance { get; set; }
        }

        [XmlRoot(ElementName = "Carrier")]
        public class Carrier
        {
            [XmlElement(ElementName = "CarrierId")]
            public string CarrierId { get; set; }
            [XmlElement(ElementName = "CarrierName")]
            public string CarrierName { get; set; }
            [XmlElement(ElementName = "SCAC")]
            public string SCAC { get; set; }
            [XmlElement(ElementName = "Mode")]
            public string Mode { get; set; }
            [XmlElement(ElementName = "Service")]
            public string Service { get; set; }
            [XmlElement(ElementName = "ServiceDays")]
            public string ServiceDays { get; set; }
            [XmlElement(ElementName = "Distance")]
            public string Distance { get; set; }
            [XmlElement(ElementName = "Id")]
            public string Id { get; set; }
            [XmlElement(ElementName = "InsuranceTypes")]
            public InsuranceTypes InsuranceTypes { get; set; }
            [XmlElement(ElementName = "Address")]
            public Address Address { get; set; }
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
        }

        [XmlRoot(ElementName = "Carriers")]
        public class Carriers
        {
            [XmlElement(ElementName = "Carrier")]
            public Carrier Carrier { get; set; }
        }

        [XmlRoot(ElementName = "Origin")]
        public class Origin
        {
            [XmlElement(ElementName = "Address")]
            public Address Address { get; set; }
        }

        [XmlRoot(ElementName = "Destination")]
        public class Destination
        {
            [XmlElement(ElementName = "Address")]
            public Address Address { get; set; }
        }

        [XmlRoot(ElementName = "TerminalInfo")]
        public class TerminalInfo
        {
            [XmlElement(ElementName = "Origin")]
            public Origin Origin { get; set; }
            [XmlElement(ElementName = "Destination")]
            public Destination Destination { get; set; }
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
        }

        [XmlRoot(ElementName = "Pickup")]
        public class Pickup
        {
            [XmlElement(ElementName = "Date")]
            public List<Date> Date { get; set; }
        }

        [XmlRoot(ElementName = "Drop")]
        public class Drop
        {
            [XmlElement(ElementName = "Date")]
            public List<Date> Date { get; set; }
        }

        [XmlRoot(ElementName = "Dates")]
        public class Dates
        {
            [XmlElement(ElementName = "Pickup")]
            public Pickup Pickup { get; set; }
            [XmlElement(ElementName = "Drop")]
            public Drop Drop { get; set; }
            [XmlElement(ElementName = "Date")]
            public List<Date> Date { get; set; }
        }

        [XmlRoot(ElementName = "AppointmentTime")]
        public class AppointmentTime
        {
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "Event")]
        public class Event
        {
            [XmlElement(ElementName = "CarrierActionCode")]
            public string CarrierActionCode { get; set; }
            [XmlElement(ElementName = "Dates")]
            public Dates Dates { get; set; }
            [XmlElement(ElementName = "LateReason")]
            public string LateReason { get; set; }
            [XmlElement(ElementName = "AppointmentType")]
            public string AppointmentType { get; set; }
            [XmlElement(ElementName = "Address")]
            public Address Address { get; set; }
            [XmlElement(ElementName = "Shipments")]
            public string Shipments { get; set; }
            [XmlElement(ElementName = "Activities")]
            public string Activities { get; set; }
            [XmlElement(ElementName = "TrackingMessages")]
            public string TrackingMessages { get; set; }
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
            [XmlAttribute(AttributeName = "sequenceNum")]
            public string SequenceNum { get; set; }
            [XmlAttribute(AttributeName = "internalId")]
            public string InternalId { get; set; }
        }

        [XmlRoot(ElementName = "Events")]
        public class Events
        {
            [XmlElement(ElementName = "Event")]
            public List<Event> Event { get; set; }
            [XmlAttribute(AttributeName = "count")]
            public string Count { get; set; }
        }

        [XmlRoot(ElementName = "Plan")]
        public class Plan
        {
            [XmlElement(ElementName = "Events")]
            public Events Events { get; set; }
        }

        [XmlRoot(ElementName = "Weight")]
        public class Weight
        {
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
            [XmlAttribute(AttributeName = "uom")]
            public string Uom { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "Weights")]
        public class Weights
        {
            [XmlElement(ElementName = "Weight")]
            public Weight Weight { get; set; }
        }

        [XmlRoot(ElementName = "Dimension")]
        public class Dimension
        {
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
            [XmlAttribute(AttributeName = "dim")]
            public string Dim { get; set; }
            [XmlAttribute(AttributeName = "uom")]
            public string Uom { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "Dimensions")]
        public class Dimensions
        {
            [XmlElement(ElementName = "Dimension")]
            public List<Dimension> Dimension { get; set; }
        }

        [XmlRoot(ElementName = "Quantity")]
        public class Quantity
        {
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
            [XmlText]
            public string Text { get; set; }
        }

        [XmlRoot(ElementName = "Quantities")]
        public class Quantities
        {
            [XmlElement(ElementName = "Quantity")]
            public List<Quantity> Quantity { get; set; }
        }

        [XmlRoot(ElementName = "Charge")]
        public class Charge
        {
            [XmlElement(ElementName = "Description")]
            public string Description { get; set; }
            [XmlElement(ElementName = "EdiCode")]
            public string EdiCode { get; set; }
            [XmlElement(ElementName = "Amount")]
            public string Amount { get; set; }
            [XmlElement(ElementName = "Rate")]
            public string Rate { get; set; }
            [XmlElement(ElementName = "RateQualifier")]
            public string RateQualifier { get; set; }
            [XmlElement(ElementName = "Quantity")]
            public string Quantity { get; set; }
            [XmlElement(ElementName = "Weight")]
            public string Weight { get; set; }
            [XmlElement(ElementName = "DimWeight")]
            public string DimWeight { get; set; }
            [XmlElement(ElementName = "FreightClass")]
            public string FreightClass { get; set; }
            [XmlElement(ElementName = "FakFreightClass")]
            public string FakFreightClass { get; set; }
            [XmlElement(ElementName = "IsMin")]
            public string IsMin { get; set; }
            [XmlElement(ElementName = "IsMax")]
            public string IsMax { get; set; }
            [XmlElement(ElementName = "IsNontaxable")]
            public string IsNontaxable { get; set; }
            [XmlElement(ElementName = "ReferenceNumbers")]
            public string ReferenceNumbers { get; set; }
            [XmlAttribute(AttributeName = "sequenceNum")]
            public string SequenceNum { get; set; }
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
            [XmlAttribute(AttributeName = "itemGroupId")]
            public string ItemGroupId { get; set; }
        }

        [XmlRoot(ElementName = "Charges")]
        public class Charges
        {
            [XmlElement(ElementName = "Charge")]
            public List<Charge> Charge { get; set; }
        }

        [XmlRoot(ElementName = "PriceSheet")]
        public class PriceSheet
        {
            [XmlElement(ElementName = "AccessorialTotal")]
            public string AccessorialTotal { get; set; }
            [XmlElement(ElementName = "SubTotal")]
            public string SubTotal { get; set; }
            [XmlElement(ElementName = "Total")]
            public string Total { get; set; }
            [XmlElement(ElementName = "ContractId")]
            public string ContractId { get; set; }
            [XmlElement(ElementName = "ContractName")]
            public string ContractName { get; set; }
            [XmlElement(ElementName = "Carrier")]
            public Carrier Carrier { get; set; }
            [XmlElement(ElementName = "ReasonCode")]
            public string ReasonCode { get; set; }
            [XmlElement(ElementName = "Status")]
            public string Status { get; set; }
            [XmlElement(ElementName = "LaneID")]
            public string LaneID { get; set; }
            [XmlElement(ElementName = "Zone")]
            public string Zone { get; set; }
            [XmlElement(ElementName = "RouteGuidePriority")]
            public string RouteGuidePriority { get; set; }
            [XmlElement(ElementName = "CarrierLocationOid")]
            public string CarrierLocationOid { get; set; }
            [XmlElement(ElementName = "OriginService")]
            public string OriginService { get; set; }
            [XmlElement(ElementName = "DestinationService")]
            public string DestinationService { get; set; }
            [XmlElement(ElementName = "DimFactor")]
            public string DimFactor { get; set; }
            [XmlElement(ElementName = "DimWeight")]
            public string DimWeight { get; set; }
            [XmlElement(ElementName = "TotalWeight")]
            public string TotalWeight { get; set; }
            [XmlElement(ElementName = "ChargeableWeight")]
            public string ChargeableWeight { get; set; }
            [XmlElement(ElementName = "Charges")]
            public Charges Charges { get; set; }
            [XmlElement(ElementName = "Comments")]
            public string Comments { get; set; }
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
            [XmlAttribute(AttributeName = "chargeModel")]
            public string ChargeModel { get; set; }
            [XmlAttribute(AttributeName = "isSelected")]
            public string IsSelected { get; set; }
            [XmlAttribute(AttributeName = "isAllocated")]
            public string IsAllocated { get; set; }
            [XmlAttribute(AttributeName = "currencyCode")]
            public string CurrencyCode { get; set; }
            [XmlAttribute(AttributeName = "createDate")]
            public string CreateDate { get; set; }
            [XmlAttribute(AttributeName = "updateDate")]
            public string UpdateDate { get; set; }
            [XmlAttribute(AttributeName = "internalId")]
            public string InternalId { get; set; }
            [XmlAttribute(AttributeName = "createBy")]
            public string CreateBy { get; set; }
            [XmlAttribute(AttributeName = "updateBy")]
            public string UpdateBy { get; set; }
        }

        [XmlRoot(ElementName = "PriceSheets")]
        public class PriceSheets
        {
            [XmlElement(ElementName = "PriceSheet")]
            public List<PriceSheet> PriceSheet { get; set; }
        }

        [XmlRoot(ElementName = "TenderResponse")]
        public class TenderResponse
        {
            [XmlAttribute(AttributeName = "carrierSCAC")]
            public string CarrierSCAC { get; set; }
            [XmlAttribute(AttributeName = "actioncode")]
            public string Actioncode { get; set; }
            [XmlAttribute(AttributeName = "date")]
            public string Date { get; set; }
        }

        [XmlRoot(ElementName = "Tender")]
        public class Tender
        {
            [XmlElement(ElementName = "TenderResponse")]
            public TenderResponse TenderResponse { get; set; }
            [XmlAttribute(AttributeName = "user")]
            public string User { get; set; }
            [XmlAttribute(AttributeName = "carrierSCAC")]
            public string CarrierSCAC { get; set; }
            [XmlAttribute(AttributeName = "method")]
            public string Method { get; set; }
            [XmlAttribute(AttributeName = "date")]
            public string Date { get; set; }
        }

        [XmlRoot(ElementName = "Tenders")]
        public class Tenders
        {
            [XmlElement(ElementName = "Tender")]
            public Tender Tender { get; set; }
        }

        [XmlRoot(ElementName = "Activity")]
        public class Activity
        {
            [XmlElement(ElementName = "ActivityID")]
            public string ActivityID { get; set; }
            [XmlElement(ElementName = "Summary")]
            public string Summary { get; set; }
            [XmlElement(ElementName = "Priority")]
            public string Priority { get; set; }
            [XmlElement(ElementName = "Required")]
            public string Required { get; set; }
            [XmlElement(ElementName = "Status")]
            public string Status { get; set; }
            [XmlElement(ElementName = "AssignedTo")]
            public string AssignedTo { get; set; }
            [XmlElement(ElementName = "PercentageComplete")]
            public string PercentageComplete { get; set; }
            [XmlElement(ElementName = "CompletedDate")]
            public string CompletedDate { get; set; }
            [XmlElement(ElementName = "StatusDetails")]
            public string StatusDetails { get; set; }
            [XmlElement(ElementName = "Location")]
            public string Location { get; set; }
            [XmlElement(ElementName = "Contact")]
            public string Contact { get; set; }
            [XmlElement(ElementName = "Documents")]
            public string Documents { get; set; }
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
        }

        [XmlRoot(ElementName = "Activities")]
        public class Activities
        {
            [XmlElement(ElementName = "Activity")]
            public Activity Activity { get; set; }
        }

        [XmlRoot(ElementName = "MasterBillOfLading")]
        public class MasterBillOfLading
        {
            [XmlElement(ElementName = "ReferenceNumbers")]
            public ReferenceNumbers ReferenceNumbers { get; set; }
            [XmlElement(ElementName = "Comments")]
            public string Comments { get; set; }
            [XmlElement(ElementName = "Services")]
            public string Services { get; set; }
            [XmlElement(ElementName = "RelatedItems")]
            public string RelatedItems { get; set; }
            [XmlElement(ElementName = "EquipmentList")]
            public string EquipmentList { get; set; }
            [XmlElement(ElementName = "ScheduledEquipment")]
            public string ScheduledEquipment { get; set; }
            [XmlElement(ElementName = "InternationalDetails")]
            public InternationalDetails InternationalDetails { get; set; }
            [XmlElement(ElementName = "Payment")]
            public Payment Payment { get; set; }
            [XmlElement(ElementName = "PODReceived")]
            public string PODReceived { get; set; }
            [XmlElement(ElementName = "RelatedParties")]
            public string RelatedParties { get; set; }
            [XmlElement(ElementName = "Status")]
            public string Status { get; set; }
            [XmlElement(ElementName = "AssignedTo")]
            public string AssignedTo { get; set; }
            [XmlElement(ElementName = "Owner")]
            public string Owner { get; set; }
            [XmlElement(ElementName = "Audits")]
            public Audits Audits { get; set; }
            [XmlElement(ElementName = "Carriers")]
            public Carriers Carriers { get; set; }
            [XmlElement(ElementName = "TerminalInfo")]
            public List<TerminalInfo> TerminalInfo { get; set; }
            [XmlElement(ElementName = "Dates")]
            public Dates Dates { get; set; }
            [XmlElement(ElementName = "Plan")]
            public Plan Plan { get; set; }
            [XmlElement(ElementName = "Shipments")]
            public string Shipments { get; set; }
            [XmlElement(ElementName = "Weights")]
            public Weights Weights { get; set; }
            [XmlElement(ElementName = "Dimensions")]
            public Dimensions Dimensions { get; set; }
            [XmlElement(ElementName = "Quantities")]
            public Quantities Quantities { get; set; }
            [XmlElement(ElementName = "PriceSheets")]
            public PriceSheets PriceSheets { get; set; }
            [XmlElement(ElementName = "Tenders")]
            public Tenders Tenders { get; set; }
            [XmlElement(ElementName = "Activities")]
            public Activities Activities { get; set; }
            [XmlElement(ElementName = "Links")]
            public string Links { get; set; }
            [XmlElement(ElementName = "TrackingMessages")]
            public string TrackingMessages { get; set; }
            [XmlElement(ElementName = "Margins")]
            public string Margins { get; set; }
            [XmlAttribute(AttributeName = "internalId")]
            public string InternalId { get; set; }
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
            [XmlAttribute(AttributeName = "createBy")]
            public string CreateBy { get; set; }
            [XmlAttribute(AttributeName = "createDate")]
            public string CreateDate { get; set; }
            [XmlAttribute(AttributeName = "updateBy")]
            public string UpdateBy { get; set; }
            [XmlAttribute(AttributeName = "updateDate")]
            public string UpdateDate { get; set; }
        }

        [XmlRoot(ElementName = "MercuryGate")]
        public class MercuryGate
        {
            [XmlElement(ElementName = "Header")]
            public Header Header { get; set; }
            [XmlElement(ElementName = "MasterBillOfLading")]
            public MasterBillOfLading MasterBillOfLading { get; set; }
            [XmlAttribute(AttributeName = "specVersion")]
            public string SpecVersion { get; set; }
        }
    }

    public class MercuryGateResponseDataLogs
    {

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Logs
        {

            private LogsLog[] logField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Log")]
            public LogsLog[] Log
            {
                get
                {
                    return this.logField;
                }
                set
                {
                    this.logField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class LogsLog
        {

            private object ownerField;

            private object userIdField;

            private object processField;

            private string eventField;

            private string actionField;

            private string severityField;

            private LogsLogObject objectField;

            private string messageField;

            private string timestampField;

            /// <remarks/>
            public object Owner
            {
                get
                {
                    return this.ownerField;
                }
                set
                {
                    this.ownerField = value;
                }
            }

            /// <remarks/>
            public object UserId
            {
                get
                {
                    return this.userIdField;
                }
                set
                {
                    this.userIdField = value;
                }
            }

            /// <remarks/>
            public object Process
            {
                get
                {
                    return this.processField;
                }
                set
                {
                    this.processField = value;
                }
            }

            /// <remarks/>
            public string Event
            {
                get
                {
                    return this.eventField;
                }
                set
                {
                    this.eventField = value;
                }
            }

            /// <remarks/>
            public string Action
            {
                get
                {
                    return this.actionField;
                }
                set
                {
                    this.actionField = value;
                }
            }

            /// <remarks/>
            public string Severity
            {
                get
                {
                    return this.severityField;
                }
                set
                {
                    this.severityField = value;
                }
            }

            /// <remarks/>
            public LogsLogObject Object
            {
                get
                {
                    return this.objectField;
                }
                set
                {
                    this.objectField = value;
                }
            }

            /// <remarks/>
            public string Message
            {
                get
                {
                    return this.messageField;
                }
                set
                {
                    this.messageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string timestamp
            {
                get
                {
                    return this.timestampField;
                }
                set
                {
                    this.timestampField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class LogsLogObject
        {

            private string referenceField;

            private string typeField;

            /// <remarks/>
            public string Reference
            {
                get
                {
                    return this.referenceField;
                }
                set
                {
                    this.referenceField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }
    }
}

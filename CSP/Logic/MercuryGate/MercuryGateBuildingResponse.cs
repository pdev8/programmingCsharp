using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.TeknowlogiAPIs.MercuryGate
{
    public class MercuryGateBuildingResponse
    {
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class MercuryGate
        {

            private MercuryGateHeader headerField;

            private MercuryGateMasterBillOfLading masterBillOfLadingField;

            private decimal specVersionField;

            /// <remarks/>
            public MercuryGateHeader Header
            {
                get
                {
                    return this.headerField;
                }
                set
                {
                    this.headerField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLading MasterBillOfLading
            {
                get
                {
                    return this.masterBillOfLadingField;
                }
                set
                {
                    this.masterBillOfLadingField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal specVersion
            {
                get
                {
                    return this.specVersionField;
                }
                set
                {
                    this.specVersionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateHeader
        {

            private object senderIDField;

            private object receiverIDField;

            private string docTypeIDField;

            private byte docCountField;

            private MercuryGateHeaderDate dateField;

            private MercuryGateHeaderExtractRequest extractRequestField;

            /// <remarks/>
            public object SenderID
            {
                get
                {
                    return this.senderIDField;
                }
                set
                {
                    this.senderIDField = value;
                }
            }

            /// <remarks/>
            public object ReceiverID
            {
                get
                {
                    return this.receiverIDField;
                }
                set
                {
                    this.receiverIDField = value;
                }
            }

            /// <remarks/>
            public string DocTypeID
            {
                get
                {
                    return this.docTypeIDField;
                }
                set
                {
                    this.docTypeIDField = value;
                }
            }

            /// <remarks/>
            public byte DocCount
            {
                get
                {
                    return this.docCountField;
                }
                set
                {
                    this.docCountField = value;
                }
            }

            /// <remarks/>
            public MercuryGateHeaderDate Date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }

            /// <remarks/>
            public MercuryGateHeaderExtractRequest ExtractRequest
            {
                get
                {
                    return this.extractRequestField;
                }
                set
                {
                    this.extractRequestField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateHeaderDate
        {

            private string typeField;

            private string valueField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateHeaderExtractRequest
        {

            private string dateField;

            private string reasonField;

            private MercuryGateHeaderExtractRequestUser userField;

            /// <remarks/>
            public string Date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }

            /// <remarks/>
            public string Reason
            {
                get
                {
                    return this.reasonField;
                }
                set
                {
                    this.reasonField = value;
                }
            }

            /// <remarks/>
            public MercuryGateHeaderExtractRequestUser User
            {
                get
                {
                    return this.userField;
                }
                set
                {
                    this.userField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateHeaderExtractRequestUser
        {

            private MercuryGateHeaderExtractRequestUserContactMethod[] contactMethodsField;

            private string userIdField;

            private string firstNameField;

            private string lastNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("ContactMethod", IsNullable = false)]
            public MercuryGateHeaderExtractRequestUserContactMethod[] ContactMethods
            {
                get
                {
                    return this.contactMethodsField;
                }
                set
                {
                    this.contactMethodsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string UserId
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
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string FirstName
            {
                get
                {
                    return this.firstNameField;
                }
                set
                {
                    this.firstNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string LastName
            {
                get
                {
                    return this.lastNameField;
                }
                set
                {
                    this.lastNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateHeaderExtractRequestUserContactMethod
        {

            private byte sequenceNumField;

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte sequenceNum
            {
                get
                {
                    return this.sequenceNumField;
                }
                set
                {
                    this.sequenceNumField = value;
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

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLading
        {

            private MercuryGateMasterBillOfLadingReferenceNumber[] referenceNumbersField;

            private object commentsField;

            private object servicesField;

            private object relatedItemsField;

            private object equipmentListField;

            private object scheduledEquipmentField;

            private MercuryGateMasterBillOfLadingInternationalDetails internationalDetailsField;

            private MercuryGateMasterBillOfLadingPayment paymentField;

            private bool pODReceivedField;

            private object relatedPartiesField;

            private string statusField;

            private object assignedToField;

            private string ownerField;

            private MercuryGateMasterBillOfLadingAudits auditsField;

            private MercuryGateMasterBillOfLadingCarriers carriersField;

            private MercuryGateMasterBillOfLadingTerminalInfo[] terminalInfoField;

            private MercuryGateMasterBillOfLadingDates datesField;

            private MercuryGateMasterBillOfLadingPlan planField;

            private object shipmentsField;

            private MercuryGateMasterBillOfLadingWeights weightsField;

            private MercuryGateMasterBillOfLadingDimension[] dimensionsField;

            private MercuryGateMasterBillOfLadingQuantity[] quantitiesField;

            private MercuryGateMasterBillOfLadingPriceSheet[] priceSheetsField;

            private MercuryGateMasterBillOfLadingTenders tendersField;

            private MercuryGateMasterBillOfLadingActivities activitiesField;

            private object linksField;

            private object trackingMessagesField;

            private object marginsField;

            private ulong internalIdField;

            private string typeField;

            private string createByField;

            private string createDateField;

            private string updateByField;

            private string updateDateField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("ReferenceNumber", IsNullable = false)]
            public MercuryGateMasterBillOfLadingReferenceNumber[] ReferenceNumbers
            {
                get
                {
                    return this.referenceNumbersField;
                }
                set
                {
                    this.referenceNumbersField = value;
                }
            }

            /// <remarks/>
            public object Comments
            {
                get
                {
                    return this.commentsField;
                }
                set
                {
                    this.commentsField = value;
                }
            }

            /// <remarks/>
            public object Services
            {
                get
                {
                    return this.servicesField;
                }
                set
                {
                    this.servicesField = value;
                }
            }

            /// <remarks/>
            public object RelatedItems
            {
                get
                {
                    return this.relatedItemsField;
                }
                set
                {
                    this.relatedItemsField = value;
                }
            }

            /// <remarks/>
            public object EquipmentList
            {
                get
                {
                    return this.equipmentListField;
                }
                set
                {
                    this.equipmentListField = value;
                }
            }

            /// <remarks/>
            public object ScheduledEquipment
            {
                get
                {
                    return this.scheduledEquipmentField;
                }
                set
                {
                    this.scheduledEquipmentField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingInternationalDetails InternationalDetails
            {
                get
                {
                    return this.internationalDetailsField;
                }
                set
                {
                    this.internationalDetailsField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPayment Payment
            {
                get
                {
                    return this.paymentField;
                }
                set
                {
                    this.paymentField = value;
                }
            }

            /// <remarks/>
            public bool PODReceived
            {
                get
                {
                    return this.pODReceivedField;
                }
                set
                {
                    this.pODReceivedField = value;
                }
            }

            /// <remarks/>
            public object RelatedParties
            {
                get
                {
                    return this.relatedPartiesField;
                }
                set
                {
                    this.relatedPartiesField = value;
                }
            }

            /// <remarks/>
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            public object AssignedTo
            {
                get
                {
                    return this.assignedToField;
                }
                set
                {
                    this.assignedToField = value;
                }
            }

            /// <remarks/>
            public string Owner
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
            public MercuryGateMasterBillOfLadingAudits Audits
            {
                get
                {
                    return this.auditsField;
                }
                set
                {
                    this.auditsField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingCarriers Carriers
            {
                get
                {
                    return this.carriersField;
                }
                set
                {
                    this.carriersField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("TerminalInfo")]
            public MercuryGateMasterBillOfLadingTerminalInfo[] TerminalInfo
            {
                get
                {
                    return this.terminalInfoField;
                }
                set
                {
                    this.terminalInfoField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingDates Dates
            {
                get
                {
                    return this.datesField;
                }
                set
                {
                    this.datesField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPlan Plan
            {
                get
                {
                    return this.planField;
                }
                set
                {
                    this.planField = value;
                }
            }

            /// <remarks/>
            public object Shipments
            {
                get
                {
                    return this.shipmentsField;
                }
                set
                {
                    this.shipmentsField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingWeights Weights
            {
                get
                {
                    return this.weightsField;
                }
                set
                {
                    this.weightsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Dimension", IsNullable = false)]
            public MercuryGateMasterBillOfLadingDimension[] Dimensions
            {
                get
                {
                    return this.dimensionsField;
                }
                set
                {
                    this.dimensionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Quantity", IsNullable = false)]
            public MercuryGateMasterBillOfLadingQuantity[] Quantities
            {
                get
                {
                    return this.quantitiesField;
                }
                set
                {
                    this.quantitiesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("PriceSheet", IsNullable = false)]
            public MercuryGateMasterBillOfLadingPriceSheet[] PriceSheets
            {
                get
                {
                    return this.priceSheetsField;
                }
                set
                {
                    this.priceSheetsField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingTenders Tenders
            {
                get
                {
                    return this.tendersField;
                }
                set
                {
                    this.tendersField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingActivities Activities
            {
                get
                {
                    return this.activitiesField;
                }
                set
                {
                    this.activitiesField = value;
                }
            }

            /// <remarks/>
            public object Links
            {
                get
                {
                    return this.linksField;
                }
                set
                {
                    this.linksField = value;
                }
            }

            /// <remarks/>
            public object TrackingMessages
            {
                get
                {
                    return this.trackingMessagesField;
                }
                set
                {
                    this.trackingMessagesField = value;
                }
            }

            /// <remarks/>
            public object Margins
            {
                get
                {
                    return this.marginsField;
                }
                set
                {
                    this.marginsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ulong internalId
            {
                get
                {
                    return this.internalIdField;
                }
                set
                {
                    this.internalIdField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string createBy
            {
                get
                {
                    return this.createByField;
                }
                set
                {
                    this.createByField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string createDate
            {
                get
                {
                    return this.createDateField;
                }
                set
                {
                    this.createDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string updateBy
            {
                get
                {
                    return this.updateByField;
                }
                set
                {
                    this.updateByField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string updateDate
            {
                get
                {
                    return this.updateDateField;
                }
                set
                {
                    this.updateDateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingReferenceNumber
        {

            private string typeField;

            private bool isPrimaryField;

            private string valueField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isPrimary
            {
                get
                {
                    return this.isPrimaryField;
                }
                set
                {
                    this.isPrimaryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingInternationalDetails
        {

            private object moveTypeField;

            private object vesselNameField;

            private object voyageNumberField;

            private object lLoydsCodeField;

            private MercuryGateMasterBillOfLadingInternationalDetailsLetterOfCredit letterOfCreditField;

            private object immediateTransportationNumberField;

            private object immediateTransportationDateField;

            private object transportationAndExportationNumberField;

            private object immediateExportNumberField;

            private object exporterReferenceNumberField;

            private object exporterLicenseNumberField;

            private object exportLicenseDateField;

            private object fMCNumberField;

            private object internalTransactionNumberField;

            private object electronicExportInformationField;

            private object exportDeclarationField;

            private object uSAMSNumberField;

            private object destinationControlStatementField;

            private object iSFShipmentTypeField;

            private object iSFBondHolderField;

            private object iSFBondNumberField;

            private object suretyNumberField;

            private object pointOfOriginField;

            private object containerStuffingLocationField;

            private object containerStufferLocationField;

            private object portOfEntryField;

            private object portOfExportField;

            private object firstPortOfUnladingField;

            private object finalPortOfDestinationField;

            private object finalCountryOfDestinationField;

            private MercuryGateMasterBillOfLadingInternationalDetailsGenericField genericFieldField;

            private object aESVesselFlagField;

            private object aESImportEntryNumberField;

            private object aESInbondTypeField;

            private object aESRelatedCompaniesField;

            private object aESRoutedTransactionField;

            private object reasonForExportField;

            private object eCCNField;

            private object blanketPeriodBeginDateField;

            private object blanketPeriodEndDateField;

            /// <remarks/>
            public object MoveType
            {
                get
                {
                    return this.moveTypeField;
                }
                set
                {
                    this.moveTypeField = value;
                }
            }

            /// <remarks/>
            public object VesselName
            {
                get
                {
                    return this.vesselNameField;
                }
                set
                {
                    this.vesselNameField = value;
                }
            }

            /// <remarks/>
            public object VoyageNumber
            {
                get
                {
                    return this.voyageNumberField;
                }
                set
                {
                    this.voyageNumberField = value;
                }
            }

            /// <remarks/>
            public object LLoydsCode
            {
                get
                {
                    return this.lLoydsCodeField;
                }
                set
                {
                    this.lLoydsCodeField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingInternationalDetailsLetterOfCredit LetterOfCredit
            {
                get
                {
                    return this.letterOfCreditField;
                }
                set
                {
                    this.letterOfCreditField = value;
                }
            }

            /// <remarks/>
            public object ImmediateTransportationNumber
            {
                get
                {
                    return this.immediateTransportationNumberField;
                }
                set
                {
                    this.immediateTransportationNumberField = value;
                }
            }

            /// <remarks/>
            public object ImmediateTransportationDate
            {
                get
                {
                    return this.immediateTransportationDateField;
                }
                set
                {
                    this.immediateTransportationDateField = value;
                }
            }

            /// <remarks/>
            public object TransportationAndExportationNumber
            {
                get
                {
                    return this.transportationAndExportationNumberField;
                }
                set
                {
                    this.transportationAndExportationNumberField = value;
                }
            }

            /// <remarks/>
            public object ImmediateExportNumber
            {
                get
                {
                    return this.immediateExportNumberField;
                }
                set
                {
                    this.immediateExportNumberField = value;
                }
            }

            /// <remarks/>
            public object ExporterReferenceNumber
            {
                get
                {
                    return this.exporterReferenceNumberField;
                }
                set
                {
                    this.exporterReferenceNumberField = value;
                }
            }

            /// <remarks/>
            public object ExporterLicenseNumber
            {
                get
                {
                    return this.exporterLicenseNumberField;
                }
                set
                {
                    this.exporterLicenseNumberField = value;
                }
            }

            /// <remarks/>
            public object ExportLicenseDate
            {
                get
                {
                    return this.exportLicenseDateField;
                }
                set
                {
                    this.exportLicenseDateField = value;
                }
            }

            /// <remarks/>
            public object FMCNumber
            {
                get
                {
                    return this.fMCNumberField;
                }
                set
                {
                    this.fMCNumberField = value;
                }
            }

            /// <remarks/>
            public object InternalTransactionNumber
            {
                get
                {
                    return this.internalTransactionNumberField;
                }
                set
                {
                    this.internalTransactionNumberField = value;
                }
            }

            /// <remarks/>
            public object ElectronicExportInformation
            {
                get
                {
                    return this.electronicExportInformationField;
                }
                set
                {
                    this.electronicExportInformationField = value;
                }
            }

            /// <remarks/>
            public object ExportDeclaration
            {
                get
                {
                    return this.exportDeclarationField;
                }
                set
                {
                    this.exportDeclarationField = value;
                }
            }

            /// <remarks/>
            public object USAMSNumber
            {
                get
                {
                    return this.uSAMSNumberField;
                }
                set
                {
                    this.uSAMSNumberField = value;
                }
            }

            /// <remarks/>
            public object DestinationControlStatement
            {
                get
                {
                    return this.destinationControlStatementField;
                }
                set
                {
                    this.destinationControlStatementField = value;
                }
            }

            /// <remarks/>
            public object ISFShipmentType
            {
                get
                {
                    return this.iSFShipmentTypeField;
                }
                set
                {
                    this.iSFShipmentTypeField = value;
                }
            }

            /// <remarks/>
            public object ISFBondHolder
            {
                get
                {
                    return this.iSFBondHolderField;
                }
                set
                {
                    this.iSFBondHolderField = value;
                }
            }

            /// <remarks/>
            public object ISFBondNumber
            {
                get
                {
                    return this.iSFBondNumberField;
                }
                set
                {
                    this.iSFBondNumberField = value;
                }
            }

            /// <remarks/>
            public object SuretyNumber
            {
                get
                {
                    return this.suretyNumberField;
                }
                set
                {
                    this.suretyNumberField = value;
                }
            }

            /// <remarks/>
            public object PointOfOrigin
            {
                get
                {
                    return this.pointOfOriginField;
                }
                set
                {
                    this.pointOfOriginField = value;
                }
            }

            /// <remarks/>
            public object ContainerStuffingLocation
            {
                get
                {
                    return this.containerStuffingLocationField;
                }
                set
                {
                    this.containerStuffingLocationField = value;
                }
            }

            /// <remarks/>
            public object ContainerStufferLocation
            {
                get
                {
                    return this.containerStufferLocationField;
                }
                set
                {
                    this.containerStufferLocationField = value;
                }
            }

            /// <remarks/>
            public object PortOfEntry
            {
                get
                {
                    return this.portOfEntryField;
                }
                set
                {
                    this.portOfEntryField = value;
                }
            }

            /// <remarks/>
            public object PortOfExport
            {
                get
                {
                    return this.portOfExportField;
                }
                set
                {
                    this.portOfExportField = value;
                }
            }

            /// <remarks/>
            public object FirstPortOfUnlading
            {
                get
                {
                    return this.firstPortOfUnladingField;
                }
                set
                {
                    this.firstPortOfUnladingField = value;
                }
            }

            /// <remarks/>
            public object FinalPortOfDestination
            {
                get
                {
                    return this.finalPortOfDestinationField;
                }
                set
                {
                    this.finalPortOfDestinationField = value;
                }
            }

            /// <remarks/>
            public object FinalCountryOfDestination
            {
                get
                {
                    return this.finalCountryOfDestinationField;
                }
                set
                {
                    this.finalCountryOfDestinationField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingInternationalDetailsGenericField GenericField
            {
                get
                {
                    return this.genericFieldField;
                }
                set
                {
                    this.genericFieldField = value;
                }
            }

            /// <remarks/>
            public object AESVesselFlag
            {
                get
                {
                    return this.aESVesselFlagField;
                }
                set
                {
                    this.aESVesselFlagField = value;
                }
            }

            /// <remarks/>
            public object AESImportEntryNumber
            {
                get
                {
                    return this.aESImportEntryNumberField;
                }
                set
                {
                    this.aESImportEntryNumberField = value;
                }
            }

            /// <remarks/>
            public object AESInbondType
            {
                get
                {
                    return this.aESInbondTypeField;
                }
                set
                {
                    this.aESInbondTypeField = value;
                }
            }

            /// <remarks/>
            public object AESRelatedCompanies
            {
                get
                {
                    return this.aESRelatedCompaniesField;
                }
                set
                {
                    this.aESRelatedCompaniesField = value;
                }
            }

            /// <remarks/>
            public object AESRoutedTransaction
            {
                get
                {
                    return this.aESRoutedTransactionField;
                }
                set
                {
                    this.aESRoutedTransactionField = value;
                }
            }

            /// <remarks/>
            public object ReasonForExport
            {
                get
                {
                    return this.reasonForExportField;
                }
                set
                {
                    this.reasonForExportField = value;
                }
            }

            /// <remarks/>
            public object ECCN
            {
                get
                {
                    return this.eCCNField;
                }
                set
                {
                    this.eCCNField = value;
                }
            }

            /// <remarks/>
            public object BlanketPeriodBeginDate
            {
                get
                {
                    return this.blanketPeriodBeginDateField;
                }
                set
                {
                    this.blanketPeriodBeginDateField = value;
                }
            }

            /// <remarks/>
            public object BlanketPeriodEndDate
            {
                get
                {
                    return this.blanketPeriodEndDateField;
                }
                set
                {
                    this.blanketPeriodEndDateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingInternationalDetailsLetterOfCredit
        {

            private object numberField;

            private object issuedDateField;

            private object expirationDateField;

            /// <remarks/>
            public object Number
            {
                get
                {
                    return this.numberField;
                }
                set
                {
                    this.numberField = value;
                }
            }

            /// <remarks/>
            public object IssuedDate
            {
                get
                {
                    return this.issuedDateField;
                }
                set
                {
                    this.issuedDateField = value;
                }
            }

            /// <remarks/>
            public object ExpirationDate
            {
                get
                {
                    return this.expirationDateField;
                }
                set
                {
                    this.expirationDateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingInternationalDetailsGenericField
        {

            private string typeField;

            private string formatField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string format
            {
                get
                {
                    return this.formatField;
                }
                set
                {
                    this.formatField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPayment
        {

            private string methodField;

            private MercuryGateMasterBillOfLadingPaymentBillTo billToField;

            /// <remarks/>
            public string Method
            {
                get
                {
                    return this.methodField;
                }
                set
                {
                    this.methodField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPaymentBillTo BillTo
            {
                get
                {
                    return this.billToField;
                }
                set
                {
                    this.billToField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPaymentBillTo
        {

            private MercuryGateMasterBillOfLadingPaymentBillToAddress addressField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPaymentBillToAddress Address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPaymentBillToAddress
        {

            private string ownerField;

            private string customerAcctNumField;

            private string locationCodeField;

            private string nameField;

            private string addrLine1Field;

            private object addrLine2Field;

            private string cityField;

            private string stateProvinceField;

            private uint postalCodeField;

            private string countryCodeField;

            private MercuryGateMasterBillOfLadingPaymentBillToAddressGeoLoc geoLocField;

            private MercuryGateMasterBillOfLadingPaymentBillToAddressContacts contactsField;

            private object commentsField;

            private string typeField;

            private bool isResidentialField;

            private bool isPrimaryField;

            /// <remarks/>
            public string Owner
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
            public string CustomerAcctNum
            {
                get
                {
                    return this.customerAcctNumField;
                }
                set
                {
                    this.customerAcctNumField = value;
                }
            }

            /// <remarks/>
            public string LocationCode
            {
                get
                {
                    return this.locationCodeField;
                }
                set
                {
                    this.locationCodeField = value;
                }
            }

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public string AddrLine1
            {
                get
                {
                    return this.addrLine1Field;
                }
                set
                {
                    this.addrLine1Field = value;
                }
            }

            /// <remarks/>
            public object AddrLine2
            {
                get
                {
                    return this.addrLine2Field;
                }
                set
                {
                    this.addrLine2Field = value;
                }
            }

            /// <remarks/>
            public string City
            {
                get
                {
                    return this.cityField;
                }
                set
                {
                    this.cityField = value;
                }
            }

            /// <remarks/>
            public string StateProvince
            {
                get
                {
                    return this.stateProvinceField;
                }
                set
                {
                    this.stateProvinceField = value;
                }
            }

            /// <remarks/>
            public uint PostalCode
            {
                get
                {
                    return this.postalCodeField;
                }
                set
                {
                    this.postalCodeField = value;
                }
            }

            /// <remarks/>
            public string CountryCode
            {
                get
                {
                    return this.countryCodeField;
                }
                set
                {
                    this.countryCodeField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPaymentBillToAddressGeoLoc GeoLoc
            {
                get
                {
                    return this.geoLocField;
                }
                set
                {
                    this.geoLocField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPaymentBillToAddressContacts Contacts
            {
                get
                {
                    return this.contactsField;
                }
                set
                {
                    this.contactsField = value;
                }
            }

            /// <remarks/>
            public object Comments
            {
                get
                {
                    return this.commentsField;
                }
                set
                {
                    this.commentsField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isResidential
            {
                get
                {
                    return this.isResidentialField;
                }
                set
                {
                    this.isResidentialField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isPrimary
            {
                get
                {
                    return this.isPrimaryField;
                }
                set
                {
                    this.isPrimaryField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPaymentBillToAddressGeoLoc
        {

            private uint latDegreesField;

            private string latDirectionField;

            private uint longDegreesField;

            private string longDirectionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint latDegrees
            {
                get
                {
                    return this.latDegreesField;
                }
                set
                {
                    this.latDegreesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string latDirection
            {
                get
                {
                    return this.latDirectionField;
                }
                set
                {
                    this.latDirectionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint longDegrees
            {
                get
                {
                    return this.longDegreesField;
                }
                set
                {
                    this.longDegreesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string longDirection
            {
                get
                {
                    return this.longDirectionField;
                }
                set
                {
                    this.longDirectionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPaymentBillToAddressContacts
        {

            private MercuryGateMasterBillOfLadingPaymentBillToAddressContactsContact contactField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPaymentBillToAddressContactsContact Contact
            {
                get
                {
                    return this.contactField;
                }
                set
                {
                    this.contactField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPaymentBillToAddressContactsContact
        {

            private string nameField;

            private MercuryGateMasterBillOfLadingPaymentBillToAddressContactsContactContactMethod[] contactMethodsField;

            private string typeField;

            private ulong oidField;

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("ContactMethod", IsNullable = false)]
            public MercuryGateMasterBillOfLadingPaymentBillToAddressContactsContactContactMethod[] ContactMethods
            {
                get
                {
                    return this.contactMethodsField;
                }
                set
                {
                    this.contactMethodsField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ulong oid
            {
                get
                {
                    return this.oidField;
                }
                set
                {
                    this.oidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPaymentBillToAddressContactsContactContactMethod
        {

            private byte sequenceNumField;

            private string typeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte sequenceNum
            {
                get
                {
                    return this.sequenceNumField;
                }
                set
                {
                    this.sequenceNumField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingAudits
        {

            private MercuryGateMasterBillOfLadingAuditsAudit auditField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingAuditsAudit Audit
            {
                get
                {
                    return this.auditField;
                }
                set
                {
                    this.auditField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingAuditsAudit
        {

            private string timestampField;

            private string userField;

            private string actionField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string user
            {
                get
                {
                    return this.userField;
                }
                set
                {
                    this.userField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string action
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingCarriers
        {

            private MercuryGateMasterBillOfLadingCarriersCarrier carrierField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingCarriersCarrier Carrier
            {
                get
                {
                    return this.carrierField;
                }
                set
                {
                    this.carrierField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingCarriersCarrier
        {

            private string carrierIdField;

            private string carrierNameField;

            private string sCACField;

            private string modeField;

            private object serviceField;

            private decimal serviceDaysField;

            private decimal distanceField;

            private string idField;

            private MercuryGateMasterBillOfLadingCarriersCarrierInsurance[] insuranceTypesField;

            private MercuryGateMasterBillOfLadingCarriersCarrierAddress addressField;

            private string typeField;

            /// <remarks/>
            public string CarrierId
            {
                get
                {
                    return this.carrierIdField;
                }
                set
                {
                    this.carrierIdField = value;
                }
            }

            /// <remarks/>
            public string CarrierName
            {
                get
                {
                    return this.carrierNameField;
                }
                set
                {
                    this.carrierNameField = value;
                }
            }

            /// <remarks/>
            public string SCAC
            {
                get
                {
                    return this.sCACField;
                }
                set
                {
                    this.sCACField = value;
                }
            }

            /// <remarks/>
            public string Mode
            {
                get
                {
                    return this.modeField;
                }
                set
                {
                    this.modeField = value;
                }
            }

            /// <remarks/>
            public object Service
            {
                get
                {
                    return this.serviceField;
                }
                set
                {
                    this.serviceField = value;
                }
            }

            /// <remarks/>
            public decimal ServiceDays
            {
                get
                {
                    return this.serviceDaysField;
                }
                set
                {
                    this.serviceDaysField = value;
                }
            }

            /// <remarks/>
            public decimal Distance
            {
                get
                {
                    return this.distanceField;
                }
                set
                {
                    this.distanceField = value;
                }
            }

            /// <remarks/>
            public string Id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Insurance", IsNullable = false)]
            public MercuryGateMasterBillOfLadingCarriersCarrierInsurance[] InsuranceTypes
            {
                get
                {
                    return this.insuranceTypesField;
                }
                set
                {
                    this.insuranceTypesField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingCarriersCarrierAddress Address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
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

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingCarriersCarrierInsurance
        {

            private string typeField;

            private decimal amountField;

            private string companyField;

            private string expirationDateField;

            private string contactNameField;

            private string contactPhoneField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal amount
            {
                get
                {
                    return this.amountField;
                }
                set
                {
                    this.amountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string company
            {
                get
                {
                    return this.companyField;
                }
                set
                {
                    this.companyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string expirationDate
            {
                get
                {
                    return this.expirationDateField;
                }
                set
                {
                    this.expirationDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string contactName
            {
                get
                {
                    return this.contactNameField;
                }
                set
                {
                    this.contactNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string contactPhone
            {
                get
                {
                    return this.contactPhoneField;
                }
                set
                {
                    this.contactPhoneField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingCarriersCarrierAddress
        {

            private string ownerField;

            private string customerAcctNumField;

            private string locationCodeField;

            private string nameField;

            private string addrLine1Field;

            private object addrLine2Field;

            private string cityField;

            private string stateProvinceField;

            private string postalCodeField;

            private string countryCodeField;

            private MercuryGateMasterBillOfLadingCarriersCarrierAddressGeoLoc geoLocField;

            private MercuryGateMasterBillOfLadingCarriersCarrierAddressContacts contactsField;

            private object commentsField;

            private string typeField;

            private bool isResidentialField;

            private bool isPrimaryField;

            /// <remarks/>
            public string Owner
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
            public string CustomerAcctNum
            {
                get
                {
                    return this.customerAcctNumField;
                }
                set
                {
                    this.customerAcctNumField = value;
                }
            }

            /// <remarks/>
            public string LocationCode
            {
                get
                {
                    return this.locationCodeField;
                }
                set
                {
                    this.locationCodeField = value;
                }
            }

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public string AddrLine1
            {
                get
                {
                    return this.addrLine1Field;
                }
                set
                {
                    this.addrLine1Field = value;
                }
            }

            /// <remarks/>
            public object AddrLine2
            {
                get
                {
                    return this.addrLine2Field;
                }
                set
                {
                    this.addrLine2Field = value;
                }
            }

            /// <remarks/>
            public string City
            {
                get
                {
                    return this.cityField;
                }
                set
                {
                    this.cityField = value;
                }
            }

            /// <remarks/>
            public string StateProvince
            {
                get
                {
                    return this.stateProvinceField;
                }
                set
                {
                    this.stateProvinceField = value;
                }
            }

            /// <remarks/>
            public string PostalCode
            {
                get
                {
                    return this.postalCodeField;
                }
                set
                {
                    this.postalCodeField = value;
                }
            }

            /// <remarks/>
            public string CountryCode
            {
                get
                {
                    return this.countryCodeField;
                }
                set
                {
                    this.countryCodeField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingCarriersCarrierAddressGeoLoc GeoLoc
            {
                get
                {
                    return this.geoLocField;
                }
                set
                {
                    this.geoLocField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingCarriersCarrierAddressContacts Contacts
            {
                get
                {
                    return this.contactsField;
                }
                set
                {
                    this.contactsField = value;
                }
            }

            /// <remarks/>
            public object Comments
            {
                get
                {
                    return this.commentsField;
                }
                set
                {
                    this.commentsField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isResidential
            {
                get
                {
                    return this.isResidentialField;
                }
                set
                {
                    this.isResidentialField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isPrimary
            {
                get
                {
                    return this.isPrimaryField;
                }
                set
                {
                    this.isPrimaryField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingCarriersCarrierAddressGeoLoc
        {

            private uint latDegreesField;

            private string latDirectionField;

            private uint longDegreesField;

            private string longDirectionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint latDegrees
            {
                get
                {
                    return this.latDegreesField;
                }
                set
                {
                    this.latDegreesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string latDirection
            {
                get
                {
                    return this.latDirectionField;
                }
                set
                {
                    this.latDirectionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint longDegrees
            {
                get
                {
                    return this.longDegreesField;
                }
                set
                {
                    this.longDegreesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string longDirection
            {
                get
                {
                    return this.longDirectionField;
                }
                set
                {
                    this.longDirectionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingCarriersCarrierAddressContacts
        {

            private MercuryGateMasterBillOfLadingCarriersCarrierAddressContactsContact contactField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingCarriersCarrierAddressContactsContact Contact
            {
                get
                {
                    return this.contactField;
                }
                set
                {
                    this.contactField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingCarriersCarrierAddressContactsContact
        {

            private string nameField;

            private MercuryGateMasterBillOfLadingCarriersCarrierAddressContactsContactContactMethods contactMethodsField;

            private string typeField;

            private ulong oidField;

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingCarriersCarrierAddressContactsContactContactMethods ContactMethods
            {
                get
                {
                    return this.contactMethodsField;
                }
                set
                {
                    this.contactMethodsField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ulong oid
            {
                get
                {
                    return this.oidField;
                }
                set
                {
                    this.oidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingCarriersCarrierAddressContactsContactContactMethods
        {

            private MercuryGateMasterBillOfLadingCarriersCarrierAddressContactsContactContactMethodsContactMethod contactMethodField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingCarriersCarrierAddressContactsContactContactMethodsContactMethod ContactMethod
            {
                get
                {
                    return this.contactMethodField;
                }
                set
                {
                    this.contactMethodField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingCarriersCarrierAddressContactsContactContactMethodsContactMethod
        {

            private byte sequenceNumField;

            private string typeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte sequenceNum
            {
                get
                {
                    return this.sequenceNumField;
                }
                set
                {
                    this.sequenceNumField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingTerminalInfo
        {

            private MercuryGateMasterBillOfLadingTerminalInfoOrigin originField;

            private MercuryGateMasterBillOfLadingTerminalInfoDestination destinationField;

            private string typeField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingTerminalInfoOrigin Origin
            {
                get
                {
                    return this.originField;
                }
                set
                {
                    this.originField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingTerminalInfoDestination Destination
            {
                get
                {
                    return this.destinationField;
                }
                set
                {
                    this.destinationField = value;
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

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingTerminalInfoOrigin
        {

            private MercuryGateMasterBillOfLadingTerminalInfoOriginAddress addressField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingTerminalInfoOriginAddress Address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingTerminalInfoOriginAddress
        {

            private object ownerField;

            private object customerAcctNumField;

            private object locationCodeField;

            private string nameField;

            private string addrLine1Field;

            private object addrLine2Field;

            private string cityField;

            private string stateProvinceField;

            private ushort postalCodeField;

            private string countryCodeField;

            private MercuryGateMasterBillOfLadingTerminalInfoOriginAddressGeoLoc geoLocField;

            private MercuryGateMasterBillOfLadingTerminalInfoOriginAddressContacts contactsField;

            private object commentsField;

            private string typeField;

            private bool isResidentialField;

            private bool isPrimaryField;

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
            public object CustomerAcctNum
            {
                get
                {
                    return this.customerAcctNumField;
                }
                set
                {
                    this.customerAcctNumField = value;
                }
            }

            /// <remarks/>
            public object LocationCode
            {
                get
                {
                    return this.locationCodeField;
                }
                set
                {
                    this.locationCodeField = value;
                }
            }

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public string AddrLine1
            {
                get
                {
                    return this.addrLine1Field;
                }
                set
                {
                    this.addrLine1Field = value;
                }
            }

            /// <remarks/>
            public object AddrLine2
            {
                get
                {
                    return this.addrLine2Field;
                }
                set
                {
                    this.addrLine2Field = value;
                }
            }

            /// <remarks/>
            public string City
            {
                get
                {
                    return this.cityField;
                }
                set
                {
                    this.cityField = value;
                }
            }

            /// <remarks/>
            public string StateProvince
            {
                get
                {
                    return this.stateProvinceField;
                }
                set
                {
                    this.stateProvinceField = value;
                }
            }

            /// <remarks/>
            public ushort PostalCode
            {
                get
                {
                    return this.postalCodeField;
                }
                set
                {
                    this.postalCodeField = value;
                }
            }

            /// <remarks/>
            public string CountryCode
            {
                get
                {
                    return this.countryCodeField;
                }
                set
                {
                    this.countryCodeField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingTerminalInfoOriginAddressGeoLoc GeoLoc
            {
                get
                {
                    return this.geoLocField;
                }
                set
                {
                    this.geoLocField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingTerminalInfoOriginAddressContacts Contacts
            {
                get
                {
                    return this.contactsField;
                }
                set
                {
                    this.contactsField = value;
                }
            }

            /// <remarks/>
            public object Comments
            {
                get
                {
                    return this.commentsField;
                }
                set
                {
                    this.commentsField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isResidential
            {
                get
                {
                    return this.isResidentialField;
                }
                set
                {
                    this.isResidentialField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isPrimary
            {
                get
                {
                    return this.isPrimaryField;
                }
                set
                {
                    this.isPrimaryField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingTerminalInfoOriginAddressGeoLoc
        {

            private uint latDegreesField;

            private string latDirectionField;

            private uint longDegreesField;

            private string longDirectionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint latDegrees
            {
                get
                {
                    return this.latDegreesField;
                }
                set
                {
                    this.latDegreesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string latDirection
            {
                get
                {
                    return this.latDirectionField;
                }
                set
                {
                    this.latDirectionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint longDegrees
            {
                get
                {
                    return this.longDegreesField;
                }
                set
                {
                    this.longDegreesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string longDirection
            {
                get
                {
                    return this.longDirectionField;
                }
                set
                {
                    this.longDirectionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingTerminalInfoOriginAddressContacts
        {

            private MercuryGateMasterBillOfLadingTerminalInfoOriginAddressContactsContact contactField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingTerminalInfoOriginAddressContactsContact Contact
            {
                get
                {
                    return this.contactField;
                }
                set
                {
                    this.contactField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingTerminalInfoOriginAddressContactsContact
        {

            private object nameField;

            private MercuryGateMasterBillOfLadingTerminalInfoOriginAddressContactsContactContactMethods contactMethodsField;

            private string typeField;

            private ulong oidField;

            /// <remarks/>
            public object Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingTerminalInfoOriginAddressContactsContactContactMethods ContactMethods
            {
                get
                {
                    return this.contactMethodsField;
                }
                set
                {
                    this.contactMethodsField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ulong oid
            {
                get
                {
                    return this.oidField;
                }
                set
                {
                    this.oidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingTerminalInfoOriginAddressContactsContactContactMethods
        {

            private MercuryGateMasterBillOfLadingTerminalInfoOriginAddressContactsContactContactMethodsContactMethod contactMethodField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingTerminalInfoOriginAddressContactsContactContactMethodsContactMethod ContactMethod
            {
                get
                {
                    return this.contactMethodField;
                }
                set
                {
                    this.contactMethodField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingTerminalInfoOriginAddressContactsContactContactMethodsContactMethod
        {

            private byte sequenceNumField;

            private string typeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte sequenceNum
            {
                get
                {
                    return this.sequenceNumField;
                }
                set
                {
                    this.sequenceNumField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingTerminalInfoDestination
        {

            private MercuryGateMasterBillOfLadingTerminalInfoDestinationAddress addressField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingTerminalInfoDestinationAddress Address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingTerminalInfoDestinationAddress
        {

            private object ownerField;

            private object customerAcctNumField;

            private object locationCodeField;

            private string nameField;

            private string addrLine1Field;

            private string addrLine2Field;

            private string cityField;

            private string stateProvinceField;

            private uint postalCodeField;

            private string countryCodeField;

            private MercuryGateMasterBillOfLadingTerminalInfoDestinationAddressGeoLoc geoLocField;

            private MercuryGateMasterBillOfLadingTerminalInfoDestinationAddressContacts contactsField;

            private object commentsField;

            private string typeField;

            private bool isResidentialField;

            private bool isPrimaryField;

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
            public object CustomerAcctNum
            {
                get
                {
                    return this.customerAcctNumField;
                }
                set
                {
                    this.customerAcctNumField = value;
                }
            }

            /// <remarks/>
            public object LocationCode
            {
                get
                {
                    return this.locationCodeField;
                }
                set
                {
                    this.locationCodeField = value;
                }
            }

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public string AddrLine1
            {
                get
                {
                    return this.addrLine1Field;
                }
                set
                {
                    this.addrLine1Field = value;
                }
            }

            /// <remarks/>
            public string AddrLine2
            {
                get
                {
                    return this.addrLine2Field;
                }
                set
                {
                    this.addrLine2Field = value;
                }
            }

            /// <remarks/>
            public string City
            {
                get
                {
                    return this.cityField;
                }
                set
                {
                    this.cityField = value;
                }
            }

            /// <remarks/>
            public string StateProvince
            {
                get
                {
                    return this.stateProvinceField;
                }
                set
                {
                    this.stateProvinceField = value;
                }
            }

            /// <remarks/>
            public uint PostalCode
            {
                get
                {
                    return this.postalCodeField;
                }
                set
                {
                    this.postalCodeField = value;
                }
            }

            /// <remarks/>
            public string CountryCode
            {
                get
                {
                    return this.countryCodeField;
                }
                set
                {
                    this.countryCodeField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingTerminalInfoDestinationAddressGeoLoc GeoLoc
            {
                get
                {
                    return this.geoLocField;
                }
                set
                {
                    this.geoLocField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingTerminalInfoDestinationAddressContacts Contacts
            {
                get
                {
                    return this.contactsField;
                }
                set
                {
                    this.contactsField = value;
                }
            }

            /// <remarks/>
            public object Comments
            {
                get
                {
                    return this.commentsField;
                }
                set
                {
                    this.commentsField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isResidential
            {
                get
                {
                    return this.isResidentialField;
                }
                set
                {
                    this.isResidentialField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isPrimary
            {
                get
                {
                    return this.isPrimaryField;
                }
                set
                {
                    this.isPrimaryField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingTerminalInfoDestinationAddressGeoLoc
        {

            private uint latDegreesField;

            private string latDirectionField;

            private uint longDegreesField;

            private string longDirectionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint latDegrees
            {
                get
                {
                    return this.latDegreesField;
                }
                set
                {
                    this.latDegreesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string latDirection
            {
                get
                {
                    return this.latDirectionField;
                }
                set
                {
                    this.latDirectionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint longDegrees
            {
                get
                {
                    return this.longDegreesField;
                }
                set
                {
                    this.longDegreesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string longDirection
            {
                get
                {
                    return this.longDirectionField;
                }
                set
                {
                    this.longDirectionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingTerminalInfoDestinationAddressContacts
        {

            private MercuryGateMasterBillOfLadingTerminalInfoDestinationAddressContactsContact contactField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingTerminalInfoDestinationAddressContactsContact Contact
            {
                get
                {
                    return this.contactField;
                }
                set
                {
                    this.contactField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingTerminalInfoDestinationAddressContactsContact
        {

            private object nameField;

            private MercuryGateMasterBillOfLadingTerminalInfoDestinationAddressContactsContactContactMethods contactMethodsField;

            private string typeField;

            private ulong oidField;

            /// <remarks/>
            public object Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingTerminalInfoDestinationAddressContactsContactContactMethods ContactMethods
            {
                get
                {
                    return this.contactMethodsField;
                }
                set
                {
                    this.contactMethodsField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ulong oid
            {
                get
                {
                    return this.oidField;
                }
                set
                {
                    this.oidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingTerminalInfoDestinationAddressContactsContactContactMethods
        {

            private MercuryGateMasterBillOfLadingTerminalInfoDestinationAddressContactsContactContactMethodsContactMethod contactMethodField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingTerminalInfoDestinationAddressContactsContactContactMethodsContactMethod ContactMethod
            {
                get
                {
                    return this.contactMethodField;
                }
                set
                {
                    this.contactMethodField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingTerminalInfoDestinationAddressContactsContactContactMethodsContactMethod
        {

            private byte sequenceNumField;

            private string typeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte sequenceNum
            {
                get
                {
                    return this.sequenceNumField;
                }
                set
                {
                    this.sequenceNumField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingDates
        {

            private MercuryGateMasterBillOfLadingDatesDate[] pickupField;

            private MercuryGateMasterBillOfLadingDatesDate1[] dropField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Date", IsNullable = false)]
            public MercuryGateMasterBillOfLadingDatesDate[] Pickup
            {
                get
                {
                    return this.pickupField;
                }
                set
                {
                    this.pickupField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Date", IsNullable = false)]
            public MercuryGateMasterBillOfLadingDatesDate1[] Drop
            {
                get
                {
                    return this.dropField;
                }
                set
                {
                    this.dropField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingDatesDate
        {

            private string typeField;

            private string valueField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingDatesDate1
        {

            private string typeField;

            private string valueField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPlan
        {

            private MercuryGateMasterBillOfLadingPlanEvents eventsField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPlanEvents Events
            {
                get
                {
                    return this.eventsField;
                }
                set
                {
                    this.eventsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPlanEvents
        {

            private MercuryGateMasterBillOfLadingPlanEventsEvent[] eventField;

            private byte countField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Event")]
            public MercuryGateMasterBillOfLadingPlanEventsEvent[] Event
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
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte count
            {
                get
                {
                    return this.countField;
                }
                set
                {
                    this.countField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPlanEventsEvent
        {

            private object carrierActionCodeField;

            private MercuryGateMasterBillOfLadingPlanEventsEventDate[] datesField;

            private object lateReasonField;

            private object appointmentTypeField;

            private MercuryGateMasterBillOfLadingPlanEventsEventAddress addressField;

            private object shipmentsField;

            private object activitiesField;

            private object trackingMessagesField;

            private string typeField;

            private byte sequenceNumField;

            private ulong internalIdField;

            /// <remarks/>
            public object CarrierActionCode
            {
                get
                {
                    return this.carrierActionCodeField;
                }
                set
                {
                    this.carrierActionCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Date", IsNullable = false)]
            public MercuryGateMasterBillOfLadingPlanEventsEventDate[] Dates
            {
                get
                {
                    return this.datesField;
                }
                set
                {
                    this.datesField = value;
                }
            }

            /// <remarks/>
            public object LateReason
            {
                get
                {
                    return this.lateReasonField;
                }
                set
                {
                    this.lateReasonField = value;
                }
            }

            /// <remarks/>
            public object AppointmentType
            {
                get
                {
                    return this.appointmentTypeField;
                }
                set
                {
                    this.appointmentTypeField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPlanEventsEventAddress Address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                }
            }

            /// <remarks/>
            public object Shipments
            {
                get
                {
                    return this.shipmentsField;
                }
                set
                {
                    this.shipmentsField = value;
                }
            }

            /// <remarks/>
            public object Activities
            {
                get
                {
                    return this.activitiesField;
                }
                set
                {
                    this.activitiesField = value;
                }
            }

            /// <remarks/>
            public object TrackingMessages
            {
                get
                {
                    return this.trackingMessagesField;
                }
                set
                {
                    this.trackingMessagesField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte sequenceNum
            {
                get
                {
                    return this.sequenceNumField;
                }
                set
                {
                    this.sequenceNumField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ulong internalId
            {
                get
                {
                    return this.internalIdField;
                }
                set
                {
                    this.internalIdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPlanEventsEventDate
        {

            private string typeField;

            private string valueField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPlanEventsEventAddress
        {

            private MercuryGateMasterBillOfLadingPlanEventsEventAddressAppointmentTime[] appointmentTimeField;

            private object locationCodeField;

            private string nameField;

            private string addrLine1Field;

            private object addrLine2Field;

            private string cityField;

            private string stateProvinceField;

            private uint postalCodeField;

            private string countryCodeField;

            private MercuryGateMasterBillOfLadingPlanEventsEventAddressGeoLoc geoLocField;

            private MercuryGateMasterBillOfLadingPlanEventsEventAddressContacts contactsField;

            private object commentsField;

            private string typeField;

            private bool isResidentialField;

            private bool isPrimaryField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("AppointmentTime")]
            public MercuryGateMasterBillOfLadingPlanEventsEventAddressAppointmentTime[] AppointmentTime
            {
                get
                {
                    return this.appointmentTimeField;
                }
                set
                {
                    this.appointmentTimeField = value;
                }
            }

            /// <remarks/>
            public object LocationCode
            {
                get
                {
                    return this.locationCodeField;
                }
                set
                {
                    this.locationCodeField = value;
                }
            }

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public string AddrLine1
            {
                get
                {
                    return this.addrLine1Field;
                }
                set
                {
                    this.addrLine1Field = value;
                }
            }

            /// <remarks/>
            public object AddrLine2
            {
                get
                {
                    return this.addrLine2Field;
                }
                set
                {
                    this.addrLine2Field = value;
                }
            }

            /// <remarks/>
            public string City
            {
                get
                {
                    return this.cityField;
                }
                set
                {
                    this.cityField = value;
                }
            }

            /// <remarks/>
            public string StateProvince
            {
                get
                {
                    return this.stateProvinceField;
                }
                set
                {
                    this.stateProvinceField = value;
                }
            }

            /// <remarks/>
            public uint PostalCode
            {
                get
                {
                    return this.postalCodeField;
                }
                set
                {
                    this.postalCodeField = value;
                }
            }

            /// <remarks/>
            public string CountryCode
            {
                get
                {
                    return this.countryCodeField;
                }
                set
                {
                    this.countryCodeField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPlanEventsEventAddressGeoLoc GeoLoc
            {
                get
                {
                    return this.geoLocField;
                }
                set
                {
                    this.geoLocField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPlanEventsEventAddressContacts Contacts
            {
                get
                {
                    return this.contactsField;
                }
                set
                {
                    this.contactsField = value;
                }
            }

            /// <remarks/>
            public object Comments
            {
                get
                {
                    return this.commentsField;
                }
                set
                {
                    this.commentsField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isResidential
            {
                get
                {
                    return this.isResidentialField;
                }
                set
                {
                    this.isResidentialField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isPrimary
            {
                get
                {
                    return this.isPrimaryField;
                }
                set
                {
                    this.isPrimaryField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPlanEventsEventAddressAppointmentTime
        {

            private string typeField;

            private string valueField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPlanEventsEventAddressGeoLoc
        {

            private uint latDegreesField;

            private string latDirectionField;

            private uint longDegreesField;

            private string longDirectionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint latDegrees
            {
                get
                {
                    return this.latDegreesField;
                }
                set
                {
                    this.latDegreesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string latDirection
            {
                get
                {
                    return this.latDirectionField;
                }
                set
                {
                    this.latDirectionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint longDegrees
            {
                get
                {
                    return this.longDegreesField;
                }
                set
                {
                    this.longDegreesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string longDirection
            {
                get
                {
                    return this.longDirectionField;
                }
                set
                {
                    this.longDirectionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPlanEventsEventAddressContacts
        {

            private MercuryGateMasterBillOfLadingPlanEventsEventAddressContactsContact contactField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPlanEventsEventAddressContactsContact Contact
            {
                get
                {
                    return this.contactField;
                }
                set
                {
                    this.contactField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPlanEventsEventAddressContactsContact
        {

            private string nameField;

            private MercuryGateMasterBillOfLadingPlanEventsEventAddressContactsContactContactMethods contactMethodsField;

            private string typeField;

            private ulong oidField;

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPlanEventsEventAddressContactsContactContactMethods ContactMethods
            {
                get
                {
                    return this.contactMethodsField;
                }
                set
                {
                    this.contactMethodsField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ulong oid
            {
                get
                {
                    return this.oidField;
                }
                set
                {
                    this.oidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPlanEventsEventAddressContactsContactContactMethods
        {

            private MercuryGateMasterBillOfLadingPlanEventsEventAddressContactsContactContactMethodsContactMethod contactMethodField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPlanEventsEventAddressContactsContactContactMethodsContactMethod ContactMethod
            {
                get
                {
                    return this.contactMethodField;
                }
                set
                {
                    this.contactMethodField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPlanEventsEventAddressContactsContactContactMethodsContactMethod
        {

            private byte sequenceNumField;

            private string typeField;

            private long valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte sequenceNum
            {
                get
                {
                    return this.sequenceNumField;
                }
                set
                {
                    this.sequenceNumField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public long Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingWeights
        {

            private MercuryGateMasterBillOfLadingWeightsWeight weightField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingWeightsWeight Weight
            {
                get
                {
                    return this.weightField;
                }
                set
                {
                    this.weightField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingWeightsWeight
        {

            private string typeField;

            private string uomField;

            private decimal valueField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string uom
            {
                get
                {
                    return this.uomField;
                }
                set
                {
                    this.uomField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public decimal Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingDimension
        {

            private string typeField;

            private string dimField;

            private string uomField;

            private decimal valueField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string dim
            {
                get
                {
                    return this.dimField;
                }
                set
                {
                    this.dimField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string uom
            {
                get
                {
                    return this.uomField;
                }
                set
                {
                    this.uomField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public decimal Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingQuantity
        {

            private string typeField;

            private decimal valueField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public decimal Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPriceSheet
        {

            private decimal accessorialTotalField;

            private decimal subTotalField;

            private decimal totalField;

            private object contractIdField;

            private object contractNameField;

            private MercuryGateMasterBillOfLadingPriceSheetCarrier carrierField;

            private object reasonCodeField;

            private string statusField;

            private string laneIDField;

            private object zoneField;

            private object routeGuidePriorityField;

            private object carrierLocationOidField;

            private object originServiceField;

            private object destinationServiceField;

            private decimal dimFactorField;

            private decimal dimWeightField;

            private decimal totalWeightField;

            private decimal chargeableWeightField;

            private MercuryGateMasterBillOfLadingPriceSheetCharge[] chargesField;

            private object commentsField;

            private string typeField;

            private string chargeModelField;

            private bool isSelectedField;

            private bool isAllocatedField;

            private string currencyCodeField;

            private string createDateField;

            private string updateDateField;

            private ulong internalIdField;

            private string createByField;

            private string updateByField;

            /// <remarks/>
            public decimal AccessorialTotal
            {
                get
                {
                    return this.accessorialTotalField;
                }
                set
                {
                    this.accessorialTotalField = value;
                }
            }

            /// <remarks/>
            public decimal SubTotal
            {
                get
                {
                    return this.subTotalField;
                }
                set
                {
                    this.subTotalField = value;
                }
            }

            /// <remarks/>
            public decimal Total
            {
                get
                {
                    return this.totalField;
                }
                set
                {
                    this.totalField = value;
                }
            }

            /// <remarks/>
            public object ContractId
            {
                get
                {
                    return this.contractIdField;
                }
                set
                {
                    this.contractIdField = value;
                }
            }

            /// <remarks/>
            public object ContractName
            {
                get
                {
                    return this.contractNameField;
                }
                set
                {
                    this.contractNameField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPriceSheetCarrier Carrier
            {
                get
                {
                    return this.carrierField;
                }
                set
                {
                    this.carrierField = value;
                }
            }

            /// <remarks/>
            public object ReasonCode
            {
                get
                {
                    return this.reasonCodeField;
                }
                set
                {
                    this.reasonCodeField = value;
                }
            }

            /// <remarks/>
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            public string LaneID
            {
                get
                {
                    return this.laneIDField;
                }
                set
                {
                    this.laneIDField = value;
                }
            }

            /// <remarks/>
            public object Zone
            {
                get
                {
                    return this.zoneField;
                }
                set
                {
                    this.zoneField = value;
                }
            }

            /// <remarks/>
            public object RouteGuidePriority
            {
                get
                {
                    return this.routeGuidePriorityField;
                }
                set
                {
                    this.routeGuidePriorityField = value;
                }
            }

            /// <remarks/>
            public object CarrierLocationOid
            {
                get
                {
                    return this.carrierLocationOidField;
                }
                set
                {
                    this.carrierLocationOidField = value;
                }
            }

            /// <remarks/>
            public object OriginService
            {
                get
                {
                    return this.originServiceField;
                }
                set
                {
                    this.originServiceField = value;
                }
            }

            /// <remarks/>
            public object DestinationService
            {
                get
                {
                    return this.destinationServiceField;
                }
                set
                {
                    this.destinationServiceField = value;
                }
            }

            /// <remarks/>
            public decimal DimFactor
            {
                get
                {
                    return this.dimFactorField;
                }
                set
                {
                    this.dimFactorField = value;
                }
            }

            /// <remarks/>
            public decimal DimWeight
            {
                get
                {
                    return this.dimWeightField;
                }
                set
                {
                    this.dimWeightField = value;
                }
            }

            /// <remarks/>
            public decimal TotalWeight
            {
                get
                {
                    return this.totalWeightField;
                }
                set
                {
                    this.totalWeightField = value;
                }
            }

            /// <remarks/>
            public decimal ChargeableWeight
            {
                get
                {
                    return this.chargeableWeightField;
                }
                set
                {
                    this.chargeableWeightField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Charge", IsNullable = false)]
            public MercuryGateMasterBillOfLadingPriceSheetCharge[] Charges
            {
                get
                {
                    return this.chargesField;
                }
                set
                {
                    this.chargesField = value;
                }
            }

            /// <remarks/>
            public object Comments
            {
                get
                {
                    return this.commentsField;
                }
                set
                {
                    this.commentsField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string chargeModel
            {
                get
                {
                    return this.chargeModelField;
                }
                set
                {
                    this.chargeModelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isSelected
            {
                get
                {
                    return this.isSelectedField;
                }
                set
                {
                    this.isSelectedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isAllocated
            {
                get
                {
                    return this.isAllocatedField;
                }
                set
                {
                    this.isAllocatedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string currencyCode
            {
                get
                {
                    return this.currencyCodeField;
                }
                set
                {
                    this.currencyCodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string createDate
            {
                get
                {
                    return this.createDateField;
                }
                set
                {
                    this.createDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string updateDate
            {
                get
                {
                    return this.updateDateField;
                }
                set
                {
                    this.updateDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ulong internalId
            {
                get
                {
                    return this.internalIdField;
                }
                set
                {
                    this.internalIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string createBy
            {
                get
                {
                    return this.createByField;
                }
                set
                {
                    this.createByField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string updateBy
            {
                get
                {
                    return this.updateByField;
                }
                set
                {
                    this.updateByField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPriceSheetCarrier
        {

            private string carrierIdField;

            private string carrierNameField;

            private string sCACField;

            private string modeField;

            private object serviceField;

            private decimal serviceDaysField;

            private decimal distanceField;

            private string idField;

            private MercuryGateMasterBillOfLadingPriceSheetCarrierInsurance[] insuranceTypesField;

            private MercuryGateMasterBillOfLadingPriceSheetCarrierAddress addressField;

            /// <remarks/>
            public string CarrierId
            {
                get
                {
                    return this.carrierIdField;
                }
                set
                {
                    this.carrierIdField = value;
                }
            }

            /// <remarks/>
            public string CarrierName
            {
                get
                {
                    return this.carrierNameField;
                }
                set
                {
                    this.carrierNameField = value;
                }
            }

            /// <remarks/>
            public string SCAC
            {
                get
                {
                    return this.sCACField;
                }
                set
                {
                    this.sCACField = value;
                }
            }

            /// <remarks/>
            public string Mode
            {
                get
                {
                    return this.modeField;
                }
                set
                {
                    this.modeField = value;
                }
            }

            /// <remarks/>
            public object Service
            {
                get
                {
                    return this.serviceField;
                }
                set
                {
                    this.serviceField = value;
                }
            }

            /// <remarks/>
            public decimal ServiceDays
            {
                get
                {
                    return this.serviceDaysField;
                }
                set
                {
                    this.serviceDaysField = value;
                }
            }

            /// <remarks/>
            public decimal Distance
            {
                get
                {
                    return this.distanceField;
                }
                set
                {
                    this.distanceField = value;
                }
            }

            /// <remarks/>
            public string Id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Insurance", IsNullable = false)]
            public MercuryGateMasterBillOfLadingPriceSheetCarrierInsurance[] InsuranceTypes
            {
                get
                {
                    return this.insuranceTypesField;
                }
                set
                {
                    this.insuranceTypesField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPriceSheetCarrierAddress Address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPriceSheetCarrierInsurance
        {

            private string typeField;

            private decimal amountField;

            private string companyField;

            private string expirationDateField;

            private string contactNameField;

            private string contactPhoneField;

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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal amount
            {
                get
                {
                    return this.amountField;
                }
                set
                {
                    this.amountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string company
            {
                get
                {
                    return this.companyField;
                }
                set
                {
                    this.companyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string expirationDate
            {
                get
                {
                    return this.expirationDateField;
                }
                set
                {
                    this.expirationDateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string contactName
            {
                get
                {
                    return this.contactNameField;
                }
                set
                {
                    this.contactNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string contactPhone
            {
                get
                {
                    return this.contactPhoneField;
                }
                set
                {
                    this.contactPhoneField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPriceSheetCarrierAddress
        {

            private string ownerField;

            private string customerAcctNumField;

            private string locationCodeField;

            private string nameField;

            private string addrLine1Field;

            private object addrLine2Field;

            private string cityField;

            private string stateProvinceField;

            private string postalCodeField;

            private string countryCodeField;

            private MercuryGateMasterBillOfLadingPriceSheetCarrierAddressGeoLoc geoLocField;

            private MercuryGateMasterBillOfLadingPriceSheetCarrierAddressContacts contactsField;

            private object commentsField;

            private string typeField;

            private bool isResidentialField;

            private bool isPrimaryField;

            /// <remarks/>
            public string Owner
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
            public string CustomerAcctNum
            {
                get
                {
                    return this.customerAcctNumField;
                }
                set
                {
                    this.customerAcctNumField = value;
                }
            }

            /// <remarks/>
            public string LocationCode
            {
                get
                {
                    return this.locationCodeField;
                }
                set
                {
                    this.locationCodeField = value;
                }
            }

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public string AddrLine1
            {
                get
                {
                    return this.addrLine1Field;
                }
                set
                {
                    this.addrLine1Field = value;
                }
            }

            /// <remarks/>
            public object AddrLine2
            {
                get
                {
                    return this.addrLine2Field;
                }
                set
                {
                    this.addrLine2Field = value;
                }
            }

            /// <remarks/>
            public string City
            {
                get
                {
                    return this.cityField;
                }
                set
                {
                    this.cityField = value;
                }
            }

            /// <remarks/>
            public string StateProvince
            {
                get
                {
                    return this.stateProvinceField;
                }
                set
                {
                    this.stateProvinceField = value;
                }
            }

            /// <remarks/>
            public string PostalCode
            {
                get
                {
                    return this.postalCodeField;
                }
                set
                {
                    this.postalCodeField = value;
                }
            }

            /// <remarks/>
            public string CountryCode
            {
                get
                {
                    return this.countryCodeField;
                }
                set
                {
                    this.countryCodeField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPriceSheetCarrierAddressGeoLoc GeoLoc
            {
                get
                {
                    return this.geoLocField;
                }
                set
                {
                    this.geoLocField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPriceSheetCarrierAddressContacts Contacts
            {
                get
                {
                    return this.contactsField;
                }
                set
                {
                    this.contactsField = value;
                }
            }

            /// <remarks/>
            public object Comments
            {
                get
                {
                    return this.commentsField;
                }
                set
                {
                    this.commentsField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isResidential
            {
                get
                {
                    return this.isResidentialField;
                }
                set
                {
                    this.isResidentialField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isPrimary
            {
                get
                {
                    return this.isPrimaryField;
                }
                set
                {
                    this.isPrimaryField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPriceSheetCarrierAddressGeoLoc
        {

            private uint latDegreesField;

            private string latDirectionField;

            private uint longDegreesField;

            private string longDirectionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint latDegrees
            {
                get
                {
                    return this.latDegreesField;
                }
                set
                {
                    this.latDegreesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string latDirection
            {
                get
                {
                    return this.latDirectionField;
                }
                set
                {
                    this.latDirectionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint longDegrees
            {
                get
                {
                    return this.longDegreesField;
                }
                set
                {
                    this.longDegreesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string longDirection
            {
                get
                {
                    return this.longDirectionField;
                }
                set
                {
                    this.longDirectionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPriceSheetCarrierAddressContacts
        {

            private MercuryGateMasterBillOfLadingPriceSheetCarrierAddressContactsContact contactField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPriceSheetCarrierAddressContactsContact Contact
            {
                get
                {
                    return this.contactField;
                }
                set
                {
                    this.contactField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPriceSheetCarrierAddressContactsContact
        {

            private string nameField;

            private MercuryGateMasterBillOfLadingPriceSheetCarrierAddressContactsContactContactMethods contactMethodsField;

            private string typeField;

            private ulong oidField;

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPriceSheetCarrierAddressContactsContactContactMethods ContactMethods
            {
                get
                {
                    return this.contactMethodsField;
                }
                set
                {
                    this.contactMethodsField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ulong oid
            {
                get
                {
                    return this.oidField;
                }
                set
                {
                    this.oidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPriceSheetCarrierAddressContactsContactContactMethods
        {

            private MercuryGateMasterBillOfLadingPriceSheetCarrierAddressContactsContactContactMethodsContactMethod contactMethodField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPriceSheetCarrierAddressContactsContactContactMethodsContactMethod ContactMethod
            {
                get
                {
                    return this.contactMethodField;
                }
                set
                {
                    this.contactMethodField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPriceSheetCarrierAddressContactsContactContactMethodsContactMethod
        {

            private byte sequenceNumField;

            private string typeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte sequenceNum
            {
                get
                {
                    return this.sequenceNumField;
                }
                set
                {
                    this.sequenceNumField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPriceSheetCharge
        {

            private string descriptionField;

            private object ediCodeField;

            private decimal amountField;

            private decimal rateField;

            private string rateQualifierField;

            private object quantityField;

            private decimal weightField;

            private decimal dimWeightField;

            private decimal freightClassField;

            private decimal fakFreightClassField;

            private bool isMinField;

            private bool isMaxField;

            private bool isNontaxableField;

            private object referenceNumbersField;

            private byte sequenceNumField;

            private string typeField;

            private string itemGroupIdField;

            /// <remarks/>
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public object EdiCode
            {
                get
                {
                    return this.ediCodeField;
                }
                set
                {
                    this.ediCodeField = value;
                }
            }

            /// <remarks/>
            public decimal Amount
            {
                get
                {
                    return this.amountField;
                }
                set
                {
                    this.amountField = value;
                }
            }

            /// <remarks/>
            public decimal Rate
            {
                get
                {
                    return this.rateField;
                }
                set
                {
                    this.rateField = value;
                }
            }

            /// <remarks/>
            public string RateQualifier
            {
                get
                {
                    return this.rateQualifierField;
                }
                set
                {
                    this.rateQualifierField = value;
                }
            }

            /// <remarks/>
            public object Quantity
            {
                get
                {
                    return this.quantityField;
                }
                set
                {
                    this.quantityField = value;
                }
            }

            /// <remarks/>
            public decimal Weight
            {
                get
                {
                    return this.weightField;
                }
                set
                {
                    this.weightField = value;
                }
            }

            /// <remarks/>
            public decimal DimWeight
            {
                get
                {
                    return this.dimWeightField;
                }
                set
                {
                    this.dimWeightField = value;
                }
            }

            /// <remarks/>
            public decimal FreightClass
            {
                get
                {
                    return this.freightClassField;
                }
                set
                {
                    this.freightClassField = value;
                }
            }

            /// <remarks/>
            public decimal FakFreightClass
            {
                get
                {
                    return this.fakFreightClassField;
                }
                set
                {
                    this.fakFreightClassField = value;
                }
            }

            /// <remarks/>
            public bool IsMin
            {
                get
                {
                    return this.isMinField;
                }
                set
                {
                    this.isMinField = value;
                }
            }

            /// <remarks/>
            public bool IsMax
            {
                get
                {
                    return this.isMaxField;
                }
                set
                {
                    this.isMaxField = value;
                }
            }

            /// <remarks/>
            public bool IsNontaxable
            {
                get
                {
                    return this.isNontaxableField;
                }
                set
                {
                    this.isNontaxableField = value;
                }
            }

            /// <remarks/>
            public object ReferenceNumbers
            {
                get
                {
                    return this.referenceNumbersField;
                }
                set
                {
                    this.referenceNumbersField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte sequenceNum
            {
                get
                {
                    return this.sequenceNumField;
                }
                set
                {
                    this.sequenceNumField = value;
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string itemGroupId
            {
                get
                {
                    return this.itemGroupIdField;
                }
                set
                {
                    this.itemGroupIdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingTenders
        {

            private MercuryGateMasterBillOfLadingTendersTender tenderField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingTendersTender Tender
            {
                get
                {
                    return this.tenderField;
                }
                set
                {
                    this.tenderField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingTendersTender
        {

            private MercuryGateMasterBillOfLadingTendersTenderTenderResponse tenderResponseField;

            private string userField;

            private string carrierSCACField;

            private string methodField;

            private string dateField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingTendersTenderTenderResponse TenderResponse
            {
                get
                {
                    return this.tenderResponseField;
                }
                set
                {
                    this.tenderResponseField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string user
            {
                get
                {
                    return this.userField;
                }
                set
                {
                    this.userField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string carrierSCAC
            {
                get
                {
                    return this.carrierSCACField;
                }
                set
                {
                    this.carrierSCACField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string method
            {
                get
                {
                    return this.methodField;
                }
                set
                {
                    this.methodField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingTendersTenderTenderResponse
        {

            private string carrierSCACField;

            private string actioncodeField;

            private string dateField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string carrierSCAC
            {
                get
                {
                    return this.carrierSCACField;
                }
                set
                {
                    this.carrierSCACField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string actioncode
            {
                get
                {
                    return this.actioncodeField;
                }
                set
                {
                    this.actioncodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingActivities
        {

            private MercuryGateMasterBillOfLadingActivitiesActivity activityField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingActivitiesActivity Activity
            {
                get
                {
                    return this.activityField;
                }
                set
                {
                    this.activityField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingActivitiesActivity
        {

            private object activityIDField;

            private object summaryField;

            private object priorityField;

            private bool requiredField;

            private string statusField;

            private object assignedToField;

            private object percentageCompleteField;

            private string completedDateField;

            private object statusDetailsField;

            private object locationField;

            private object contactField;

            private object documentsField;

            private string typeField;

            /// <remarks/>
            public object ActivityID
            {
                get
                {
                    return this.activityIDField;
                }
                set
                {
                    this.activityIDField = value;
                }
            }

            /// <remarks/>
            public object Summary
            {
                get
                {
                    return this.summaryField;
                }
                set
                {
                    this.summaryField = value;
                }
            }

            /// <remarks/>
            public object Priority
            {
                get
                {
                    return this.priorityField;
                }
                set
                {
                    this.priorityField = value;
                }
            }

            /// <remarks/>
            public bool Required
            {
                get
                {
                    return this.requiredField;
                }
                set
                {
                    this.requiredField = value;
                }
            }

            /// <remarks/>
            public string Status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            public object AssignedTo
            {
                get
                {
                    return this.assignedToField;
                }
                set
                {
                    this.assignedToField = value;
                }
            }

            /// <remarks/>
            public object PercentageComplete
            {
                get
                {
                    return this.percentageCompleteField;
                }
                set
                {
                    this.percentageCompleteField = value;
                }
            }

            /// <remarks/>
            public string CompletedDate
            {
                get
                {
                    return this.completedDateField;
                }
                set
                {
                    this.completedDateField = value;
                }
            }

            /// <remarks/>
            public object StatusDetails
            {
                get
                {
                    return this.statusDetailsField;
                }
                set
                {
                    this.statusDetailsField = value;
                }
            }

            /// <remarks/>
            public object Location
            {
                get
                {
                    return this.locationField;
                }
                set
                {
                    this.locationField = value;
                }
            }

            /// <remarks/>
            public object Contact
            {
                get
                {
                    return this.contactField;
                }
                set
                {
                    this.contactField = value;
                }
            }

            /// <remarks/>
            public object Documents
            {
                get
                {
                    return this.documentsField;
                }
                set
                {
                    this.documentsField = value;
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

﻿// <auto-gnereated></auto-generated>
using System.Xml.Serialization;

namespace CSP.TeknowlogiAPIs.MercuryGate
{
    public class MercuryGateFailedResponse
    {
        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
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

            private MercuryGateMasterBillOfLadingRelatedItems relatedItemsField;

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

            private MercuryGateMasterBillOfLadingShipments shipmentsField;

            private MercuryGateMasterBillOfLadingWeight[] weightsField;

            private MercuryGateMasterBillOfLadingDimension[] dimensionsField;

            private MercuryGateMasterBillOfLadingQuantity[] quantitiesField;

            private MercuryGateMasterBillOfLadingPriceSheet[] priceSheetsField;

            private MercuryGateMasterBillOfLadingTenders tendersField;

            private MercuryGateMasterBillOfLadingActivities activitiesField;

            private object linksField;

            private object trackingMessagesField;

            private object marginsField;

            private string internalIdField;

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
            public MercuryGateMasterBillOfLadingRelatedItems RelatedItems
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
            public MercuryGateMasterBillOfLadingShipments Shipments
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
            [System.Xml.Serialization.XmlArrayItemAttribute("Weight", IsNullable = false)]
            public MercuryGateMasterBillOfLadingWeight[] Weights
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
            public string internalId
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
        public partial class MercuryGateMasterBillOfLadingRelatedItems
        {

            private MercuryGateMasterBillOfLadingRelatedItemsPackages packagesField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingRelatedItemsPackages Packages
            {
                get
                {
                    return this.packagesField;
                }
                set
                {
                    this.packagesField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingRelatedItemsPackages
        {

            private MercuryGateMasterBillOfLadingRelatedItemsPackagesPackage packageField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingRelatedItemsPackagesPackage Package
            {
                get
                {
                    return this.packageField;
                }
                set
                {
                    this.packageField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingRelatedItemsPackagesPackage
        {

            private MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageDimension[] dimensionsField;

            private MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageWeight[] weightsField;

            private MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroups itemGroupsField;

            private string typeField;

            private string internalIdField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Dimension", IsNullable = false)]
            public MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageDimension[] Dimensions
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
            [System.Xml.Serialization.XmlArrayItemAttribute("Weight", IsNullable = false)]
            public MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageWeight[] Weights
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
            public MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroups ItemGroups
            {
                get
                {
                    return this.itemGroupsField;
                }
                set
                {
                    this.itemGroupsField = value;
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
            public string internalId
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
        public partial class MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageDimension
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
        public partial class MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageWeight
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
        public partial class MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroups
        {

            private MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroup itemGroupField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroup ItemGroup
            {
                get
                {
                    return this.itemGroupField;
                }
                set
                {
                    this.itemGroupField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroup
        {

            private string descriptionField;

            private byte containmentIdField;

            private MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupWeight[] weightsField;

            private MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupQuantity[] quantitiesField;

            private MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupDimension[] dimensionsField;

            private MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupFreightClass freightClassField;

            private byte stackabilityField;

            private object trackingNumberField;

            private object deliveryStatusField;

            private object referenceNumbersField;

            private MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItem lineItemField;

            private string internalIdField;

            private bool isShipUnitField;

            private bool isHandlingUnitField;

            private byte sequenceField;

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
            public byte ContainmentId
            {
                get
                {
                    return this.containmentIdField;
                }
                set
                {
                    this.containmentIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Weight", IsNullable = false)]
            public MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupWeight[] Weights
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
            [System.Xml.Serialization.XmlArrayItemAttribute("Quantity", IsNullable = false)]
            public MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupQuantity[] Quantities
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
            [System.Xml.Serialization.XmlArrayItemAttribute("Dimension", IsNullable = false)]
            public MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupDimension[] Dimensions
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
            public MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupFreightClass FreightClass
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
            public byte Stackability
            {
                get
                {
                    return this.stackabilityField;
                }
                set
                {
                    this.stackabilityField = value;
                }
            }

            /// <remarks/>
            public object TrackingNumber
            {
                get
                {
                    return this.trackingNumberField;
                }
                set
                {
                    this.trackingNumberField = value;
                }
            }

            /// <remarks/>
            public object DeliveryStatus
            {
                get
                {
                    return this.deliveryStatusField;
                }
                set
                {
                    this.deliveryStatusField = value;
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
            public MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItem LineItem
            {
                get
                {
                    return this.lineItemField;
                }
                set
                {
                    this.lineItemField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string internalId
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
            public bool isShipUnit
            {
                get
                {
                    return this.isShipUnitField;
                }
                set
                {
                    this.isShipUnitField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isHandlingUnit
            {
                get
                {
                    return this.isHandlingUnitField;
                }
                set
                {
                    this.isHandlingUnitField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte sequence
            {
                get
                {
                    return this.sequenceField;
                }
                set
                {
                    this.sequenceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupWeight
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
        public partial class MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupQuantity
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
        public partial class MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupDimension
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
        public partial class MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupFreightClass
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
        public partial class MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItem
        {

            private MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemWeights weightsField;

            private MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemQuantities quantitiesField;

            private string itemIdField;

            private string descriptionField;

            private decimal freightClassField;

            private object commodityField;

            private object nmfcCodeField;

            private object stccCodeField;

            private object customerPartNumField;

            private object manufacturerPartNumField;

            private object distributorPartNumField;

            private byte cubeField;

            private MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemTemperatureRange temperatureRangeField;

            private bool hazardousMaterialField;

            private MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemHazMatDetail hazMatDetailField;

            private MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemDimension[] dimensionsField;

            private object harmonizedTariffCodeField;

            private object portOfLadingField;

            private object countryOfOriginField;

            private object countryOfManufactureField;

            private object customsValueField;

            private object customsValueCurrencyField;

            private object insuredValueField;

            private object insuredValueCurrencyField;

            private object aESExportCodeField;

            private object scheduleBNumberField;

            private object domesticField;

            private object eCCNField;

            private object originationCountryField;

            private object manufacturingCountryField;

            private object licenseNumberField;

            private object licenseTypeField;

            private object referenceNumbersField;

            private byte lineNumberField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemWeights Weights
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
            public MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemQuantities Quantities
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
            public string ItemId
            {
                get
                {
                    return this.itemIdField;
                }
                set
                {
                    this.itemIdField = value;
                }
            }

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
            public object Commodity
            {
                get
                {
                    return this.commodityField;
                }
                set
                {
                    this.commodityField = value;
                }
            }

            /// <remarks/>
            public object NmfcCode
            {
                get
                {
                    return this.nmfcCodeField;
                }
                set
                {
                    this.nmfcCodeField = value;
                }
            }

            /// <remarks/>
            public object StccCode
            {
                get
                {
                    return this.stccCodeField;
                }
                set
                {
                    this.stccCodeField = value;
                }
            }

            /// <remarks/>
            public object CustomerPartNum
            {
                get
                {
                    return this.customerPartNumField;
                }
                set
                {
                    this.customerPartNumField = value;
                }
            }

            /// <remarks/>
            public object ManufacturerPartNum
            {
                get
                {
                    return this.manufacturerPartNumField;
                }
                set
                {
                    this.manufacturerPartNumField = value;
                }
            }

            /// <remarks/>
            public object DistributorPartNum
            {
                get
                {
                    return this.distributorPartNumField;
                }
                set
                {
                    this.distributorPartNumField = value;
                }
            }

            /// <remarks/>
            public byte Cube
            {
                get
                {
                    return this.cubeField;
                }
                set
                {
                    this.cubeField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemTemperatureRange TemperatureRange
            {
                get
                {
                    return this.temperatureRangeField;
                }
                set
                {
                    this.temperatureRangeField = value;
                }
            }

            /// <remarks/>
            public bool HazardousMaterial
            {
                get
                {
                    return this.hazardousMaterialField;
                }
                set
                {
                    this.hazardousMaterialField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemHazMatDetail HazMatDetail
            {
                get
                {
                    return this.hazMatDetailField;
                }
                set
                {
                    this.hazMatDetailField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Dimension", IsNullable = false)]
            public MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemDimension[] Dimensions
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
            public object HarmonizedTariffCode
            {
                get
                {
                    return this.harmonizedTariffCodeField;
                }
                set
                {
                    this.harmonizedTariffCodeField = value;
                }
            }

            /// <remarks/>
            public object PortOfLading
            {
                get
                {
                    return this.portOfLadingField;
                }
                set
                {
                    this.portOfLadingField = value;
                }
            }

            /// <remarks/>
            public object CountryOfOrigin
            {
                get
                {
                    return this.countryOfOriginField;
                }
                set
                {
                    this.countryOfOriginField = value;
                }
            }

            /// <remarks/>
            public object CountryOfManufacture
            {
                get
                {
                    return this.countryOfManufactureField;
                }
                set
                {
                    this.countryOfManufactureField = value;
                }
            }

            /// <remarks/>
            public object CustomsValue
            {
                get
                {
                    return this.customsValueField;
                }
                set
                {
                    this.customsValueField = value;
                }
            }

            /// <remarks/>
            public object CustomsValueCurrency
            {
                get
                {
                    return this.customsValueCurrencyField;
                }
                set
                {
                    this.customsValueCurrencyField = value;
                }
            }

            /// <remarks/>
            public object InsuredValue
            {
                get
                {
                    return this.insuredValueField;
                }
                set
                {
                    this.insuredValueField = value;
                }
            }

            /// <remarks/>
            public object InsuredValueCurrency
            {
                get
                {
                    return this.insuredValueCurrencyField;
                }
                set
                {
                    this.insuredValueCurrencyField = value;
                }
            }

            /// <remarks/>
            public object AESExportCode
            {
                get
                {
                    return this.aESExportCodeField;
                }
                set
                {
                    this.aESExportCodeField = value;
                }
            }

            /// <remarks/>
            public object ScheduleBNumber
            {
                get
                {
                    return this.scheduleBNumberField;
                }
                set
                {
                    this.scheduleBNumberField = value;
                }
            }

            /// <remarks/>
            public object Domestic
            {
                get
                {
                    return this.domesticField;
                }
                set
                {
                    this.domesticField = value;
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
            public object OriginationCountry
            {
                get
                {
                    return this.originationCountryField;
                }
                set
                {
                    this.originationCountryField = value;
                }
            }

            /// <remarks/>
            public object ManufacturingCountry
            {
                get
                {
                    return this.manufacturingCountryField;
                }
                set
                {
                    this.manufacturingCountryField = value;
                }
            }

            /// <remarks/>
            public object LicenseNumber
            {
                get
                {
                    return this.licenseNumberField;
                }
                set
                {
                    this.licenseNumberField = value;
                }
            }

            /// <remarks/>
            public object LicenseType
            {
                get
                {
                    return this.licenseTypeField;
                }
                set
                {
                    this.licenseTypeField = value;
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
            public byte lineNumber
            {
                get
                {
                    return this.lineNumberField;
                }
                set
                {
                    this.lineNumberField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemWeights
        {

            private MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemWeightsWeight weightField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemWeightsWeight Weight
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
        public partial class MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemWeightsWeight
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
        public partial class MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemQuantities
        {

            private MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemQuantitiesQuantity quantityField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemQuantitiesQuantity Quantity
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemQuantitiesQuantity
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
        public partial class MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemTemperatureRange
        {

            private byte minField;

            private byte maxField;

            private string uomField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte min
            {
                get
                {
                    return this.minField;
                }
                set
                {
                    this.minField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte max
            {
                get
                {
                    return this.maxField;
                }
                set
                {
                    this.maxField = value;
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemHazMatDetail
        {

            private string properShippingNameField;

            private object hazMatIDField;

            private object packageGroupField;

            private decimal hazMatClassField;

            private string contactNameField;

            private object contactPhoneField;

            private bool hazMatPlacardsField;

            private object hazMatPlacardsDetailsField;

            private byte hazMatEMSNumberField;

            private MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemHazMatDetailHazMatFlashPointTemp hazMatFlashPointTempField;

            private object commentsField;

            /// <remarks/>
            public string ProperShippingName
            {
                get
                {
                    return this.properShippingNameField;
                }
                set
                {
                    this.properShippingNameField = value;
                }
            }

            /// <remarks/>
            public object HazMatID
            {
                get
                {
                    return this.hazMatIDField;
                }
                set
                {
                    this.hazMatIDField = value;
                }
            }

            /// <remarks/>
            public object PackageGroup
            {
                get
                {
                    return this.packageGroupField;
                }
                set
                {
                    this.packageGroupField = value;
                }
            }

            /// <remarks/>
            public decimal HazMatClass
            {
                get
                {
                    return this.hazMatClassField;
                }
                set
                {
                    this.hazMatClassField = value;
                }
            }

            /// <remarks/>
            public string ContactName
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
            public object ContactPhone
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

            /// <remarks/>
            public bool HazMatPlacards
            {
                get
                {
                    return this.hazMatPlacardsField;
                }
                set
                {
                    this.hazMatPlacardsField = value;
                }
            }

            /// <remarks/>
            public object HazMatPlacardsDetails
            {
                get
                {
                    return this.hazMatPlacardsDetailsField;
                }
                set
                {
                    this.hazMatPlacardsDetailsField = value;
                }
            }

            /// <remarks/>
            public byte HazMatEMSNumber
            {
                get
                {
                    return this.hazMatEMSNumberField;
                }
                set
                {
                    this.hazMatEMSNumberField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemHazMatDetailHazMatFlashPointTemp HazMatFlashPointTemp
            {
                get
                {
                    return this.hazMatFlashPointTempField;
                }
                set
                {
                    this.hazMatFlashPointTempField = value;
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemHazMatDetailHazMatFlashPointTemp
        {

            private string uomField;

            private decimal valueField;

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
        public partial class MercuryGateMasterBillOfLadingRelatedItemsPackagesPackageItemGroupsItemGroupLineItemDimension
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

            private string postalCodeField;

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

            private string latDegreesField;

            private string latDirectionField;

            private string longDegreesField;

            private string longDirectionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string latDegrees
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
            public string longDegrees
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

            private string oidField;

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
            public string oid
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

            private string latDegreesField;

            private string latDirectionField;

            private string longDegreesField;

            private string longDirectionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string latDegrees
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
            public string longDegrees
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

            private string oidField;

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
            public string oid
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

            private string postalCodeField;

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

            private string latDegreesField;

            private string latDirectionField;

            private string longDegreesField;

            private string longDirectionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string latDegrees
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
            public string longDegrees
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

            private string oidField;

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
            public string oid
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

            private string postalCodeField;

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

            private string latDegreesField;

            private string latDirectionField;

            private string longDegreesField;

            private string longDirectionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string latDegrees
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
            public string longDegrees
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

            private string oidField;

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
            public string oid
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

            private MercuryGateMasterBillOfLadingPlanEventsEventWeight weightField;

            private MercuryGateMasterBillOfLadingPlanEventsEventShipments shipmentsField;

            private object activitiesField;

            private object trackingMessagesField;

            private string typeField;

            private byte sequenceNumField;

            private string internalIdField;

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
            public MercuryGateMasterBillOfLadingPlanEventsEventWeight Weight
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
            public MercuryGateMasterBillOfLadingPlanEventsEventShipments Shipments
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
            public string internalId
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

            private string postalCodeField;

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

            private string latDegreesField;

            private string latDirectionField;

            private string longDegreesField;

            private string longDirectionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string latDegrees
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
            public string longDegrees
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

            private string oidField;

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
            public string oid
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
        public partial class MercuryGateMasterBillOfLadingPlanEventsEventWeight
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
        public partial class MercuryGateMasterBillOfLadingPlanEventsEventShipments
        {

            private MercuryGateMasterBillOfLadingPlanEventsEventShipmentsReferenceNumbers referenceNumbersField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPlanEventsEventShipmentsReferenceNumbers ReferenceNumbers
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPlanEventsEventShipmentsReferenceNumbers
        {

            private MercuryGateMasterBillOfLadingPlanEventsEventShipmentsReferenceNumbersReferenceNumber referenceNumberField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingPlanEventsEventShipmentsReferenceNumbersReferenceNumber ReferenceNumber
            {
                get
                {
                    return this.referenceNumberField;
                }
                set
                {
                    this.referenceNumberField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingPlanEventsEventShipmentsReferenceNumbersReferenceNumber
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
        public partial class MercuryGateMasterBillOfLadingShipments
        {

            private MercuryGateMasterBillOfLadingShipmentsShipment shipmentField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipment Shipment
            {
                get
                {
                    return this.shipmentField;
                }
                set
                {
                    this.shipmentField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingShipmentsShipment
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentReferenceNumber[] referenceNumbersField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentComments commentsField;

            private string statusField;

            private object assignedToField;

            private string ownerField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentAudits auditsField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentQuoteDetail quoteDetailField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentCarriers carriersField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfo[] terminalInfoField;

            private object equipmentListField;

            private object scheduledEquipmentField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentQuantities quantitiesField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentWeight[] weightsField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentDimension[] dimensionsField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentDates datesField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheet[] priceSheetsField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentShipper shipperField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentConsignee consigneeField;

            private object servicesField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPackages packagesField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPayment paymentField;

            private bool pODReceivedField;

            private object relatedPartiesField;

            private object ordersField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentLateReason lateReasonField;

            private object originalSourceField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentEnterprise enterpriseField;

            private object activitiesField;

            private object linksField;

            private string internalIdField;

            private string typeField;

            private string createByField;

            private string createDateField;

            private string updateByField;

            private string updateDateField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("ReferenceNumber", IsNullable = false)]
            public MercuryGateMasterBillOfLadingShipmentsShipmentReferenceNumber[] ReferenceNumbers
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentComments Comments
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentAudits Audits
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentQuoteDetail QuoteDetail
            {
                get
                {
                    return this.quoteDetailField;
                }
                set
                {
                    this.quoteDetailField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentCarriers Carriers
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfo[] TerminalInfo
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentQuantities Quantities
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
            [System.Xml.Serialization.XmlArrayItemAttribute("Weight", IsNullable = false)]
            public MercuryGateMasterBillOfLadingShipmentsShipmentWeight[] Weights
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentDimension[] Dimensions
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentDates Dates
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
            [System.Xml.Serialization.XmlArrayItemAttribute("PriceSheet", IsNullable = false)]
            public MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheet[] PriceSheets
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentShipper Shipper
            {
                get
                {
                    return this.shipperField;
                }
                set
                {
                    this.shipperField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentConsignee Consignee
            {
                get
                {
                    return this.consigneeField;
                }
                set
                {
                    this.consigneeField = value;
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentPackages Packages
            {
                get
                {
                    return this.packagesField;
                }
                set
                {
                    this.packagesField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentPayment Payment
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
            public object Orders
            {
                get
                {
                    return this.ordersField;
                }
                set
                {
                    this.ordersField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentLateReason LateReason
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
            public object OriginalSource
            {
                get
                {
                    return this.originalSourceField;
                }
                set
                {
                    this.originalSourceField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentEnterprise Enterprise
            {
                get
                {
                    return this.enterpriseField;
                }
                set
                {
                    this.enterpriseField = value;
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
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string internalId
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentReferenceNumber
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentComments
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentCommentsComment commentField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentCommentsComment Comment
            {
                get
                {
                    return this.commentField;
                }
                set
                {
                    this.commentField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentCommentsComment
        {

            private string typeField;

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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentAudits
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentAuditsAudit auditField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentAuditsAudit Audit
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentAuditsAudit
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentQuoteDetail
        {

            private object quotedToField;

            private object quotePhoneField;

            private object quoteFaxField;

            private object quoteEmailField;

            private object quoteDateField;

            private string quoteByField;

            /// <remarks/>
            public object QuotedTo
            {
                get
                {
                    return this.quotedToField;
                }
                set
                {
                    this.quotedToField = value;
                }
            }

            /// <remarks/>
            public object QuotePhone
            {
                get
                {
                    return this.quotePhoneField;
                }
                set
                {
                    this.quotePhoneField = value;
                }
            }

            /// <remarks/>
            public object QuoteFax
            {
                get
                {
                    return this.quoteFaxField;
                }
                set
                {
                    this.quoteFaxField = value;
                }
            }

            /// <remarks/>
            public object QuoteEmail
            {
                get
                {
                    return this.quoteEmailField;
                }
                set
                {
                    this.quoteEmailField = value;
                }
            }

            /// <remarks/>
            public object QuoteDate
            {
                get
                {
                    return this.quoteDateField;
                }
                set
                {
                    this.quoteDateField = value;
                }
            }

            /// <remarks/>
            public string QuoteBy
            {
                get
                {
                    return this.quoteByField;
                }
                set
                {
                    this.quoteByField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentCarriers
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrier carrierField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrier Carrier
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrier
        {

            private string carrierIdField;

            private string carrierNameField;

            private string sCACField;

            private string modeField;

            private object serviceField;

            private decimal serviceDaysField;

            private decimal distanceField;

            private string idField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierInsurance[] insuranceTypesField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierAddress addressField;

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
            public MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierInsurance[] InsuranceTypes
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierAddress Address
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierInsurance
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierAddress
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

            private MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierAddressGeoLoc geoLocField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierAddressContacts contactsField;

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
            public MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierAddressGeoLoc GeoLoc
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierAddressContacts Contacts
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierAddressGeoLoc
        {

            private string latDegreesField;

            private string latDirectionField;

            private string longDegreesField;

            private string longDirectionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string latDegrees
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
            public string longDegrees
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierAddressContacts
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierAddressContactsContact contactField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierAddressContactsContact Contact
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierAddressContactsContact
        {

            private string nameField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierAddressContactsContactContactMethods contactMethodsField;

            private string typeField;

            private string oidField;

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
            public MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierAddressContactsContactContactMethods ContactMethods
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
            public string oid
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierAddressContactsContactContactMethods
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierAddressContactsContactContactMethodsContactMethod contactMethodField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierAddressContactsContactContactMethodsContactMethod ContactMethod
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentCarriersCarrierAddressContactsContactContactMethodsContactMethod
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfo
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOrigin originField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestination destinationField;

            private string typeField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOrigin Origin
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestination Destination
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOrigin
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOriginAddress addressField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOriginAddress Address
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOriginAddress
        {

            private object ownerField;

            private object customerAcctNumField;

            private object locationCodeField;

            private string nameField;

            private string addrLine1Field;

            private object addrLine2Field;

            private string cityField;

            private string stateProvinceField;

            private string postalCodeField;

            private string countryCodeField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOriginAddressGeoLoc geoLocField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOriginAddressContacts contactsField;

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
            public MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOriginAddressGeoLoc GeoLoc
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOriginAddressContacts Contacts
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOriginAddressGeoLoc
        {

            private string latDegreesField;

            private string latDirectionField;

            private string longDegreesField;

            private string longDirectionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string latDegrees
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
            public string longDegrees
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOriginAddressContacts
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOriginAddressContactsContact contactField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOriginAddressContactsContact Contact
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOriginAddressContactsContact
        {

            private object nameField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOriginAddressContactsContactContactMethods contactMethodsField;

            private string typeField;

            private string oidField;

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
            public MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOriginAddressContactsContactContactMethods ContactMethods
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
            public string oid
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOriginAddressContactsContactContactMethods
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOriginAddressContactsContactContactMethodsContactMethod contactMethodField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOriginAddressContactsContactContactMethodsContactMethod ContactMethod
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoOriginAddressContactsContactContactMethodsContactMethod
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestination
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestinationAddress addressField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestinationAddress Address
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestinationAddress
        {

            private object ownerField;

            private object customerAcctNumField;

            private object locationCodeField;

            private string nameField;

            private string addrLine1Field;

            private string addrLine2Field;

            private string cityField;

            private string stateProvinceField;

            private string postalCodeField;

            private string countryCodeField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestinationAddressGeoLoc geoLocField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestinationAddressContacts contactsField;

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
            public MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestinationAddressGeoLoc GeoLoc
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestinationAddressContacts Contacts
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestinationAddressGeoLoc
        {

            private string latDegreesField;

            private string latDirectionField;

            private string longDegreesField;

            private string longDirectionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string latDegrees
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
            public string longDegrees
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestinationAddressContacts
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestinationAddressContactsContact contactField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestinationAddressContactsContact Contact
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestinationAddressContactsContact
        {

            private object nameField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestinationAddressContactsContactContactMethods contactMethodsField;

            private string typeField;

            private string oidField;

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
            public MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestinationAddressContactsContactContactMethods ContactMethods
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
            public string oid
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestinationAddressContactsContactContactMethods
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestinationAddressContactsContactContactMethodsContactMethod contactMethodField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestinationAddressContactsContactContactMethodsContactMethod ContactMethod
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentTerminalInfoDestinationAddressContactsContactContactMethodsContactMethod
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentQuantities
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentQuantitiesQuantity quantityField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentQuantitiesQuantity Quantity
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentQuantitiesQuantity
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentWeight
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentDimension
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentDates
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentDatesDate[] pickupField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentDatesDate1[] dropField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Date", IsNullable = false)]
            public MercuryGateMasterBillOfLadingShipmentsShipmentDatesDate[] Pickup
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentDatesDate1[] Drop
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentDatesDate
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentDatesDate1
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheet
        {

            private decimal accessorialTotalField;

            private decimal subTotalField;

            private decimal totalField;

            private object contractIdField;

            private object contractNameField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrier carrierField;

            private object reasonCodeField;

            private object statusField;

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

            private MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCharge[] chargesField;

            private object commentsField;

            private string typeField;

            private string chargeModelField;

            private bool isSelectedField;

            private bool isAllocatedField;

            private string currencyCodeField;

            private string createDateField;

            private string updateDateField;

            private string internalIdField;

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
            public MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrier Carrier
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
            public object Status
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCharge[] Charges
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
            public string internalId
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrier
        {

            private string carrierIdField;

            private string carrierNameField;

            private string sCACField;

            private string modeField;

            private object serviceField;

            private decimal serviceDaysField;

            private decimal distanceField;

            private string idField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierInsurance[] insuranceTypesField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierAddress addressField;

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
            public MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierInsurance[] InsuranceTypes
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierAddress Address
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierInsurance
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierAddress
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

            private MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierAddressGeoLoc geoLocField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierAddressContacts contactsField;

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
            public MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierAddressGeoLoc GeoLoc
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierAddressContacts Contacts
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierAddressGeoLoc
        {

            private string latDegreesField;

            private string latDirectionField;

            private string longDegreesField;

            private string longDirectionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string latDegrees
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
            public string longDegrees
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierAddressContacts
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierAddressContactsContact contactField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierAddressContactsContact Contact
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierAddressContactsContact
        {

            private string nameField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierAddressContactsContactContactMethods contactMethodsField;

            private string typeField;

            private string oidField;

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
            public MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierAddressContactsContactContactMethods ContactMethods
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
            public string oid
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierAddressContactsContactContactMethods
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierAddressContactsContactContactMethodsContactMethod contactMethodField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierAddressContactsContactContactMethodsContactMethod ContactMethod
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCarrierAddressContactsContactContactMethodsContactMethod
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPriceSheetCharge
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentShipper
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentShipperAddress addressField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentShipperAddress Address
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentShipperAddress
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentShipperAddressAppointmentTime[] appointmentTimeField;

            private object locationCodeField;

            private string nameField;

            private string addrLine1Field;

            private object addrLine2Field;

            private string cityField;

            private string stateProvinceField;

            private string postalCodeField;

            private string countryCodeField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentShipperAddressGeoLoc geoLocField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentShipperAddressContacts contactsField;

            private object commentsField;

            private string typeField;

            private bool isResidentialField;

            private bool isPrimaryField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("AppointmentTime")]
            public MercuryGateMasterBillOfLadingShipmentsShipmentShipperAddressAppointmentTime[] AppointmentTime
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentShipperAddressGeoLoc GeoLoc
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentShipperAddressContacts Contacts
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentShipperAddressAppointmentTime
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentShipperAddressGeoLoc
        {

            private string latDegreesField;

            private string latDirectionField;

            private string longDegreesField;

            private string longDirectionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string latDegrees
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
            public string longDegrees
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentShipperAddressContacts
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentShipperAddressContactsContact contactField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentShipperAddressContactsContact Contact
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentShipperAddressContactsContact
        {

            private string nameField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentShipperAddressContactsContactContactMethod[] contactMethodsField;

            private string typeField;

            private string oidField;

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
            public MercuryGateMasterBillOfLadingShipmentsShipmentShipperAddressContactsContactContactMethod[] ContactMethods
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
            public string oid
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentShipperAddressContactsContactContactMethod
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentConsignee
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentConsigneeAddress addressField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentConsigneeAddress Address
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentConsigneeAddress
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentConsigneeAddressAppointmentTime[] appointmentTimeField;

            private object locationCodeField;

            private string nameField;

            private string addrLine1Field;

            private object addrLine2Field;

            private string cityField;

            private string stateProvinceField;

            private string postalCodeField;

            private string countryCodeField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentConsigneeAddressGeoLoc geoLocField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentConsigneeAddressContacts contactsField;

            private object commentsField;

            private string typeField;

            private bool isResidentialField;

            private bool isPrimaryField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("AppointmentTime")]
            public MercuryGateMasterBillOfLadingShipmentsShipmentConsigneeAddressAppointmentTime[] AppointmentTime
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentConsigneeAddressGeoLoc GeoLoc
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentConsigneeAddressContacts Contacts
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentConsigneeAddressAppointmentTime
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentConsigneeAddressGeoLoc
        {

            private string latDegreesField;

            private string latDirectionField;

            private string longDegreesField;

            private string longDirectionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string latDegrees
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
            public string longDegrees
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentConsigneeAddressContacts
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentConsigneeAddressContactsContact contactField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentConsigneeAddressContactsContact Contact
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentConsigneeAddressContactsContact
        {

            private string nameField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentConsigneeAddressContactsContactContactMethod[] contactMethodsField;

            private string typeField;

            private string oidField;

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
            public MercuryGateMasterBillOfLadingShipmentsShipmentConsigneeAddressContactsContactContactMethod[] ContactMethods
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
            public string oid
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentConsigneeAddressContactsContactContactMethod
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPackages
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackage packageField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackage Package
            {
                get
                {
                    return this.packageField;
                }
                set
                {
                    this.packageField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackage
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageDimension[] dimensionsField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageWeight[] weightsField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroups itemGroupsField;

            private string typeField;

            private string internalIdField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Dimension", IsNullable = false)]
            public MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageDimension[] Dimensions
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
            [System.Xml.Serialization.XmlArrayItemAttribute("Weight", IsNullable = false)]
            public MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageWeight[] Weights
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroups ItemGroups
            {
                get
                {
                    return this.itemGroupsField;
                }
                set
                {
                    this.itemGroupsField = value;
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
            public string internalId
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageDimension
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageWeight
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroups
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroup itemGroupField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroup ItemGroup
            {
                get
                {
                    return this.itemGroupField;
                }
                set
                {
                    this.itemGroupField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroup
        {

            private string descriptionField;

            private byte containmentIdField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupWeight[] weightsField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupQuantity[] quantitiesField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupDimension[] dimensionsField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupFreightClass freightClassField;

            private byte stackabilityField;

            private object trackingNumberField;

            private object deliveryStatusField;

            private object referenceNumbersField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItem lineItemField;

            private string internalIdField;

            private bool isShipUnitField;

            private bool isHandlingUnitField;

            private byte sequenceField;

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
            public byte ContainmentId
            {
                get
                {
                    return this.containmentIdField;
                }
                set
                {
                    this.containmentIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Weight", IsNullable = false)]
            public MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupWeight[] Weights
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
            [System.Xml.Serialization.XmlArrayItemAttribute("Quantity", IsNullable = false)]
            public MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupQuantity[] Quantities
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
            [System.Xml.Serialization.XmlArrayItemAttribute("Dimension", IsNullable = false)]
            public MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupDimension[] Dimensions
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupFreightClass FreightClass
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
            public byte Stackability
            {
                get
                {
                    return this.stackabilityField;
                }
                set
                {
                    this.stackabilityField = value;
                }
            }

            /// <remarks/>
            public object TrackingNumber
            {
                get
                {
                    return this.trackingNumberField;
                }
                set
                {
                    this.trackingNumberField = value;
                }
            }

            /// <remarks/>
            public object DeliveryStatus
            {
                get
                {
                    return this.deliveryStatusField;
                }
                set
                {
                    this.deliveryStatusField = value;
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItem LineItem
            {
                get
                {
                    return this.lineItemField;
                }
                set
                {
                    this.lineItemField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string internalId
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
            public bool isShipUnit
            {
                get
                {
                    return this.isShipUnitField;
                }
                set
                {
                    this.isShipUnitField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool isHandlingUnit
            {
                get
                {
                    return this.isHandlingUnitField;
                }
                set
                {
                    this.isHandlingUnitField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte sequence
            {
                get
                {
                    return this.sequenceField;
                }
                set
                {
                    this.sequenceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupWeight
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupQuantity
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupDimension
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupFreightClass
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItem
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemWeights weightsField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemQuantities quantitiesField;

            private string itemIdField;

            private string descriptionField;

            private decimal freightClassField;

            private object commodityField;

            private object nmfcCodeField;

            private object stccCodeField;

            private object customerPartNumField;

            private object manufacturerPartNumField;

            private object distributorPartNumField;

            private byte cubeField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemTemperatureRange temperatureRangeField;

            private bool hazardousMaterialField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemHazMatDetail hazMatDetailField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemDimension[] dimensionsField;

            private object harmonizedTariffCodeField;

            private object portOfLadingField;

            private object countryOfOriginField;

            private object countryOfManufactureField;

            private object customsValueField;

            private object customsValueCurrencyField;

            private object insuredValueField;

            private object insuredValueCurrencyField;

            private object aESExportCodeField;

            private object scheduleBNumberField;

            private object domesticField;

            private object eCCNField;

            private object originationCountryField;

            private object manufacturingCountryField;

            private object licenseNumberField;

            private object licenseTypeField;

            private object referenceNumbersField;

            private byte lineNumberField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemWeights Weights
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemQuantities Quantities
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
            public string ItemId
            {
                get
                {
                    return this.itemIdField;
                }
                set
                {
                    this.itemIdField = value;
                }
            }

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
            public object Commodity
            {
                get
                {
                    return this.commodityField;
                }
                set
                {
                    this.commodityField = value;
                }
            }

            /// <remarks/>
            public object NmfcCode
            {
                get
                {
                    return this.nmfcCodeField;
                }
                set
                {
                    this.nmfcCodeField = value;
                }
            }

            /// <remarks/>
            public object StccCode
            {
                get
                {
                    return this.stccCodeField;
                }
                set
                {
                    this.stccCodeField = value;
                }
            }

            /// <remarks/>
            public object CustomerPartNum
            {
                get
                {
                    return this.customerPartNumField;
                }
                set
                {
                    this.customerPartNumField = value;
                }
            }

            /// <remarks/>
            public object ManufacturerPartNum
            {
                get
                {
                    return this.manufacturerPartNumField;
                }
                set
                {
                    this.manufacturerPartNumField = value;
                }
            }

            /// <remarks/>
            public object DistributorPartNum
            {
                get
                {
                    return this.distributorPartNumField;
                }
                set
                {
                    this.distributorPartNumField = value;
                }
            }

            /// <remarks/>
            public byte Cube
            {
                get
                {
                    return this.cubeField;
                }
                set
                {
                    this.cubeField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemTemperatureRange TemperatureRange
            {
                get
                {
                    return this.temperatureRangeField;
                }
                set
                {
                    this.temperatureRangeField = value;
                }
            }

            /// <remarks/>
            public bool HazardousMaterial
            {
                get
                {
                    return this.hazardousMaterialField;
                }
                set
                {
                    this.hazardousMaterialField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemHazMatDetail HazMatDetail
            {
                get
                {
                    return this.hazMatDetailField;
                }
                set
                {
                    this.hazMatDetailField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Dimension", IsNullable = false)]
            public MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemDimension[] Dimensions
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
            public object HarmonizedTariffCode
            {
                get
                {
                    return this.harmonizedTariffCodeField;
                }
                set
                {
                    this.harmonizedTariffCodeField = value;
                }
            }

            /// <remarks/>
            public object PortOfLading
            {
                get
                {
                    return this.portOfLadingField;
                }
                set
                {
                    this.portOfLadingField = value;
                }
            }

            /// <remarks/>
            public object CountryOfOrigin
            {
                get
                {
                    return this.countryOfOriginField;
                }
                set
                {
                    this.countryOfOriginField = value;
                }
            }

            /// <remarks/>
            public object CountryOfManufacture
            {
                get
                {
                    return this.countryOfManufactureField;
                }
                set
                {
                    this.countryOfManufactureField = value;
                }
            }

            /// <remarks/>
            public object CustomsValue
            {
                get
                {
                    return this.customsValueField;
                }
                set
                {
                    this.customsValueField = value;
                }
            }

            /// <remarks/>
            public object CustomsValueCurrency
            {
                get
                {
                    return this.customsValueCurrencyField;
                }
                set
                {
                    this.customsValueCurrencyField = value;
                }
            }

            /// <remarks/>
            public object InsuredValue
            {
                get
                {
                    return this.insuredValueField;
                }
                set
                {
                    this.insuredValueField = value;
                }
            }

            /// <remarks/>
            public object InsuredValueCurrency
            {
                get
                {
                    return this.insuredValueCurrencyField;
                }
                set
                {
                    this.insuredValueCurrencyField = value;
                }
            }

            /// <remarks/>
            public object AESExportCode
            {
                get
                {
                    return this.aESExportCodeField;
                }
                set
                {
                    this.aESExportCodeField = value;
                }
            }

            /// <remarks/>
            public object ScheduleBNumber
            {
                get
                {
                    return this.scheduleBNumberField;
                }
                set
                {
                    this.scheduleBNumberField = value;
                }
            }

            /// <remarks/>
            public object Domestic
            {
                get
                {
                    return this.domesticField;
                }
                set
                {
                    this.domesticField = value;
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
            public object OriginationCountry
            {
                get
                {
                    return this.originationCountryField;
                }
                set
                {
                    this.originationCountryField = value;
                }
            }

            /// <remarks/>
            public object ManufacturingCountry
            {
                get
                {
                    return this.manufacturingCountryField;
                }
                set
                {
                    this.manufacturingCountryField = value;
                }
            }

            /// <remarks/>
            public object LicenseNumber
            {
                get
                {
                    return this.licenseNumberField;
                }
                set
                {
                    this.licenseNumberField = value;
                }
            }

            /// <remarks/>
            public object LicenseType
            {
                get
                {
                    return this.licenseTypeField;
                }
                set
                {
                    this.licenseTypeField = value;
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
            public byte lineNumber
            {
                get
                {
                    return this.lineNumberField;
                }
                set
                {
                    this.lineNumberField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemWeights
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemWeightsWeight weightField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemWeightsWeight Weight
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemWeightsWeight
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemQuantities
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemQuantitiesQuantity quantityField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemQuantitiesQuantity Quantity
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemQuantitiesQuantity
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemTemperatureRange
        {

            private byte minField;

            private byte maxField;

            private string uomField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte min
            {
                get
                {
                    return this.minField;
                }
                set
                {
                    this.minField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte max
            {
                get
                {
                    return this.maxField;
                }
                set
                {
                    this.maxField = value;
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemHazMatDetail
        {

            private string properShippingNameField;

            private object hazMatIDField;

            private object packageGroupField;

            private decimal hazMatClassField;

            private string contactNameField;

            private object contactPhoneField;

            private bool hazMatPlacardsField;

            private object hazMatPlacardsDetailsField;

            private byte hazMatEMSNumberField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemHazMatDetailHazMatFlashPointTemp hazMatFlashPointTempField;

            private object commentsField;

            /// <remarks/>
            public string ProperShippingName
            {
                get
                {
                    return this.properShippingNameField;
                }
                set
                {
                    this.properShippingNameField = value;
                }
            }

            /// <remarks/>
            public object HazMatID
            {
                get
                {
                    return this.hazMatIDField;
                }
                set
                {
                    this.hazMatIDField = value;
                }
            }

            /// <remarks/>
            public object PackageGroup
            {
                get
                {
                    return this.packageGroupField;
                }
                set
                {
                    this.packageGroupField = value;
                }
            }

            /// <remarks/>
            public decimal HazMatClass
            {
                get
                {
                    return this.hazMatClassField;
                }
                set
                {
                    this.hazMatClassField = value;
                }
            }

            /// <remarks/>
            public string ContactName
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
            public object ContactPhone
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

            /// <remarks/>
            public bool HazMatPlacards
            {
                get
                {
                    return this.hazMatPlacardsField;
                }
                set
                {
                    this.hazMatPlacardsField = value;
                }
            }

            /// <remarks/>
            public object HazMatPlacardsDetails
            {
                get
                {
                    return this.hazMatPlacardsDetailsField;
                }
                set
                {
                    this.hazMatPlacardsDetailsField = value;
                }
            }

            /// <remarks/>
            public byte HazMatEMSNumber
            {
                get
                {
                    return this.hazMatEMSNumberField;
                }
                set
                {
                    this.hazMatEMSNumberField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemHazMatDetailHazMatFlashPointTemp HazMatFlashPointTemp
            {
                get
                {
                    return this.hazMatFlashPointTempField;
                }
                set
                {
                    this.hazMatFlashPointTempField = value;
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemHazMatDetailHazMatFlashPointTemp
        {

            private string uomField;

            private decimal valueField;

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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPackagesPackageItemGroupsItemGroupLineItemDimension
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPayment
        {

            private string methodField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillTo billToField;

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
            public MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillTo BillTo
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillTo
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillToAddress addressField;

            private bool thirdPartyField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillToAddress Address
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
            public bool thirdParty
            {
                get
                {
                    return this.thirdPartyField;
                }
                set
                {
                    this.thirdPartyField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillToAddress
        {

            private string ownerField;

            private string customerAcctNumField;

            private object locationCodeField;

            private string nameField;

            private string addrLine1Field;

            private string addrLine2Field;

            private string cityField;

            private string stateProvinceField;

            private string postalCodeField;

            private string countryCodeField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillToAddressGeoLoc geoLocField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillToAddressContacts contactsField;

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
            public MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillToAddressGeoLoc GeoLoc
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
            public MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillToAddressContacts Contacts
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillToAddressGeoLoc
        {

            private string latDegreesField;

            private string latDirectionField;

            private string longDegreesField;

            private string longDirectionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string latDegrees
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
            public string longDegrees
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillToAddressContacts
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillToAddressContactsContact contactField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillToAddressContactsContact Contact
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillToAddressContactsContact
        {

            private object nameField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillToAddressContactsContactContactMethods contactMethodsField;

            private string typeField;

            private string oidField;

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
            public MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillToAddressContactsContactContactMethods ContactMethods
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
            public string oid
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillToAddressContactsContactContactMethods
        {

            private MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillToAddressContactsContactContactMethodsContactMethod contactMethodField;

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillToAddressContactsContactContactMethodsContactMethod ContactMethod
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentPaymentBillToAddressContactsContactContactMethodsContactMethod
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
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentLateReason
        {

            private string codeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string code
            {
                get
                {
                    return this.codeField;
                }
                set
                {
                    this.codeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentEnterprise
        {

            private bool multiNationalField;

            private string typeField;

            private string descriptionField;

            private string customerAcctNumField;

            private object federalEINField;

            private object dUNSField;

            private byte primarySICField;

            private byte rankingField;

            private bool carrierInvoicePODRequiredField;

            private bool customerInvoicePODRequiredField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentEnterpriseCredit creditField;

            private MercuryGateMasterBillOfLadingShipmentsShipmentEnterpriseVisibility visibilityField;

            private object displayNotesField;

            private object locationsField;

            private string nameField;

            private string parentNameField;

            private string internalIdField;

            private bool activeField;

            /// <remarks/>
            public bool MultiNational
            {
                get
                {
                    return this.multiNationalField;
                }
                set
                {
                    this.multiNationalField = value;
                }
            }

            /// <remarks/>
            public string Type
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
            public object FederalEIN
            {
                get
                {
                    return this.federalEINField;
                }
                set
                {
                    this.federalEINField = value;
                }
            }

            /// <remarks/>
            public object DUNS
            {
                get
                {
                    return this.dUNSField;
                }
                set
                {
                    this.dUNSField = value;
                }
            }

            /// <remarks/>
            public byte PrimarySIC
            {
                get
                {
                    return this.primarySICField;
                }
                set
                {
                    this.primarySICField = value;
                }
            }

            /// <remarks/>
            public byte Ranking
            {
                get
                {
                    return this.rankingField;
                }
                set
                {
                    this.rankingField = value;
                }
            }

            /// <remarks/>
            public bool CarrierInvoicePODRequired
            {
                get
                {
                    return this.carrierInvoicePODRequiredField;
                }
                set
                {
                    this.carrierInvoicePODRequiredField = value;
                }
            }

            /// <remarks/>
            public bool CustomerInvoicePODRequired
            {
                get
                {
                    return this.customerInvoicePODRequiredField;
                }
                set
                {
                    this.customerInvoicePODRequiredField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentEnterpriseCredit Credit
            {
                get
                {
                    return this.creditField;
                }
                set
                {
                    this.creditField = value;
                }
            }

            /// <remarks/>
            public MercuryGateMasterBillOfLadingShipmentsShipmentEnterpriseVisibility Visibility
            {
                get
                {
                    return this.visibilityField;
                }
                set
                {
                    this.visibilityField = value;
                }
            }

            /// <remarks/>
            public object DisplayNotes
            {
                get
                {
                    return this.displayNotesField;
                }
                set
                {
                    this.displayNotesField = value;
                }
            }

            /// <remarks/>
            public object Locations
            {
                get
                {
                    return this.locationsField;
                }
                set
                {
                    this.locationsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
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
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string parentName
            {
                get
                {
                    return this.parentNameField;
                }
                set
                {
                    this.parentNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string internalId
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
            public bool active
            {
                get
                {
                    return this.activeField;
                }
                set
                {
                    this.activeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentEnterpriseCredit
        {

            private bool cashOnlyField;

            private decimal limitField;

            private string checkOnShipmentDuplicateField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool cashOnly
            {
                get
                {
                    return this.cashOnlyField;
                }
                set
                {
                    this.cashOnlyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal limit
            {
                get
                {
                    return this.limitField;
                }
                set
                {
                    this.limitField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string checkOnShipmentDuplicate
            {
                get
                {
                    return this.checkOnShipmentDuplicateField;
                }
                set
                {
                    this.checkOnShipmentDuplicateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingShipmentsShipmentEnterpriseVisibility
        {

            private bool loginField;

            private bool quoteField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool login
            {
                get
                {
                    return this.loginField;
                }
                set
                {
                    this.loginField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool quote
            {
                get
                {
                    return this.quoteField;
                }
                set
                {
                    this.quoteField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MercuryGateMasterBillOfLadingWeight
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

            private string internalIdField;

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
            public string internalId
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

            private string latDegreesField;

            private string latDirectionField;

            private string longDegreesField;

            private string longDirectionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string latDegrees
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
            public string longDegrees
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

            private string oidField;

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
            public string oid
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

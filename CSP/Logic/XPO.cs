using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.TeknowlogiAPIs
{
    public class XPO
    {
        public enum XPOStatusCode
        {
            All_Short = 15,
            Appointment_Required_at_Destination = 13,
            Arrived_at_Destination = 6,
            Arrived_at_Interim = 3,
            At_Destination = 44,
            At_Interim = 43,
            At_Origin = 25,
            Attempted_Delivery = 19,
            Awaiting_Unloading_at_Consignee = 18,
            BOL_Image_Available = 31,
            Consolidating_Shipments_Per_Consignee = 10,
            Delayed_en_Route_to_Destination= 7,
            Delayed_en_Route_to_Interim = 4,
            Delivered_by = 23,
            Delivered_Past_Short = 20,
            Delivery_Receipt_Image_Available = 30,
            En_Route_to_Destination = 5,
            En_Route_to_Interim = 2,
            En_Route_to_Alaska = 38,
            En_Route_Hawaii = 39,
            En_Route_to_Puerto_Rico = 40,
            Final_Delivery_Pending_Review = 28,
            Followed_up_Delayed = 35,
            Followed_up_on_Time = 34,
            Holding_on_Dock_for_Cartage_Carrier_at_Destination = 14,
            Holding_on_Dock_for_Customs_Clearance_at_Destination = 11,
            Internation_Shipment_From_Mexico_Has_Been_Tendered_to_the_Broker = 42,
            International_Shipment_to_Mexico_Has_Been_Tendered_to_the_Broker = 41,
            Late = 37,
            Late_But_No_Possible_Delay_Notification_Sent = 36,
            Non_Movement_PRO = 24,
            Out_For_Delivery = 8,
            Overage = 27,
            Picked_up = 1,
            Possible_Delay_Notification = 33,
            Recorded_in_System = 32,
            Refused_Delivery = 21,
            Refused_for_Damage = 22,
            Returned_to_Dock_No_Attempt_to_Delivery = 17,
            Shipment_Has_Been_Canceled = 26,
            Transfer = 29,
            Undeliverable = 12
        }
    }
}

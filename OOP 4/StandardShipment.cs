using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4
{
    public class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5m);
            }
        }
        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            Console.WriteLine($"Tracking Code  : {TrackingCode}");
            Console.WriteLine($"Description    : {Description}");
            Console.WriteLine($"Weight         : {Weight} KG");
            Console.WriteLine($"Delivery Fee   : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
        }

    }
}

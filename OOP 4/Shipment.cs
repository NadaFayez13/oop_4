using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4
{
    public class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;

        public string TrackingCode
        {
            get { return trackingCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }
            }
        }
        public Shipment(string trackingCode)
    : this(trackingCode, "Unknown", 1, 50, new DeliveryAddress("alex", "default Street", 1))
        {
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.trackingCode = "UNKNOWN";
            this.description = "Unknown";
            this.weight = 1;
            this.deliveryFee = 50;
            this.Destination = destination;

            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }

        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }

        public void UpdateWeight(decimal newWeight)
        {
            Weight = newWeight;
        }

        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            if (newWeight > 0 && extraPackingWeight >= 0)
            {
                Weight = newWeight + extraPackingWeight;
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }

        public DeliveryAddress Destination { get; set; }
        public virtual decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + ((decimal)Weight * 5m);
            }
        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }

        public virtual void PrintShipment()
        {
            Console.WriteLine($"tracking code:  {TrackingCode}");
            Console.WriteLine($"description:  {Description}");
            Console.WriteLine($"weight:  {Weight} kg");
            Console.WriteLine($"delivery fee:  {DeliveryFee:C}");
            Console.WriteLine($"destination:  {Destination.GetFullAddress()}");
            Console.WriteLine($"estimated cost:  {EstimatedCost:C}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace A_OOP02
{
     public class Shipment
     {
        private string _trackingCode;
        private string _description;
        private double _weight;
        private decimal _deliveryFee;

        public string TrackingCode
        {
            get => _trackingCode;

            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _trackingCode = value;
            }
        }

        public string Description
        {
            get => _description;

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _description = value;

            }
        }
        public double Weight
        {
            get => _weight;
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }


        }
        public decimal DeliveryFee
        {
            get => _deliveryFee;
            private set
            {
                if (value > 0)
                {
                    _deliveryFee = value;


                }

            }

        }

        public DeliveryAddress Destination { get; set; }

        public virtual decimal EstimatedCost
        {
            get => DeliveryFee + (decimal)(Weight * 5);
        }
        // first constructor
        public Shipment(string trackingCode)
        {
            _trackingCode = trackingCode;
            _description = "Unknown";
            _weight = 1;
            _deliveryFee = 50;
            Destination = default;

        }
        // second constructor
        public Shipment (string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            _trackingCode = trackingCode;
            _description = description;
            _weight = weight > 0 ? weight : 1;
            _deliveryFee = deliveryFee > 0 ? deliveryFee : 50;
            Destination = destination;
        }
        // first method
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                _deliveryFee = newFee;
            }
        }
        // second method
        public virtual void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        }



     }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace A_OOP02
{
     public class ExpressShipment : Shipment
    {

        private decimal _extraFee;

        public decimal ExtraFee 
        {
            get => _extraFee;
            set
            {
                if (value > 0)
                {
                    _extraFee = value;
                }
            }
        }

        public ExpressShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public override decimal EstimatedCost { get => base.EstimatedCost + ExtraFee; }

        public override void PrintShipment()
        {
                base.PrintShipment();
            Console.WriteLine($"Extra Fee: {ExtraFee}");
        }
        
    }

    
}

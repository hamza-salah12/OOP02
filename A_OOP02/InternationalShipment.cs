using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace A_OOP02
{
   
    public class InternationalShipment : Shipment
    {
        private string _destinationCountry;
        private decimal _customsFee;

        public string DestinationCountry 
        {
            get => _destinationCountry;

            set 
            {
                if(!string.IsNullOrEmpty(value))
                {
                    _destinationCountry = value;
                }
            }
         
        }

        public decimal CustomsFee {
        
        get => _customsFee;
            set {
            
                if (value > 0)
                {
                    _customsFee = value;
                }

            }
        }

        public InternationalShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        { 
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public override decimal EstimatedCost {
        
        get => base.EstimatedCost + CustomsFee;

        }

        public override void PrintShipment()
        {
            base.PrintShipment();
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee}");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace A_OOP02
{
    public class DeliveryCenter
    {
       
            public string CenterName { get; set; }
            private Shipment[] _shipments;
            private int _count;


            // Constructor DeliveryCenter
            public DeliveryCenter()
            {
                _shipments = new Shipment[20];
                _count = 0;
            }

            public Shipment this[int index]
            {
                get
                {
                    if (_shipments != null && index >= 0 && index < _shipments.Length)
                    {
                        return _shipments[index];
                    }
                    return default;
                }
                set
                {
                    if (_shipments != null && index >= 0 && index < _shipments.Length)
                    {
                        _shipments[index] = value;
                    }
                }
            }

            public Shipment this[string trackingCode]
            {
                get
                {
                    if (_shipments != null && !string.IsNullOrWhiteSpace(trackingCode))
                    {
                        for (int i = 0; i < _count; i++)
                        {
                            if (_shipments[i].TrackingCode == trackingCode)
                            {
                                return _shipments[i];
                            }
                        }
                    }
                    return default;
                }
            }
            public bool AddShipment(Shipment shipment)
            {
                if (_shipments == null)
                {
                    _shipments = new Shipment[10];
                }
                if (_count < _shipments.Length)
                {
                    _shipments[_count] = shipment;
                    _count++;
                    return true;
                }
                return false;
            }



        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_shipments[i].TrackingCode.Equals(trackingCode, StringComparison.OrdinalIgnoreCase))
                {
                    
                    for (int j = i; j < _count - 1; j++)
                    {
                        _shipments[j] = _shipments[j + 1];
                    }
                    _shipments[--_count] = null; 
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            Console.WriteLine($"\n================ Delivery Center: {CenterName} ================");
            if (_count == 0)
            {
                Console.WriteLine("No shipments in the center.");
                return;
            }

            for (int i = 0; i < _count; i++)
            {
                _shipments[i].PrintShipment();
                Console.WriteLine("------------------------------------------------");
            }
        }
    }




    
}

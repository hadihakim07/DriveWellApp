using System;
using System.Collections.Generic;
using System.Text;

namespace DriveWellApp.BusinessLogic
{
    internal class Car
    {

        string _vinNumber;
        string _carMake;
        CarType _carType;
        float _price;
        int _modelYear;



        public Car(string vinNumber, string carMake, CarType carType, float price, int modelYear)
        {
            _vinNumber = vinNumber;
            _carMake = carMake;
            _carType = carType;
            _price = price;
            _modelYear = modelYear;
        }

        public string VinNumber
        {
            get { return _vinNumber; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("The vehicle must have a Vin Number");
                _vinNumber = value;
            }
        }

        public string CarMake => _carMake;

        public CarType CarType => _carType;

        public float Price
        {
         
                get { return _price; }
                set
                {
                    if (value <= 0)
                        throw new Exception("The price must be greater than 0");
                    _price = value;
                }
        }

        public int ModelYear => _modelYear;


        public override string ToString()
        {
            return $"{VinNumber},{CarMake},{CarType},{Price},{ModelYear}";
        }

    }
}

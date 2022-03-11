using System;
using System.Collections.Generic;
using System.Text;

namespace DriveWellApp.BusinessLogic
{
    internal class UsedCar : Car
    {
        int _mileage;

        public UsedCar
            (string vinNumber, string carMake, CarType carType, float price, int modelYear, int mileage)
            :base(vinNumber, carMake, carType, price, modelYear)
        {
            _mileage = mileage;
        }


        public int Mileage
        {

            get { return _mileage; }
            set
            {
                if (value <= 0)
                    throw new Exception("The mileage must be greater than 0");
                _mileage = value;
            }
        }

        public double TotalDepreciation => Price - ((Mileage / 10000) * 0.9 + (Price / (0.10 * ModelYear)) );

        public override string ToString()
        {
            return $"{VinNumber},{CarMake},{CarType},{Price},{ModelYear},{Mileage},{TotalDepreciation}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DriveWellApp.BusinessLogic
{
    internal class CarRepository
    {

        ObservableCollection<Car> _car = new ObservableCollection<Car>();

        public ObservableCollection<Car> Car => _car;


        public CarRepository(string vinNumber, string carMake, CarType carType)
        {
               
        }

        public void Add(Car newCar)
        {

            foreach (Car car in _car) 
                if (newCar.VinNumber == car.VinNumber)
                    throw new Exception("The Vehicle being added already exists");

            _car.Add(newCar);
        }

        public string GetByVin(Car newCar)
        {
            foreach (Car car in _car)
                if (newCar.VinNumber == car.VinNumber)
                    return newCar.VinNumber;

                else
                    throw new Exception("The Vehicle being searched does not exist in the records");
                    return null;
        }

        public Car Cars(Car newCar)
        {
            return newCar;
        }
    }
}

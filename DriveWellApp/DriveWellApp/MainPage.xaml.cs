using DriveWellApp.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace DriveWellApp
{
    public partial class MainPage : ContentPage
    {

        CarRepository _carRepository = new CarRepository();

        public MainPage()
        {
            InitializeComponent();

            CarTypes.ItemsSource = Enum.GetValues(typeof(CarType));
        }

        private void Add_Btn_Clicked(object sender, EventArgs e)
        {
            Car car = CaptureCarInfo();
        }



        private Car CaptureCarInfo()
        {
            Car car = null;

            //reading all user input from the UI controls Type cast it to appropriate data type
            string vinNumber = VinLabel.Text;
            string carMake = CarMakes.Text;
            CarType carType = (CarType)CarTypes.SelectedItem;
            float price = float.Parse(PurchasePrice.Text);
            int modelYear = (int)ModelYear.SelectedItem;
            

            if (IsUsed.IsChecked)
            //create an instance of product using the data above
            {
                int mileage = int.Parse(Mileage.Text);
                //base class reference can point to instances of derived class. Implicit type-cast
                car = new UsedCar(vinNumber, carMake, carType, price, modelYear, mileage);
            }
            else
                car = new Car(vinNumber, carMake, carType, price, modelYear);

            //return the instnace to the caller
            return car;
        }

        private void Clear_Btn_Clicked(object sender, EventArgs e)
        {
            VinLabel.Text = "";
            CarMakes.Text = "";
            CarTypes.SelectedItem = null;
            PurchasePrice.Text = "";
            IsUsed.IsChecked = false;
            ModelYear.SelectedItem = null;
            Mileage.Text = "";
        }

        private void Update_Btn_Clicked(object sender, EventArgs e)
        {

        }
    }
}

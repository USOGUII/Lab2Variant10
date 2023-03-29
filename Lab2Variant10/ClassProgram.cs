using System;
using System.Collections.Generic;

namespace Automobile
{
    abstract class Transport {
        protected string Name;
        protected double Powerful;
        protected int MaxSpeed;
        protected DateTime RegistrationDate;
        protected double HorsePower;
        protected int TimeSpanDuration;//Ввести в консоль
        protected double Nalog;//Ввести в консоль
        protected int Month;
        protected void MonthCount(DateTime RegistrationDate) { var months = ((DateTime.Now.Year - RegistrationDate.Year) * 12) + DateTime.Now.Month - RegistrationDate.Month; Month = months; }
        protected void HorsePowerCount(double Powerful) { HorsePower = Powerful / 735.499;}
        protected abstract double Way();

        protected double NalogCount() {
            return Nalog * HorsePower * Month;
        }
    }
    class AvtoMoblie: Transport {
        private double FuelVolume = 60;
        private double FuelConsumption = 0.08;
        protected new string Name = "Renault Fluence";
        protected new double Powerful = 78000;
        protected new int MaxSpeed = 180;
        protected new DateTime RegistrationDate = new DateTime(2016, 1, 23);
        private double Reffil;
        protected override double Way()
        {
            return (MaxSpeed / 2) * TimeSpanDuration;
        }

        /*
         protected abstract newFunction();*/
        public void RefillCount()
        {
            Reffil = Way() / (FuelVolume / FuelConsumption);
            var Reffil1 = Math.Round(Reffil);
            Reffil = Reffil1;
        }
        public void Print()
        {
            Console.WriteLine($"Count of reffils - {Reffil}, Tax - {Nalog} rubles");
        }
        public AvtoMoblie()
        {
            Console.WriteLine("Enter the TimeSpan Duration:");
            string TimeSpanDuration1, Nalog1 ;
            TimeSpanDuration1 = Console.ReadLine();
            TimeSpanDuration = int.Parse(TimeSpanDuration1);
            Console.WriteLine("Enter the Tax:");
            Nalog1 = Console.ReadLine();
            Nalog = double.Parse(Nalog1);
            MonthCount(RegistrationDate);
            HorsePowerCount(Powerful);
            Nalog = NalogCount();
        }
    }
}

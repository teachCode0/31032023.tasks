using System;
using System.Collections.Generic;
using System.Text;

namespace _31032023.tasks
{
    internal class Car
    {
        private string _brand;
        private string _model;
        private int _fuelCapasity;
        private int _nowCapasity;

        public string Brand
        {
            get=> this._brand;
            set
            {
                if(!string.IsNullOrEmpty(value) && value.Length<=20 && value.Length>2)
                    this._brand = value;
            }
        }

        public string Model
        {
            get => this._model;
            set
            {
                if(!string.IsNullOrEmpty(value) && value.Length <= 10 && value.Length > 1)
                    this._model = value;    
            }
        }
        public int FuelCapasity
        {
            get => this._fuelCapasity;
            set
            {
                if(value<=200 && value>30)
                    this._fuelCapasity = value;
            }
        }
        public int NowCapasity
        {
            get => this._nowCapasity;
            set
            {
                if (value <= 200 && value > 0)
                    this._nowCapasity = value;
            }
        }

        public int FuelFor1Km { get; set; }

        public void Drive(int km)
        {
            //int fuel = FuelFor1Km * km;
            NowCapasity = NowCapasity - FuelFor1Km * km;
        }

        public string GetInfo()
        {
            return $"Brand : {Brand} - Model : {Model} - FuelCapasity : {FuelCapasity} - NowCapasity : {NowCapasity} - FuelFor1Km : {FuelFor1Km}";
        }


    }
}

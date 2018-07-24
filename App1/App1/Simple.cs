using System;
using System.ComponentModel;

namespace App1
{
    class Simple : INotifyPropertyChanged
    {
        double multiplicand, multiplier, product;
        public event PropertyChangedEventHandler PropertyChanged;
        //被乘數
        public double Multiplicand
        {
            set
            {
                if (multiplicand != value)
                {
                    multiplicand = value;
                    OnPropertyChanged("Multiplicand");
                    UpdateProduct();
                }
            }
            get
            {
                return multiplicand;
            }
        }

        //乘數
        public double Multiplier
        {
            set
            {
                if (multiplier != value)
                {
                    multiplier = value;
                    OnPropertyChanged("Multiplier");
                    UpdateProduct();
                }
            }
            get
            {
                return multiplier;
            }
        }

        public double Product
        {
            protected set
            {
                if (product != value)
                {
                    product = value;
                    OnPropertyChanged("Product");
                }
            }
            get
            {
                return product;
            }
        }

        void UpdateProduct()
        {
            Product = Multiplicand * Multiplier;
        }

        //OnPropertyChanged 寫成共用副程式
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

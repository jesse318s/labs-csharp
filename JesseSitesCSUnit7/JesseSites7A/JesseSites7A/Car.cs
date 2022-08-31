using System;
using System.Collections.Generic;
using System.Text;

namespace JesseSites7A
{
    class Car
    {
            private int _year;
            private string _make;
            private int _speed;

            public int Year
            {
                get
                {
                    return _year;
                }
                set
                {
                    _year = value;
                }
            }

            public string Make
            {
                get
                {
                    return _make;
                }
                set
                {
                    _make = value;
                }
            }

            public int Speed
            {
                get
                {
                    return _speed;
                }
                set
                {
                    _speed = value;
                }
            }

            public Car(int year, string make)
            {
                _speed = 0;
                _year = year;
                _make = make;
            }

            public void Accelerate()
            {
                Speed = Speed + 5;
            }

            public void Brake()
            {
                Speed = Speed - 5;
            }
    }
}

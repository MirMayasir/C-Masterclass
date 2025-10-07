using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{ 
    internal class Car
    {
        private string _model = "";
        public string Model { get => _model;
            set { if(String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered nothing");
                    _model = "Default Value";
                }
                else
                {
                    _model = value;
                }
                }
                } 
        public Car(string model) {
            Model = model;
            Console.WriteLine("I have a " + Model + "  car");
        }
    }
}

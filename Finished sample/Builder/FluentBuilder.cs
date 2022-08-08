using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    public class Bus 
    {
        private string? _model;
        private string? _color;
        private int? _manufactureYear;
        public Bus()
        {
            _model = "Default model";
            _color = "Default color";
            _manufactureYear = int.MaxValue;
        }
        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine($"{_model}, {_color}, {_manufactureYear}");
        }
       
        public class BusBuilder
        {
            private Bus _bus;
            public BusBuilder()
            { 
              _bus = new Bus();
            }
            public BusBuilder WithModel(string model)
            {
                _bus._model = model;
                return this;
            }
            public BusBuilder WithColor(string color)
            {
                _bus._color = color;
                return this;
            }
            public BusBuilder WithManufactureYear(int year)
            {
                _bus._manufactureYear = year;
                return this;
            }
            public Bus Build()
            {
                return _bus;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Building
    {
        public string name;
        public float height;
        public float area;
        public string address;

        public Building(string name, float height, float area, string address)
        {
            this.name = name;
            this.height = height;
            this.area = area;
            this.address = address;
        }

        public string GetDetails()
        {
            return $"{name} {height} {area} {address}";
        }

        public float GetVolume()
        {
            return (area * height);
        }

    }
}

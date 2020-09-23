using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    abstract class Weapon : IShootable
    {
        private string _brand;

        public Weapon(string brand)
        {
            _brand = brand;
        }

        public virtual string Shoot()
        {
            return $"{ToString()} - {_brand}";
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }

    }
}

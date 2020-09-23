using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Hunter : Person, IShootable
    {
        public IShootable Shooter { get; set; }

        public Hunter() { }
        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
        {
            Shooter = shooter;
        }

        public string Shoot()
        {
            var name = GetFullName();
            if (Shooter == null)
            {
                return name += "has no weapon to shoot";
            }
            else
            {
                return name += $" { Shooter.Shoot()}";
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}

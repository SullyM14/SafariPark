using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Airplane : Vehicle
    {
        private string _airline;
        private int _altitude;

        public Airplane(int capacity) : base(capacity)
        {
        }

        public Airplane(int capacity, int speed, string name) : base(capacity, speed)
        {
            _airline = name;
        }

        public void Ascend(int distance)
        {
            _altitude += distance;
        }

        public void Descend(int distance)
        {
            _altitude -= distance;
        }

        public override string Move()
        {
            var move = base.Move();
            return $"{move} at an altitude of {_altitude} metres.";
        }

        public override string Move(int times)
        { 
            var move = base.Move();
            return $"{move} at an altitude of {_altitude} metres.";
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} altitude {_altitude}";
        }

    }
}
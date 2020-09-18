using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;
        private int _speed; 

        public Vehicle()
        {
            _speed = 10;
        }

        public Vehicle(int capacity,int speed = 10)
        {
            _capacity = capacity;
            _speed = speed;
        }

        public int NumPassengers {
            get { return _numPassengers; }
            set {
                if (value > 0 && _numPassengers < _capacity)
                {
                    var remaining = _capacity - _numPassengers;
                    if (value <= remaining)
                    {
                        _numPassengers += value;
                    }
                    else if (value > remaining) 
                    {
                        var allowed = value - (value - remaining);
                        _numPassengers += allowed;
                    }
                //Capacity - _NumPassengers = remianing spaces
                //The Number trying to be assigned if meeting the other conditions is checked to see if it is less than or equal to the remaing spaces
                //If less than the remaining spaces then add them
                //If more than the remainning spaces then the value - (value-remaining) spaces is added
            }
            } 
        }

        public int Position { get; private set; }

        public virtual string Move()
        {
            Position += _speed ;
            return "Moving along";
        }

        public virtual string Move(int times)
        {
            Position += _speed * times;
            return ($"Moving along {times} times");
        }

        public override string ToString()
        {
            return $"{base.ToString()} capacity: {_capacity} passengers: {_numPassengers} speed: {_speed} position: {Position}";
        }
    }
}

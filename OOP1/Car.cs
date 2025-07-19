using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Car
    {
        // Id
        #region Attributes
        private double id;
        private int speed;
        private string model;
        #endregion

        #region Properties
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public double Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        // CLR : Will Generate Parameterless Constructor
        // This Constructor Do Nothing

        // CTOR

        //public Car()
        //{

        //} //  Do Nothing

        //public Car()
        //{
        //	Id = default;
        //	Model = default;
        //	Speed = default;
        //}

        public Car(int id, int speed, string model) : this(id, speed)
        {
            //Id = id;
            //Speed = speed;
            Model = model;
        }

        public Car(int id, int speed) : this(id)
        {
            //Id = id;
            Speed = speed;
        }

        public Car(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return $"Id : {Id} :: Speed : {Speed} :: Model: {Model}";

        
        }

        }
    }

using System;

namespace Interfaces
{

    class Cyborg : ICar, IPrerson
    {
        private int speed;
        public int Speed { get => speed; set => speed = value; }

        public void Create()
        {
            throw new NotImplementedException();
        }

        int ICar.Move(int distance)
        {
            return distance / 100;
        }

        int IPrerson.Move(int distance)
        {
            return distance / 15;
        }
    }
}

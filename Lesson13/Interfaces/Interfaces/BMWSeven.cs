using System;

namespace Interfaces
{
    class BMWSeven : ICar
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public int Move(int distance)
        {
            return distance / 100;
        }
    }
}

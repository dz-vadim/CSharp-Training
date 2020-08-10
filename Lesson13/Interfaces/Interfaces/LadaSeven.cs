using System;

namespace Interfaces
{
    class LadaSeven : ICar
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public int Move(int distance)
        {
            return distance / 40;
        }
    }
}

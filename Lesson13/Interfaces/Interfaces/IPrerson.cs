using System;

namespace Interfaces
{
    interface IPrerson
    {
        int Speed { get; set; }

        int Move(int distance);
    }
}

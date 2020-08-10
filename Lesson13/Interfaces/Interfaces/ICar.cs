using System;

namespace Interfaces
{
    interface ICar: IObject
    {
        /// <summary>
        /// Realese Moving
        /// </summary>
        /// <param name="distance">Moving distance</param>
        /// <returns>Time moving</returns>
        int Move(int distance);
    }
}

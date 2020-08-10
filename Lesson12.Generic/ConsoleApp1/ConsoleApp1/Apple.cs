using System;


namespace ConsoleApp1
{
    class Apple<T>: Product<T>
    {
        public Apple(string name, T volume, T energy)
            : base( name, volume, energy)
        {

        }
    }
}

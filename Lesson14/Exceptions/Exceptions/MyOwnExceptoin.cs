using System;


namespace Exceptions
{
    class MyOwnExceptoin : Exception
    {
        public MyOwnExceptoin() : base ("This my exception")
        {
        }
        public MyOwnExceptoin(string messege):base(messege)
        {

        }
    }
}

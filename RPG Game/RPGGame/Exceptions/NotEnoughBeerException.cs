
namespace RPGGame.Exceptions
{
    using System;
    public class NotEnoughBeerException : Exception
    {
        public NotEnoughBeerException(string msg) : base(msg)
        {

        }
    }
}

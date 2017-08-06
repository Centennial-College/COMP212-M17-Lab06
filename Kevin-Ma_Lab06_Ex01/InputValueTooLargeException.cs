using System;

namespace Kevin_Ma_Lab06_Ex01
{
    class InputValueTooLargeException : Exception
    {
        //Always need to implement three common constructors when creating user-defined exception classes
        public InputValueTooLargeException() { }
        public InputValueTooLargeException(string msg) : base(msg) { }
        public InputValueTooLargeException(string msg, Exception inner) : base(msg, inner) { }
    }
}

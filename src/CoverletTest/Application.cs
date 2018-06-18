using System;

namespace CoverletTest
{
    public class Application
    {
        public bool DoSomething(bool choice)
        {
            bool result;

            if (choice)
            {
                result = ActionA("Hello");
            }
            else
            {
                result = ActionB(1337);
            }

            return result;
        }

        private bool ActionA(string foo)
        {
            Console.WriteLine(foo);

            return true;
        }

        private bool ActionB(int bar)
        {
            Console.WriteLine(bar);

            return false;
        }
    }
}

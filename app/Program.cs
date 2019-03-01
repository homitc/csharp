using System;

namespace app
{
    public class Program
    {
        /// <summary>
        /// Some field.
        /// </summary>
        int field = 3;

        /// <summary>
        /// My console app's entrypoint.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        static void Main(string[] args)
        {
            new Program().AnotherMethod();
        }

        void AnotherMethod()
        {
            string local = "somevalue" + field;
            string anotherLocal = local;

            string finalOne = string.Join(local, anotherLocal);
        }
    }
}

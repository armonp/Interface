using System;
using System.Collections.Generic;
using System.Text;

namespace Interface {
    class English : ISpeakable {

        public void SayHello() {
            Console.WriteLine("Hello");
        }
        public void SayGoodbye() {
            Console.WriteLine("Goodbye");
        }
    }
}

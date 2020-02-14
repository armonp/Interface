using System;
using System.Collections.Generic;
using System.Text;

namespace Interface {
    class Swahili : ISpeakable{

        public void SayHello() {
            Console.WriteLine("Habari");
        }
        public void SayGoodbye() {
            Console.WriteLine("Kwaheri");
        }

    }
}

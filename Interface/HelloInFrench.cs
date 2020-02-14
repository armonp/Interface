using System;
using System.Collections.Generic;
using System.Text;

namespace Interface {
    class French : ISpeakable{

        public void SayHello() {
            Console.WriteLine("Bonjour");
        }
        public void SayGoodbye() {
            Console.WriteLine("Au revior");
        }

    }
}

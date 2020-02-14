using System;
using System.Collections.Generic;
using System.Text;

namespace Interface {
    class Hello { //class depends on interjection from other classes 

        ISpeakable Language; //variable of type Interface

        public Hello(ISpeakable language) { //default constructor. pass in language 
            Language = language; //set variable equal to parameter entered
        }

        public void Speak() {
            Language.SayHello(); //run the function that is shared
            Language.SayGoodbye();

        }
    }
}

using System;
using System.Collections.Generic;

namespace Interface {
    class Program {
        static void Main(string[] args) {
            (new Hello(new English())).Speak();
            (new Hello(new Swahili())).Speak();
            (new Hello(new English())).Speak();
            var english = new English();
            var spanish = new Spanish();
            
            var hello = new Hello(english);
            hello.Speak();
            var hello2 = new Hello(spanish);
            hello2.Speak();

            var hellofr = new Hello(new French());
            hellofr.Speak();

            (new Hello(new Swahili())).Speak();
            

            #region test interface Widget
            /*static void TestInterfaceWidget {
                var w1 = new Widget();
                var aw = new AdvWidget();
                var sw = new SuperWidget();
                var widgets = new List<IPrintable>(); //collection is IPrintable

                widgets.Add(w1);
                widgets.Add(aw);
                widgets.Add(sw);

                foreach (var widget in widgets) {
                    widget.Print(); 
                } //can only call the method that each element shares
            } */
            #endregion
        }

    }
}


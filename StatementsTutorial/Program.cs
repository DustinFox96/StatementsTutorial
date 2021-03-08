using System;

namespace StatementsTutorial {
    class Program {
        static void Main(string[] args) {


            ////Console.WriteLine("Enter a number");
            ////var aNbr = Console.ReadLine();
            ////var nbr = Convert.ToInt32(aNbr);
            ////if(nbr % 2 == 0) {
            ////    Console.WriteLine($"The number {nbr} is even");


            ////} else {
            ////    Console.WriteLine($"The number {nbr} is odd");
            //} //need a lot of help with this one with becca
            var ints = new[] {77, 32, 94, 46, 28 };
            for (var idx =0; idx < 5; idx++) {
                Console.WriteLine($"idx is {idx} and ints[idx] is {ints[idx]}");
            }

        }
    }
}

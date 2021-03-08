using System;

namespace StatementsTutorial {
    class Program {
        static void Main(string[] args) {



            var x = 0;
            while(x < 10) {
                Console.WriteLine($"This is args string");
                x++;
             //without this; it is infinite!
            }






            //var ints3 = new[] { 77, 32, 94, 46, 28 };

            //var total = 0;
            //for (var idx3 = 0; idx3 < ints3.Length; idx3++) {
            //    total = total + ints3[idx3];
            //    Console.WriteLine($"Total of ints3 is {total}");
            //}






            ////FIZBUZZ assignment slide C# 108
            //for (var idx = 1; idx <= 30; idx++) {
            //    if (idx % 3 == 0 && idx % 5 == 0) {
            //        Console.WriteLine("FIZZBUZZ");
            //    } else {
            //        if (idx % 3 == 0) {
            //            Console.WriteLine("FIZZ ");
            //        } else {
            //            if (idx % 5 == 0) {
            //                Console.WriteLine("BUZZ ");
            //            } else {
            //                Console.WriteLine($"{idx} ");
            //            }
            //        }
            //    }

            //}


            //// Ternary example
            //var trafficLight = "green";
            //var command = (trafficLight == "red") ? "stop" : "go";
            //Console.WriteLine($"The sign saids {command}");



            //// newer version of switch
            //var stateCode = "OH";

            //var stateName = stateCode switch {
            //    "OH" =>/* this is a lambda (fat arrow)*/ "Ohio",
            //    "KY" => "Kentucky",
            //    "IN" => "Indiana",
            //    _ => "Not found"
            //};





            /*
            var stateCode = "xx";
            var stateName = "";
            switch(stateCode) {
                case "IN":
                    stateName = "Indiana";
                    break;
                case "KY":
                    stateName = "Kentucky";
                    break;
                case "OH":
                    stateName = "Ohio";
                    break;
                default:
                    stateName = "Not found";
                    break;
            }
            Console.WriteLine($"Statecode is {stateCode}, name is {stateName}");
            */
            /*
            // slide 101 assignment 
            var counter = 1;
            while(counter <= 25) {
                if(counter % 2 != 0) {
                    Console.WriteLine($"The number is {counter * counter * counter}");
                }
                counter++;

            }
            */



            /*
            var thriller = new Song {
                Title = "Thriller;",
                Artist = "Michael Jackson",
                Genre = "Pop",
                Released = new DateTime(1984, 6, 1),
                Platinum = true
            };
            var thunderstruct = new Song {
                Title = "Thunderstruct",
                Artist = "Ac/DC",
                Genre = "Rock",
                Released = new DateTime(1990, 1, 1),
                Platinum = true
            };
            var wastedOnTheWay = new Song {
                Title = "Wasted on the Way",
                Artist = "Crossby, Stills, & Nash",
                Genre = "Folk",
                Released = new DateTime(1982, 12, 31),
                Platinum = false
            };

            var songs = new Song[] { thriller, thunderstruct, wastedOnTheWay };

            foreach(var song in songs) {
                if(song.Platinum == true) { 
                Console.WriteLine($"{song.Title}");
                }
            }


            //Console.WriteLine("Enter a number");
            //var aNbr = Console.ReadLine();
            //var nbr = Convert.ToInt32(aNbr);
            //if (nbr % 2 == 0) {
            //    Console.WriteLine($"The number {nbr} is even");


            //} else {
            //    Console.WriteLine($"The number {nbr} is odd");
            //} //need a lot of help with this one with becca
            //var ints = new[] {77, 32, 94, 46, 28 };
            */
            /*
            var ints1 = new[] { 20, 49, 94, 91, 64, 92, 26, 37, 45, 49 };
            var ints2 = new[] { 611, 589, 466, 792, 876, 752, 270, 166, 357 };
            var ints3 = new[] { 2155, 5622, 2974, 2563, 8201, 6627, 3380, 2551 };
            // this is an easier way to do what we were doing below this statement 
            // you could also change ints to what ever number you want, like ints1, ints2, ints3. this is way easier to get the data we want
            var sum = 0;
            foreach(var anint in ints2) {
                if(anint % 3 == 0) { 
                    sum += anint;
                }
            }
            Console.WriteLine($"sum is {sum}");
            */







            //var total3 = 0;
            //for (var idx =0; idx < ints1.Length; idx++) {
            //    if (ints1[idx] % 2 == 0) {
            //        total3 = total3 + ints1[idx];
            //    }
            //}
            //    Console.WriteLine($"Total of ints1 is {total3}");


            ////for (var idx = 0; idx < 5; idx++) {
            ////    Console.WriteLine($"idx is {idx} and ints[idx] is {ints1[idx]}");
            ////}

            //var total2 = 0;
            //for (var idx2 =0; idx2 < ints2.Length; idx2++) {
            //    total2 = total2 + ints2[idx2];
            //}
            //    Console.WriteLine($"Total of ints2 is {total2}");

            //var total = 0;
            //for (var idx3 =0; idx3 < ints3.Length; idx3++) {
            //    if(ints3[idx3] % 2 == 1) {
            //        total = total + ints3[idx3];
            //    }

            //}
            //    Console.WriteLine($"Total of ints3 is {total}");

        }
    }
    }

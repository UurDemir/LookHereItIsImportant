using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using LHIII.Common;

namespace LHIII.ListCapacity
{
    class Program
    {
        private const int RepetitionsCount = 100;
        private const int Capacity = 100;

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                var generatedString = RandomHelper.GenerateString(10);
                ListNoCapacity();
                ListHasCapacity();
                SortedListNoCapacity();
                SortedListHasCapacity();
                ArrayListNoCapacity();
                ArrayListHasCapacity();
                DictionaryNoCapacity();
                DictionaryHasCapacity();
               // LinkedListNoCapacity();

            } while (Console.ReadKey().Key == ConsoleKey.R);
        }

        private static void LinkedListNoCapacity()
        {
            Console.WriteLine(new string('-', 50));
            WriteLineWithColor("LinkedList No Capacity");
            var allElapseds = new long[RepetitionsCount];
            var timer = new Stopwatch();
            LinkedList<string> noCapacityList;
            for (var i = 0; i < RepetitionsCount; i++)
            {
                noCapacityList = new LinkedList<string>();

                var values = Enumerable.Repeat(RandomHelper.GenerateString(10), Capacity).ToArray();

                timer.Restart();
                for (var j = 0; j < Capacity; j++)
                {
                    LinkedListNode<string> newNode = new LinkedListNode<string>(values[j]);
                    noCapacityList.AddLast(newNode);
                }
                timer.Stop();
                var elapsedTicks = timer.ElapsedTicks;
                allElapseds[i] = elapsedTicks;
                RepeatLog(i, elapsedTicks);
            }
            OverallLog(allElapseds);

        }

        private static void DictionaryNoCapacity()
        {
            Console.WriteLine(new string('-', 50));
            WriteLineWithColor("Dictionary No Capacity");
            var allElapseds = new long[RepetitionsCount];
            var timer = new Stopwatch();
            Dictionary<int,string> noCapacityList;
            for (var i = 0; i < RepetitionsCount; i++)
            {
                noCapacityList = new Dictionary<int, string>();

                var values = Enumerable.Repeat(RandomHelper.GenerateString(10), Capacity).ToArray();

                timer.Restart();
                for (var j = 0; j < Capacity; j++)
                {
                    noCapacityList.Add(j,values[j]);
                }
                timer.Stop();
                var elapsedTicks = timer.ElapsedTicks;
                allElapseds[i] = elapsedTicks;
                RepeatLog(i, elapsedTicks);
            }
            OverallLog(allElapseds);

        }

        private static void DictionaryHasCapacity()
        {
            Console.WriteLine(new string('-', 50));
            WriteLineWithColor("Dictionary Has Capacity");
            var allElapseds = new long[RepetitionsCount];
            var timer = new Stopwatch();
            Dictionary<int, string> capacityList;
            for (var i = 0; i < RepetitionsCount; i++)
            {
                capacityList = new Dictionary<int, string>(RepetitionsCount);

                var values = Enumerable.Repeat(RandomHelper.GenerateString(10), Capacity).ToArray();

                timer.Restart();
                for (var j = 0; j < Capacity; j++)
                {
                    capacityList.Add(j, values[j]);
                }

                timer.Stop();
                var elapsedTicks = timer.ElapsedTicks;
                allElapseds[i] = elapsedTicks;
                RepeatLog(i, elapsedTicks);
            }
            OverallLog(allElapseds);
        }

        private static void ListNoCapacity()
        {
            Console.WriteLine(new string('-', 50));
            WriteLineWithColor("List No Capacity");
            var allElapseds = new long[RepetitionsCount];
            var timer = new Stopwatch();
            List<string> noCapacityList;
            for (var i = 0; i < RepetitionsCount; i++)
            {
                noCapacityList = new List<string>();

                var values = Enumerable.Repeat(RandomHelper.GenerateString(10), Capacity).ToArray();

                timer.Restart();
                for (var j = 0; j < Capacity; j++)
                {
                    noCapacityList.Add(values[j]);
                }
                timer.Stop();
                var elapsedTicks = timer.ElapsedTicks;
                allElapseds[i] = elapsedTicks;
                RepeatLog(i, elapsedTicks);
            }
            OverallLog(allElapseds);

        }

        private static void ListHasCapacity()
        {
            Console.WriteLine(new string('-', 50));
            WriteLineWithColor("List Has Capacity");
            var allElapseds = new long[RepetitionsCount];
            var timer = new Stopwatch();
            List<string> capacityList;
            for (var i = 0; i < RepetitionsCount; i++)
            {
                capacityList = new List<string>(RepetitionsCount);

                var values = Enumerable.Repeat(RandomHelper.GenerateString(10), Capacity).ToArray();

                timer.Restart();
                for (var j = 0; j < Capacity; j++)
                {
                    capacityList.Add(values[j]);
                }
                timer.Stop();
                var elapsedTicks = timer.ElapsedTicks;
                allElapseds[i] = elapsedTicks;
                RepeatLog(i, elapsedTicks);
            }
            OverallLog(allElapseds);
        }


        private static void SortedListNoCapacity()
        {
            Console.WriteLine(new string('-', 50));
            WriteLineWithColor("SortedList No Capacity");
            var allElapseds = new long[RepetitionsCount];
            var timer = new Stopwatch();
            SortedList<string, int> noCapacityList;
            for (var i = 0; i < RepetitionsCount; i++)
            {
                noCapacityList = new SortedList<string, int>();

                var values = Enumerable.Repeat(RandomHelper.GenerateString(10), Capacity).ToArray();

                timer.Restart();
                for (var j = 0; j < Capacity; j++)
                {
                    noCapacityList.Add(values[j]+j,j);
                }
                timer.Stop();
                var elapsedTicks = timer.ElapsedTicks;
                allElapseds[i] = elapsedTicks;
                RepeatLog(i, elapsedTicks);
            }
            OverallLog(allElapseds);

        }

        private static void SortedListHasCapacity()
        {
            Console.WriteLine(new string('-', 50));
            WriteLineWithColor("SortedList Has Capacity");
            var allElapseds = new long[RepetitionsCount];
            var timer = new Stopwatch();
            SortedList<string,int> capacityList;
            for (var i = 0; i < RepetitionsCount; i++)
            {
                capacityList = new SortedList<string, int>(RepetitionsCount);

                var values = Enumerable.Repeat(RandomHelper.GenerateString(10), Capacity).ToArray();

                timer.Restart();
                for (var j = 0; j < Capacity; j++)
                {
                    capacityList.Add(values[j]+j,j);
                }
                timer.Stop();
                var elapsedTicks = timer.ElapsedTicks;
                allElapseds[i] = elapsedTicks;
                RepeatLog(i, elapsedTicks);
            }
            OverallLog(allElapseds);
        }

        private static void ArrayListNoCapacity()
        {
            Console.WriteLine(new string('-', 50));
            WriteLineWithColor("ArrayList No Capacity");
            var allElapseds = new long[RepetitionsCount];
            var timer = new Stopwatch();
            ArrayList noCapacityList;
            for (var i = 0; i < RepetitionsCount; i++)
            {
                noCapacityList = new ArrayList();

                var values = Enumerable.Repeat(RandomHelper.GenerateString(10), Capacity).ToArray();

                timer.Restart();
                for (var j = 0; j < Capacity; j++)
                {
                    noCapacityList.Add(values[j]);
                }
                timer.Stop();
                var elapsedTicks = timer.ElapsedTicks;
                allElapseds[i] = elapsedTicks;
                RepeatLog(i, elapsedTicks);
            }
            OverallLog(allElapseds);

        }

        private static void ArrayListHasCapacity()
        {
            Console.WriteLine(new string('-', 50));
            WriteLineWithColor("ArrayList Has Capacity");
            var allElapseds = new long[RepetitionsCount];
            var timer = new Stopwatch();
            ArrayList capacityList;
            for (var i = 0; i < RepetitionsCount; i++)
            {
                capacityList = new ArrayList(RepetitionsCount);

                var values = Enumerable.Repeat(RandomHelper.GenerateString(10), Capacity).ToArray();

                timer.Restart();
                for (var j = 0; j < Capacity; j++)
                {
                    capacityList.Add(values[j]);
                }
                timer.Stop();
                var elapsedTicks = timer.ElapsedTicks;
                allElapseds[i] = elapsedTicks;
                RepeatLog(i, elapsedTicks);
            }
            OverallLog(allElapseds);
        }

        private static void OverallLog(long[] allElapseds)
        {
            Console.WriteLine(
                $"Total Repeat Count : {RepetitionsCount}, Total Item Count : {Capacity} , Overall Elapsed Time : {allElapseds.Sum()} , Average Elapsed Time : {allElapseds.Average()}");
        }

        private static void RepeatLog(int i, long elapsedTicks)
        {
            return;
            Console.WriteLine($"Repeat Number : {i} , Elapsed Time : {elapsedTicks}");
        }

        private static void WriteLineWithColor(string text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

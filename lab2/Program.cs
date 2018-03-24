using System;



namespace ConsoleApplication

{

    class Program

    {

        public static int BinarySearch(int[] array, int value)

        {

            //код поиска значения value в массиве array
            var left = 0;
            var right = array.Length-1;
            if (array.Length == 0)
                return -1;
            while (left < right)
            {
                var middle =(right + left) / 2;
                if (value <= array[middle])
                    right = middle;
                else left = middle + 1;
            }
            if (array[right] == value)
                return right;
            return -1;

        }



        static void Main(string[] args)

        {

            TestNegativeNumbers();

            TestNonExistentElement();
            TestOneInFive();
            BigArrayTest();
            RepeatElement();
            EmptyArray();


            Console.ReadKey();

        }



        private static void TestNegativeNumbers()

        {

            //Тестирование поиска в отрицательных числах

            int[] negativeNumbers = new[] { -5, -4, -3, -2 };

            if (BinarySearch(negativeNumbers, -3) != 2)

                Console.WriteLine("! Поиск не нашёл число -3 среди чисел {-5, -4, -3, -2}");

            else

                Console.WriteLine("Поиск среди отрицательных чисел работает корректно");

        }

        private static void TestNonExistentElement()

        {

            //Тестирование поиска отсутствующего элемента

            int[] negativeNumbers = new[] { -5, -4, -3, -2 };

            if (BinarySearch(negativeNumbers, -1) >= 0)

                Console.WriteLine("! Поиск нашёл число -1 среди чисел {-5, -4, -3, -2}");

            else

                Console.WriteLine("Поиск отсутствующего элемента вернул корректный результат, работает корректно");

        }
        private static void TestOneInFive()
        {
            //Тестирование поиска одного элемента в массиве из пяти
            int[] array = new[] { 1, 2, 3, 4, 5 };
            if (BinarySearch(array, 3) != 2)
                Console.WriteLine("! Поиск не нашел числа 3 среди чисел {1, 2, 3, 4, 5}");
            else
                Console.WriteLine("Поиск одного элемента из пяти вернул корректный результат, работает корректно");
        }
        private static void BigArrayTest()
        {
            //Тестирование поиска в массиве из 100001
            int[] bigArray = new int[100001];
            for (int i = 0; i < bigArray.Length; i++)
            {
                bigArray[i] = i;
            }
            if (BinarySearch(bigArray, 5006) != 5006)
                Console.WriteLine("! Поиск не нашел числа 5006 среди 100001 чисел");
            else
                Console.WriteLine("Поиск одного элемента среди 100001 вернул корректный результат, работает корректно"); 
        }
        private static void RepeatElement()
        {
            //Тестирование поиска повторяющегося элемента
            int[] repeatElementArray = new int[] {1, 1, 2, 3, 4, 5, 6 };
            if (BinarySearch(repeatElementArray, 1) != 0 && BinarySearch(repeatElementArray, 1) != 1)
                Console.WriteLine("! Поиск не нашел повторяющийся элемент 1 в среди чисел {1, 1, 2, 3, 4, 5, 6} ");
            else
                Console.WriteLine("Поиск повторяющегося элемента вернул корректный результат, работает корректно");
        }
        private static void EmptyArray()
        {
            //тестирование поиска в пустом массиве
            int[] emptyArray = new int[0];
            if (BinarySearch(emptyArray, 4) != -1)
                Console.WriteLine("! Поиск нашел элемент в пустом массиве");
            else
                Console.WriteLine("Поиск элемента в пустом массиве вернул корректный результат, работат корректно");
        }

    }

}
namespace lesson_7
{
    enum SortAlgorithmType
    {
        Selection = 1,
        Bubble,
        Insertion,
    }
    enum OrderBy
    {
        Asc = 1,
        Desc = -1,
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int sortingType = 0;
            int how = 0;
            int leng;
            Random random = new Random();

            do
            {
                Console.Write("Введіть довжину масива - ");
                leng = int.Parse(Console.ReadLine());
                if (leng > 1)
                {
                    int[] ints = new int[leng];
                    for (int i = 0; i < leng; i++)
                        ints[i] = random.Next(100);

                    WriteArray(ints);
                    UserInput(ref sortingType, ref how);
                    Sort(ints, (SortAlgorithmType)sortingType, (OrderBy)how);
                    Console.WriteLine();
                    WriteArray(ints);
                    break;
                }
                else Console.WriteLine("Введіть значення більше 1\n");
            } while (true);

            Console.ReadKey();
        }


        public static void UserInput(ref int sortingType, ref int how)
        {
            do
            {
                Console.WriteLine("Виберіть тип сортування:\n\n" +
                    "Selection Sort - 1\n" +
                    "Bubble Sort - 2\n" +
                    "Insertion Sort - 3\n");
                Console.Write("Ваш вибір - ");
                sortingType = int.Parse(Console.ReadLine());

                if (sortingType < 1 || sortingType > 3)
                {
                    Console.WriteLine("Хибний ввід!\n");
                    continue;
                }
                break;

            } while (true);
            do
            {
                Console.WriteLine("Виберіть порядок сортування:\n\n" +
                        "За зростанням - 1\n" +
                        "За спаданням - -1\n");
                Console.Write("Ваш вибір - ");
                how = int.Parse(Console.ReadLine());

                if (how == 1 || how == -1) break;
                else Console.WriteLine("Хибний ввід!\n");

            } while (true);
        }
        public static void WriteArray(int[] arr)
        {
            int check = 0;
            Console.Write("Массив зараз = { ");
            foreach (int item in arr)
            {
                if (check != arr.Length - 1)
                {
                    Console.Write(item + ", ");
                }
                else Console.WriteLine(item +" }\n");

                check++;
            }
        }
        public static void Sort(int[] unsortedArr, SortAlgorithmType type, OrderBy ord)
        {
            switch (type)
            {
                case SortAlgorithmType.Selection:
                    Selection(unsortedArr, ord);
                    break;
                case SortAlgorithmType.Bubble:
                    Bubble(unsortedArr, ord);
                    break;
                case SortAlgorithmType.Insertion:
                    Insertion(unsortedArr, ord);
                    break;
            }
        }
        public static void Selection(int[] unsortedArr, OrderBy ord)
        {
            int temp;
            int index;

            if (ord == OrderBy.Asc)
            {
                for (int i = 0; i < unsortedArr.Length - 1; i++)
                {
                    index = i;

                    for (int j = i + 1; j < unsortedArr.Length; j++)
                    {
                        if (unsortedArr[j] < unsortedArr[index]) index = j;
                    }

                    temp = unsortedArr[i];
                    unsortedArr[i] = unsortedArr[index];
                    unsortedArr[index] = temp;
                }
            }
            else
            {
                for (int i = 0; i < unsortedArr.Length - 1; i++)
                {
                    index = i;

                    for (int j = i + 1; j < unsortedArr.Length; j++)
                    {
                        if (unsortedArr[j] > unsortedArr[index]) index = j;
                    }

                    temp = unsortedArr[i];
                    unsortedArr[i] = unsortedArr[index];
                    unsortedArr[index] = temp;
                }
            }
        }
        public static void Bubble(int[] unsortedArr, OrderBy ord)
        {
            int temp;

            if (ord == OrderBy.Asc)
            {
                for (int i = 0; i < unsortedArr.Length - 1; i++)
                {
                    for (int j = 0; j < unsortedArr.Length - i - 1; j++)
                    {
                        if (unsortedArr[j] > unsortedArr[j + 1])
                        {
                            temp = unsortedArr[j];
                            unsortedArr[j] = unsortedArr[j + 1];
                            unsortedArr[j + 1] = temp;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < unsortedArr.Length - 1; i++)
                {
                    for (int j = 0; j < unsortedArr.Length - i - 1; j++)
                    {
                        if (unsortedArr[j] < unsortedArr[j + 1])
                        {
                            temp = unsortedArr[j];
                            unsortedArr[j] = unsortedArr[j + 1];
                            unsortedArr[j + 1] = temp;
                        }
                    }
                }
            }
        }
        public static void Insertion(int[] unsortedArr, OrderBy ord)
        {
            int temp;

            if(ord == OrderBy.Asc)
            {
                for (int i = 1; i < unsortedArr.Length; i++)
                {
                    temp = unsortedArr[i];
                    int j = i - 1;

                    for (; j >= 0 && unsortedArr[j] > temp; j--)
                    {
                        unsortedArr[j + 1] = unsortedArr[j];
                    }
                    unsortedArr[j + 1] = temp;
                }
            }
            else
            {
                for (int i = 1; i < unsortedArr.Length; i++)
                {
                    temp = unsortedArr[i];
                    int j = i - 1;

                    for (; j >= 0 && unsortedArr[j] < temp; j--)
                    {
                        unsortedArr[j + 1] = unsortedArr[j];
                    }
                    unsortedArr[j + 1] = temp;
                }
            }
        }
    }
}
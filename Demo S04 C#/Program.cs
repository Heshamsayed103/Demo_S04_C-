namespace Demo_S04_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers;
            // Declare For Reference (Pointer) From Type 'Array of Integers'
            // Numbers : Can Refer To Object From Type 'Array of Integers'
            // Numbers : Refer To Null

            // 8 Bytes Will Be Allocated At Stack For The Reference 'Numbers'
            // 0 Bytes Will Be Allocated At Heap

            Numbers = new int[5];
            // new
            // 1. Allocate The Number of Required Bytes For The Object At HEAP (4 Bytes * 5)
            // 2. Initialized The Allocated Bytes With The Default Value Of The Datatypes
            // 3. Call User-Defined Constructor if Exists
            // 4. Assign The Object To The Reference 'Numbers'


            //Numbers[0] = 12;
            //Numbers[1] = 6;
            //Numbers[2] = 7;
            //Numbers[3] = 11;
            //Numbers[4] = 19;
            ////Numbers[5] = 20; // Out of Range (Index 5 is invalid for an array of size 5)

            //Console.WriteLine(Numbers[0]); // Output: 12
            //Console.WriteLine(Numbers[1]); // Output: 6
            //Console.WriteLine(Numbers[2]); // Output: 7
            //Console.WriteLine(Numbers[3]); // Output: 11
            //Console.WriteLine(Numbers[4]); // Output: 19


            //int[] Numbers01 = { 1, 2, 3, 4, 5, 6, 7, 8 }; // Array initialized with values (size inferred)

            //int[] Numbers02 = new int[4] { 1, 2, 3, 4 }; // Array with explicit size and initialization

            //int[] Numbers03 = new int[6] { 1, 2, 3, 4, 0, 0 }; // Array with explicit size and partial initialization (remaining elements set to default)

            //int[] Numbers04 = new int[6]; // Array with explicit size (all elements initialized to default 0)

            //    for (int i = 0; i < Numbers.Length; i++)
            //    {
            //        Console.Write(value: $"Enter Numbers[{i}]: "); // Prompt user for input
            //        Numbers[i] = int.Parse(Console.ReadLine()); // Read input and store in array
            //    }

            //    Console.Write(value:"======================");
            //    for (int i = 0; i < Numbers.Length; i++)
            //    {
            //        Console.WriteLine($"{Numbers[i]}");
            //    }

            #region  One D Array 

            //    Console.WriteLine(Numbers.Length //Size
            //    Console.WriteLine(Numbers.Rank);  // Dimension 

            //}


            #endregion

            #region Two D Array
            //int[,] Marks = new int[3, 3];

            //Marks[0, 0] = 99;
            //Marks[0, 1] = 99;
            //Marks[0, 2] = 99;

            //Marks[1, 0] = 80;
            //Marks[1, 1] = 98;
            //Marks[1, 2] = 97;

            //Marks[2, 0] = 88;
            //Marks[2, 1] = 78;
            //Marks[2, 2] = 47;

            //Console.WriteLine(Marks[0, 0]);
            //Console.WriteLine(Marks[0, 1]);
            //Console.WriteLine(Marks[0, 2]);

            //Console.WriteLine(Marks[1, 0]);
            //Console.WriteLine(Marks[1, 1]);
            //Console.WriteLine(Marks[1, 2]);

            //Console.WriteLine(Marks[2, 0]);
            //Console.WriteLine(Marks[2, 1]);
            //Console.WriteLine(Marks[2, 2]);

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Enter Marks[{i}, {j}]: ");
            //        Marks[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine();

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{Marks[i,j]}");

            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            //int[][] Marks = new int[3][];

            //Marks[0] = new int[] { 1, 2, 3 };

            //Marks[1] = new int[] { 1, 2 };

            //Marks[2] = new int[] { 1, 2, 3, 4 };


            int[][] Marks = new int[3][];

            Marks[0] = new int[2];
            Marks[1] = new int[5];
            Marks[2] = new int[1];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < Marks[i].Length; j++)
                {
                    Console.WriteLine($"Marks[{i}][{j}]");
                    Marks[i][j] = int.Parse(Console.ReadLine());
                }
            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < Marks[i].Length; j++)
                {
                    Console.WriteLine($"{Marks[i][j]}");
                }
            }


            #region Gudge Array

            ////int[][] Marks = new int[3][];


            ////Marks[0] = new int[] {1,2,3,4,5};
            ////Marks[1] = new int[] { 1, 2};
            ////Marks[2] = new int[] { 1, 2, 3};



            //int[][] Marks = new int[3][];


            //Marks[0] = new int[2];
            //Marks[1] = new int[5];
            //Marks[2] = new int[7];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.WriteLine($"enter MArks{i},{j}");
            //        Marks[i][j] = int.Parse(Console.ReadLine());

            //    }
            //}


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.WriteLine(Marks[i][j]);

            //    }
            //} 
            #endregion

            #region Function ProtoType


            // Functions : Block Of Code That Have Name if U Need To Execute This Code

            //  U Need To Call The  Function By The Name 
            // DRY

            // Function ProtoType
            //1. Signature
            //1.1.Name
            //1.2.Return Type
            //1.3. Parameters (Inputs)
            //2. Body (Code)


            //Calling For The Functions
            //PrintShape( 3 );
            //PrintShape(5,"*"); //Passing By Order
            //PrintShape(Pattern:"*",count: 3); //Passing By Name



            // Methods 
            //1. Class Member Method (Static Method)
            //2. Object Member Method (non static method)

            ////int sum =SumNumbers(1, 2);
            ////Console.WriteLine(sum);
            //Console.WriteLine(SumNumbers(1,2));

            #endregion

            #region  Passing By value

            ////SumNumbers(1, 2);


            //// Passing By Value 
            //// Pasiing By Reference



            //// Passing Paramater Value Type 
            //// 1. Passing By Value 
            //// 2. Passing By Ref


            ////int A = 4; int B = 5;
            ////Console.WriteLine($"A : {A}");
            ////Console.WriteLine($"B : {B}");
            ////Console.WriteLine("========after swap=========");
            //////Swap (4,5)
            ////Swap(A,B );  // Passing by  Value 

            ////Console.WriteLine($"A : {A}");
            ////Console.WriteLine($"B : {B}");


            //// 2. Passing By Ref 
            //int A = 4; int B = 5;
            //Console.WriteLine($"A : {A}");//4
            //Console.WriteLine($"B : {B}");//5

            //Console.WriteLine("========after swap=========");


            //Swap(ref A,ref B);  // Passing by  Ref 

            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}"); 
            #endregion

            #region Passing Paramater Reference Type

            //// Passing Paramater Reference Type

            //// 1. Passing By Value 

            ////int[] Numbers = { 1, 2, 3  };
            ////int  Result = SumArray(Numbers);
            ////Console.WriteLine(Result);
            ////Console.WriteLine(Numbers[0]);

            //// 2. Passing By Reference


            //int[] Numbers = { 1, 2, 3 };
            //int Result = SumArray(ref Numbers);
            //Console.WriteLine(Result);
            //Console.WriteLine(Numbers[0]); 
            #endregion

            #region Passing Paramater Reference Type

            //Passing Paramater Reference Type
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbers)); //Passing By Value
            //Console.WriteLine(Numbers[0]);


            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Numbers)); //Passing By Ref
            //Console.WriteLine(Numbers[0]);

            #endregion

            #region Passing By Out

            //    //int A = 3, B = 6;

            //    //int[] Result = SumMul(A,B) ;

            //    //Console.WriteLine( Result[0]);
            //    //Console.WriteLine(Result[1]);



            //   // int A = 3, B = 6;

            //   //   NewData result = SumMul(A, B);

            //   //Console.WriteLine(result[0]);
            //   // Console.WriteLine(result[1]);


            //    // Output Paramater 

            //    // Passing By Out 

            //int A = 4,  B = 5,sum ,mul;

            //SumMul(A, B, out sum, out mul);
            //Console.WriteLine(sum);
            //Console.WriteLine(mul); 
            #endregion

            #region Params

            ////Params

            //int[] Numbers = { 1, 2, 3, 5, 4 };
            //Console.WriteLine(SumArry(Numbers));

            //Console.WriteLine(SumArry(1,2,3,4,5)); 


            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Numbers)); //Passing By Ref
            //Console.WriteLine(Numbers[0]);
            #endregion


            #region Passing By Out

            //    //int A = 3, B = 6;

            //    //int[] Result = SumMul(A,B) ;

            //    //Console.WriteLine( Result[0]);
            //    //Console.WriteLine(Result[1]);



            //   // int A = 3, B = 6;

            //   //   NewData result = SumMul(A, B);

            //   //Console.WriteLine(result[0]);
            //   // Console.WriteLine(result[1]);


            //    // Output Paramater 

            //    // Passing By Out 

            //int A = 4,  B = 5,sum ,mul;

            //SumMul(A, B, out sum, out mul);
            //Console.WriteLine(sum);
            //Console.WriteLine(mul); 
            #endregion

            #region Params

            ////Params

            //int[] Numbers = { 1, 2, 3, 5, 4 };
            //Console.WriteLine(SumArry(Numbers));

            //Console.WriteLine(SumArry(1,2,3,4,5)); 
            #endregion





        }
    }
}

using System.Runtime.InteropServices;
using System.Threading.Channels;
using static AC__Delegate.Helper<T>;

namespace AC__Delegate
{
    internal class Program
    {
        //Built in delegate
        //--1.Predicate--[take one parameter] and return bool

        public static List<T> GetElements<T>(List<T> elements, Predicate<T> condition)
        {
            List<T> Result = new List<T>();
            if (elements is not null && condition is not null)

                for (int i = 0; i < elements.Count; i++)

                    if (condition(elements[i])) Result.Add(elements[i]);

            return Result;


        }


        //--2. Func
        // Func<> //can refer to function that can take [0-16] parameter and must be return

        //--3.Action--
        //refer to function take [0-16] parameters and must be void

        static void Main(string[] args)
        {
            #region Delegate ex1

            // int[] numbers = { 10, 2, 3, 4, 15, 1, 8, 20};
            // SortingAlgorithm.BubbleSort(numbers, CompareFunctions.CompareGrt);

            // CompareFuncDelegate compareFunc = CompareFunctions.CompareLess;//1st step(seclare ref from delegate)

            //// SortingAlgorithm.BubbleSort(numbers, CompareFunctions.CompareLess);//3rd step (use delegate ref(call method)
            // foreach (int number in numbers) 
            //     Console.Write($"{number}  ");

            // //the other function(sortingbydesc) is not normal cause um repeating the code 
            // //so the delegate solve this problem as I can send the operation to decide to make it sorting asec or desc





            #endregion

            #region Delegate ex2
            //string[]Names= { "amr", "Aly", "Maha", "Kareem" };
            //CompareFuncDelegate<string> compareFunc = CompareFunctions.SortDecsending;
            ////SO
            //SortingAlgorithm<string>.BuubleSort(Names, compareFunc);

            ////OR
            //SortingAlgorithm<string>.BuubleSort(Names,CompareFunctions.SortAscending);

            //foreach( string name in Names ) 
            //    Console.WriteLine(name); 
            #endregion

            #region with generic
            //List<int> Numbers = Enumerable.Range(1,100).ToList();
            ////  List<int> oddnumber= Helper.GetNumber(Numbers, ConditionalFunctions.CheckOdd);


            //List<string> Names = new List<string>() { "Ahmed", "Omar" ,"May","Kareem","Manar"};
            //List<string> Result = Helper<string>.GetElements(Names, ConditionalFunctions.CheckStringLength);

            //foreach (string name in Result) 
            //    Console.Write($"{name}  "); 
            #endregion

            #region predicate
            //Predicate<int> predicate; // Ref => func take one parameter [int] and return bool
            //predicate = TestingFunctions.Test01;
            //predicate.Invoke(10);
            //Console.WriteLine(predicate(10));//syntsax sugar 
            #endregion

            #region FUNC 
            //Func<int, string> Func;//last parameter is output

            //Func = TestingFunctions.Test02;
            //Console.WriteLine(Func(5));//casting from int to string 
            #endregion

            #region Action 
            // Action action; //Non generic -0 parameter - void
            // Action<int> action; // Generic - 1 parameter - void

            //1.. non-Generic
            //Action action;
            //action = TestingFunctions.Test03;
            //action();//Hello

            //2..Generic..
            //Action<string> action; //Generic - 1 parameter[int] - void
            ////Action=> Refer to function take 1 parameter [string] return void
            //action = TestingFunctions.Test04;
            //action("Mona");//Hello Mona 
            #endregion

            #region AnonymousMethod
            //Anonymous function to avoid making function to use it one time
            //only so instead I can make for example

            //Predicate<int> predicate;
            //// predicate= public static bool Test01(int x) { return x>0;}  
            ////no need for public ,static , bool or its name I can make instead
            //predicate = delegate(int x) { return x > 0; }//make it for only one time use and call
            //---========================================================================================

            //Func<int, string> Func;
            //Func = delegate (int x) { return x.ToString(); };
            //Console.WriteLine(Func(5));
            //============================================================================================

            //Action Non-Generic
            //Action action;
            //action = delegate () { Console.WriteLine("Hello"); };
            //action();
            //-----------------------------------------
            //Action - Generic
            //Action<string> action;
            //action = delegate (string s) { Console.WriteLine($"Hello {s}"); };
            //action("Mona"); 
            #endregion

            #region LambdaExpression
            //   //Anonymous function to avoid making function to use it one time
            //  // only so instead I can make for example

            //  Predicate<int> predicate;
            // predicate= public static bool Test01(int x) { return x>0;}  
            //no need for public ,static , bool or its name I can make instead
            // predicate = (X) => X > 0;// Lambda expression
            // (=>) called fat arrow , but read as goes to
            //  // -- -========================================================================================

            //   Func<int, string> Func;
            //Func =   (X) => X.ToString(); // Lambda expression
            //   Console.WriteLine(Func(5));
            // //  ============================================================================================

            ////   Action Non - Generic
            // Action action;
            //  action = ()=> Console.WriteLine("Hello"); 
            //   action();
            ////   -----------------------------------------
            ///
            ////   Action - Generic
            // Action<string> action;
            //action = (S) => Console.WriteLine($"Hello {S}"); // Lambda Expression
            // action("Mona"); 
            #endregion

            #region var in Delegate 
            //// new features at delegate in c# 10
            //// C# is strongly typed

            ////  Predicate<int> predicate= (X) => X > 0;// old feature
            //var predicate = (int x) => x > 0;// new feature in delegate

            ////  // -- -========================================================================================

            ////   Func<int, string> Func =(X) => X.ToString();
            //var Func = (int x)=> x.ToString();// new feature

            ////   Console.WriteLine(Func(5));
            //// //  ============================================================================================

            //////   Action Non - Generic
            //// Action action  = ()=> Console.WriteLine("Hello");
            //var action = () => Console.WriteLine("Hello");/// new feature
            ////   action();
            //////   -----------------------------------------
            /////
            //////   Action - Generic
            //// Action<string> action;
            ////action = (S) => Console.WriteLine($"Hello {S}"); // Lambda Expression
            //// action("Mona");  
            #endregion

            #region BuildIn func help in delegate   
            //List<int> Numbers= Enumerable.Range(1,100).ToList();
            //// List<int> oddnumber = GetElements(Numbers, delegate (int x) { return x % 2 == 1; });// Anonymous function
            //// List<int> oddnumber = GetElements(Numbers, (X) => X%2==1);// Lambda Expression

            //List<int> oddNumber = Numbers.FindAll(Number => Number % 2 == 1);// take each Number in Numbers
            ////return all elements matches the condition                     // List ans check if its odd or
            //                                                                 // not nad return it in a list

            //int oddnumber = Numbers.Find(Number => Number % 2 == 1);// return the first element matches the condition
            //========================================================================================================

            //List<int> Numbers= Enumerable.Range(1,100).ToList();
            //Numbers.ForEach(x => Console.WriteLine(x));// instead of print Line
            //Numbers.ForEach(x => Console.WriteLine(x+10));// print each element with addition of 10
            //perform a specific Action on each element in list
            //===================================================================================================

            //int count= Numbers.RemoveAll(x => x%5==0);//remove all elements matches the condion
            //Console.WriteLine(count);                //then return the count of elements had removed 
            #endregion

        }
    }
    class TestingFunctions //for built delegate ex
    {
        //public static bool Test01(int x)
        //{
        //    return x > 0;
        //}//Predicate ex

        //public static string Test02(int x)
        //{
        //    return x.ToString();
        //}//Func ex

        //public static void Test03()
        //{
        //    Console.WriteLine("Hello");
        //}// Action non generic ex

        //public static void Test04(string Name) // Action Generic ex
        {
            Console.WriteLine($"Hello {Name}");
        }

        
}

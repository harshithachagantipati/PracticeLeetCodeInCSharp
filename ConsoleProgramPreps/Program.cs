using System.Numerics;
using System.Reflection;
using ConsoleProgramPreps;
using static ConsoleProgramPreps.Practice;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hi this is Program file ");
        Practice pc = new Practice();
        //pc.test();
        /*Console.WriteLine("Enter a name to reverse: ");
        string name = Console.ReadLine();
        pc.reverseString(name);*/
        /*  char[] s = new char[] { 'h', 'a', 'r', 's', 'h', 'i', 't', 'h', 'a' };
          Console.WriteLine("Original Sting: "+new string(s));
          pc.reverseStringArrayChars(s);
          Console.WriteLine("Reversed String " + new string(s));*/
        /*Console.WriteLine("Enter Number to sum the from 1 to n:");
        int n = Convert.ToInt32(Console.ReadLine());
        pc.sumofNaturalNumbers(n);*/
        //pc.tableMultiplication(8);
        /*Console.WriteLine("Enter String to remove duplicate Characters: ");
        string n = Console.ReadLine();
        pc.removeDuplicateChars(n);*/
        /*Console.WriteLine("Enter a Number for FizzBuzz: ");
        int n = Convert.ToInt32(Console.ReadLine());
        IList<string> output = pc.FizzBuzz(n);
        Console.WriteLine("["+string.Join(",",output)+"]");*/
        /*int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Reverse of number: "+ pc.ReverseNumber(n));*/
        /*int[] num = { 1, 2, 3, 4, 5, 6 };
        int[] output = pc.DecompressRunList(num);
        Console.WriteLine("The Frequency of numbers are: "+string.Join(", ", output));*/
        //Console.WriteLine("No. Of Steps of 14 is:"+ pc.NumberOfSteps(14));
        /*int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int m = 3, n = 3;
        int[] nums2 = { 2, 5, 6 };
        Console.WriteLine("Array nums 1 is: " + string.Join(",", nums1) + " M value:" + m + " N value: " + n + " Nums2: " + string.Join(",", nums2));
        pc.MergeSort(nums1, m, nums2, n);
        Console.WriteLine("New Array nums 1 is: " + string.Join(",", nums1) + " M value:" + m + " N value: " + n + " Nums2: " + string.Join(",", nums2));
*/
        
        RandomsizedSet set = new RandomsizedSet();
        Console.WriteLine("Insert 10: " + set.Insert(10));  // true
        Console.WriteLine("Insert 20: " + set.Insert(20));  // true
        Console.WriteLine("Insert 10 again: " + set.Insert(10));  // false
        Console.WriteLine("Random Element: " + set.GetRandom());

        Console.WriteLine("Remove 10: " + set.Remove(10));  // true
        Console.WriteLine("Remove 30: " + set.Remove(30));  // false

        Console.WriteLine("Random Element: " + set.GetRandom());
        /*
                //example: know how many stars a specific github repository has
                var starts = new GithubService().GetStars("throw"); // fetch stars from githubservice, has single method getstars() receives repo name 

                class GithubService //generate class and method:  
            { //most apps this service wont actually have the implementation details of how to go ahead and call the github API, but that will sit in some GithubClient. 
                public int GetStars(string repoName) //
                {
                    return new GithubClient().GetRepo(repoName).Stars; // thats why we simply returning what comes back from Github client, pass reponame and access no,of stars specific for this repo 
                }
            }
            class GithubClient
            {
                public (string repoName, int stars) GetRepo(string repoName) //returns a tuple of repo name and no.of stars
                {
                    return (repoName, repoName.Length); 
                }
            }*/
        //we have github service that to fetch no.of stars based on repo name, github client implememts implements goint to github api and fetching repo details
        //Githubclient is responsible to go to github API and fetch the repo : reponame and no.of stars acc to reponame length like : repo: throw, stars: 5. return back to github service and github service takes no.of stars and return to caller
        //this pattern is common and used in backend apps. this method is concrete type of github client.
        //here larger module githubservice is dependent on the smaller module githubclient, so large module will depend on various smaller module 


    }


    /*
    abcdefghijklmnopqrstuvwxyz
    ABCD EFGHIJK LMNO PQRRSTUVWXYZ
    AB C D E F G H I J K L M N O P Q R S T U V W X Y Z 
    AA BB CC DD EE FF GG HH II JJ KK LL MM NN OO PP QQ RR SS TT UU VV WW XX YY ZZ
    AA BB CC DD EE FF GG HH II JJ KK LL MM NN OO PP QQ RR SS TT UU VV WW XX YY ZZ
    AA BB CC DD EE FF GG HH II JJ KK LL MM NN OO PP QQ RR SS TT UU VV WW XX YY ZZ
    AA BB CC DD EE FF GG HH II JJ KK LL MM NN OO PP QQ RR SS TT UU VV WW XX YY ZZ
    abcdefghijklmnopqrstuvwxyz

    Refactoring : The fact of rewriting or reorganizing code is a constant never ending tale. writing semi-dirty code is ok but leaving it dirty is not okay.

    *//*

    //Enum: 
    private enum State
    {
        LookingForEnemy,
        MovingToEnemy,
        AttackingEnemy,
    }
    private State state;

    //Properties
    private static string PlayerName { get; set; }
    private static string playerName;
    private static void SetPlayerName(string playerName)
    {
        Program.playerName = playerName;
    }
    private static string GetPlayerName()
    {
        return Program.playerName;
    }
    //MultiDimentional Arrays:
    //00,01,01,03
    //10,11,12,13
    //20,21,22,23
    //30,31,32,33
    //40,41,42,43

    //Nested Loops
    *//*  for(int i = 0; i < 3; i++){
          for(int j =0; j<2; j++){
          Console.WriteLine(i + ", " + j);
          }    
      }*//*
    //Recursion 
    private static void TestRecursion()
    {
        TestRecursion();
    }
    //Dictionary - key value pair stone - 24 
    //Collections: Stack pop, push, FILO First In Last Out
    //Function Params
    private static void PrintPlayerName(params string[] playerNameArray)
    {
        Console.WriteLine(playerNameArray.Length);
    }
    //optional parameters
    *//* private static void SpawnUnit(
         Vector3 spawnPosition = default,
         UnitType unitType = UnitType.Melee,
         Quaternion spawnRotation = default,
         int healthAmount = Default_Health_Amount
         )
     {
         Console.WriteLine("Spawning unit of type ");
     }*//*
    //Value and Reference Types : Value Types Contains their Data: int, float, bool, enum, struct : var -> value, var -> copy
    //Reference Type stores reference to their Data: class, object, array, string : var, var ->obj
    //structs : public struct Player {} - these are value types but similar to classes
    //class intermediate: its about inheretance, polymorphism much more.. Unit: float speed; void Move() >> Player: Unit: void MovePlayer(); Enemy: Unit: int enemyHealth;
    //Interfaces IAttackable : void Damage(); >> Player: IAttackable : void Damage(); , Enemy: IAttackable : void Damage();
    //is as casting : if(attackable is Player){ Console.Writeline("Is a player!"); }
    //Switch Type Matching 
    *//*switch (attackable){
         default:
         break;
         case Player player when player.health > 50:
         Console.WriteLine("Health is 50");
         player.PlayerSayHellp();
         break:
         case Player player:
         player.PlayerSayHello();
         break:
         case Enemy enemy:
         break;
     }*//*
    //Delegates, Lambdas and Anonymous functions
    //Local Functions Vs Lambda 
    Action<string> myAction = (string message) =>
    {
        Console.WriteLine(message);
    };
    void Print(string message)
    {
        Console.WriteLine(message);
    }
    //Events : Publishers of events << subscribers sub sub
    //Generics 
    private class MyList<T> where T : class, new()
    {
        public T field;
        public T MyFunction()
        {
            return new T();
        }
    }
    //constants, Readonly
    private const float Player_Speed = 5f;
    private readonly Player player = new Player();
    //Try Catch Exceptions
    //Ienumerable, Yield Return
    //namespaces how to make it own : namespace CodeMonkey_Csharp
    //Singleton Pattern is a design pattern
    public class GameManager
    {
        public static GameManager instance;
        public static GameManager Instance {
            get {
                if (instance == null) {
                    instance = new GameManager();
                }
                return instance;
            }
        }
        private GameManager()
        {
            instance = this;
        }
        //Design patterns overview
        //intermediate project to use all of these

        //Advanced Topic: Reflection . Reflection is how you can dynamically inspect your code and work with it without directly calling any functions or reading any fields
        Excercise excercise = new Excercise();
        Type playerType = typeof(Excercise).GetnestedType("Player");
        Console.WriteLine(playerType);

        Excercise.Player player = new Excercise.Player();
        MethodInfo myFunctionMethodInfo = playerType.GetMethod("MyFunction");
        myFunctionMethodInfo.Invoke(new Excercise.Player(), new object[] {56});

    //Function Extensions: simple but iteresting one, its how you can make function extensions. This allows you to extend a type with more fuctions without having to modigy the type itself. This is really useful when you dont have access to the type itself, when you dont have source code access.
    public static class TransformExtensiona
    {
        public static void MoveRight(this Transform transform, float amount) {
            transform.position += new Vector3(1, 0, 0) * amount;
        }
        public static bool IsTrue(this bool b)
        {
            return b;
        }

    }
    //Static constructor : kind of normal constructor but they run just once for the entire class
    static Player()
    {
        Console.WriteLine( "Player static constructor");
        if = 56;
    }
    //typeof keyword: 
    private void Start()
    {
        GetComponent(typeof(Player));
    }
    //nameof keyword: helps to get a string name for some kind of type, This is really useful to help you avoid strings in your code
    Console.WriteLine(nameof(Player);
    Console.WriteLine(nameof(Player.IsGrounded));

    //sizeof operator: this one lets you get the size of your types like int is 4 bytes, a short is 2 bytes 
    int i = 5;
    Console.WriteLine(sizeof(int));

    //default: if you do default of an int you get 0, if yu default of a ball you get false, default of some object you get null ....
    Console.WriteLine(default(int));
    //Expression-Bodied Members -> This is really intresting very compact way to write simple short functions, there is no need to write usual function boiler plate code. This is basically just lambda
    public void SetPlayerName(string playerName) => this.playerName = playerName;
    //Records: super simple way to create immutable types to organize data
    public record class Person(string FirstName, string LastName);
    //Null Conditional operators: 
    Console.WriteLine(player?.playerName);
    
    //Null colescing operator: it lets you quickly tests against null. If its null refurn a default value in this example its Unknown Player is default value if value is null
    Console.WriteLine(player?.GetPlayerName() ?? "Unknown Player");
    //Ternary Conditional operator : compact syntax for if,  if condition is true returns Alive, If false then returns Dead
    return health > 0 ? "ALIVE" : "DEAD";
    // Main command Line Args: how to passin command line values using console app
    //Nullable: for value types int or bool
    int? able = null;
    Console.WriteLine(able.GetValueOrDefault(12));
    //Span: effecient way to do logic on arrays or slices of arrays, It does not cost any new memory, does not create a new object, This is just a pointer
    int[] numArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, };
    Span<int> intSpan = new Span<int>(numArr, 1, 5);
    intSpan.Sort();

    //Bitwise operaions AND & OR 2power0, 1,2,3,4,5,6,7: 00000101 = 5 > 2*0 + 2*2 = 1+ 4 = 5 and 00000011 = 3 > 2*0 + 2*1 = 1+ 2 = 3
    //Enum Flags: for intresting combinations
    [Flags]
    public enum Ability : byte
    {
        None = 0,
        Jump = 1 << 0,
        Sprint = 1 << 1,
        Shoot = 1 << 2,
        Fly = 1 << 3,
    }
    //Preprocessor Directives: with this we can give orders to the compileritself, we can define symbols and include or not include some code in the compilation
    #define Testing
    public class Programm
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!");
            #if Testing
            Console.WriteLine("Testing");
            #endif
        }

    }
    //ref, out, in keywords
    //Data Boxing: 
    //Dynamic: very Advanced topic, we can work with types that don't actually exist. so we can define something as dynamic and call functions or read films on that object/ type even if they don't really exists. That validation logic is only going to run at runtime, not at compile time, This dynamic is very useful for data from web server 
    //Class Indexer: you can make your own custom type support as through an index just like a list or array, you can add whatever logic you want and make it readonly or read
    //Attributes: with this you can add metadata to your code
    [IsObjectType(ObjectType.Unit)] 
    public class Player {}
    //Anonymous types: quick way of organizing some data without having to 1st define a specific type
    var playersData = new {name = "Code Monkey", Id = 1};
    //Typles : very simillar to Anonymous types to organize some data without 1st defining a type, watch differences between this and above:
    var myTuple = {"code Monkey", 78};
    //using, IDisposable: code block and interface
    public void Dispose()
    {
        fileStream.Dispose();
    }
    //Override operators: using these we can add support for our own classes to do things like add or multiply, we can define logic to add 2 custom classes together
    //LINQ : do query operations on any collection of data weather its a list or array or xml or database, we grab data and we can queryfor some conditions and select few elements, sort some things, union and so on like SQL
    //winforms: to do visual C# programs
    //DLL Import, Extern, WinAPI
    //Asserts, unit testing
    //unsafe, pointers very very advanced topic
    //async, await, Task
    //MultiThreading
    //take it slow and learn
*/
}
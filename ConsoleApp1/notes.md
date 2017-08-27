### Data Types

- C# can handle three data types: floating point numbers, integer numbers, and text.

- A double is a double precision floating point number. Floats are simply numbers with decimal floats. From smallest to largest precision, we have floats(7), doubles(15), then decimal floats(29). Decimals use more space but they provide ultimate accuracy which is useful for things like currency. 

- Most programmers tend to use int and float variable types to make the programs easier to understand. Better not to fuss about the wasted memory. In ACOM, we deal with numbers that require accuracy, hence the use of decimals. 

- Choosing the right type of variable is a learned skill. Try to use floating point storage as a last resort. It lacks precision. Instead, you can represent 1.5 dollars as 150 cents.

### Section 2 Simple Data Processing

- All C# statements return a value.

- Always strive for simplicity.

##### Casting/Widening/Narrowing
- The compiler will throw an error if you try to narrow a value:
ex. int integerNumber = 1 -> float floatNumber = integerNumber

- You have to explicity cast if you want this done: float floatNumber = (float)integerNumber

- Be careful when casting values and look up the behavior if you're not sure what you end up getting.

- You can do the reverse without casting:
ex. double doubleNumber = 5.555555 -> decimal decimalNumber = doubleNumber

##### Adjusting Real Number Precision

- Placeholders can have formatting information added to them: 

```
int i = 150;
double f = 1234.56789
Console.WriteLine("i: {0:0} f: {1:0.00}, i, f");

// i: 150 f: 1234.57
```

### Section 3 Creating Programs

##### Methods

- A `static` function, unlike a regular (*instance*) function, is not associated with an instance of the class.

- a `static` class is a class which can only contain `static` members, and therefore cannot be instantiated. 

Example:

```
class ExampleClass {
    public int InstanceMethod() { return 1; }
    public static int StaticMethod() { return 42; }
}
```
- In order to cal `InstanceMethod`, you need an instance of the class:

```
ExampleClass instance = new ExampleClass();
instance.InstanceMethod(); // Fine
instance.Staticmethod(); // Won't compile

ExampleClass.InstanceMethod(); // Won't compile
ExampleClass.StaticMethod(); // Fine
```

- You can name your arguments to make your code clearer:

```
public class Program
{
	public static void Main()
	{

		var x = readValues(str2:"first string", str1:"second string");
		
		Console.WriteLine(x); // second string first string
		
	}
	
	static string readValues(string str1, string str2)
	{
		return $"{str1} {str2}";
	}
}
```

##### Pass By Value VS Pass By Reference

- Unless you specify otherwise, only the value of an argument is passed into a call to a method.

- Pass by value is safe, because nothing the method does can affect the variables in the code which calls it. However, it is a limitation when we want to create a method which returns more than one value.

- C# provides a way to reference the variable in memory instead of a new value through the `ref` keyword. This change is called a side effect of the method. 

```
static void addOneToRefParam (ref int i) 
{
    i = i + 1;
    Console.WriteLine("i is: " + 1);
}

test = 20;
addOneToRefParam(ref test);
Console.WriteLine("test is: " + test);

// i is: 21
// test is: 21 
```

##### Using the *out* keyword

```
using System;

class OutExample
{
   static void Method(out int i)
   {
      i = 44;
   }
   
   static void Main()
   {
      int value;
      Method(out value);
      Console.WriteLine(value);     // value is now 44
   }
}
```

##### Streams and Files

- A stream is a link between your program and a data resource. Data can flow up or down your stream, so that streams can be used to read and write to files. The operating system does the actual work but the C# library you are using will convert your request to use streams into instructions for the operating system.

```
StreamWrite writer;
writer = new StreamWriter("test.txt);

writer.WriteLine("hello world");

writer.Close();
```

Forgetting to close a stream is bad for a number of reasons:
- It is possible that the program may finish without the file being properly closed. Some of the data that you wrote into the file will not be there.
- Other program may not be able to use that file. It will also be impossible to move or rename the file.
- An open stream consumes a small, but significant, part of operating resource.

### Creating Solutions

- The scope of a system is a description of the things that the system is going to do and what the system is **not** going to do.

##### Enumeration and States

- Enumerated types are just lists of states. Every time that you have to hold something which can take a limited number of possible values or states, you should think of using enumerated types to hold the values.

```
enum SeaState 
{
	EmptySea,
	Attacked,
	Battleship,
};
```

##### Structures

- A collection of variables which you can treat as a single entity.

```
struct Account
{
    public AccountState State;
    public string Name;
    public string Address;
    public int AccountNumber;
    public int Balance;
    public int Overdraft;
};

Account RobsAccount;
RobsAccount.State = AccountState.Active;
RobsAccount.Balance = 1000000;
```

##### Objects and Structures

- Structures and objects are similar in that they both hold data and contain methods. However, the main difference is that structures are managed in terms of value whereas objects are managed in terms of reference.

- Reread 4.4.3 "Why Bother with References" 

##### Member Protection Inside Objects (Public vs Private)

- Consider the protected field called balance:

```
class Account
{
    private decimal balance;
}
```

- We can only change the balance through code in the class itself.

- Data members should usually be private and method members should be public.

##### Static Class Members

- A static member is a member of the class, not a member of an instance of the class.

Static data member
```
public class Account 
{
    public decimal Balance;
    public static decimal InterestRateCharged;
}
```

- Since the interest rate is the same for all accounts, we made it static. We should be careful though. A change to a static value will affect your entire system so they should always be made private and updated by means of method calls.

- Static methods are useful when creating libraries.

###### Overloading Constructors

```
public Account(string inName, string inAddress, decimal inBalance)
{
    name = inName;
    address = inAddress;
    balance = inBalance;
}

public Account (string inName, string inAddress) :
    this (inName, inAddress, 0)
{
}

public Account (string inName) :
    this (inName, "Not Supplied", 0)
{
}
```

##### 4.8.2 Components and Interfaces
- An interface specifies how a software component could be used by another software component. 

public class CustomerAccount : IAccount {
    ...
}

- IAccount is how the class implements the IAccount interface. This means that the class contains concrete versions of all the methods described in the interface. If the class does not contain a method that the interface needs you will get a compilation error.

- With interfaces, we move away from considering classes in terms of what they are, and start to think about them in terms of what they can do.

- A C# component is a class that implements an interface. 

##### 4.8.7 Designing with Interfaces

- The steps to creating a system are:

1) Gather as much metadata as you can about the problem; what is important to the customer, what values need to be represented and manipulated and the range of those values.
2) Identify classes that you will have to create to represent the components in the problem.
3) Identify the methods and properties that the components must provide.
4) Put these into interfaces for each of the components.
5) Decide how these values and actions are to be tested.

##### 4.9.2 Overriding Methods
- If you want the ability to override a method from the class you inherited from, add `virtual` to the base method and add `override` to the new class. 

- If you need to make private members visible to classes which extend the parent, you can use `protected`. 

- A better way to do this is to use the parent class's method through the keyword `base`. We can access the method like so `base.WithdrawFunds(amount)`

- Interface: lets you identify a set of behaviours (i.e. methods) which a component can be made to implement. Any component which implements the interface can be thought of in terms of a reference of that interface type. A concrete example of this would be something like IPrintHardCopy. Lots of items in my bank system will need to do this and so we could put the behaviour details into the interface for them to implement in their own way. Then our printer can just regard each of the instances that implement this interface purely in this way. Interfaces let me describe a set of behaviours which a component can implement. Once a component can implement an interface it can be regarded purely in terms of a component with this ability. Objects can implement more than one interface, allowing them to present different faces to the systems that use them.

- Abstract: lets you create a parent class which holds template information for all the classes which extend it. If you want to create a related set of items, for example all the different kinds of bank account you might need to deal with, including credit card, deposit account, current account etc. then the best way to do this is to set up a parent class which contains abstract and non-abstract methods. The child classes can make use of the methods from the parent and override the ones that need to be provided differently for that particular class.

###### 4.10 Object Etiquette
- Creating a new class actually inherits from the C# object class.

`public class Account` 

is equal to 

`public class Account : object`

##### 4.10.3 Objects and `this`
- `this` is a referenace to the current instance.

```
public class Counter 
{
    public int Data = 0l
    public void Count()
    {
        this.Data = this.Data + 1;
    }
}
```

- The compiler allows you to omit the `this` keyword in classes. You can add them if you want to be explicit that we are using a member of a class rather than a local variable.

##### 4.11 Strings and chars
- Strings are objects but they don't always behave like objects.

- Example:

```
string s1 = "Rob";
string s2 = s1;
s2 = "different";

// s1 === "Rob"
```

- In the above example, `s1` is still `"Rob"` because strings are immutable. This is because programmers want strings to behave like values in this respect.

- If you try to change a string, the C# system created a new string and changes the reference. This is to save memory. All the same strings can just refer to the same instance. 

##### 4.12.1 Properties as class members
```
public class Staffmember 
{
    public int Age;
}
```

- The above example is bad because we can directly set this public property. A better way to implement this would be to create a private variable and use public methods to get and set. 

##### 4.12.6 Using Delegates
- A delegate is a type safe reference to a method in a class.
- 
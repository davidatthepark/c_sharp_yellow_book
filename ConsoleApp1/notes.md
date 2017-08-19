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
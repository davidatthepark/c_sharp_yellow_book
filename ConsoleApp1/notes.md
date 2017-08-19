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
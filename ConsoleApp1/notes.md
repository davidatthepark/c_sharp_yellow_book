## Section 2 Simple Data Processing

### Casting/Widening/Narrowing
-The compiler will throw an error if you try to narrow a value:
ex. int integerNumber = 1 -> float floatNumber = integerNumber

-You have to explicity cast if you want this done: float floatNumber = (float)integerNumber

-Be careful when casting values and look up the behavior if you're not sure what you end up getting.

-You can do the reverse without casting:
ex. double doubleNumber = 5.555555 -> decimal decimalNumber = doubleNumber


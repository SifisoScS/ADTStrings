# ADT Strings

## Overview

The `AbstractString` class provides an abstract representation of strings, enhancing the standard C way of handling strings. Key features include:

1. **Constructor**: Initializes an instance of `AbstractString` with an initial value.
2. **Concatenation Method**: Allows concatenating two abstract strings.
3. **Length Property**: Retrieves the length of the abstract string.
4. **ToString Override**: Returns the underlying string value.

Additionally, the project includes `UTStrings`, which are utility functions for working with strings:

- **`utstrdup(const char* src)`**:
  - Creates a `UTString` on the heap that holds a copy of the source string.
  - Sets the length, capacity, and other properties appropriately.
  - Returns a pointer to the `UTString`.

- **`uint32_t utstrlen(const UTString* src)`**:
  - Analogous to the C standard library function `strlen`.
  - Calculates the length of the `UTString`.

## Goals

The primary goals of this project are to create a robust and efficient ADT for handling strings, ensuring proper memory management, and providing useful string manipulation functions.

## Getting Started

1. Clone this repository.
2. Explore the `AbstractString.cs` file for the ADT implementation.
3. Check out the `UTStrings.cs` file for utility functions.

## Usage

```csharp
// Initialize a string variable s1 with the value "Hello Developers"
string s1 = "Hello Developers";

// Create a character array c1 with specific characters
char[] c1 = new char[] { 'S', 'i', 'f', 'i', 's', 'o', ' ', 'S', 'h', 'e', 'z', 'i' };

// Create a new string s2 by converting the character array c1
string s2 = new string(c1);

// Concatenate s2 to s1
s1 += s2;
Console.WriteLine($"Concatenated string: {s1}");

// Convert s2 to uppercase
s2 = s2.ToUpper();
Console.WriteLine($"Uppercase string: {s2}");

// Convert s2 to lowercase
s2 = s2.ToLower();
Console.WriteLine($"Lowercase string: {s2}");
```

## Testing

Ensure thorough testing of the ADT Strings and UTStrings. Write unit tests to cover different scenarios.

---

Feel free to explore the project and contribute if you'd like! 🚀
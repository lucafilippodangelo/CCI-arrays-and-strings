# Arrays and Strings 

## 1.1 Is Unique: 
Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures? 
SOLUTION:
- Different approaches implemented
  - Nested For
  - Bit Vector
  - Hash Table
- Added Unit Tests project "1.1_Is_Unique_UT"

USEFUL LINKS:
- difference between ASCII and UNICODE http://www.differencebetween.net/technology/software-technology/difference-between-unicode-and-ascii/

## 1.2 Check Permutations: 
Given two strings, write a method to decide if one is a permutation of the other.
Note: permutation means same caracters but in different order.

SOLUTION:
- In order to check if the two strings were identical I had two approaches
  - Loop in the one input string and use a dictionary to store cardinality of key values, loop in the second string and decrease from the dictionary the occurrences. If at the end of the loops the dictionary is empty we have permutation.
  - Convert the string in "CharArray", sort the two arrays, convert the to array in strings and compare if they are identical.
- Added Unit Tests project "1.2 Check Permutation_UT"

## 1.3 URLify:
Write a method to replace all spaces in the input string with '__'
Note: the suggestion whe manipulating strings is to edit the string starting from the end and working backwards

SOLUTION:
- In my approach I did use a char[], gave it the new dimension and played with the index.
- Added Unit Tests project "1.3 URLify_UT"

## 1.4 Check if Permutation of Palindrome:
Given an input string, write a function to check if it is a permutation of a palindrome.
Note: A palindrome is a word or phrase that is the same forwards and backwards. A permutation is a rearrangment of letters.

EXAMPLE Palindrome, the word is the same forward and backwards:
- madam
- racecar

EXAMPLE Permutation of "abc":
- abc
- acb
- bac
- bca
- cba
- cab

EXAMPLE this is a permutation of a palindrome:
the given string "tactcoapapa" is a palindrome permutation, because is composed by:
- #2 "t"
- #2 "c"
- #2 "p"
- #4 "a"
- #1 "o" -> only one odd

SOLUTION:
- EASY: use an array big as the alphabet to count how many time each character appears, then iterate through the hash table and ensure that at most just one character has odd count.
- ELEGANT: Using bit manipulation. We don't need to know the count, it's enough to know if the count is even or odd. 
The idea is to flip a toggle on or off each time the state change. Whe can't know how many flips but we will know if at the end we have an odd count
- Added Unit Tests project "1.4 Palindrome and Permutation_UT"

Useful:
- Find all the permutations of a given string: https://www.geeksforgeeks.org/write-a-c-program-to-print-all-permutations-of-a-given-string/
  - https://www.calculator.net/binary-calculator.html
  - Bit Shift http://etutorials.org/cert/java+certification/Chapter+3.+Operators+and+Assignments/3.14+Shift+Operators+lt+lt+gt/
  - https://www.webucator.com/blog/2010/12/net-framework-using-the-bitvector32-structure/
  - Bit Manipulation http://www.anotherchris.net/csharp/csharp-bit-manipulation-by-example-part-2/
  - https://www.i-programmer.info/programming/c/1281-c-bit-bashing-the-bitconverter.html
  - https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/operators/left-shift-operator
  
## 1.5 One Way:
Considering the possibility to add, remove or edit a character in strings. Given two input strings write a method to check if they are max one edit away.

Example: 
- pale, ple -> true
- pales, pale -> true
- pale, bale -> true
- pale, bae -> false

SOLUTION:
- Code commented. To recap on this, we play within a while loop with two indexes. Incrementing one index when difference found. When second difference found if Index is already different, second difference found. 

## 1.6 String Compression:
Write a method to perform string compression using the count of repeated characters. For example "aabcccccaaa" become "a2b1c5a3".
If the new string is not smaller than the original one, the method should return the original string.

SOLUTION:
- It's a boring solution, a for loop where within we look to the next char, if the same we increment a count of the consecutive. When a difference in place we build part of the new string with specific char and occurrency.
  - In demo the solution implemented is the second presented by the book.

## 1.7:
Write a method to replace all spaces in the input string with '__'
Note: the suggestion whe manipulating strings is to edit the string starting from the end and working backwards

SOLUTION:
- In my approach I did use a char[], gave it the new dimension and played with the index.
- Added Unit Tests project "1.3 URLify_UT"

## 1.8:
Write a method to replace all spaces in the input string with '__'
Note: the suggestion whe manipulating strings is to edit the string starting from the end and working backwards

SOLUTION:
- In my approach I did use a char[], gave it the new dimension and played with the index.
- Added Unit Tests project "1.3 URLify_UT"

## 1.9:
Write a method to replace all spaces in the input string with '__'
Note: the suggestion whe manipulating strings is to edit the string starting from the end and working backwards

SOLUTION:
- In my approach I did use a char[], gave it the new dimension and played with the index.
- Added Unit Tests project "1.3 URLify_UT"
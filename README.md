# Arrays and Strings 

## 1.1 Is Unique: 
Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures? 
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
- In order to check if the two strings were identical I had two approaches
  - Loop in the one input string and use a dictionary to store cardinality of key values, loop in the second string and decrease from the dictionary the occurrences. If at the end of the loops the dictionary is empty we have permutation.
  - Convert the string in "CharArray", sort the two arrays, convert the to array in strings and compare if they are identical.
- Added Unit Tests project "1.2 Check Permutation_UT"

## 1.3 URLify:
Write a method to replace all spaces in the input string with '__'
Note: the suggestion whe manipulating strings is to edit the string starting from the end and working backwards
- In my approach I did use a char[], gave it the new dimension and played with the index.
- Added Unit Tests project "1.3 URLify_UT"



- 
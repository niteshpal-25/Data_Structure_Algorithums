**1. Problem: Write a function to reverse an array in-place (without using extra space).**

Example:

Input: [1, 2, 3, 4, 5]
Output: [5, 4, 3, 2, 1]
Constraints:

You must reverse the array without using any extra array.

Try to solve it in O(n) time.

Bonus: Solve it for both even and odd-length arrays.

**2. Problem: Write a function to find the second largest element in a given array.**

Example:

Input: [12, 35, 1, 10, 34, 1]
Output: 34
Constraints:

Do not sort the array.

Handle duplicate values (e.g., if the largest occurs multiple times, second largest should be different).

Edge Cases to Consider:

**3. Problem: Given a string that contains alphabets and non-alphabet characters (like -, /, etc.), reverse only the alphabetic characters, and keep all non-alphabetic characters in their original positions.**

Example:

Input: "a-bcd"
Output: "d-cba"

Input: "ab-c/de!"
Output: "ed-c/ba!"

Constraints:

You must reverse only letters.

Non-letter characters (like -, /, !) must stay in the same position.
Try to solve it in O(n) time with O(1) extra space if possible.

Edge Cases to Consider:

What if the string has no letters?
What if the string has all non-alphabetic characters?
What if the string is empty?

What if all elements are the same?
What if the array has only one element?

**4 Description Inserting an element at a specific index in an array means placing the new element at that position while shifting the existing elements to the right to make space.**

The process depends on the type of array:

Static arrays (like in C, C++): Manual shifting is required.

Dynamic arrays (like in Python, JavaScript, Java's ArrayList): Built-in functions handle shifting internally.

Array: [1, 2, 4, 5, 6]  
Index: 2  
Element to insert: 3

Output: [1, 2, 3, 4, 5, 6]

**5 Description
Deleting an element from an array involves removing the element at a specific index or by value and then shifting all subsequent elements one position to the left to fill the gap.**

Static arrays (C, C++): You must manually shift elements.

Dynamic arrays/lists (Python, JavaScript, Java's ArrayList): Built-in methods handle deletion and shifting internally.

INPUT

Array: [1, 2, 3, 4, 5]
Index to delete: 2

OUTPUT
[1, 2, 4, 5]

**6. Description
Given a string, find the first character that does not repeat and return its index. If it doesn’t exist, return -1.**

This problem tests:

Hashing (using a Array)

Time complexity optimization (target: O(n))

String traversal logic

**INPUT : "amazon" **
**OUTPUT : 0 **

**INPUT : "swiss" **
**OUTPUT : 1 **


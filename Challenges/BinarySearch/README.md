# Binary Search

## Challenge
Write a method called BinarySearch which takes in 2 parameters: a sorted array and the 
search key. Without utilizing any of the built-in methods available to your language, 
return the index of the array’s element that is equal to the search key, or -1 if the 
element does not exist.

## Approach & Efficiency

1. Big O Time = O(log n) // Big O Space = O(1)
	- The iterative approach to binary search comes with a logn time because the array is
	continually being divided in half after every comparison. Since no other space is being analyzed
	or used, it stays at O(1).

2. Big O Time O(log n) // Big O Space = O(H)
	- The recursive approach is not necessarily the "best" implementation of a binary search. The 
	search continually gets divided in half after each comparison. The space increases because every time
	 the recursive method is called, it adds a new frame to the stack, making the space O(H), H 
	 representing a new frame on the call stack. 

## Solution

![Whiteboard Image]()

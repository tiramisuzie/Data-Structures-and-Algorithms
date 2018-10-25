# FIFO (first in, first out)
## Challenge
First-in, First out Animal Shelter. Create a class called AnimalShelter which holds only dogs and cats. The shelter operates using a first-in, first-out approach.
Implemented the following methods:
enqueue(animal): adds animal to the shelter. animal can be either a dog or a cat object.
dequeue(pref): returns either a dog or a cat. If pref, a string, is ‘cat’ return the longest-waiting cat. If pref is ‘dog’, return the longest-waiting dog. For anything else, return either a cat or a dog.

## Approach & Efficiency
Enqueue()

Space complexity: O(n)
Time complexity: O(1)
Dequeue()

Space complexity: O(1)
Time complexity: O(n)
## Whiteboard
![whiteboard challenge 11](/Challenges/animalShelter/assets/challenge11.jpg)

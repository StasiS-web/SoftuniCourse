// 1. sort() method sorts the elements of an array in place and returns 
// the reference to the same array, now sorted. The default sort order is ascending, 
// built upon converting the elements into strings, then comparing their sequences of UTF-16 code units values.

const months = ['March', 'Jan', 'Feb', 'Dec'];
months.sort();
console.log(months);
// expected output: Array ["Dec", "Feb", "Jan", "March"]

const numbers2 = [4, 2, 5, 1, 3];
numbers2.sort((a, b) => a - b);
console.log(numbers2);
// expected output: [1, 2, 3, 4, 5]

// 2. shift() method removes the first element from an array and returns that removed element. 
// This method changes the length of the array. shift() method removes the element at the zeroth index 
// and shifts the values at consecutive indexes down, then returns the removed value. 
// If the length property is 0, undefined is returned.

const array1 = [1, 2, 3, 4, 5, 6];
const firstElement = array1.shift();
console.log(array1);
// expected output: Array [2, 3, 4, 5, 6]
console.log(firstElement);
// expected output: 1

// 3. map() method creates a new array populated with the results of calling a provided function 
// on every element in the calling array.

const arr = [1, 4, 9, 16];
// pass a function to map
const map1 = arr.map(x => x * 2);
console.log(map1);
// expected output: Array [2, 8, 18, 32]

// 4. some() method tests whether at least one element in the array passes the test implemented
// by the provided function. It returns true if, in the array, it finds an element for which 
// the provided function returns true; otherwise it returns false. It doesn't modify the array.

const array = [1, 2, 3, 4, 5];
// checks whether an element is even
const even = (element) => element % 2 === 0;
console.log(array.some(even));
// expected output: true

// 5. slice() method returns a shallow copy of a portion of an array into a new array 
// object selected from start to end (end not included) where start and end represent 
// the index of items in that array. The original array will not be modified.
// Syntax: slice(); slice(start); slice(start, end)

const animals = ['ant', 'bison', 'camel', 'duck', 'elephant'];
console.log(animals.slice(2));
// expected output: Array ["camel", "duck", "elephant"]
console.log(animals.slice(2, 4));
// expected output: Array ["camel", "duck"]
console.log(animals.slice(1, 5));
// expected output: Array ["bison", "camel", "duck", "elephant"]
console.log(animals.slice(-2));
// expected output: Array ["duck", "elephant"]
console.log(animals.slice(2, -1));
// expected output: Array ["camel", "duck"]
console.log(animals.slice());
// expected output: Array ["ant", "bison", "camel", "duck", "elephant"]

// 6. reduce() method executes a user-supplied "reducer" callback function on each element 
// of the array, in order, passing in the return value from the calculation on the preceding element. 
// The final result of running the reducer across all elements of the array is a single value.

const array2 = [1, 2, 3, 4];
// 0 + 1 + 2 + 3 + 4
const initialValue = 0;
const sumWithInitial = array1.reduce(
  (previousValue, currentValue) => previousValue + currentValue,
  initialValue
);
console.log(sumWithInitial);
// expected output: 10

// 7. filter() method creates a shallow copy of a portion of a given array, filtered down to just 
// the elements from the given array that pass the test implemented by the provided function.

const words = ['spray', 'limit', 'elite', 'exuberant', 'destruction', 'present'];
const result = words.filter(word => word.length > 6);
console.log(result);
// expected output: Array ["exuberant", "destruction", "present"]

// 8. The map() method creates a new array populated with the results of calling
// a provided function on every element in the calling array.map calls a provided callbackFn 
// function once for each element in an array, in order, and constructs a new array from the results.

const array3 = [1, 4, 9, 16];
// pass a function to map
const map = array3.map(x => x * 2);
console.log(map);
// expected output: Array [2, 8, 18, 32]
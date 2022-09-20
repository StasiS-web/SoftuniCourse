// 1. localeCompare() method returns a number indicating whether 
// a reference string comes before, or after, or is the same as 
// the given string in sort order. 

const a = 'réservé'; // with accents, lowercase
const b = 'RESERVE'; // no accents, uppercase
console.log(a.localeCompare(b));
// expected output: 1

// Numeric sorting  by default, "2" > "10"
console.log("2".localeCompare("10")); // 1

// 2. charAt() method returns a new string consisting 
// of the single UTF-16 code unit located at the specified offset into the string.
// Characters in a string are indexed from left to right. 
// The index of the first character is 0, and the index of the last character—in a string 
// called stringName—is stringName.length - 1. If the index you supply is out of this range, 
// JavaScript returns an empty string.

const sentence = 'The quick brown fox jumps over the lazy dog.';
const index = 4;
console.log(`The character at index ${index} is ${sentence.charAt(index)}`);
// expected output: "The character at index 4 is q"

// 3. concat() method concatenates the string arguments to the calling string and returns a new string.

const str1 = 'Hello';
const str2 = 'World';

console.log(str1.concat(', ', str2));
// expected output: "Hello, World"

// 4. indexOf() method, given one argument: a substring to search for, searches the entire calling string, 
// and returns the index of the first occurrence of the specified substring. Given a second argument: 
// a number, the method returns the first occurrence of the specified substring at an index greater than 
// or equal to the specified number.

const paragraph = 'The quick brown fox jumps over the lazy dog. If the dog barked, was it really lazy?';
const searchTerm = 'dog';
const indexOfFirst = paragraph.indexOf(searchTerm);

console.log(`The index of the first "${searchTerm}" from the beginning is ${indexOfFirst}`);
// expected output: "The index of the first "dog" from the beginning is 40"
console.log(`The index of the 2nd "${searchTerm}" is ${paragraph.indexOf(searchTerm, (indexOfFirst + 1))}`);
// expected output: "The index of the 2nd "dog" is 52"
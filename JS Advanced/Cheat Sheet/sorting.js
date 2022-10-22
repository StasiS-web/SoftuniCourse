// sorting collection in several ways
const students = [
            { name:'Maria', age: 22, enrolledDate: 'Dec 12, 2021' },
            { name: 'John', age: 32, enrolledDate: 'Aug 15, 2010' },
            { name: 'Ann', age: 13, enrolledDate: 'Oct 16, 2010' },
            { name: 'Peter', age: 15, enrolledDate: 'Jul 1, 2018' }
    ];
      
students.sort((a,b) => a.age - b.age);  // sorting by age in ascending
students.sort((a,b) => b.age - a.age); // sorting  by age in descending order
students.sort((a,b) => a.name.localeCompare(b.name)); // sorting alphabetically by name

// sort the students array by name property case-insensitively in ascending, 
// pass the compare function that compares two strings case-insensitively 
students.sort(function(x, y) {
     let a = x.name.toUpperCase(), 
     b = y.name.toLowerCase();

     return a == b ? 0 : a > b ? 1 : -1;
});

// sorting by comparing two valid date in ascending
students.sort(function(x,y) {
     let a = new Date(x.enrolledDate),
     b = new Date(y.enrolledDate);
});

console.table(students);

// EXAMPLE 2
// sort the name by its length
// temporary array holds objects with position and length of element
let names = ['Maria', 'John', 'Ann','Peter'] 
var lengths = names.map(function(e, i) {
    return { index: i, value: e.length };
});

// sorting the lengths array containing the lengths of students names
lengths.sort(function(a, b){
    return +(a.value > b.value) || +(a.value === b.value) - 1;
});

// copy element back to the array
var sortedNames = lengths.map(function(e) {
    return names[e.index];
});

console.log(sortedNames)

// sorting by using compare function multiple times for each element in the array.
names.sort(function(a,b){
    console.log(a,b);
    return a.length - b.length;
});

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

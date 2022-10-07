// 1. NodeList objects are collections of nodes, usually returned by properties such as Node.childNodes 
// and methods such as document.querySelectorAll(). Although they are both considered NodeList objects,
// there are 2 varieties of NodeList: live and static.

const parent = document.getElementById('parent');
let childNodes = parent.childNodes;
console.log(childNodes.length); // let's assume "2"
parent.appendChild(document.createElement('div'));
console.log(childNodes.length); // outputs "3"

// 2. The HTMLCollection interface represents a generic collection (array-like object similar to arguments) 
// of elements (in document order) and offers methods and properties for selecting from the list. 
// An HTMLCollection in the HTML DOM is live; it is automatically updated when the underlying document is changed. 
// For this reason it is a good idea to make a copy (e.g., using Array.from) to iterate over if adding, moving, or removing nodes.
// HTMLCollection.item() - Returns the specific node at the given zero-based index into the list. 
// Returns null if the index is out of range.
// An alternative to accessing collection[i] (which instead returns undefined when i is out-of-bounds). 
//This is mostly useful for non-JavaScript DOM implementations.
// HTMLCollection.namedItem() - Returns the specific node whose ID or, as a fallback, name matches the string specified by name. 
// Matching by name is only done as a last resort, only in HTML, and only if the referenced element supports the name attribute. 
// Returns null if no node exists by the given name. An alternative to accessing collection[name] 
// (which instead returns undefined when name does not exist). This is mostly useful for non-JavaScript DOM implementations.

let elem1, elem2;
// document.forms is an HTMLCollection
elem1 = document.forms[0];
elem2 = document.forms.item(0);

alert(elem1 === elem2); // shows: "true"
elem1 = document.forms.myForm;
elem2 = document.forms.namedItem("myForm");
alert(elem1 === elem2); // shows: "true"
elem1 = document.forms["named.item.with.periods"];


// works by adding a function, or an object that implements EventListener, 
// to the list of event listeners for the specified event type on the EventTarget 
// on which it's called. If the function or object is already in the list of event listeners for this target, the function or object is not added a second time.

// Different ways to implement internal functions
/*variant 1*/
input.addEventListener("click", changeEvent);
function changeEvent (event){
    // TODO: function logic here
}

/*variant 2*/
input.addEventListener("click", changeEvent);
let changeEvent = function () {
    // TODO: function logic here
}

/*variant 3*/
input.addEventListener("click", () => {
     // TODO: function logic here
});
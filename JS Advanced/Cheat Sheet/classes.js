// This method makes loading of the products in the store
vegetables.forEach(product => { // for each element in the array contains information about vegetable 
    let [type, quantity, price] = product.split(" ");   // separate the products info by space
    quantity = Number(quantity); // using in several places so requires to be parsed as Number
    price = Number(price); // requires to be parsed as Number

    let currVegies = this.availableProducts.find(v => v.type === type); // find current vegetable 

    // check if already exists in the availableProducts array
    if (!currVegies) { // if does not exist add the vegetable with its info
         this.availableProducts.push({
              type,
              quantity,
              price
         });
     }
     else {  // if already present in the array add the new quantity to the old one and update the old price 
          currVegies.quantity += quantity;
                
          if(currVegies.price < price) { 
              currVegies.price = price;
          }
    }
});

// 1. export one or multiple objects

module.exports = Cat;

module.exports = {
    Cat,
    Dog
};

class Cat {
    name;
    age;
}

class Dog {
    name;
    age;
}

// 2. constructor and methods in a class

class Cat {
    constructor(name, age) {
        super(true);  // inherits constructor from base class 

        this.name = name;
        this.age = age;
    }

    // getter and setter of properties
    get name () {
        return  this._name;
    }   
    
    set name (value) {
        if (value.lenght < 3) 
        {
            throw new Error('Cat name cannot be have less than 3 letters.');
        }

        this._name = value;
    }

    get age (){
        return this._age;
    }

    set age (value) {
        if (value < 0 ) {
            return 'Cat age must not be a negative number.'
        }

        return this._age = value;
    }

    // two ways to write methods
    mew = () => {  // normal function is throwing error
        return `${this.name}: Meow`;
    }

    mew () {  // is throwing error and it need to be used a .call
        return `${this.name}: Meow`;
    }
}

// the static methods can be called only from the class
// #identifier for private data that does not have to be touched 
// because something could break

class Person {
    constructor(firstName, lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    getFullName() {
        return this.firstName + ' ' + this.lastName;
    }
}

// 3. Attributes for html DOM elements. Sets the value of an attribute on the specified element. 
// If the attribute already exists, the value is updated; otherwise a 
// new attribute is added with the specified name and value.

<button>Hello World</button>
const button = document.querySelector("button");
button.setAttribute("name", "helloButton");
button.setAttribute("disabled", "");

// 4. The getAttribute() method of the Element interface returns the value
// of a specified attribute on the element. If the given attribute does not exist, 
// the value returned will either be null or "" (the empty string); 

//-- example div in an HTML DOC 
<div id="div1">Hi Champ!</div>

// in a console
const div1 = document.getElementById('div1');
//=> <div id="div1">Hi Champ!</div>

const exampleAttr= div1.getAttribute('id');
//=> "div1"

const align = div1.getAttribute('align')
//=> null

// 5. The Element.hasAttribute() method returns a Boolean value indicating whether 
// the specified element has the specified attribute or not.

const foo = document.getElementById("foo");
if (foo.hasAttribute("bar")) {
    // do something
}

// 6. The Element method removeAttribute() removes the attribute with the specified 
// name from the element. You should use removeAttribute() instead of setting 
// the attribute value to null either directly or using setAttribute(). 
// Many attributes will not behave as expected if you set them to null.

removeAttribute(attrName)

// 7. A WeakMap is a collection of key/value pairs whose keys must be objects, with values of any arbitrary 
// JavaScript type, and which does not create strong references to its keys. That is, an object's presence 
//as a key in a WeakMap does not prevent the object from being garbage collected. Once an object used 
// as a key has been collected, its corresponding values in any WeakMap become candidates for garbage collection 
// as well — as long as they aren't strongly referred to elsewhere.
// WeakMap allows associating data to objects in a way that doesn't prevent the key objects from being collected, 
// even if the values reference the keys. However, a WeakMap doesn't allow observing the liveness of its keys, 
// which is why it doesn't allow enumeration; if a WeakMap exposed any method to obtain a list of its keys, 
// the list would depend on the state of garbage collection, introducing non-determinism. If you want to have 
// a list of keys, you should use a Map rather than a WeakMap.

class ClearableWeakMap {
    constructor(init) {
      this._wm = new WeakMap(init);
    }
    clear() {
      this._wm = new WeakMap();
    }
    delete(k) {
      return this._wm.delete(k);
    }
    get(k) {
      return this._wm.get(k);
    }
    has(k) {
      return this._wm.has(k);
    }
    set(k, v) {
      this._wm.set(k, v);
      return this;
    }
  }

// 8. The WeakSet object lets you store weakly held objects in a collection. WeakSet objects are collections of objects. 
// Just as with Sets, each object in a WeakSet may occur only once; all objects in a WeakSet's collection are unique.
// The main differences to the Set object are:
// WeakSets are collections of objects only. They cannot contain arbitrary values of any type, as Sets can.
// The WeakSet is weak, meaning references to objects in a WeakSet are held weakly. If no other references 
// to an object stored in the WeakSet exist, those objects can be garbage collected.

// Execute a callback on everything stored inside an object
function execRecursively(fn, subject, _refs = new WeakSet()) {
    // Avoid infinite recursion
    if (_refs.has(subject)) {
      return;
    }
  
    fn(subject);
    if (typeof subject === "object") {
      _refs.add(subject);
      for (const key in subject) {
        execRecursively(fn, subject[key], _refs);
      }
    }
  }
  
  const foo1 = {
    foo: "Foo",
    bar: {
      bar: "Bar",
    },
  };
  
  foo1.bar.baz = foo1; // Circular reference!
  execRecursively((obj) => console.log(obj), foo1);

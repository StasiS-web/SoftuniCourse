 class Circle {
    constructor(radius) {
        this._radius = radius;
    }

    get radius() { 
        return this._radius;
    }

    get diameter (){
        return this._radius * 2;
    }

    set diameter (value) {
        this._radius = value / 2;
    }

    get area(){
        return Math.PI * (this.radius ** 2)
    }
}

let c = new Circle(2);
console.log(`Radius: ${c.radius}`);
console.log(`Diameter: ${c.diameter}`);
console.log(`Area: ${c.area}`);

c.diameter = 1.6;
console.log(`Radius: ${c.radius}`);
console.log(`Diameter: ${c.diameter}`);
console.log(`Area: ${c.area}`);
class Garden {
    constructor(spaceAvailable){
        this.spaceAvailable = spaceAvailable;
        this.plants = [];
        this.storage = [];
    }
 
    addPlant (plantName, spaceRequired) {
    //  If there is not enough space in the garden for the new plant throw an Error
        if(spaceRequired > this.spaceAvailable) {
            throw new Error('Not enough space in the garden.');
        }

    // Otherwise, this function should add the object plant with to the plants array, 
        let objPlants = {
            plantName,
            spaceRequired,
            ripe: false,
            quantity: 0
        }

        this.plants.push(objPlants);
        this.spaceAvailable -= spaceRequired; // reduce the space available with the space required by the plant
        
        return `The ${plantName} has been successfully planted in the garden.`
    }

    ripenPlant(plantName, quantity) {
        // If the plant is not found, throw an Error
        let currPlant = this.plants.find(p => p.plantName === plantName);

        if (!currPlant) {
            throw new Error(`There is no ${plantName} in the garden.`);
        }

        // If the plant is already ripe, throw an Error
        if(currPlant.ripe) {
            throw new Error(`The ${plantName} is already ripe.`);
        }

        // If the received quantity is less than or equal to 0, throw an Error
        if (quantity <= 0) {
            throw new Error('The quantity cannot be zero or negative.');
        }

        // Set the ripe property of the particular plant to true and add the quantity to the quantity property of the plant. 
        currPlant.ripe = true;
        currPlant.quantity = quantity;

        return quantity === 1 ?
             `${quantity} ${plantName} has successfully ripened.` :
             `${quantity} ${plantName}s have successfully ripened.`;
    }

    harvestPlant(plantName) {
        // If the plant is not found, throw an Error
        let currPlant = this.plants.find(p => p.plantName === plantName);

        if(!currPlant) {
            throw new Error(`There is no ${plantName} in the garden.`);
        }

        // If the plant is not ripe, throw an Error
        if(!currPlant.ripe) {
            throw new Error(`The ${plantName} cannot be harvested before it is ripe.`);
        }

        this.plants = this.plants.filter(p => p.plantName !== plantName); // remove the plant from the plants array
        this.storage.push({  // add it to storage with properties plantName and quantity
            plantName: currPlant.plantName, 
            quantity: currPlant.quantity
        }); 
        this.spaceAvailable += currPlant.spaceRequired;

        return `The ${plantName} has been successfully harvested.`
    }

    generateReport() {
        let result = '';
        // This method should return the complete information about the garden
        result += `The garden has ${this.spaceAvailable} free space left.\n`;

        // On the second line list all plants that are in the garden ordered alphabetically by plant name ascending 
        result += `Plants in the garden: `
        this.plants.sort((a,b) => a.plantName.localeCompare(b.plantName))
            .forEach(p => result += `${p.plantName}, `);
        result = result.substring(0, result.length - 2);
        result += `\n`;

        // If there are no plants in the storage
        if(this.storage.length === 0) {
            result += `Plants in storage: The storage is empty.`
        }
        else {  // If there are plants in the storage list them
            result += `Plants in storage: `;
            this.storage.forEach(p => result += `${p.plantName} (${p.quantity}), `);
        }
        result = result.substring(0, result.length - 2);

        return result;
    }
}

const myGarden = new Garden(250)
console.log(myGarden.addPlant('apple', 20));
console.log(myGarden.addPlant('orange', 200));
console.log(myGarden.addPlant('raspberry', 10));
console.log(myGarden.ripenPlant('apple', 10));
console.log(myGarden.ripenPlant('orange', 1));
console.log(myGarden.harvestPlant('orange'));
console.log(myGarden.generateReport());
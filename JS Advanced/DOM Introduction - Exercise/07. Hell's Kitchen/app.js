function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);
   let objRestaurants = [];

   function onClick () {
     let restaurantsInfo = JSON.parse(document.querySelector('#inputs textarea').value);
     let bestRestInfo = document.querySelector('#bestRestaurant p');
     let bestResWorker = document.querySelector('#workers p');

     for(let data of restaurantsInfo) {
         let [name, workerList] = data.split(' - ');

         if(!objRestaurants.find(r => r.name === name)) {
            objRestaurants.push({
               name,
               avgSalary: 0,
               bestSalary: 0, 
               sumSalary: 0,
               workerList: []
            });
         }

         let currRestaurant = objRestaurants.find(r => r.name === name);
         workerList = workerList && workerList.split(', ');

         for(let currWorker of workerList) {
            updateRestaurant(currRestaurant, currWorker);
         }
   }

      let sortedRestaurants = objRestaurants.sort((a, b) => b.avgSalary - a.avgSalary);
      let bestRestaurant = sortedRestaurants[0];
      bestRestInfo.textContent = `Name: ${bestRestaurant.name} Average Salary: ${bestRestaurant.avgSalary.toFixed(2)} Best Salary: ${bestRestaurant.bestSalary.toFixed(2)}`
            
      let sortedWorkerList = bestRestaurant.workerList.sort((a, b) => b.salary - a.salary);
      let workersBestRest = '';

      for (let employee of sortedWorkerList) {
         workersBestRest += `Name: ${employee.name} With Salary: ${employee.salary} `
      }

      bestResWorker.textContent += workersBestRest;
   }   

   function updateRestaurant(obj, worker) {
      let [name, salary] = worker.split(' ');
      salary = Number(salary);
      obj.sumSalary += salary;

      if(obj.bestSalary < salary) {
         obj.bestSalary = salary;
      }
      
      obj.workerList.push({
         name,
         salary
      });

      obj.avgSalary = obj.sumSalary / obj.workerList.length;
   }
}
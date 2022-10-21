'use strict';

class SmartHike {
    constructor(username) {
        this.username = username;
        this.goals = {};
        this.listOfHikes = [];
        this.resources = 100;
    }

    addGoal (peak, altitude) {
        // If the goal exists in the goals object
        if(this.goals[peak])
        {
            return `${peak} has already been added to your goals`;
        }
        else {
            this.goals[peak] = Number(altitude);
            return `You have successfully added a new goal - ${peak}`;
        }
    }

    hike (peak, time, difficultyLevel) {
        // If the peak doesn’t exist in the goals object, throw an Error
        if(!this.goals[peak]) {
            throw new Error(`${peak} is not in your current goals`);
        }

        // If the peak exists in the goals object but the resources are already 0, throw an Error
        if(this.resources === 0) {
            throw new Error("You don't have enough resources to start the hike");
        }

        // find the difference between the current resources and the time, multiplied by 10. 
        let difference = this.resources - (time * 10);
        // If the difference is a negative number
        if(difference < 0) {
            return "You don't have enough resources to complete the hike";
        }
        else {
        // Otherwise extract the used resources from all resources and add the hike to the list of hikes 
            this.resources = difference;
            this.listOfHikes.push({peak, time, difficultyLevel});

            return `You hiked ${peak} peak for ${time} hours and you have ${this.resources}% resources left`;
        }
    }

    rest (time) {
       this.resources += time * 10; // add the time for rest multiplied by 10 to the resources

        // If the resources are more than or equal to 100, set them to 100 
        if(this.resources >= 100) {
            this.resources = 100;
            return `Your resources are fully recharged. Time for hiking!`;
        }
        else {
            return `You have rested for ${time} hours and gained ${time*10}% resources`
        }
    }

    showRecord (criteria) {
        if (this.listOfHikes.length === 0) {
            return `${this.username} has not done any hiking yet`;
        }

        if(criteria === 'hard' || criteria === 'easy') {
            let filterHikes = this.listOfHikes.filter(h => h.difficultyLevel === criteria);
            filterHikes.sort((a,b) => a.time - b.time);
            let bestHike = filterHikes[0];

            if(!bestHike) {
                return `${this.username} has not done any ${criteria} hiking yet`;
            }
            else {
                return  `${this.username}'s best ${criteria} hike is ${bestHike.peak} peak, for ${bestHike.time} hours`
            }
        }
        else if (criteria === 'all') {
            let result = [
                "All hiking records:"
            ];

            this.listOfHikes.forEach(h => {
                result.push(`${this.username} hiked ${h.peak} for ${h.time} hours`);
            });
            return result.join('\n');
        }
    }
}

const user = new SmartHike('Vili');
user.addGoal('Musala', 2925);
user.hike('Musala', 8, 'hard');
console.log(user.showRecord('easy'));
user.addGoal('Vihren', 2914);
user.hike('Vihren', 4, 'hard');
console.log(user.showRecord('hard'));
user.addGoal('Rui', 1706);
user.hike('Rui', 3, 'easy');
console.log(user.showRecord('all'));
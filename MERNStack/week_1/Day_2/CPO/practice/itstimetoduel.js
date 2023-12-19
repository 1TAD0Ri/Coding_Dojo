
class Card {
    constructor(name, cost) {
        this.name = name
        this.cost = cost
    }
}

class Unit extends Card {
    constructor(name, cost, power, res) {
        super(name, cost)
        this.power = power
        this.res = res
    }
    attack(target) {
        //instanceof ya3ni il card that we are going to use is from Unit 
        if (target instanceof Unit) {
            target.res -= this.power;
            return target

        }
        
    }
    checkStat(){
        console.log(`${this.name} power: ${this.power} resillence: ${this.res}`);}
}


class Effect extends Card {
    constructor(name, cost, text, stat, magnitude) {
        super(name, cost)
        this.text = text
        this.stat = stat
        this.magnitude = magnitude
    }
    play(target) {
        if (target instanceof Unit) {
            // implement card text here
            if(this.stat==="resilience"){
                target.res+= this.magnitude

            }else{
                target.power+=this.magnitude

            }return target
        } else {
            throw new Error("Target must be a unit!");
        }
    }

}


// Create instances of the units and effects.
const Red_Belt_Ninja = new Unit("Red Belt Ninja", 3, 3, 4);
const Black_Belt_Ninja = new Unit("Black Belt Ninja", 4, 5, 4);
const Hard_Algorithm = new Effect("Hard Algorithm", 2, "increase target's resilience by 3", "res", 3);
const Unhandled_Promise_Rejection = new Effect("Unhandled Promise Rejection", 1, "reduce target's resilience by 2", "res", -2);
const Pair_Programming = new Effect("Pair Programming", 3, "increase target's power by 2", "power", 2);


// Action 1
console.log("Action 1:");
console.log("Making an instance of Red Belt Ninja.");

// Action 2
console.log("\nAction 2:");
console.log("Making an instance of Hard Algorithm and playing it on Red Belt Ninja.");
Hard_Algorithm.play(Red_Belt_Ninja);

// Action 3
console.log("\nAction 3:");
console.log("Making an instance of Black Belt Ninja.");

// Action 4
console.log("\nAction 4:");
console.log("Making an instance of Unhandled Promise Rejection and playing it on Red Belt Ninja.");
Unhandled_Promise_Rejection.play(Red_Belt_Ninja).checkStat();

// Action 5
console.log("\nAction 5:");
console.log("Making an instance of Pair Programming and playing it on Red Belt Ninja.");
Pair_Programming.play(Red_Belt_Ninja).checkStat();

// Action 6
console.log("\nAction 6:");
console.log("Red Belt Ninja attacks Black Belt Ninja.");
Red_Belt_Ninja.attack(Black_Belt_Ninja).checkStat();













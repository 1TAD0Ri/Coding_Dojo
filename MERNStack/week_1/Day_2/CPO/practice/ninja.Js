class Ninja {
    constructor(name,health,speed,strength){
        this.name=name;
        this.health=90;
        this.speed=3;
        this.strength=3;
    }

    sayName(){
        console.log(this.name);
    }

    showStats() {
        console.log(`Name: ${this.name}, Health: ${this.health}, Speed: ${this.speed}, Strength: ${this.strength}`);
    }


    drinkSake(){
        this.health+=10
    }

}


const hakkariiii = new Ninja("hakkarii");
hakkariiii.sayName(); 
hakkariiii.showStats();
hakkariiii.drinkSake();
hakkariiii.showStats();


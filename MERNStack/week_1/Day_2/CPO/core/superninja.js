// class Ninja {
//     constructor(name, health = 90, speed = 3, strength = 3) {
//         this.name = name;
//         this.health = health;
//         this.speed = speed;
//         this.strength = strength;
//     }



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


const Hakkari = new Ninja("hakkarii");
Hakkari.sayName(); 
Hakkari.showStats();
Hakkari.drinkSake();
Hakkari.showStats();

class Sensei extends Ninja{
    //the one we add and to change in the paramater of the constructor 
    constructor(name ,wisdom=10){
        super(name,200,10,10);
        this.wisdom=wisdom;

    }
    speakWisdom(){
        super.drinkSake();
        console.log("what programmer can do .....");
    }

}

const kakashiSensei = new Sensei("kakashi hatake")
kakashiSensei.speakWisdom();
kakashiSensei.showStats();





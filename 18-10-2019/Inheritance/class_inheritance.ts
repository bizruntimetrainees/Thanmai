class Animal
{
    name:string;
    constructor(thename:string)
    {
        this.name = thename;
    }
    move(distance:number=0)
    {
        console.log(this.name +  "  "+"moved"+"   "+distance);
    }

}

class Cat extends Animal
{
    constructor(name:string)
    {
        super(name);
    }
    move(distance:number = 20)
    {
        console.log("Meow..Meow...");
        super.move(distance);
    }
}

class Dog extends Animal
{
    constructor(name:string)
    {
        super(name);
    }
    move(distance:number=50)
    {
        console.log("Bow...Bow...");
        super.move(distance);
    }
}

let c = new Cat("cat");
let ad:Animal = new Dog("Dog");
c.move();
ad.move(100);
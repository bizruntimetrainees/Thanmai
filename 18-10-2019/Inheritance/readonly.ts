class Person_Name 
{
    readonly name: string;
    readonly numberOfLeg = 2;
    constructor (theName: string) {
        this.name = theName;
    }
}
let man = new Person_Name("A Person with"+"  "+this.numberOfLeg+" legs");
console.log(man);

//class as interface
console.log("class as interface....")
class Point
{
    x: number; 
    y: number;
}

interface IPoints extends Point
{
    z: number;
}

let p: IPoints = {x:10, y:20, z:30};
console.log(p);
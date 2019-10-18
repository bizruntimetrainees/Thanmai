class Person
{
    protected name: string;
    protected constructor(theName: string)
     { 
         this.name = theName;
     }
}

class Man extends Person
{
    private department: string;

    constructor(name: string, department: string) 
    {
        super(name);
        this.department = department;
    }

    public getElevatorPitch() 
    {
        return 'Hello, my name is'+ '  '+this.name+'   '+ 'and I work in' +'  '+ this.department;
    }
}

let Thanmai = new Man("Thanu", "IT");
//let Teena = new Person("John");
console.log(Thanmai);
//console.log(Teena);
// Interface as type
console.log("Interface as type.........")
interface keypair
{
key:number;
value:string;
} 

let kv1:keypair = {key:1,value :"Thanmai"};
let kv2:keypair = {key:2,value:"Teena"};
console.log(kv1);
console.log(kv2);
console.log();


//interface as type for a function
console.log("Interface as functionype.........")

interface KeyValueProcessor
{
    (key: number, value: string): void;
};

function addKeyValue(key:number, value:string):void 
{ 
    console.log('addKeyValue: key = ' + key + ', value = ' + value)
}

function updateKeyValue(key: number, value:string):void { 
    console.log('updateKeyValue: key = '+ key + ', value = ' + value)
}
    
let kvp :KeyValueProcessor = addKeyValue;
kvp(1, 'kill'); 

kvp = updateKeyValue;
kvp(2, 'will');
console.log();


//optional variable in interface
console.log("Interface optional parameters.........")

interface employee
{
    empname:string;
    empid:number;
    empdept?:string;
}
let e:employee={empname:"Thanmai",empid:100};
let e2:employee={empname:"Teena",empid:1001,empdept:"ECE"};
console.log("Optionaparameters",e);
console.log("Optionaparameter",e2);
console.log();

//implementing Interface through class
console.log("implementing Interface through class");
interface emp_details
{
    empname:string;
    empid:number;
    getsalary:(number)=>number;
}

 class Employee implements emp_details
{
    empname: string;
    empid: number;
emp_name:string;
emp_id:number;
constructor(name:string,id:number)
{
    this.emp_name = name;
    this.emp_id = id;
}
getsalary(salary:number):number
{
    return 1000;

}
}
let em = new Employee("Thanmai",1001);
console.log(em)


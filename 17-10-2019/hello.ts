function T_Name(person)
{
    return "Hello"+" "+person;
}
let user ="Thanmai";
console.log(T_Name(user));

function addsum(a,b)
{
    return a+b ;
}
var sum = addsum(50,50);
console.log("sum is:"+sum);


let first: number = 12.0;     
let n =10;        
let second: number = 0x37CF;          
let third: number = 0o377 ;            
let fourth: number = 0b111001;           
  
console.log(first);             
console.log(second);           
console.log(third);           
console.log(fourth);  
console.log(n);            


let empName: string = "Rohan";   
let empDept: string = "IT";   
  
 
let output1: string = empName + " works in the " + empDept + " department.";    
let output2: string = `${empName} works in the ${empDept} department.`;   
  
console.log(output1); 
console.log(output2);

function ProcessData(x: any, y: any) {  
    return x + y;  
}  
var result,result1: any;  
result = ProcessData("Hello ", "WORLD!!"); 
result1 = ProcessData(2, 3);
console.log(result,result1);
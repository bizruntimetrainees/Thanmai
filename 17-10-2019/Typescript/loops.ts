let num = 4;  
let factorial = 1;  
  
while(num >=1) {  
   factorial = factorial * num;  
   num--;  
}  
console.log("The factorial of the given number is: "+factorial);


let n = 10;   
do
 {   
    console.log(n);   
    n++;   
 } 
 while(n<=15)
 console.log(n);

 let myArray = [10, 20, 30, 40, 50,];  
console.log("Output of for..in loop ");  
for (let index in myArray) {  
   console.log(index);  
}  
console.log("Output of for..of loop ");  
for (let val of myArray) {  
   console.log(val);  
} 
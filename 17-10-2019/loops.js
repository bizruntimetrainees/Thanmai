var num = 4;
var factorial = 1;
while (num >= 1) {
    factorial = factorial * num;
    num--;
}
console.log("The factorial of the given number is: " + factorial);
var n = 10;
do {
    console.log(n);
    n++;
} while (n <= 15);
console.log(n);
var myArray = [10, 20, 30, 40, 50,];
console.log("Output of for..in loop ");
for (var index in myArray) {
    console.log(index);
}
console.log("Output of for..of loop ");
for (var _i = 0, myArray_1 = myArray; _i < myArray_1.length; _i++) {
    var val = myArray_1[_i];
    console.log(val);
}

function fun() {
    var X = 5;
    if (true) {
        var Y = 10; //Available globally inside f()   
        console.log(X);
        console.log(Y);
    }
    console.log(X);
    console.log(Y);
}
fun();
//console.log(X);  
//console.log(Y);
//let variable
function f(input) {
    var x = 100;
    if (input) {
        var y = x + 1;
        return y;
    }
    console.log(x);
}
//const
function constTest() {
    var VAR = 10;
    console.log("Output: " + VAR);
    var VAR2 = 100;
    console.log("Output: " + VAR2);
}
constTest();

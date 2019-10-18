var Person_Name = /** @class */ (function () {
    function Person_Name(theName) {
        this.numberOfLeg = 2;
        this.name = theName;
    }
    return Person_Name;
}());
var man = new Person_Name("A Person with" + "  " + this.numberOfLeg + " legs");
console.log(man);
//class as interface
console.log("class as interface....");
var Point = /** @class */ (function () {
    function Point() {
    }
    return Point;
}());
var p = { x: 10, y: 20, z: 30 };
console.log(p);

var CaluculateSalary;
(function (CaluculateSalary) {
    function salary(fee, term) {
        return fee * term;
    }
    CaluculateSalary.salary = salary;
})(CaluculateSalary || (CaluculateSalary = {}));
/// <reference path = "namespace.ts" />
let s = CaluculateSalary.salary(100, 20);
console.log("Output: " + s);

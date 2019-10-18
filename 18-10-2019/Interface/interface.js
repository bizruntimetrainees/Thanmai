// Interface as type
console.log("Interface as type.........");
var kv1 = { key: 1, value: "Thanmai" };
var kv2 = { key: 2, value: "Teena" };
console.log(kv1);
console.log(kv2);
console.log();
//interface as type for a function
console.log("Interface as functionype.........");
;
function addKeyValue(key, value) {
    console.log('addKeyValue: key = ' + key + ', value = ' + value);
}
function updateKeyValue(key, value) {
    console.log('updateKeyValue: key = ' + key + ', value = ' + value);
}
var kvp = addKeyValue;
kvp(1, 'kill');
kvp = updateKeyValue;
kvp(2, 'will');
console.log();
//optional variable in interface
console.log("Interface optional parameters.........");
var e = { empname: "Thanmai", empid: 100 };
var e2 = { empname: "Teena", empid: 1001, empdept: "ECE" };
console.log("Optionaparameters", e);
console.log("Optionaparameter", e2);
console.log();
//implementing Interface through class
console.log("implementing Interface through class");
var Employee = /** @class */ (function () {
    function Employee(name, id) {
        this.emp_name = name;
        this.emp_id = id;
    }
    Employee.prototype.getsalary = function (salary) {
        return 1000;
    };
    return Employee;
}());
var em = new Employee("Thanmai", 1001);
console.log(em);

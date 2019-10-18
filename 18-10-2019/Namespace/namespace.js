var CaluculateSalary;
(function (CaluculateSalary) {
    function salary(fee, term) {
        return fee * term;
    }
    CaluculateSalary.salary = salary;
})(CaluculateSalary || (CaluculateSalary = {}));

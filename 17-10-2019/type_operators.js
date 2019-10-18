var Bike = { make: 'Honda', model: 'CLIQ', year: 2018 };
console.log('make' in Bike);
var Bike2 = { Company1: 'Honda',
    Company2: 'Hero',
    Company3: 'Royal Enfield'
};
delete Bike2.Company1;
console.log(Bike2);
var message = "Welcome to " + "JavaTpoint";
console.log(typeof message);
var arr = [1, 2, 3];
console.log(arr instanceof Array);
console.log(arr instanceof String);

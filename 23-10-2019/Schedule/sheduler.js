"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
var observable = new rxjs_1.Observable(function (observer) {
    observer.next(1);
    observer.next(2);
    observer.next(3);
    observer.complete();
}).pipe(operators_1.observeOn(rxjs_1.asyncScheduler));
observable.subscribe({
    next: function (x) {
        console.log('got value ' + x);
    }
});
console.log('just before subscribe');
console.log('just after subscribe');

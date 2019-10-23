"use strict";
//only the last value of the Observable execution is sent to its observers, 
//and only when the execution completes.
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var subject = new rxjs_1.AsyncSubject();
subject.subscribe({
    next: function (v) { return console.log('observerA: ' + v); }
});
subject.next(1);
subject.next(2);
subject.next(3);
subject.next(4);
subject.subscribe({
    next: function (v) { return console.log('observerB: ' + v); }
});
subject.next(5);
subject.complete();

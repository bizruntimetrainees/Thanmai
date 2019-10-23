"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
// it can send old values to new subscribers, 
//but it can also record a part of the Observable execution.
//When creating a ReplaySubject, you can specify how many values to replay:
var subject = new rxjs_1.ReplaySubject(2); // buffer 3 values for new subscribers
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

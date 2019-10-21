"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
var observable = new rxjs_1.Observable(function subscribe(subscriber) {
    // Keep track of the interval resource
    var intervalId = setInterval(function () {
        subscriber.next('hi');
    }, 1000);
    // Provide a way of canceling and disposing the interval resource
    return function unsubscribe() {
        clearInterval(intervalId);
    };
});
function subscribe(subscriber) {
    var intervalId = setInterval(function () {
        subscriber.next('hi');
    }, 1000);
    return function unsubscribe() {
        clearInterval(intervalId);
    };
}
var unsubscribe = subscribe({ next: function (x) { return console.log(x); } });
unsubscribe();

"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
require("rxjs/aoperator/from");
function multiplyByTen(input) {
    var output = rxjs_1.Observable.create(function subscribe(observer) {
        input.subscribe({
            next: function (v) { return observer.next(10 * v); },
            error: function (err) { return observer.error(err); },
            complete: function () { return observer.complete(); }
        });
    });
    return output;
}
var input = rxjs_1.Observable.from([1, 2, 3, 4]);
var output = multiplyByTen(input);
output.subscribe(function (x) { return console.log(x); });

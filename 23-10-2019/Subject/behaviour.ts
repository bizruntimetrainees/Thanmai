// It stores the latest value emitted to its consumers, and whenever a new Observer subscribes, 
//it will immediately receive the "current value" from the BehaviorSubject.

import {BehaviorSubject} from "rxjs";

var subject = new BehaviorSubject(0); 

subject.subscribe({
  next: (v) => console.log('observerA: ' + v)
});

subject.next(1);
subject.next(2);

subject.subscribe({
  next: (v) => console.log('observerB: ' + v)
});

subject.next(3);

import { Observable } from 'rxjs';
     
const foo = new Observable(subscriber => {
  console.log('Hello');
  subscriber.next(42);
  subscriber.next(100);
  subscriber.next(200);
  setTimeout(() => {
    subscriber.next(300); // happens asynchronously
  }, 1000);
});
 
console.log('before');
foo.subscribe(x => {
  console.log(x);
});
console.log('after');


const observable = new Observable(function subscribe(subscriber) {
    subscriber.next(1);
    subscriber.next(2);
    subscriber.next(3);
    subscriber.complete();
    subscriber.next(4); // Is not delivered because it would violate the contract
  });
  observable.subscribe(x => {
    console.log(x);
  });
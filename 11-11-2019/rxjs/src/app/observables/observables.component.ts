import { Component, OnInit } from '@angular/core';
import  {fromEvent,timer,of} from 'rxjs';


@Component({
  selector: 'app-observables',
  templateUrl: './observables.component.html',
  styleUrls: ['./observables.component.css']
})
export class ObservablesComponent implements OnInit {

  constructor() { }

  ngOnInit()
  {
    const interval$ = timer(3000,1000);
    interval$.subscribe(val=>console.log("stream 1 =>"+val));
   
     const click$ =fromEvent(document,'click');
     click$.subscribe(evt=>console.log(evt));


     const myObservable = of(1, 2, 3);
     const myObserver = 
     {
 
      next: x => console.log('Observer got a next value: ' + x),
      error: err => console.error('Observer got an error: ' + err),
      complete: () => console.log('Observer got a complete notification'),
     };

    myObservable.subscribe(myObserver);
  
  }

}

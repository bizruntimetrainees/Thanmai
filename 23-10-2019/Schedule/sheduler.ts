    import { Observable, asyncScheduler } from 'rxjs';
    import { observeOn } from 'rxjs/operators';
     
    const observable = new Observable((observer) => {
      observer.next(1);
      observer.next(2);
      observer.next(3);
      observer.complete();
    }).pipe(
      observeOn(asyncScheduler)
    );
    observable.subscribe({
        next(x) {
          console.log('got value ' + x)
        },
     
      });
    console.log('just before subscribe');
    console.log('just after subscribe');
  

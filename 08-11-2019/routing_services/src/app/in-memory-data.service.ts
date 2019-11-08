import { Injectable } from '@angular/core';
import { Hero } from './hero';
import { InMemoryDbService } from 'angular-in-memory-web-api';

@Injectable({
  providedIn: 'root'
})
export class InMemoryDataService  implements InMemoryDbService
 {
  createDb()
  {
    const heroes = [
      { id: 101, name: 'Thanmai' },
      { id: 102, name: 'Kiranmai' },
      { id: 103, name: 'Jyothirmai' },
      { id: 104, name: 'Karan' },
      { id: 105, name: 'Chinmai' },
      { id: 106, name: 'Sunitha' },
      { id: 107, name: 'Diya' },
      { id: 108, name: 'Ramani'},
      { id: 109, name: 'Megha' },
      { id: 110, name: 'Taruni' }
    ];
    return {heroes};
  }

  constructor() { }
}

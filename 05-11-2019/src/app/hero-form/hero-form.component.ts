import { Component } from '@angular/core';

import { Hero }    from '../hero';

@Component({
  selector: 'app-hero-form',
  templateUrl: './hero-form.component.html',
  styleUrls: ['./hero-form.component.css']
})
export class HeroFormComponent 
{

  powers = ['Smart Actor', 'Fighter','Entertainer', 'DialogKing'];

  model = new Hero(1, 'Prabhas','JubliHills', this.powers[3] );

  submitted = false;

  onSubmit() 
  {
     this.submitted = true;
  }

  showFormControls(form: any) 
  {
    return form 
    &&form.controls['name'].value
 
  }



}

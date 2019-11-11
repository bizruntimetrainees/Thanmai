import { Component } from '@angular/core';
import {MatChipInputEvent} from '@angular/material/chips';
import {COMMA, ENTER} from '@angular/cdk/keycodes';

export interface Skill{
  name: string;
}
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent
 {
  title = 'TabsButtons';
  visible = true;
  selectable = true;
  removable = true;
  addOnBlur = true;
  readonly separatorKeysCodes: number[] = [ENTER, COMMA];
  skills: Skill[] = [ {name: 'c++'},{name: 'C#'},{name: 'java'}, ];

  add(event: MatChipInputEvent): void
   {
    const input = event.input;
    const value = event.value;

    // Add our fruit
    if ((value || '').trim())
    {
      this.skills.push({name: value.trim()});
    }

    // Reset the input value
    if (input)
    {
      input.value = '';
    }
  }

  remove(skill: Skill): void
   {
    const index = this.skills.indexOf(skill);

    if (index >= 0)
    { 
       this.skills.splice(index, 1);
    }
  }
 }

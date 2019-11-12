import { Component, OnInit } from '@angular/core';
import  {fromEvent} from 'rxjs';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.css']
})
export class AboutComponent implements OnInit
{

  constructor() { }

  ngOnInit()
  {
    document.addEventListener('click',evt =>
    {
      console.log(evt);
      setTimeout(()=>
      {
        console.log("Finished...");
        let counter =0
    
              setInterval(()=>
               {
                console.log(counter);
                counter++
               },1000);
      },3000);
    })


    

   
  }

}

import { Component, OnInit, } from '@angular/core';


@Component({
  selector: 'app-tabs',
  templateUrl: './tabs.component.html',
  styleUrls: ['./tabs.component.css']
})
export class TabsComponent implements OnInit {

  selected ={"value":0}
  
  tabs = [{"tabName":"CRUD","data":["GET","POST","POST FROM DATA","PUT","PATCH","DELETE"]},
          {"tabName":"Headers","data":["RequestHeader","ResponseHeader"]},
          {"tabName":"Authentication","data":["BasicAuth"]},
        ]
        SelectedTab(event){
          console.log(event)
        }
  constructor() { }

  ngOnInit() {
  }

}

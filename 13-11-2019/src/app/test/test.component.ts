import { Component, OnInit, Input } from '@angular/core';
import { FormControl } from '@angular/forms';


@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {

  selected = new FormControl(0);
  @Input() data;

  constructor() { }
  selectedButton(name) {
    console.log(name)
  }
  ngOnInit() {
  }

}

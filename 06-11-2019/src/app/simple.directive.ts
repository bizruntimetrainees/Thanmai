import { Directive,ElementRef,Input, OnInit, HostListener } from '@angular/core';

@Directive({
  selector: '[appSimple]'
})
export class SimpleDirective implements OnInit {
@Input() foreColor:string;
@Input() bgColor:string;
@HostListener('mouseenter') onMouseEnter()
{
this.el.nativeElement.style.color = this.foreColor;
this.el.nativeElement.style.backgroundColor = this.bgColor;
}
@HostListener('mouseleave') onmouseleave()
{
this.el.nativeElement.style.color = null;
    this.el.nativeElement.style.backgroundColor = null;
}


 constructor(private el:ElementRef) 
  {
    console.log("Custom dirctive Simple loaded as appSimple");
    console.log(this.el);
    
  }
  ngOnInit()
  {
    
  }

}

  



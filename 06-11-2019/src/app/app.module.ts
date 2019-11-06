import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { SimpleDirective } from './simple.directive';
import { PipeComponent } from './pipe/pipe.component';
import { DecimalPrecessionDirective } from './decimal-precession.directive';

@NgModule({
  declarations: [
    AppComponent,
    SimpleDirective,
    PipeComponent,
    DecimalPrecessionDirective,
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

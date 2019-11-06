import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MatSliderModule} from '@angular/material/slider';
import {MatButtonModule,
  MatCheckboxModule,
  MatFormFieldModule,
  MatInputModule,
  MatAutocompleteModule, } from '@angular/material';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ReactiveFormsModule, FormsModule } from '@angular/forms'

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule, 
     MatSliderModule,
     MatButtonModule,
     MatCheckboxModule,
     MatFormFieldModule,
     MatInputModule,
     MatAutocompleteModule,
     ReactiveFormsModule,
     FormsModule



  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

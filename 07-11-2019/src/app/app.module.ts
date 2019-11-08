import {NgModule} from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {MatButtonModule,MatFormFieldModule,MatAutocompleteModule} from '@angular/material';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ReactiveFormsModule, FormsModule } from '@angular/forms'
import {MatCheckboxModule} from '@angular/material/checkbox';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatNativeDateModule, MatRippleModule} from '@angular/material/core';
import {MatInputModule} from '@angular/material/input'; 
import {MatRadioModule} from '@angular/material/radio'; 
import {MatSlideToggleModule} from '@angular/material/slide-toggle'; 
import {MatMenuModule} from '@angular/material/menu'; 
import {MatSidenavModule} from '@angular/material/sidenav'; 


@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule ,ReactiveFormsModule, FormsModule,
    MatButtonModule,MatFormFieldModule,MatAutocompleteModule,
    MatCheckboxModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatRippleModule,
    MatInputModule,
    MatRadioModule,
    MatSlideToggleModule,
    MatMenuModule,
    MatSidenavModule,
    
  ],
    
  
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule 
{
  //sidenav-open
  opened = false;
 }

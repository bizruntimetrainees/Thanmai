import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatButtonModule} from '@angular/material/button';
import { MatCardModule} from '@angular/material/card';
import {MatDividerModule} from '@angular/material/divider'; 
import {MatListModule} from '@angular/material/list'; 
import {MatExpansionModule} from '@angular/material/expansion'; 
import {MatGridListModule} from '@angular/material/grid-list'; 
import {MatStepperModule} from '@angular/material/stepper'; 
import {MatIconModule} from '@angular/material/icon'; 
import {MatTabsModule} from '@angular/material/tabs'; 
import {MatTreeModule} from '@angular/material/tree'; 
import {MatButtonToggleModule} from '@angular/material/button-toggle'; 
import {MatBadgeModule} from '@angular/material/badge'; 
import {MatChipsModule} from '@angular/material/chips'; 
import {MatFormFieldModule} from '@angular/material/form-field'; 
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner'; 
import {MatProgressBarModule} from '@angular/material/progress-bar'; 
import {MatCheckboxModule} from '@angular/material/checkbox'; 

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatCardModule,
    MatDividerModule,
    MatListModule,
    MatExpansionModule,
    MatGridListModule,
    MatStepperModule,
    MatButtonModule,
    MatTabsModule,
    MatIconModule,
    MatTreeModule,
    MatButtonToggleModule,
    MatBadgeModule,
    MatChipsModule,
    MatFormFieldModule,
    MatProgressSpinnerModule,
    MatProgressBarModule,
    MatCheckboxModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

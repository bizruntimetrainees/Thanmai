import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { PaginatorComponent } from './paginator/paginator.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatButtonModule,MatFormFieldModule,MatAutocompleteModule} from '@angular/material';
import { ReactiveFormsModule, FormsModule } from '@angular/forms'
import {MatCheckboxModule} from '@angular/material/checkbox';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatNativeDateModule, MatRippleModule} from '@angular/material/core';
import {MatInputModule} from '@angular/material/input'; 
import {MatRadioModule} from '@angular/material/radio'; 
import {MatSlideToggleModule} from '@angular/material/slide-toggle'; 
import {MatMenuModule} from '@angular/material/menu'; 
import {MatSidenavModule} from '@angular/material/sidenav'; 
import {MatToolbarModule} from '@angular/material/toolbar'; 
import {MatPaginatorModule} from '@angular/material/paginator';
import { SortheaderComponent } from './sortheader/sortheader.component'; 
import {MatSortModule} from '@angular/material/sort';
import { TableComponent } from './table/table.component'; 
import {MatTableModule} from '@angular/material/table';
import { TooltipComponent } from './tooltip/tooltip.component'; 
import {MatTooltipModule} from '@angular/material/tooltip';
import { SnackbarComponent } from './snackbar/snackbar.component'; 
import {MatSnackBarModule} from '@angular/material/snack-bar'; 


import {MatIconModule} from '@angular/material/icon'; 

@NgModule({
  declarations: [
    AppComponent,
    PaginatorComponent,
    SortheaderComponent,
    TableComponent,
    TooltipComponent,
    SnackbarComponent
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
    MatToolbarModule,
    MatPaginatorModule,MatSortModule,
    MatTableModule,MatTooltipModule,MatSnackBarModule
    ,MatIconModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

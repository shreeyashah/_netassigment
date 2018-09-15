import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { FetchEmployeeComponent } from './components/fetchemployee/fetchemployee.component';
import { createemployee } from './components/addemployee/addemployee.component';
import { CommonModule } from '@angular/common';
import { HttpModule } from '@angular/http';
import { EmployeeService } from './Services/empservice.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    FetchEmployeeComponent,
    createemployee
  ],
  imports: [
    BrowserModule,

    CommonModule,

    HttpModule,

    FormsModule,

    ReactiveFormsModule,

    RouterModule.forRoot([

      { path: '', redirectTo: 'home', pathMatch: 'full' },

      { path: 'home', component: HomeComponent },

      { path: 'fetch-employee', component: FetchEmployeeComponent },

      { path: 'register-employee', component: createemployee },

      { path: 'employee/edit/:id', component: createemployee },

      { path: '**', redirectTo: 'home' }

    ])  
  ],
  providers: [EmployeeService],
  bootstrap: [AppComponent]  
  
})
export class AppModule { }

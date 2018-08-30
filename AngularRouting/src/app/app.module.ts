

import { BrowserModule } from '@angular/platform-browser';

import {FormsModule} from '@angular/forms';

import { NgModule } from '@angular/core';

import {RouterModule} from '@angular/router';

import {HttpModule} from '@angular/http';



import { AppComponent } from './app.component';

import { FirstPage } from './Home/Home.component';
import { EmployeeFetch } from './Employee/Employee.service';
import { EmployeeList } from './Employee/Employee-list.component';
import { EmployeeDetails } from './Employee/Employee.component';


@NgModule({

  declarations: [

    AppComponent,

    EmployeeDetails,

    EmployeeList,

    FirstPage

  ],

  imports: [

    BrowserModule,

     HttpModule,

                RouterModule.forRoot([{path:'list',component:EmployeeList},

                {path:'Home',component:FirstPage},

                {path:'',redirectTo:'Home',pathMatch:'full'},

                {path:'registration',component:EmployeeDetails}]),



    FormsModule

  ],

  providers: [EmployeeFetch],

  bootstrap: [AppComponent]

})

export class AppModule { }
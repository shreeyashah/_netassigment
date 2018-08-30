import{Component} from '@angular/core';

import {Router } from '@angular/router';

import{EmployeeFetch}from './Employee.service';

@Component({
    templateUrl:'./Employee-list.component.html'
})
export class EmployeeList{
    data:any=[];

    arr:any;

    constructor(private router:Router,

        private Service:EmployeeFetch){}



    deleteFieldValue(index:any):void {

        console.log(index);

        this.data.splice(index, 1);

    }

           ngOnInit(): void {               

                this.data=this.Service.getData();



                console.log(this.data);

    }
}
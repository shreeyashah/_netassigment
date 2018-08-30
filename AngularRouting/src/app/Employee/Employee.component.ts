import { Component,OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import {EmployeeFetch}from './Employee.service'
import { Employee } from './Employee.module';

@Component({

    templateUrl: './Employee.component.html'

})

export class EmployeeDetails implements OnInit {

     constructor(private router:Router,

        private Service:EmployeeFetch) { }

    qualifications :string [];

    experiences :string [];

    languages:string [];

    lang:string[];

    data:any;  

    model:any;

    i:number;      

    





ngOnInit()

{

    this.qualifications =['B.tech','M.tech','MBA','BCA'];

    this.experiences =['Fresher','Less than 5 years','More than 5 years'];

    this.languages=['C/C++','Java','C#','PHP','python'];

    this.model=new Employee('','','','','','','','','','',false,false,false,false,false,this.lang);

    this.lang=[];

    

}

show():void{

      this.i=0;

      if(this.model.C == true)

      {

        this.lang[this.i]=this.languages[0];

        this.i = this.i+1;

      }

      if(this.model.Java == true)

      {

        this.lang[this.i]=this.languages[1];

        this.i = this.i+1;

      }

      if(this.model.CSharp == true)

      {

        this.lang[this.i]=this.languages[2];

        this.i = this.i+1;

      }

      if(this.model.Php == true)

      {

        this.lang[this.i]=this.languages[3];

        this.i = this.i+1;

      }

      if(this.model.Python == true)

      {

        this.lang[this.i]=this.languages[4];

        this.i = this.i+1;

      }

      this.model.languages=this.lang;

      this.data=this.model;

      this.Service.setData(this.data);

      this.router.navigate(['/list']);

      

}



 



}
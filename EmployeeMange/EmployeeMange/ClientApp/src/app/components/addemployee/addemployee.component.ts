import { Component, OnInit } from '@angular/core';

import { Http, Headers } from '@angular/http';

import { NgForm, FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';

import { Router, ActivatedRoute } from '@angular/router';

import { FetchEmployeeComponent } from '../fetchemployee/fetchemployee.component';

import { EmployeeService } from '../../Services/empservice.service';



@Component({
  selector: 'register-employee',

  templateUrl: './addEmployee.component.html'

})



export class createemployee implements OnInit {

  employeeForm: FormGroup;

  title: string = "Create";

  employeeId: number;

  errorMessage: any;

  departmentList: Array<Department> = [];


  constructor(private _fb: FormBuilder, private _avRoute: ActivatedRoute,

    private _employeeService: EmployeeService, private _router: Router) {

    if (this._avRoute.snapshot.params["id"]) {

      this.employeeId = this._avRoute.snapshot.params["id"];

    }



    this.employeeForm = this._fb.group({

      employeeId: 0,
      firstName: ['', [Validators.required]],
      lastName: ['', [Validators.required]],

      contactNumber: ['', [Validators.required]],
      address: ['', [Validators.required]],

      gender: ['', [Validators.required]],
      qualification: ['', [Validators.required]],
      department: ['', [Validators.required]],

    })

  }



  ngOnInit() {



    this._employeeService.getDepartmentList().subscribe
      (

      data => {
        this.departmentList = data
         // console.log(this.departmentList)
      }

    )



    if (this.employeeId > 0) {

      this.title = "Edit";

      this._employeeService.getEmployeeById(this.employeeId)

        .subscribe(resp => this.employeeForm.setValue(resp)

          , error => this.errorMessage = error);

    }



  }



  save() {



    if (!this.employeeForm.valid) {

      return;

    }



    if (this.title == "Create") {

      this._employeeService.saveEmployee(this.employeeForm.value)

        .subscribe((data) => {

          this._router.navigate(['/fetch-employee']);

        }, error => this.errorMessage = error)

    }

    else if (this.title == "Edit") {

      this._employeeService.updateEmployee(this.employeeForm.value)

        .subscribe((data) => {

          this._router.navigate(['/fetch-employee']);

        }, error => this.errorMessage = error)

    }

  }



  cancel() {

    this._router.navigate(['/fetch-employee']);

  }



  get firstName() { return this.employeeForm.get('firstName'); }
  get lastName() { return this.employeeForm.get('lastName'); }
  get contactNumber() { return this.employeeForm.get('contactNumber'); }
  get address() { return this.employeeForm.get('address'); }
  get gender() { return this.employeeForm.get('gender'); }
  get qualification() { return this.employeeForm.get('qualification'); }
  get department() { return this.employeeForm.get('department'); }

}

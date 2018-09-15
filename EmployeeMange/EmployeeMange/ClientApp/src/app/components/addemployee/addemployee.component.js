"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var createemployee = /** @class */ (function () {
    function createemployee(_fb, _avRoute, _employeeService, _router) {
        this._fb = _fb;
        this._avRoute = _avRoute;
        this._employeeService = _employeeService;
        this._router = _router;
        this.title = "Create";
        this.departmentList = [];
        if (this._avRoute.snapshot.params["id"]) {
            this.employeeId = this._avRoute.snapshot.params["id"];
        }
        this.employeeForm = this._fb.group({
            employeeId: 0,
            firstName: ['', [forms_1.Validators.required]],
            lastName: ['', [forms_1.Validators.required]],
            contactNumber: ['', [forms_1.Validators.required]],
            address: ['', [forms_1.Validators.required]],
            gender: ['', [forms_1.Validators.required]],
            qualification: ['', [forms_1.Validators.required]],
            department: ['', [forms_1.Validators.required]],
        });
    }
    createemployee.prototype.ngOnInit = function () {
        var _this = this;
        this._employeeService.getDepartmentList().subscribe(function (data) {
            _this.departmentList = data;
            // console.log(this.departmentList)
        });
        if (this.employeeId > 0) {
            this.title = "Edit";
            this._employeeService.getEmployeeById(this.employeeId)
                .subscribe(function (resp) { return _this.employeeForm.setValue(resp); }, function (error) { return _this.errorMessage = error; });
        }
    };
    createemployee.prototype.save = function () {
        var _this = this;
        if (!this.employeeForm.valid) {
            return;
        }
        if (this.title == "Create") {
            this._employeeService.saveEmployee(this.employeeForm.value)
                .subscribe(function (data) {
                _this._router.navigate(['/fetch-employee']);
            }, function (error) { return _this.errorMessage = error; });
        }
        else if (this.title == "Edit") {
            this._employeeService.updateEmployee(this.employeeForm.value)
                .subscribe(function (data) {
                _this._router.navigate(['/fetch-employee']);
            }, function (error) { return _this.errorMessage = error; });
        }
    };
    createemployee.prototype.cancel = function () {
        this._router.navigate(['/fetch-employee']);
    };
    Object.defineProperty(createemployee.prototype, "firstName", {
        get: function () { return this.employeeForm.get('firstName'); },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(createemployee.prototype, "lastName", {
        get: function () { return this.employeeForm.get('lastName'); },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(createemployee.prototype, "contactNumber", {
        get: function () { return this.employeeForm.get('contactNumber'); },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(createemployee.prototype, "address", {
        get: function () { return this.employeeForm.get('address'); },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(createemployee.prototype, "gender", {
        get: function () { return this.employeeForm.get('gender'); },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(createemployee.prototype, "qualification", {
        get: function () { return this.employeeForm.get('qualification'); },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(createemployee.prototype, "department", {
        get: function () { return this.employeeForm.get('department'); },
        enumerable: true,
        configurable: true
    });
    createemployee = __decorate([
        core_1.Component({
            selector: 'register-employee',
            templateUrl: './addEmployee.component.html'
        })
    ], createemployee);
    return createemployee;
}());
exports.createemployee = createemployee;
//# sourceMappingURL=addemployee.component.js.map
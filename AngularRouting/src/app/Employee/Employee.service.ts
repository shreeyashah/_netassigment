import {Injectable} from '@angular/core';


@Injectable()

export class EmployeeFetch
{

constructor()
{

}

    data:any = [];

    array:any;

    value:any;

    setData(data:any)
    {

        this.data.push(data);



    }

    getData():any{

        return this.data;

        

    }

    getvalue():any{

        return this.value;

    }

    setvalue(data:any){

        this.value=data;

    }



}
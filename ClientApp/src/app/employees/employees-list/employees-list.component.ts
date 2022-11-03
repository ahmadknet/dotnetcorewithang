import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html'
})

export class EmployeesListComponent  {
  public employeelist: EmployeeList[] = [];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    
    http.get<EmployeeList[]>(baseUrl + 'employees').subscribe(result => {
      console.log(result)
      this.employeelist = result
    },
      error => {
        console.error(error)
      }
    );

  }
}



interface EmployeeList {
  id: string;
  name: string;
  email: string;
  phone: string;
  salary: string;
  department: string;
}

      
        
       

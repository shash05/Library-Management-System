import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root',
})
export class StudentService {
  readonly APIUrl = 'http://localhost:4206/api';
  constructor(private http: HttpClient) {}

  login(val: any) {
    return this.http.post(this.APIUrl + '/Auth/login', val);
  }
  register(val: any) {
    return this.http.post(this.APIUrl + '/Auth/register', val);
  }
  studentId(val: any) {
    return this.http.get<any>(this.APIUrl + '/Student/StudentId?name=' + val);
  }

  books(val: any) {
    return this.http.post(this.APIUrl + '/Student/GetBookList', val);
  }

  placeOrder(val: any) {
    return this.http.post(this.APIUrl + '/Student/PlaceOrder', val);
  }

  orderDetails(val: any) {
    return this.http.post(this.APIUrl + '/Student/GetOrderDetails', val);
  }

  returnOrder(val: any) {
    return this.http.post(this.APIUrl + '/Student/ReturnBook', val);
  }
}
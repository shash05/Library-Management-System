import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, observable } from 'rxjs';
import { ThisReceiver, ThrowStmt } from '@angular/compiler';

@Injectable({
  providedIn: 'root',
})
export class AdminService {
  readonly APIUrl = 'http://localhost:4206/api';

  constructor(private http: HttpClient) {}

  viewBooks(): Observable<any[]> {
    return this.http.get<any>(this.APIUrl + '/admin');
  }

  getOrders(): Observable<any[]> {
    return this.http.get<any>(this.APIUrl + '/admin/GetAllOrders');
  }

  addBooks(val:any){
    return this.http.post(this.APIUrl+'/admin',val);
  }
}

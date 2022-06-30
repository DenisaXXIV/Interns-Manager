import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { Admin } from '../Model/admin.model';

@Injectable({
  providedIn: 'root'
})
export class AdminServiceService {

  readonly baseUrl = 'http://localhost:7124'
  readonly httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
      'Response-Type': 'application/json',
      'Data-Type': 'text'
    }),
  }

  constructor(private http: HttpClient) { }

  getAdmins(): Observable<Admin[]> {
    return this.http.get<Admin[]>(this.baseUrl + "/Admin", this.httpOptions);
  }

  getAdmin(adminID: number): Observable<Admin> {
    return this.http.get<Admin>(this.baseUrl + "/Admin/" + adminID, this.httpOptions);
  }

  addAdmin(admin: Admin) {

    let jsonAdmin = JSON.stringify(admin)

    return this.http.post(this.baseUrl + "/Admin/create", jsonAdmin, this.httpOptions);
  }

  verifyPassword(password:string) : Observable<any>{
    return this.http.put(`${this.baseUrl}/verify/password`,password, this.httpOptions);
  }

  verifyUsername(username: string) : Observable<any>{
    return this.http.put(`${this.baseUrl}/verify/username`,username, this.httpOptions);
  }

  deleteAdmin(admin: Admin) {
    return this.http.delete(`${this.baseUrl}/Admin/delete/${admin.idAdmin}`, this.httpOptions);
  }

  editAdmin(id: number, admin: Admin) {
    return this.http.put(this.baseUrl + "/Admin/update/" + id, admin, this.httpOptions);
  }
}

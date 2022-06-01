
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { Intern } from '../Model/intern.model';

@Injectable({
  providedIn: 'root'
})
export class InternServiceService {

  readonly baseUrl = 'http://localhost:7169'
  readonly httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
      'Response-Type': 'application/json',
      'Data-Type': 'text'
    }),
  }

  constructor(private http: HttpClient) { }

  getInterns(): Observable<Intern[]> {
    return this.http.get<Intern[]>(this.baseUrl + "/Intern", this.httpOptions);
  }

  getIntern(internID: string): Observable<Intern> {
    return this.http.get<Intern>(this.baseUrl + "/Intern/" + internID, this.httpOptions);
  }

  addIntern(intern: Intern) {

    let jsonIntern = JSON.stringify(intern)

    return this.http.post(this.baseUrl + "/Intern/create", jsonIntern, this.httpOptions);
  }

  deleteIntern(intern: Intern) {
    let jsonNoteID = JSON.stringify(intern.id)
    // return this.http.delete(this.baseUrl + '/Notes/Delete/' + jsonNoteID, this.httpOptions);
    return this.http.delete(`${this.baseUrl}/Intern/delete/${intern.id}`, this.httpOptions);
  }

  editIntern(id: string, intern: Intern) {
    return this.http.put(this.baseUrl + "/Intern/update" + id, intern, this.httpOptions);
  }

}

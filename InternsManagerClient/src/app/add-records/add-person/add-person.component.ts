import { Component, OnInit } from '@angular/core';
import { Person } from 'src/app/Model/person.model';
import { PersonServiceService } from 'src/app/Services/person-service.service';
import { AddPageComponent } from '../add-page/add-page.component';

@Component({
  selector: 'add-person',
  templateUrl: './add-person.component.html',
  styleUrls: ['./add-person.component.scss']
})
export class AddPersonComponent implements OnInit {
  inputName: string = '';
  inputDateOfBirth: string = '';
  inputGender: string = '';
  inputPicPath: string = '';
  
  constructor(private service: PersonServiceService, private page: AddPageComponent) { }

  ngOnChanges(): void {
    this.ngOnInit();
  }

  ngOnInit(): void {
  }

  addPerson() {
    let person: Person = {
      idPerson: 0,
      name: this.inputName,
      dateOfBirth: this.inputDateOfBirth,
      gender: this.inputGender,
      picPath: this.inputPicPath
    }
    this.service.addPerson(person).subscribe();
    this.ngOnChanges()
    this.page.ngOnChanges();
  }

}

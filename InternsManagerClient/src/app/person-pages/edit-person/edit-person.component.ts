import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs/internal/Subscription';
import { Intern } from 'src/app/Model/intern.model';
import { Internship } from 'src/app/Model/internship.model';
import { Person } from 'src/app/Model/person.model';
import { InternServiceService } from 'src/app/Services/intern-service.service';
import { InternshipServiceService } from 'src/app/Services/internship-service.service';
import { PersonServiceService } from 'src/app/Services/person-service.service';

@Component({
  selector: 'app-edit-person',
  templateUrl: './edit-person.component.html',
  styleUrls: ['./edit-person.component.scss']
})
export class EditPersonComponent implements OnInit {

  inputName: string = '';
  inputDateOfBirth: string = '';
  inputGender: string = '';
  inputPicPath: string = '';
  intern!: Intern;
  person!: Person;

  constructor(private serviceIntern: InternServiceService, private servicePerson: PersonServiceService,
    private serviceInternship: InternshipServiceService,
    private router: Router,
    private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.activatedRoute.params.subscribe(params => {
      this.serviceIntern.getIntern(params["idIntern"]).subscribe(intern => this.intern = intern);
    });

    this.servicePerson.getPerson(this.intern.idPerson).subscribe(person => this.person = person);
  }

  ngOnChanges(): void {
    this.ngOnInit();
  }



  editPerson() {
    let person: Person = {
      idPerson: 0,
      name: this.inputName,
      dateOfBirth: this.inputDateOfBirth,
      gender: this.inputGender,
      picPath: this.inputPicPath
    }
    this.servicePerson.editPerson(this.intern.idPerson,person).subscribe();
    this.ngOnChanges()
  }

}

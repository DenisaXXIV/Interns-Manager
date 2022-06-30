import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs/internal/Subscription';
import { Intern } from 'src/app/Model/intern.model';
import { Internship } from 'src/app/Model/internship.model';
import { Person } from 'src/app/Model/person.model';
import { InternServiceService } from 'src/app/Services/intern-service.service';
import { InternshipServiceService } from 'src/app/Services/internship-service.service';
import { PersonServiceService } from 'src/app/Services/person-service.service';

@Component({
  selector: 'app-add-intern',
  templateUrl: './add-intern.component.html',
  styleUrls: ['./add-intern.component.scss']
})
export class AddInternComponent implements OnInit {

  thisPerson!: Person;
  public set setthisPerson(value: Person)
  {
    this.thisPerson=value;
  }
  thisInternship!: Internship;
  vacationDays!: number;
  listPersons: Person[] = [];
  listInternships: Internship[] = [];
  getPersonsSub: Subscription = new Subscription;
  getInternshipSub: Subscription = new Subscription;

  constructor(private serviceIntern: InternServiceService, private servicePerson: PersonServiceService,
    private serviceInternship: InternshipServiceService) { }

  ngOnInit(): void {
    this.getPersonsSub = this.servicePerson.getPersons().subscribe((listPersons) => { this.listPersons = listPersons });
    this.getInternshipSub = this.serviceInternship.getInternships().subscribe((listInternships) => { this.listInternships = listInternships });

  }

  ngOnChanges(): void {
    this.ngOnInit();
  }


  addIntern() {
    let intern: Intern = {
      idIntern: 0,
      idInternship: this.thisInternship.idInternship,
      idPerson: this.thisPerson.idPerson,
      vacationDays: this.vacationDays
    }

    this.serviceIntern.addIntern(intern).subscribe();
    this.ngOnChanges();
  }

}

import { Component, ElementRef, OnInit, Renderer2, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs/internal/Subscription';
import { Intern } from 'src/app/Model/intern.model';
import { Internship } from 'src/app/Model/internship.model';
import { Person } from 'src/app/Model/person.model';
import { InternServiceService } from 'src/app/Services/intern-service.service';
import { InternshipServiceService } from 'src/app/Services/internship-service.service';
import { PersonServiceService } from 'src/app/Services/person-service.service';

@Component({
  selector: 'internCard',
  templateUrl: './intern-card.component.html',
  styleUrls: ['./intern-card.component.scss']
})
export class InternCardComponent implements OnInit {

  interns: Intern[] = [];
  persons: Person[] = [];
  internships: Internship[] = [];
  getPersonsSub: Subscription = new Subscription;
  getInternsSub: Subscription = new Subscription;
  getInternshipsSub: Subscription = new Subscription;
  sources: string[] = [];

  constructor(private internService: InternServiceService,
    private personService: PersonServiceService,
    private internshipService: InternshipServiceService) { }

  ngOnChanges(): void {
    this.getPersonsSub = this.personService.getPersons().subscribe((persons) => { this.persons = persons });
    this.getInternshipsSub = this.internshipService.getInternships().subscribe((internships) => { this.internships = internships });
    this.getInternsSub = this.internService.getInterns().subscribe((interns) => { this.interns = interns });
  }

  ngOnInit(): void {
    this.getPersonsSub = this.personService.getPersons().subscribe((persons) => { this.persons = persons });
    this.getInternshipsSub = this.internshipService.getInternships().subscribe((internships) => { this.internships = internships });
    this.getInternsSub = this.internService.getInterns().subscribe((interns) => { this.interns = interns });
  }

  deleteIntern(intern: Intern) {
    this.internService.deleteIntern(intern).subscribe();

    this.ngOnChanges();
  }

  public getAge(birthday: string): number {
    const today = new Date();
    let birthdayDate = new Date(birthday);

    return today.getFullYear() - birthdayDate.getFullYear();
  }

  public getInternshipId(intern: Intern): number {
    for (var index = 0; index < this.internships.length; index++) {
      if (this.internships[index].idInternship == intern.idInternship)
        return index;
    }
    return 1;

  }


  public getPersonId(intern: Intern): number {
    for (var index = 0; index < this.persons.length; index++) {
      if (this.persons[index].idPerson == intern.idPerson)
        return index;
    }
    return 1;

  }

}


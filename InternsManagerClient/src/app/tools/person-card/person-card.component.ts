import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs/internal/Subscription';
import { Admin } from 'src/app/Model/admin.model';
import { Person } from 'src/app/Model/person.model';
import { AdminServiceService } from 'src/app/Services/admin-service.service';
import { PersonServiceService } from 'src/app/Services/person-service.service';

@Component({
  selector: 'personCard',
  templateUrl: './person-card.component.html',
  styleUrls: ['./person-card.component.scss']
})
export class PersonCardComponent implements OnInit {
  persons: Person[] = [];
  admins: Admin[] = [];
  getPersonsSub: Subscription = new Subscription;
  getAdminsSub: Subscription = new Subscription;
  sources: string[] = [];

  constructor(private personService: PersonServiceService, private adminService: AdminServiceService) { }

  ngOnChanges(): void {
    this.ngOnInit();
  }

  ngOnInit(): void {
    this.getPersonsSub = this.personService.getPersons().subscribe((persons) => { this.persons = persons });
    this.getAdminsSub = this.adminService.getAdmins().subscribe((admins) => { this.admins = admins});
  }

  deletePerson(person: Person) {
    this.personService.deletePerson(person).subscribe();
    this.ngOnChanges();
  }

  public getAge(birthday: string): number {
    const today = new Date();
    let birthdayDate = new Date(birthday);

    return today.getFullYear() - birthdayDate.getFullYear();
  }

}

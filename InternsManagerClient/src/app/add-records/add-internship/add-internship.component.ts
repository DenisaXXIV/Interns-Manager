import { Component, OnInit } from '@angular/core';
import { Internship } from 'src/app/Model/internship.model';
import { InternshipServiceService } from 'src/app/Services/internship-service.service';
import { AddPageComponent } from '../add-page/add-page.component';

@Component({
  selector: 'add-internship',
  templateUrl: './add-internship.component.html',
  styleUrls: ['./add-internship.component.scss']
})
export class AddInternshipComponent implements OnInit {
  inputName: string = '';
  inputStartDate: any;
  inputEndDate: any;
  start: any;
  inputSalaryBRUT: string = '';
  inputPosition: string = '';
  Positions: string[] = ['Software Engineer Intern', 'QA Intern', 'Web Develover Intern', 'Junior Programmer Intern',
    'Intern', 'Cloud Support Intern', 'Tester Intern', 'Data Engineer Intern', 'Mobile Developer Intern',
    'Full Stack Developer Intern'];
  constructor(private service: InternshipServiceService, private page: AddPageComponent) { }

  ngOnInit(): void {
    this.start = new Date();
  }

  ngOnChanges(): void {
    this.ngOnInit();
  }

  addInternship() {
    let internship: Internship = {
      idInternship: 0,
      name: this.inputName,
      startDate: <string>this.inputStartDate,
      endDate: <string>this.inputEndDate,
      salaryBRUT: <string>this.inputSalaryBRUT,
      position: this.inputPosition
    }

    this.service.addInternship(internship).subscribe();
    this.ngOnChanges();
    this.page.ngOnChanges();
  }


}

import { Component, OnInit } from '@angular/core';
import { Intern } from 'src/app/Model/intern.model';
import { InternServiceService } from 'src/app/Services/intern-service.service';

@Component({
  selector: 'app-add-intern',
  templateUrl: './add-intern.component.html',
  styleUrls: ['./add-intern.component.scss']
})
export class AddInternComponent implements OnInit {

  inputName: string = '';
  inputDateOfBirth: string = '';
  inputGender: string = '';
  thisAge : any;
  ages: any[] = [16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65]
  
  constructor(private service:InternServiceService) { }

  ngOnInit(): void {
  }

  addIntern(){
    let intern: Intern = {
      id: '',
      name: this.inputName,
      age: this.thisAge,
      dateOfBirth: this.inputDateOfBirth,
      gender: this.inputGender
    }
    this.service.addIntern(intern).subscribe();
  }

}

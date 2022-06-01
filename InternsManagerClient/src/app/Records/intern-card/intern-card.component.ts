import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs/internal/Subscription';
import { Intern } from 'src/app/Model/intern.model';
import { InternServiceService } from 'src/app/Services/intern-service.service';

@Component({
  selector: 'internCard',
  templateUrl: './intern-card.component.html',
  styleUrls: ['./intern-card.component.scss']
})
export class InternCardComponent implements OnInit {

  interns: Intern[] = [];
  getInternsSub: Subscription = new Subscription;
  sources: string[] = [];

  constructor(private service: InternServiceService,
    private router: Router) { }

  ngOnChanges(): void {
    this.getInternsSub = this.service.getInterns().subscribe((interns) => { this.interns = interns });
  }

  ngOnInit(): void {
    this.getInternsSub = this.service.getInterns().subscribe((interns) => { this.interns = interns });
  }

  deleteIntern(intern: Intern) {
    this.service.deleteIntern(intern).subscribe();

    this.ngOnChanges();
  }

  private changeAspect() {
    for (let index = 0; index < this.interns.length; index++) {
      if (this.interns[index].gender == 'F') {
        this.sources[index] = "../../../assets/Female.png";
      }
      else {
        this.sources[index] = "../../../assets/Male.png";
      }
    }
  }

}

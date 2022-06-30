import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/tools/guard/auth.service';
import { SecurityService } from 'src/app/Services/security.service';

@Component({
  selector: 'logIn',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.scss']
})
export class LogInComponent implements OnInit {

  username:string ='';
  password:string = '';

  ngOnInit(): void {
  }

  @ViewChild('closeModal') closeModal!: ElementRef;

  constructor(private authService: SecurityService){}

  login(username: string,password:string) {
    this.authService.login(username,password)
      .subscribe(res => {
        if (res.success) {
          this.closeModal.nativeElement.click();
        }
      });
  }

}

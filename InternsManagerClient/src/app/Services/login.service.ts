import { Injectable } from '@angular/core';
import { AdminServiceService } from './admin-service.service';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(private service: AdminServiceService) { }

  public LogIn(username: string, password: string): boolean
  {
    if(this.service.verifyUsername(username) == this.service.verifyPassword(password))
    {
      return true;
    }
    return false;
  }
}

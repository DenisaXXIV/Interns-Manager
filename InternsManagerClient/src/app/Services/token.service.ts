import { Injectable} from '@angular/core';
import {JwtHelperService} from '@auth0/angular-jwt'
import { Token } from '../Model/token.model';

@Injectable({
  providedIn: 'root'
})
export class TokenService {

  constructor(private jwtHelper:JwtHelperService) 
  { 
  }

  public getToken():string | null
  {
    console.log(localStorage.getItem('accessToken'));
    return localStorage.getItem('accessToken');
  }


  public getTokenObject():Token
  {
    let tokenCoded:string = localStorage.getItem("accessToken") as string;

    let userId:number = this.jwtHelper.decodeToken(tokenCoded)["IdUser"] as number;
    let role:string = this.jwtHelper.decodeToken(tokenCoded)["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"];

    let token:Token = new Token(userId,role);
    
    return token;
  }
}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { AppUser } from '../models/appuser.model';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  baseUrl = environment.apiUrl;
  constructor(private http:HttpClient) { 
}

//Register the user
registerUser(userToRegister:AppUser){
  return this.http.post(this.baseUrl + "Account/Register", userToRegister);
}


}

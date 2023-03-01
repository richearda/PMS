import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { RegisterUserDto } from '../dto/command/registeruser.dto';
import { AppUser } from '../models/appuser.model';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  baseUrl = environment.apiUrl;
  constructor(private http:HttpClient) { 
}

//Register the user
registerPerson(personToRegister:RegisterUserDto){
  console.log("Service: Person to Register " + JSON.stringify(personToRegister))
  return this.http.post(this.baseUrl + "Account/Register", personToRegister);
}


}

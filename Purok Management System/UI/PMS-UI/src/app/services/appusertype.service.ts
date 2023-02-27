import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { AppUserType } from '../models/appusertype.model';

@Injectable({
  providedIn: 'root'
})

export class AppusertypeService {
  baseUrl:string = environment.apiUrl;

  constructor(private http:HttpClient) { }

  //Get a specific AppUserType from Database using an Id.
  getAppUserType(id:number):Observable<AppUserType>{
    return this.http.get<AppUserType>(this.baseUrl + "AppUserType/Get/" + id);
  }
  //Get the list of AppUserType
  getAppUserTypes():Observable<AppUserType[]>{
    return this.http.get<AppUserType[]>(this.baseUrl + "AppUserType/List");
  }
  //Add an AppUserType into Database
  addAppUserType(appUserType:AppUserType):Observable<AppUserType>{
    return this.http.post<AppUserType>(this.baseUrl + "AppUserType/Create", appUserType);
  }
  //Update an existing AppUserType from Database
  updateAppUserType(appUserType:AppUserType):Observable<AppUserType>{
    return this.http.put<AppUserType>(this.baseUrl + "AppUserType/Update", appUserType);
  }
  //Delete an AppUserType from Database using an Id.
  deleteAppUserType(id:number):Observable<AppUserType>{
    return this.http.delete<AppUserType>(this.baseUrl + "AppUserType/Delete/" + id);
  }
  
}

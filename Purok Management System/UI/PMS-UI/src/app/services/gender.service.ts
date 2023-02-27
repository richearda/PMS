import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { CreateGenderDto } from '../dto/command/creategender.dto';
import { GenderListDto } from '../dto/query/genderlist.dto';
import { Gender } from '../models/gender.model';

@Injectable({
  providedIn: 'root'
})
export class GenderService {
  baseUrl:string = environment.apiUrl;
  constructor(private http:HttpClient) { }

  getGenders():Observable<GenderListDto[]>{
    return this.http.get<GenderListDto[]>(this.baseUrl + "gender/list");
  }
  addGender(gender:CreateGenderDto){
    return this.http.post(this.baseUrl + "gender/create",gender);
  }
  updateGender(gender:any):Observable<Gender> {
    return this.http.put<Gender>(this.baseUrl + "gender/update", gender);
   }
   
   deleteGender(id:number):Observable<Gender> {
    return this.http.delete<Gender>(this.baseUrl + "gender/delete/" + id);
   }
}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { CreateBloodTypeDto } from '../dto/command/createbloodtype.dto';
import { BloodTypeListDto } from '../dto/query/bloodtypelist.dto';
import { BloodType } from '../models/bloodtype.model';

@Injectable({
  providedIn: 'root'
})
export class BloodtypeService {
  baseUrl:string = environment.apiUrl;
  constructor(private http:HttpClient) { }


getBloodTypes():Observable<BloodTypeListDto[]>{
  return this.http.get<BloodTypeListDto[]>(this.baseUrl + "bloodtype/list");
}

addBloodType(bloodType:CreateBloodTypeDto){
  return this.http.post(this.baseUrl + "bloodtype/create", bloodType);
}

updateBloodType(bloodType:any):Observable<BloodType> {
  return this.http.put<BloodType>(this.baseUrl + "bloodtype/update", bloodType);
 }
 
 deleteBloodType(id:number):Observable<BloodType> {
  return this.http.delete<BloodType>(this.baseUrl + "bloodtype/delete/" + id);
 }

}

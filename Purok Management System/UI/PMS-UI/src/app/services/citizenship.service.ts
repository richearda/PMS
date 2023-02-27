import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { CreateCitizenshipDto } from '../dto/command/createcitizenship.dto';
import { CitizenshipListDto } from '../dto/query/citizenshiplist.dto';
import { Citizenship } from '../models/citizenship.model';

@Injectable({
  providedIn: 'root'
})
export class CitizenshipService {
  baseUrl:string = environment.apiUrl;
  constructor(private http: HttpClient) { 
  }

  getCitizenships():Observable<CitizenshipListDto[]>{
    return this.http.get<CitizenshipListDto[]>(this.baseUrl + "citizenship/list");
  }
  addCitizenship(citizenship:CreateCitizenshipDto){
    return this.http.post(this.baseUrl + "citizenship/create", citizenship);
  }
  updateCitizenship(citizenship:any):Observable<Citizenship> {
    return this.http.put<Citizenship>(this.baseUrl + "citizenship/update", citizenship);
   }
   
   deleteCitizehship(id:number):Observable<Citizenship> {
    return this.http.delete<Citizenship>(this.baseUrl + "citizenship/delete/" + id);
   }
}


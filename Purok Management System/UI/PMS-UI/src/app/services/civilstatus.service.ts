import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { CreateCivilStatusDto } from '../dto/command/createcivilstatus.dto';
import { CivilStatusListDto } from '../dto/query/civilstatuslist.dto';
import { CivilStatus } from '../models/civilstatus.model';

@Injectable({
  providedIn: 'root'
})
export class CivilstatusService {
  baseUrl:string = environment.apiUrl;
  constructor(private http:HttpClient) { }

  getCivilStatuses():Observable<CivilStatusListDto[]>{
    return this.http.get<CivilStatusListDto[]>(this.baseUrl + "civilstatus/list");
  }
  addCivilStatus(civilStatus:CreateCivilStatusDto){
    return this.http.post(this.baseUrl + "civilstatus/create",civilStatus);
  }
  updateCivilStatus(civilStatus:any):Observable<CivilStatus> {
    return this.http.put<CivilStatus>(this.baseUrl + "civilstatus/update", civilStatus);
   }
   
   deleteCivilStatus(id:number):Observable<CivilStatus> {
    return this.http.delete<CivilStatus>(this.baseUrl + "civilstatus/delete/" + id);
   }
}

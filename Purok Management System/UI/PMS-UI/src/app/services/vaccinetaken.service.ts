import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { CreateVaccineTakenDto } from '../dto/command/createvaccinetaken.dto';
import { VaccineListDto } from '../dto/query/vaccinelist.dto';
import { VaccineTaken } from '../models/vaccinetaken.model';

@Injectable({
  providedIn: 'root'
})
export class VaccineTakenService {
  baseUrl:string = environment.apiUrl;

  constructor(private http:HttpClient) { }


  getVaccinesTaken():Observable<VaccineListDto[]> {
    return this.http.get<VaccineListDto[]>(this.baseUrl + "vaccinetaken/list")
  }
  addVaccineTaken(vaccine:CreateVaccineTakenDto){
return this.http.post(this.baseUrl + "vaccinetaken/create", vaccine);
  }
  updateVaccineTaken(vaccineTaken:any):Observable<VaccineTaken> {
    return this.http.put<VaccineTaken>(this.baseUrl + "vaccinetaken/update", vaccineTaken);
  }
  deleteVaccineTaken(id:number):Observable<VaccineTaken> {
    return this.http.delete<VaccineTaken>(this.baseUrl + "vaccinetaken/delete/" + id);
  }
}


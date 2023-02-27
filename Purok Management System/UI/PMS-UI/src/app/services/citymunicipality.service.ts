import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { CityMunicipalityListDto } from '../dto/query/citymunicipalitylist.dto';
import { CreateCityMunicipalityDto } from '../dto/command/createcitymunicipality.dto';
import { BarangayListDto } from '../dto/query/barangaylist.dto';
import { CityMunicipality } from '../models/citymunicipality.model';

@Injectable({
  providedIn: 'root'
})
export class CityMunicipalityService {
  baseUrl:string = environment.apiUrl;
  constructor(private http:HttpClient) { }

  getCityMunicipalities():Observable<CityMunicipalityListDto[]> {
    return this.http.get<CityMunicipalityListDto[]>(this.baseUrl + "citymunicipality/list");
  }

  addCityMunicipality(cityMunicipality:CreateCityMunicipalityDto){
    return this.http.post(this.baseUrl + "citymunicipality/create", cityMunicipality);
  }

  getBarangaysByCityMunicipalityId(cityMunicipalityId:number):Observable<BarangayListDto[]> {
    return this.http.get<BarangayListDto[]>(this.baseUrl + "citymunicipality/list/barangays?Id=" + cityMunicipalityId);
  }
  
  updateCityMunicipality(cityMunicipality:any):Observable<CityMunicipality> {
    return this.http.put<CityMunicipality>(this.baseUrl + "citymunicipality/update", cityMunicipality);
   }
   
   deleteCityMunicipality(id:number):Observable<CityMunicipality> {
    return this.http.delete<CityMunicipality>(this.baseUrl + "citymunicipality/delete/" + id);
   }
}

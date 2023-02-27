import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { BarangayListDto } from '../dto/query/barangaylist.dto';
import { CreateBarangayDto } from '../dto/command/createbarangay.dto';
import { Barangay } from '../models/barangay.model';
import { PurokSitioListDto } from '../dto/query/puroksitiolist.dto';
import { PaginatedResult } from '../models/pagination';

@Injectable({
  providedIn: 'root'
})

export class BarangayService {
  baseUrl:string = environment.apiUrl;


  constructor(private http:HttpClient) {
   }



   getBarangaysWithParams(page?:number,itemsPerPage?:number,barangayParams?:string):Observable<PaginatedResult<BarangayListDto[]>> {
    const paginatedResult: PaginatedResult<BarangayListDto[]> = new PaginatedResult<BarangayListDto[]>
    
    let params = new HttpParams();

    if (page != null && itemsPerPage != null) {
      params = params.append('pageNumber', page);
      params = params.append('pageSize', itemsPerPage);
    }

    if (barangayParams != null) {
      params = params.append('cityMunicipalityName', barangayParams);
    }

    return this.http.get<BarangayListDto[]>(this.baseUrl + "barangay/list/bycitymunicipality", {observe: 'response', params})
    .pipe(
        map(response => {
          paginatedResult.result = response.body!;
          if (response.headers.get('Pagination') != null) {
            paginatedResult.pagination = JSON.parse(
              response.headers.get('Pagination')!
            );
          }
          return paginatedResult;
        })
      );
   }

   getBarangays(){
    return this.http.get<BarangayListDto[]>(this.baseUrl + "api/barangay/list");
   }

   getPurokSitiosByBarangayId(barangayId:number):Observable<PurokSitioListDto[]> {
    return this.http.get<PurokSitioListDto[]>(this.baseUrl + "barangay/list/puroksitios?Id=" + barangayId);
   }

   addBarangay(barangay:CreateBarangayDto):Observable<CreateBarangayDto> {
    return this.http.post<CreateBarangayDto>(this.baseUrl + "barangay/create", barangay);
   }

   updateBarangay(barangay:any):Observable<Barangay> {
    return this.http.put<Barangay>(this.baseUrl + "barangay/update", barangay);
   }
   
   deleteBarangay(id:number):Observable<Barangay> {
    return this.http.delete<Barangay>(this.baseUrl + "barangay/delete/" + id);
   }
   
   
}

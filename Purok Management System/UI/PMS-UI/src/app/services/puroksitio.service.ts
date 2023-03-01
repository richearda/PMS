import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { CreatePurokSitioDto } from '../dto/command/createpuroksitio.dto';
import { PurokSitioListDto } from '../dto/query/puroksitiolist.dto';
import { PaginatedResult } from '../models/pagination';
import { PurokSitio } from '../models/puroksitio.model';

@Injectable({
  providedIn: 'root'
})
export class PuroksitioService {
  baseUrl:string = environment.apiUrl;
  constructor(private http:HttpClient) { 

  }

  getPurokSitios():Observable<PurokSitioListDto[]> {
    return this.http.get<PurokSitioListDto[]>(this.baseUrl + "puroksitio/list");
  }
  addPurokSitio(purokSitio:CreatePurokSitioDto){
    return this.http.post(this.baseUrl + "puroksitio/create", purokSitio);
  }
  getPurokSitioWithParams(page?:number,itemsPerPage?:number, barangayParams?:string):Observable<PaginatedResult<PurokSitioListDto[]>> {
    const paginatedResult: PaginatedResult<PurokSitioListDto[]> = new PaginatedResult<PurokSitioListDto[]>
    let params = new HttpParams();

    if (page != null && itemsPerPage != null) {
      params = params.append('pageNumber', page);
      params = params.append('pageSize', itemsPerPage);
    }

    if (barangayParams != null) {
      params = params.append('barangayName', barangayParams);
    }

    return this.http.get<PurokSitioListDto[]>(this.baseUrl + "puroksitio/list/bybarangay", {observe: 'response', params})
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

  updatePurokSitio(purokSitio:any):Observable<PurokSitio> {
    return this.http.put<PurokSitio>(this.baseUrl + "puroksitio/update", purokSitio);
  }
  deletePurokSitio(id:number):Observable<PurokSitio> {
    return this.http.delete<PurokSitio>(this.baseUrl + "puroksitio/delete/" + id);
  }

}

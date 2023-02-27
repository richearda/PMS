import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { CreatePersonDto } from '../dto/command/createperson.dto';
import { PersonListDto } from '../dto/query/personlist.dto';
import { UserParams } from '../helpers/userparams';
import { PaginatedResult } from '../models/pagination';
import { Person } from '../models/person.model';

@Injectable({
  providedIn: 'root'
})
export class PersonService{
  baseUrl:string = environment.apiUrl;
  constructor(private http:HttpClient) { }

  getPersons(page?:number,itemsPerPage?:number,userParams?:string):Observable<PaginatedResult<PersonListDto[]>> {
    const paginatedResult: PaginatedResult<PersonListDto[]> = new PaginatedResult<PersonListDto[]>

    let params = new HttpParams();

    if (page != null && itemsPerPage != null) {
      params = params.append('pageNumber', page);
      params = params.append('pageSize', itemsPerPage);
    }

    if (userParams != null) {
      params = params.append('barangayName', userParams);
    }


    return this.http.get<PersonListDto[]>(this.baseUrl + "person/list", {observe: 'response', params})
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

  

  addPerson(personToAdd:CreatePersonDto){
    return this.http.post(this.baseUrl + "person/create", personToAdd);
  }
  updatePerson(person:any):Observable<Person> {
    return this.http.put<Person>(this.baseUrl + "person/update", person);
   }
   
   deletePerson(id:number):Observable<Person> {
    return this.http.delete<Person>(this.baseUrl + "person/delete/" + id);
   }

}

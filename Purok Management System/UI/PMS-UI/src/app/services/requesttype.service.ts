import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { CreateRequestTypeDto } from '../dto/command/createrequesttype.dto';
import { RequestTypeListDto } from '../dto/query/requesttypelist.dto';
import { RequestType } from '../models/requesttype.model';

@Injectable({
  providedIn: 'root'
})
export class RequesttypeService {
  baseUrl:string = environment.apiUrl;
  constructor(private http:HttpClient) { 

  }

 getRequestTypes():Observable<RequestTypeListDto[]>{
  return this.http.get<RequestTypeListDto[]>(this.baseUrl + "requesttype/list");
 }
  addRequestType(requestType: CreateRequestTypeDto){
    return this.http.post(this.baseUrl + "requesttype/create", requestType);
  }

  updateRequestType(requestType:CreateRequestTypeDto){
    return this.http.put(this.baseUrl + "requesttype/update", requestType);
  }
  deleteRequestType(id:number) : Observable<RequestType>{
    return this.http.delete<RequestType>(this.baseUrl + "requesttype/delete/" + id);
  }
}

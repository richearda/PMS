import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { CreatePreExistingConditionDto } from '../dto/command/createpreexistingcondition.dto';
import { PreExistingConditionListDto } from '../dto/query/preexistingconditionlist.dto';
import { PreExistingCondition } from '../models/preexistingcondition.model';

@Injectable({
  providedIn: 'root'
})
export class PreexistingconditionService {
  baseUrl:string = environment.apiUrl;
  constructor(private http:HttpClient) { }

getPreExistingConditions():Observable<PreExistingConditionListDto[]> {
  return this.http.get<PreExistingConditionListDto[]>(this.baseUrl + "preexistingcondition/list");
}
addPreExistingCondition(condition:CreatePreExistingConditionDto){
  return this.http.post(this.baseUrl + "preexistingcondition/create",condition);
}
updatePreExistingCondition(preExistingCondition:any):Observable<PreExistingCondition> {
  return this.http.put<PreExistingCondition>(this.baseUrl + "preexistingcondition/update", preExistingCondition);
}
deletePreExistingCondition(id:number):Observable<PreExistingCondition> {
  return this.http.delete<PreExistingCondition>(this.baseUrl + "preexistingcondition/delete/" + id);
}
}

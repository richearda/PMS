import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class RequestService {
  baseUrl:string = environment.apiUrl;
  constructor() { }
}

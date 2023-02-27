import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class HealthbackgroundService {
  baseUrl:string = environment.apiUrl;
  constructor() { }
}

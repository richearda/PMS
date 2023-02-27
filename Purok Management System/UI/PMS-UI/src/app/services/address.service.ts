import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { CreateAddressDto } from '../dto/command/createaddress.dto';
import { AddressListDto } from '../dto/query/addresslist.dto';
import { Address } from '../models/address.model';

@Injectable({
  providedIn: 'root'
})
export class AddressService {
baseUrl:string = environment.apiUrl;
addressToAdd!: CreateAddressDto;

  constructor(private http:HttpClient) { }

  getAddresses():Observable<AddressListDto[]> {
    return this.http.get<AddressListDto[]>(this.baseUrl + "address/list");
  }

}

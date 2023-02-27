import { AfterViewInit, Component, ElementRef, Input, OnInit, Output, ViewChild } from '@angular/core';
import { CreatePersonDto } from 'src/app/dto/command/createperson.dto';
import { BarangayListDto } from 'src/app/dto/query/barangaylist.dto';
import { PersonListDto } from 'src/app/dto/query/personlist.dto';
import { PaginatedResult, Pagination } from 'src/app/models/pagination';
import { Person } from 'src/app/models/person.model';
import { CityMunicipalityService } from 'src/app/services/citymunicipality.service';
import { PersonService } from 'src/app/services/person.service';

@Component({
  selector: 'app-manage-user',
  templateUrl: './manage-user.component.html',
  styleUrls: ['./manage-user.component.css']
})
export class ManageUserComponent implements OnInit {
  /*I need to display the barangay base on the city of logged in user.
    1. If the user is admin, I need to populate the select with all the barangays base on the city of the logged in user.
    2. If the user is not admin, I need to populate the select with only the barangay of the logged in user.
    3. If the user is constituent, I need to hide the manage user module to prevent them from accessing the records.
  */
  //I need to display the constituent base on the default barangay of the logged in user.
    
  @ViewChild('selectedBarangay') selectedBarangay?: ElementRef;
  title:string = "Manage User"
  barangayName?:string = "Mantuyong";
  pagination?: Pagination;
  userParams?: string;
  persons?: PersonListDto[];
  person?:Person;
  personToUpdate!: CreatePersonDto;
  barangays?:BarangayListDto[];
  //personToUpdate?:CreatePersonDto;

  ngOnInit():void {
    this.getBarangaysByCityMunicipality(1);
    this.loadPersons();
  }

constructor(private personService: PersonService, private cityMunicipalityService: CityMunicipalityService ){
 
}

loadPersons() {
  this.userParams = this.selectedBarangay?.nativeElement.value ? this.selectedBarangay?.nativeElement.value : "Mantuyong";
  //this.userParams = this.barangays?.find((barangay) => barangay.barangayName === barangay.barangayName)?.barangayName;
  console.log("Barangay: " + this.userParams);
   this.personService.getPersons(this.pagination?.currentPage,this.pagination?.itemsPerPage, this.userParams)
  .subscribe({next:(result:PaginatedResult<PersonListDto[]>) => {
     this.persons = result.result; 
     console.log("Persons:" + JSON.stringify(this.persons));
    this.pagination = result.pagination;
    console.log("Pagination:" + JSON.stringify(this.pagination));
  }
  });
}

setUpdateValue(personToUpdate:CreatePersonDto){
  this.personToUpdate = personToUpdate;
}
//Gets the barangay by city/municipality
getBarangaysByCityMunicipality(id:number){
this.cityMunicipalityService
.getBarangaysByCityMunicipalityId(id)
.subscribe(
  { next: (barangays) => {
    this.barangays = barangays; 
    console.log("Barangays " + JSON.stringify(barangays)) 
  }});
}

deletePerson(personId:number){
  this.personService.deletePerson(personId).subscribe({next:(response) => this.person = response})
}

onChange()
{
  alert("Select Changed!");
}

range(start: number, end: number) {
  return new Array(end - start + 1).fill(0).map((_, idx) => start + idx)
}

previous(){
  if(this.pagination!.currentPage >1){
    this.pagination!.currentPage--;
    this.loadPersons();
  }
}
next(){
  if(this.pagination!.currentPage<this.pagination!.totalPages){
    this.pagination!.currentPage++;
    this.loadPersons();
  }
}
setPage(page: number){
  this.pagination!.currentPage = page;
  this.loadPersons();
}

}



import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CreatePurokSitioDto } from 'src/app/dto/command/createpuroksitio.dto';
import { BarangayListDto } from 'src/app/dto/query/barangaylist.dto';
import { PurokSitioListDto } from 'src/app/dto/query/puroksitiolist.dto';
import { BarangayService } from 'src/app/services/barangay.service';
import { PuroksitioService } from 'src/app/services/puroksitio.service';
import { CityMunicipalityListDto } from 'src/app/dto/query/citymunicipalitylist.dto';
import { ManageBarangayComponent } from '../manage-barangay/manage-barangay.component';
import { CityMunicipalityService } from '../../services/citymunicipality.service';
import { PaginatedResult, Pagination } from '../../models/pagination';

@Component({
  selector: 'app-manage-purok-sitio',
  templateUrl: './manage-purok-sitio.component.html',
  styleUrls: ['./manage-purok-sitio.component.css'],
})
export class ManagePurokSitioComponent implements OnInit {
  @ViewChild('selectedBarangay') barangayName?: ElementRef;
  @ViewChild('barangayOffCanvas', { static: true })
  barangayOffCanvas?: ElementRef;
  title: string = 'Purok/Sitio';
  purokSitios?: PurokSitioListDto[] = [];
  purokSitioInputForm!: FormGroup;
  purokSitioToAdd = new CreatePurokSitioDto();
  purokSitioToUpdate = new CreatePurokSitioDto();
  barangays!: BarangayListDto[];
  cityMunicipalities?: CityMunicipalityListDto[];
  pagination?: Pagination;
  editMode?:boolean = false;
  

  constructor(
    private formBuilder: FormBuilder,
    private purokSitioService: PuroksitioService,
    private barangayService: BarangayService,
    private cityMunicipalityService: CityMunicipalityService
  ) {}
  ngOnInit(): void {
    //this.getPurokSitios();
    //executes when the page is displayed.
    this.getBarangays();
    this.getCityMunicipalities();
    this.initializeForm();
    this.loadPurokSitios();
    this.barangayOffCanvas?.nativeElement.addEventListener('show.bs.offcanvas',
    () => {
      //executes when the off canvas is shown.
      this.getBarangays();
    })
  }
//Initialize reactive form for purokSitio.
  initializeForm() {
    this.purokSitioInputForm = this.formBuilder.group({
      purokSitioId:[0],
      purokSitioName: ['', Validators.required],
      barangayId: ['Select Barangay', Validators.required],
      isActive: [false],
    });
  }
//get all barangays of all cities
  getBarangays() {
    return this.barangayService
      .getBarangays()
      .subscribe({ next: (barangays) => (this.barangays = barangays) });
  }
//get purok/sitios of all barangays.
  getPurokSitios() {
    this.purokSitioService.getPurokSitios().subscribe({
      next: (purokSitios) => (this.purokSitios = purokSitios),
    });
  }
  //subscribes to getPurokSitionWithParams method from PurokSitio service.
//get purok sitio of a specific barangay and load it to table with pagination.
  loadPurokSitios() {
    return this.purokSitioService
      .getPurokSitioWithParams(
        this.pagination?.currentPage,
        this.pagination?.itemsPerPage,
        this.barangayName?.nativeElement.value
      )
      .subscribe({
        next: (result: PaginatedResult<PurokSitioListDto[]>) => {
          this.purokSitios = result.result;
          console.log('Purok Sitios:' + JSON.stringify(this.purokSitios));
          this.pagination = result.pagination;
          console.log('Pagination:' + JSON.stringify(this.pagination));
        },
      });
  }
//subscribes to addPurokSitio method from PurokSitio service.
//add purokSitio to the database.
  addPurokSitio(purokSitioToAdd: CreatePurokSitioDto) {
   purokSitioToAdd = this.purokSitioInputForm.value;
    this.purokSitioService
      .addPurokSitio(purokSitioToAdd)
      .subscribe({ next: (purokSitioAdded) => console.log(purokSitioAdded) });
    this.purokSitioInputForm.reset();
  }
//subscribes to updatePurokSitio method from PurokSitio service.
//update the existing purok/sitio from the database.
  updatePurokSitio(purokSitioToUpdate:CreatePurokSitioDto){
    purokSitioToUpdate = this.purokSitioInputForm.value;  
    this.purokSitioService.updatePurokSitio(purokSitioToUpdate).subscribe({next:(purokSitioUpdated) => console.log("Purok/Sitio successfully updated!: " + JSON.stringify(purokSitioUpdated))})
  }
  //subscribes deletePurokSitio method from PurokSitio service.
  //delete a Purok/Sitio from database.
  deletePurokSitio(id:number){
    this.purokSitioService.deletePurokSitio(id).subscribe({next:(deletedPurokSitio) => console.log("Purok sitio with ID: " + id + "has been deleted successfully!")})
  } 
  //subscribes to getCityMunicipalities method from CityMunicipality service.
  //get cityMunicipalities.
  getCityMunicipalities() {
    this.cityMunicipalityService.getCityMunicipalities().subscribe({
      next: (citymunicipalities) => {
        this.cityMunicipalities = citymunicipalities;
        console.log(citymunicipalities);
      },
      error: (response) => {
        console.log(response);
      },
    });
  }
  //set the Purok/Sitio form values to update
  setUpdateForm(purokSitioToUpdate:PurokSitioListDto){
    this.purokSitioInputForm.controls['purokSitioId'].setValue(purokSitioToUpdate.purokSitioId);
    this.purokSitioInputForm.controls['purokSitioName'].setValue(purokSitioToUpdate.purokSitioName);
    let selectedBarangay = this.barangays.find((barangay) => barangay.barangayName === purokSitioToUpdate.barangayName)?.barangayId
    this.purokSitioInputForm.controls['barangayId'].setValue(selectedBarangay);
    this.purokSitioInputForm.controls['isActive'].setValue(purokSitioToUpdate.isActive);
    this.editMode = true;
  }

  //Set edit mode property to false and reset form value
  setEditModeFalse(){
    this.editMode = false;
    this.purokSitioInputForm.reset();
  }

//check if the selected select option is the first option.
  checkSelectValidation() {
    return (
      this.purokSitioInputForm.get('barangayId')?.value == 'Select Barangay'
    );
  }

  range(start: number, end: number) {
    return new Array(end - start + 1).fill(0).map((_, idx) => start + idx)
  }
  
  previous(){
    if(this.pagination!.currentPage >1){
      this.pagination!.currentPage--;
      this.loadPurokSitios();
    }
  }
  next(){
    if(this.pagination!.currentPage<this.pagination!.totalPages){
      this.pagination!.currentPage++;
      this.loadPurokSitios();
    }
  }
  setPage(page: number){
    this.pagination!.currentPage = page;
    this.loadPurokSitios();
  }
}

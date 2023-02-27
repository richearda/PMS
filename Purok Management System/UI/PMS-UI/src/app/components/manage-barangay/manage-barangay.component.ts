import {
  AfterViewInit,
  Component,
  ElementRef,
  OnInit,
  ViewChild,
} from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { BarangayListDto } from 'src/app/dto/query/barangaylist.dto';
import { CityMunicipalityListDto } from 'src/app/dto/query/citymunicipalitylist.dto';
import { CreateBarangayDto } from 'src/app/dto/command/createbarangay.dto';
import { BarangayService } from 'src/app/services/barangay.service';
import { CityMunicipalityService } from 'src/app/services/citymunicipality.service';
import { PaginatedResult, Pagination } from '../../models/pagination';
import { CityMunicipality } from 'src/app/models/citymunicipality.model';

@Component({
  selector: 'app-manage-barangay',
  templateUrl: './manage-barangay.component.html',
  styleUrls: ['./manage-barangay.component.css'],
})
export class ManageBarangayComponent implements OnInit {
  //properties
  @ViewChild('selectedCityMunicipality') cityMunicipalityName?: ElementRef;
  @ViewChild('barangayOffCanvas', { static: true })
  barangayOffCanvas?: ElementRef;
  title: string = 'Manage Barangay';
  barangays?: BarangayListDto[] = [];
  cityMunicipalities: CityMunicipalityListDto[] = [];
  barangayInputForm!: FormGroup;
  barangayToAdd = new CreateBarangayDto();
  barangayToUpdate = new CreateBarangayDto();
  cityMunicipality?: CityMunicipalityListDto[];
  //barangayParams?: string = this.name?.nativeElement.value;
  pagination?: Pagination;
  editMode?: boolean = false;

  //constructor
  constructor(
    private formBuilder: FormBuilder,
    private barangayService: BarangayService,
    private cityMunicipalityService: CityMunicipalityService
  ) {}

  ngOnInit(): void {
    this.getCityMunicipalities();
    this.initializeForm();
    this.loadBarangays();
    //adds an event listener to the canvass.
    this.barangayOffCanvas?.nativeElement.addEventListener(
      'show.bs.offcanvas',
      () => {
        //executes when the off canvas is shown.
        this.getCityMunicipalities();
      }
    );
  }

  //Reactive Form
  //Barangay Form
  initializeForm() {
    this.barangayInputForm = this.formBuilder.group({
      barangayId: [0],
      barangayName: ['', Validators.required],
      cityMunicipalityId: ['Select City/Municipality', Validators.required],
      isActive: [''],
    });
  }

//subscribes to getBarangaysWithParams method in Barangay service.
//passed pagination and filter value
  loadBarangays() {
    console.log('City: ' + this.cityMunicipalityName?.nativeElement.value);
    this.barangayService
      .getBarangaysWithParams(
        this.pagination?.currentPage,
        this.pagination?.itemsPerPage,
        this.cityMunicipalityName?.nativeElement.value
      )
      .subscribe({
        next: (result: PaginatedResult<BarangayListDto[]>) => {
          this.barangays = result.result;
          console.log('Barangays:' + JSON.stringify(this.barangays));
          this.pagination = result.pagination;
          console.log('Pagination:' + JSON.stringify(this.pagination));
        },
      });
  }

  //subscribes to getCityMunicipalities method in CityMunicipality service.
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
//subscribes to addBarangay method in Barangay service.
//add barangay to database.
  addBarangay(barangayToAdd: CreateBarangayDto) {
    barangayToAdd = this.barangayInputForm.value;
    barangayToAdd.barangayId = 0;
    this.barangayService
      .addBarangay(barangayToAdd)
      .subscribe({
        next: (barangayAdded) =>
          console.log('Added barangay successfully!:' + JSON.stringify(barangayAdded)),
      });
      console.log('Barangay to Add: ' + JSON.stringify(barangayToAdd));
      this.barangayInputForm.reset();
  }
//subscribes to updateBarangay method in Barangay service.
//updates existing barangay from database.
  updateBarangay(barangayToUpdate: CreateBarangayDto) {
    barangayToUpdate = this.barangayInputForm.value; 
    this.barangayService.updateBarangay(barangayToUpdate).subscribe({next:(res) => console.log("Updated barangay successfully!: " + JSON.stringify(res))})
    this.barangayInputForm.reset();
  }
//subscribes to deleteBarangay metho in Barangay service.
//deletes existing barangay in database using the barangay id.
  deleteBarangay(id: number) {
    this.barangayService
      .deleteBarangay(id)
      .subscribe({
        next: (response) =>
          console.log('Barangay with ID: ' + id + ' is deleted successfully!'),
      });
  }

  //handles submission base on operation
  //executes when the add/update button is clicked.
  submitForm(barangay: CreateBarangayDto) {
    if (!this.editMode) {
      this.addBarangay(barangay);
    } else {
      this.updateBarangay(barangay);
    }
  }
  setUpdateForm(barangay: BarangayListDto) {
    alert('Update Barangay with record: ' + JSON.stringify(barangay));
    this.editMode = true;
    this.barangayInputForm.controls['barangayId'].setValue(
      barangay.barangayId
    );   
    this.barangayInputForm.controls['barangayName'].setValue(
      barangay.barangayName
    );
    let selectedCityMunicipalityId = this.cityMunicipalities.find(
      (citymunicipality) =>
        citymunicipality.cityMunicipalityName === barangay.cityMunicipalityName
    )?.cityMunicipalityId;
    this.barangayInputForm.controls['cityMunicipalityId'].setValue(
      selectedCityMunicipalityId
    );
    this.barangayInputForm.controls['isActive'].setValue(barangay.isActive);

    this.barangayToUpdate = this.barangayInputForm.value;
    //this.barangayService.updateBarangay(this.barangayInputForm.value)
    console.log('Barangay to Update: ' + JSON.stringify(this.barangayToUpdate));
  }
  checkSelectValidation() {
    return (
      this.barangayInputForm.get('cityMunicipalityId')?.value ==
        'Select City/Municipality' || null
    );
  }
  range(start: number, end: number) {
    return new Array(end - start + 1).fill(0).map((_, idx) => start + idx);
  }
  previous() {
    if (this.pagination!.currentPage > 1) {
      this.pagination!.currentPage--;
      this.loadBarangays();
    }
  }
  next() {
    if (this.pagination!.currentPage < this.pagination!.totalPages) {
      this.pagination!.currentPage++;
      this.loadBarangays();
    }
  }
  setPage(page: number) {
    this.pagination!.currentPage = page;
    this.loadBarangays();
  }
  setEditModeFalse() {
    this.barangayInputForm.reset();
    this.editMode = false;
  }
}

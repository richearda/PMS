import { AfterContentInit, AfterViewInit, Component, ElementRef, Input, OnInit, Output, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CreatePersonDto } from 'src/app/dto/command/createperson.dto';
import { BarangayListDto } from 'src/app/dto/query/barangaylist.dto';
import { BloodTypeListDto } from 'src/app/dto/query/bloodtypelist.dto';
import { CitizenshipListDto } from 'src/app/dto/query/citizenshiplist.dto';
import { CityMunicipalityListDto } from 'src/app/dto/query/citymunicipalitylist.dto';
import { CivilStatusListDto } from 'src/app/dto/query/civilstatuslist.dto';
import { GenderListDto } from 'src/app/dto/query/genderlist.dto';
import { PersonListDto } from 'src/app/dto/query/personlist.dto';
import { PreExistingConditionListDto } from 'src/app/dto/query/preexistingconditionlist.dto';
import { PurokSitioListDto } from 'src/app/dto/query/puroksitiolist.dto';
import { VaccineListDto } from 'src/app/dto/query/vaccinelist.dto';
import { AppUserType } from 'src/app/models/appusertype.model';
import { Person } from 'src/app/models/person.model';
import { AppusertypeService } from 'src/app/services/appusertype.service';
import { BarangayService } from 'src/app/services/barangay.service';
import { BloodtypeService } from 'src/app/services/bloodtype.service';
import { CitizenshipService } from 'src/app/services/citizenship.service';
import { CityMunicipalityService } from 'src/app/services/citymunicipality.service';
import { CivilstatusService } from 'src/app/services/civilstatus.service';
import { GenderService } from 'src/app/services/gender.service';
import { PersonService } from 'src/app/services/person.service';
import { PreexistingconditionService } from 'src/app/services/preexistingcondition.service';
import { VaccineTakenService} from 'src/app/services/vaccinetaken.service';
import { UserParams } from '../../helpers/userparams';

@Component({
  selector: 'app-user-form',
  templateUrl: './user-form.component.html',
  styleUrls: ['./user-form.component.css']
})
export class UserFormComponent implements OnInit, AfterViewInit {
  //Properties
  genders!: GenderListDto[];
  civilStatuses!: CivilStatusListDto[];
  citizenships!: CitizenshipListDto[];
  cityMunicipalities!: CityMunicipalityListDto[];
  cityMunicipalityBarangays!: BarangayListDto[];
  barangayPurokSitios!: PurokSitioListDto[];
  selectedCityMunicipalityId!:number;
  userFormData!:FormGroup;
  personToAdd = new CreatePersonDto();
  person?:Person;
  @Input() personToUpdate!:CreatePersonDto;
  preExistingConditions?: PreExistingConditionListDto[];
  vaccinesTaken?: VaccineListDto[];
  bloodTypes?:BloodTypeListDto[];
  @Input() userParams?:UserParams;
  @ViewChild('selectedCityMunicipality') id!:any;
  @ViewChild('selectedBarangay') barangayId!:any;
  userModal?:ElementRef;
  appUserTypes?:AppUserType[];

  //Constructor
  constructor(
    private genderService: GenderService,
    private civilStatusService: CivilstatusService,
    private citizenshipService: CitizenshipService,
    private cityMunicipalityService: CityMunicipalityService,
    private barangayService: BarangayService,
    private personService: PersonService,
    private preExistingConditionService: PreexistingconditionService,
    private vaccineTakenService: VaccineTakenService,
    private bloodTypeService: BloodtypeService,
    private appUserTypeService: AppusertypeService,
    private formBuilder: FormBuilder
  ) {}

  //ngOnInit
  ngOnInit() {
    this.getCityMunicipalities();
    this.getPreExistingConditions();
    this.getVaccinesTaken()
    this.getBloodTypes();
    this.getAppUserTypes();
    this.initializeUserForm();
  }
  ngAfterViewInit(){
  //this.setUpdateForm(this.personToUpdate);
  this.testMethod(this.personToUpdate);
  }
  //Method to initialize form
  initializeUserForm(){
  this.userFormData = this.formBuilder.group({
    appUser : this.formBuilder.group({
      userName: ['', Validators.required],
      password:[''],
      appUserTypeId: ["Select User Type",Validators.required]
    }),
    person : this.formBuilder.group({
    personId: ['',Validators.min(1)],
    firstName: ['',Validators.required],
    lastName: ['',Validators.required],
    middleName: [''],
    birthPlace:[''],
    birthDate:[''],
    telephoneNo:[''],
    mobileNo:[''],
    email:['',Validators.email],
    height:[''],
    weight:[''],
    religion:[''],
    withNatId:[false],
    withSssGsis:[false],
    withDriversLicense:[false],
    isRegisteredVoter:[false],
    precintNo:[''],
    photoLink:[''],
    isActive:[false],
    genderId:[''],
    bloodTypeId:[''],
    civilStatusId:[''],
    citizenshipId:[''],
  }),
    healthBackground: this.formBuilder.group({ //healthbackground
      isMalnurish: [false], 
      isPwd: [false],
      preExistingConditionId: [''],
      vaccineTakenId: [''],
    }),  
    address:this.formBuilder.group({ //Address
      houseBlockLotNo: [''],  
      street: [''],
      cityMunicipalityId:['',Validators.required],
      barangayId: ['', Validators.required],
      purokSitioId: ['', Validators.required]
    })     
  })
  }

  testMethod(personToUpdate:CreatePersonDto){
    console.log("this is the data: " + JSON.stringify(personToUpdate));
    this.userFormData.controls['firstName'].setValue(personToUpdate.firstName);
  }

//GET Methods
  getAppUserTypes(){
   return this.appUserTypeService.getAppUserTypes().subscribe({next:(appUserTypes) => {(this.appUserTypes = appUserTypes), console.log("App user types: " + JSON.stringify(appUserTypes))}})
  }
  getGenders() {
    return this.genderService
      .getGenders()
      .subscribe({ next: (genders) => (this.genders = genders) });
  }
  getCivilStatuses() {
    return this.civilStatusService.getCivilStatuses().subscribe({
      next: (civilstatuses) => (this.civilStatuses = civilstatuses)
    });
  }
  getCitizenships() {
    return this.citizenshipService
      .getCitizenships()
      .subscribe({
        next: (citizenships) => (this.citizenships = citizenships)
      });
  }

  getCityMunicipalities() {
    return this.cityMunicipalityService
      .getCityMunicipalities()
      .subscribe({
        next: (citymunicipalities) =>
          (this.cityMunicipalities = citymunicipalities)
      });
  }

  getPurokSitiosByBarangayId(barangayId: number) {
    return this.barangayService
      .getPurokSitiosByBarangayId(barangayId)
      .subscribe({
        next: (purokSitios) => (this.barangayPurokSitios = purokSitios)
      });
  }

  getBarangaysByCityMunicipalityId(cityMunicipalityId: number) {
    console.log(this.id.nativeElement.value);
    return this.cityMunicipalityService
      .getBarangaysByCityMunicipalityId(cityMunicipalityId)
      .subscribe({
        next: (barangays) => (this.cityMunicipalityBarangays = barangays, console.log("Barangays:" + JSON.stringify(barangays)))        
      });
  }

  getPreExistingConditions(){
    return this.preExistingConditionService.getPreExistingConditions().subscribe({next:(conditions) => this.preExistingConditions = conditions})
  }

  getVaccinesTaken() {
    return this.vaccineTakenService.getVaccinesTaken().subscribe({next:(vaccines) => this.vaccinesTaken = vaccines})
  }

  getBloodTypes(){
    return this.bloodTypeService.getBloodTypes().subscribe({next:(bloodTypes) => this.bloodTypes = bloodTypes})
  }

  setUpdateForm(personToUpdate:CreatePersonDto){   
    setTimeout(() => {
      alert("Person to Update: " + JSON.stringify(personToUpdate));
      this.userFormData.controls['firstName'].setValue(personToUpdate.firstName);
    }, 2000);  
  }

//POST/PUT Method
  registerPerson(){
    
  }

  addPerson(personToAdd:CreatePersonDto){ 
    personToAdd = this.userFormData.value; 
    console.log("User to add: " + JSON.stringify(personToAdd));//{...personToAdd, ...this.userFormData.value};  
    this.personService.addPerson(personToAdd).subscribe({next:(personAdded => console.log("Person Added: " + JSON.stringify(personAdded)))})
    this.userFormData.reset();
  }
  updatePerson(person:CreatePersonDto){
    this.personService.updatePerson(person).subscribe({next:(response) => this.person = response})
  }

}

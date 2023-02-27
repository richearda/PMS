
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CreateVaccineTakenDto } from 'src/app/dto/command/createvaccinetaken.dto';
import { VaccineListDto } from 'src/app/dto/query/vaccinelist.dto';
import { VaccineTakenService } from 'src/app/services/vaccinetaken.service';

@Component({
  selector: 'app-manage-vaccine',
  templateUrl: './manage-vaccine.component.html',
  styleUrls: ['./manage-vaccine.component.css']
})
export class ManageVaccineComponent implements OnInit {
public title:string = "Manage Vaccine";
vaccines:VaccineListDto[] = [];
vaccineForm!:FormGroup;
vaccineTakenToUpdate!:CreateVaccineTakenDto;
vaccineTakenToAdd!:CreateVaccineTakenDto;
editMode?:boolean = false;

constructor(private vaccineTakenService:VaccineTakenService, private formBuilder:FormBuilder)
{}

ngOnInit(){
this.getVaccinesTaken();
this.initializeForm();
}

initializeForm(){
  this.vaccineForm = this.formBuilder.group({
    vaccineTakenId:[0],
    vaccineName:['',Validators.required],
    isActive: [false]
  })
}

addVaccineTaken(vaccineTakenToAdd:CreateVaccineTakenDto){
 vaccineTakenToAdd = this.vaccineForm.value;
 this.vaccineTakenService.addVaccineTaken(vaccineTakenToAdd).subscribe({next:(vaccineAdded) => console.log("Vaccine has been added successfully!: " + JSON.stringify(vaccineAdded))})
 this.vaccineForm.reset();
}
updateVaccineTaken(vaccineTakenToUpdate:CreateVaccineTakenDto){
  vaccineTakenToUpdate = this.vaccineForm.value;
 this.vaccineTakenService.updateVaccineTaken(vaccineTakenToUpdate).subscribe({next:(vaccineUpdated) => console.log("Vaccine has been updated successfully!: " + vaccineUpdated)})
this.vaccineForm.reset();
}
deleteVaccine(id:number){
  this.vaccineTakenService.deleteVaccineTaken(id).subscribe({next:(deletedVaccine) => console.log("Vaccine with the ID: " + id + " has been successfully deleted!")})
}
setUpdateForm(vaccineTakenToUpdate:VaccineListDto){
  this.vaccineForm.controls['vaccineTakenId'].setValue(vaccineTakenToUpdate.vaccineTakenId);
  this.vaccineForm.controls['vaccineName'].setValue(vaccineTakenToUpdate.vaccineName);
  this.vaccineForm.controls['isActive'].setValue(vaccineTakenToUpdate.isActive);
  this.editMode = true;
}

  getVaccinesTaken() {
    this.vaccineTakenService.getVaccinesTaken().subscribe({next:(vaccines) => this.vaccines = vaccines})
  }

setEditModeFalse(){
  this.editMode = false;
  this.vaccineForm.reset(); 
}
}

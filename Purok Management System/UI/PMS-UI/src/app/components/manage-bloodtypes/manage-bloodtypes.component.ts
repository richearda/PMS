import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CreateBloodTypeDto } from 'src/app/dto/command/createbloodtype.dto';
import { BloodTypeListDto } from 'src/app/dto/query/bloodtypelist.dto';
import { BloodtypeService } from 'src/app/services/bloodtype.service';

@Component({
  selector: 'app-manage-bloodtypes',
  templateUrl: './manage-bloodtypes.component.html',
  styleUrls: ['./manage-bloodtypes.component.css']
})
export class ManageBloodtypesComponent {
title:string = 'Manage Blood Type';
bloodtypes?:BloodTypeListDto[];
bloodTypeForm!:FormGroup;
bloodTypeToAdd!:CreateBloodTypeDto;
bloodTypeToUpdate!:CreateBloodTypeDto;
editMode:boolean = false;


constructor(private formBuilder:FormBuilder, private bloodTypeService:BloodtypeService){
this.InitializeForm();
this.getBloodTypes();
}


InitializeForm(){
  this.bloodTypeForm = this.formBuilder.group({
    bloodTypeId:[0],
    bloodTypeName:['',Validators.required],
    isActive:[false]
  })
}

getBloodTypes(){
  this.bloodTypeService.getBloodTypes().subscribe({next:(bloodTypes) => this.bloodtypes = bloodTypes})
}

addBloodType(bloodTypeToAdd:CreateBloodTypeDto){
  bloodTypeToAdd = this.bloodTypeForm.value;
  this.bloodTypeService.addBloodType(bloodTypeToAdd).subscribe({next:(bloodTypeAdded) => console.log("Blood type has been added successfully!")});
  this.bloodTypeForm.reset();
}

updateBloodType(bloodTypeToUpdate:CreateBloodTypeDto){
  bloodTypeToUpdate = this.bloodTypeForm.value;
  this.bloodTypeService.updateBloodType(bloodTypeToUpdate).subscribe({next:(bloodTypeUpdated) => console.log("Blood type has been updated successfully!")})
  this.bloodTypeForm.reset();

}

deleteBloodType(id:number){
  this.bloodTypeService.deleteBloodType(id).subscribe({next:(deletedBloodType) => console.log("The blood type with id: " + id + " has been deleted successfully!")})
}

setUpdateForm(bloodTypeToUpdate:CreateBloodTypeDto){
this.bloodTypeForm.setValue({
  bloodTypeId: bloodTypeToUpdate.bloodTypeId,
  bloodTypeName: bloodTypeToUpdate.bloodTypeName,
  isActive: bloodTypeToUpdate.isActive
})
this.editMode = true;
}
setEditModeFalse(){
  this.editMode = false;
  this.bloodTypeForm.reset();
}
}

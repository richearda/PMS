import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CreateRequestTypeDto } from 'src/app/dto/command/createrequesttype.dto';
import { RequestTypeListDto } from 'src/app/dto/query/requesttypelist.dto';
import { RequesttypeService } from 'src/app/services/requesttype.service';

@Component({
  selector: 'app-manage-requesttype',
  templateUrl: './manage-requesttype.component.html',
  styleUrls: ['./manage-requesttype.component.css'],
})
export class ManageRequesttypeComponent {
  title: string = 'Manage Request Type';
  requestTypeToAdd!: CreateRequestTypeDto;
  requestTypeToUpdate!: CreateRequestTypeDto;
  requestTypes!: RequestTypeListDto[];
  requestTypeForm!:FormGroup;
  editMode:boolean = false;

  constructor(private requestTypeService: RequesttypeService, private formBuilder:FormBuilder) {
    this.initializeForm();
    this.getRequestTypes();
  }

  //Reactive form for Request Type input
  initializeForm(){
    this.requestTypeForm = this.formBuilder.group({
      requestTypeId:[0],
      requestTypeName:["",Validators.required],
      isActive:[false]
    })
  }

  //Subscribes to getRequestTypes method in RequestTypeService.
  //Get all request types.
  getRequestTypes() {
    return this.requestTypeService
      .getRequestTypes()
      .subscribe({
        next: (requestTypes) => (this.requestTypes = requestTypes),
      });
  }
  //Subscribes to addRequestType method in RequestTypeService.
  //Add new request type to the database.
  addRequestType(requestTypeToAdd: CreateRequestTypeDto) {
    requestTypeToAdd =  this.requestTypeForm.value;
    return this.requestTypeService.addRequestType(requestTypeToAdd).subscribe({
      next: (requestTypeAdded) =>
        console.log(
          'Request Type successfully added! : ' +
            JSON.stringify(requestTypeAdded)
        ),
    });
    this.requestTypeForm.reset();
  }
   //Subscribes to updateRequestType method in RequestTypeService.
  //Update existing request type from the database.
  updateRequestType(requestTypeToUpdate: CreateRequestTypeDto) {
    requestTypeToUpdate = this.requestTypeForm.value;
   return this.requestTypeService
      .updateRequestType(requestTypeToUpdate)
      .subscribe({
        next: (requestTypeUpdated) =>
          console.log(
            'Request Type successfully updated! ' +
              JSON.stringify(requestTypeUpdated)
          ),
      });
      this.requestTypeForm.reset();
  }
   //Subscribes to deleteRequestType method in RequestTypeService.
  //Delete the request type from the database using the request type id.
  deleteRequestType(id: number) {
    return this.requestTypeService
      .deleteRequestType(id)
      .subscribe({
        next: (deletedRequestType) =>
          console.log(
            'Request type with id: ' + id + ' has been deleted successfully!'
          ),
      });
  }
//Sets the value of the form.
  setUpdateForm(requestTypeToUpdate:CreateRequestTypeDto){
    this.requestTypeForm.setValue(requestTypeToUpdate);
    this.editMode = true;
  }
  //Set editMode property to false and reset form.
  setEditModeFalse(){
    this.editMode = false;
    this.requestTypeForm.reset();
  }
}

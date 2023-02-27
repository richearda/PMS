import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { PreExistingConditionListDto } from 'src/app/dto/query/preexistingconditionlist.dto';
import { PreexistingconditionService } from 'src/app/services/preexistingcondition.service';
import { CreatePreExistingConditionDto } from 'src/app/dto/command/createpreexistingcondition.dto';
@Component({
  selector: 'app-manage-condition',
  templateUrl: './manage-condition.component.html',
  styleUrls: ['./manage-condition.component.css'],
})
export class ManageConditionComponent implements OnInit {
  title: string = 'Manage Condition';
  conditionInputForm!: FormGroup;
  conditionToAdd = new CreatePreExistingConditionDto();
  preExistingConditions: PreExistingConditionListDto[] = [];
  conditionToUpdate = new CreatePreExistingConditionDto();
  editMode?: boolean = false;

  constructor(
    private formBuilder: FormBuilder,
    private preExistingConditionService: PreexistingconditionService
  ) {}

  ngOnInit(): void {
    //executes when the page is displayed.
    this.getPreExistingConditions();
    this.initializeForm();
  }
  //Initialize reactive form for condition.
  initializeForm() {
    this.conditionInputForm = this.formBuilder.group({
      conditionId: [0],
      conditionName: ['', Validators.required],
      isActive: [''],
    });
  }
  //Get all PreExistingConditions and assign it to preExistingConditions property.
  getPreExistingConditions() {
    this.preExistingConditionService.getPreExistingConditions().subscribe({
      next: (conditions) => (this.preExistingConditions = conditions),
    });
  }
  //subscribes addPreExistingCondition method from PreExistingCondition service.
  //Add PreExistingCondition to database.
  addPreExistingCondition(conditionToAdd: CreatePreExistingConditionDto) {
    conditionToAdd = this.conditionInputForm.value;
    conditionToAdd.conditionId = 0;
    this.preExistingConditionService
      .addPreExistingCondition(conditionToAdd)
      .subscribe({
        next: (conditionAdded) =>
          console.log(
            'The ' + conditionAdded + ' has been added successfully!'
          ),
      });
    this.conditionInputForm.reset();
  }
  //subscribes updatePreExistingCondition method from PreExistingCondition service.
  //Updates existing condition from the database.
  updatePreExistingCondition(conditionToUpdate: CreatePreExistingConditionDto) {
    conditionToUpdate = this.conditionInputForm.value;
    console.log('Condition to Update: ' + JSON.stringify(conditionToUpdate));
    this.preExistingConditionService
      .updatePreExistingCondition(conditionToUpdate)
      .subscribe({
        next: (res) =>
          console.log('Updated successfully!: ' + JSON.stringify(res)),
      });
    this.conditionInputForm.reset();
  }
  //subscribes deletePreExistingCondition method from PreExistingCondition service.
  //deletes existing condition from the database using the condition id.
  deletePreExistingCondition(id: number) {
    this.preExistingConditionService.deletePreExistingCondition(id).subscribe({
      next: (res) =>
        console.log(
          'The Condition with ID: ' + id + ' has been successfully deleted.'
        ),
    });
  }
  //set value to the condition input form.
  setUpdateForm(conditionToUpdate: PreExistingConditionListDto) {
    this.conditionInputForm.controls['conditionId'].setValue(
      conditionToUpdate.preExistingConditionId
    );
    this.conditionInputForm.controls['conditionName'].setValue(
      conditionToUpdate.conditionName
    );
    this.conditionInputForm.controls['isActive'].setValue(
      conditionToUpdate.isActive
    );
    //sets editMode to true
    this.editMode = true;
  }
  //handles submit form
  submitForm(condition: CreatePreExistingConditionDto) {
    if (!this.editMode) {
      this.addPreExistingCondition(condition);
    } else {
      this.updatePreExistingCondition(condition);
    }
  }

  //set editMode property to false and reset form values.
  setEditModeFalse() {
    this.editMode = false;
    this.conditionInputForm.reset();
  }
}

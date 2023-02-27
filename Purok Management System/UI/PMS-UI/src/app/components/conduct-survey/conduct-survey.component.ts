import { Component, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { BarangayListDto } from 'src/app/dto/query/barangaylist.dto';
import { CitizenshipListDto } from 'src/app/dto/query/citizenshiplist.dto';
import { CityMunicipalityListDto } from 'src/app/dto/query/citymunicipalitylist.dto';
import { CivilStatusListDto } from 'src/app/dto/query/civilstatuslist.dto';
import { GenderListDto } from 'src/app/dto/query/genderlist.dto';
import { PurokSitioListDto } from 'src/app/dto/query/puroksitiolist.dto';
import { BarangayService } from 'src/app/services/barangay.service';
import { CitizenshipService } from 'src/app/services/citizenship.service';
import { CityMunicipalityService } from 'src/app/services/citymunicipality.service';
import { CivilstatusService } from 'src/app/services/civilstatus.service';
import { GenderService } from 'src/app/services/gender.service';

@Component({
  selector: 'app-conduct-survey',
  templateUrl: './conduct-survey.component.html',
  styleUrls: ['./conduct-survey.component.css'],
})
export class ConductSurveyComponent implements OnInit {
 

  constructor(
   
  ) {}
  ngOnInit() {
   
  }

 
}

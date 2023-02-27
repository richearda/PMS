import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http'

import { SidebarComponent } from './components/sidebar/sidebar.component';
import { ManageBarangayComponent } from './components/manage-barangay/manage-barangay.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { ConductSurveyComponent } from './components/conduct-survey/conduct-survey.component';
import { ManageUserComponent } from './components/manage-user/manage-user.component';
import { RequestBarangayIdComponent } from './components/request-barangay-id/request-barangay-id.component';
import { RequestBarangayClearanceComponent } from './components/request-barangay-clearance/request-barangay-clearance.component';
import { ManagePurokSitioComponent } from './components/manage-purok-sitio/manage-purok-sitio.component';
import { ManageConditionComponent } from './components/manage-condition/manage-condition.component';
import { ManageVaccineComponent } from './components/manage-vaccine/manage-vaccine.component';
import { UserFormComponent } from './components/user-form/user-form.component';
import { ManageBloodtypesComponent } from './components/manage-bloodtypes/manage-bloodtypes.component';
import { ManageRequesttypeComponent } from './components/manage-requesttype/manage-requesttype.component';


@NgModule({
  declarations: [
    AppComponent,
    SidebarComponent,
    ManageBarangayComponent,
    HomeComponent,
    LoginComponent,
    ConductSurveyComponent,
    ManageUserComponent,
    RequestBarangayIdComponent,
    RequestBarangayClearanceComponent,
    ManagePurokSitioComponent,
    ManageConditionComponent,
    ManageVaccineComponent,
    UserFormComponent,
    ManageBloodtypesComponent,
    ManageRequesttypeComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

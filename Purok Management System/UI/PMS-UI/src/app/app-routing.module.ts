import { Component, NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { ManageBarangayComponent } from "./components/manage-barangay/manage-barangay.component";
import { HomeComponent } from "./components/home/home.component";
import { SidebarComponent } from "./components/sidebar/sidebar.component";
import { LoginComponent } from "./components/login/login.component";
import { ConductSurveyComponent } from "./components/conduct-survey/conduct-survey.component";
import { ManageUserComponent } from "./components/manage-user/manage-user.component";
import { RequestBarangayIdComponent } from "./components/request-barangay-id/request-barangay-id.component";
import { RequestBarangayClearanceComponent } from "./components/request-barangay-clearance/request-barangay-clearance.component";
import { ManagePurokSitioComponent } from "./components/manage-purok-sitio/manage-purok-sitio.component";
import { ManageConditionComponent } from "./components/manage-condition/manage-condition.component";
import { ManageVaccineComponent } from "./components/manage-vaccine/manage-vaccine.component";
import { ManageBloodtypesComponent } from "./components/manage-bloodtypes/manage-bloodtypes.component";
import { ManageRequesttypeComponent } from "./components/manage-requesttype/manage-requesttype.component";
import { UserFormComponent } from "./components/user-form/user-form.component";
const routes: Routes = [
{path: "login", component: LoginComponent},
{path:"register", component: UserFormComponent},
{path:"", component: SidebarComponent,
children: [
   
    {path: "home", component: HomeComponent},
    {path:"conductsurvey", component: ConductSurveyComponent},
    {path:"manage/user", component: ManageUserComponent},
    {path:"request/barangay-id", component: RequestBarangayIdComponent},
    {path:"request/barangay-clearance", component: RequestBarangayClearanceComponent},
    {path: "app/setting/manage/barangay", component: ManageBarangayComponent },
    {path: "app/setting/manage/purok-sitio", component: ManagePurokSitioComponent },
    {path: "app/setting/manage/condition", component: ManageConditionComponent },
    {path: "app/setting/manage/vaccine", component: ManageVaccineComponent },
    {path: "app/setting/manage/bloodtypes", component: ManageBloodtypesComponent },
    {path : "app/setting/manage/requesttype", component: ManageRequesttypeComponent}
]
},
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports:[RouterModule]
})

export class AppRoutingModule {

}
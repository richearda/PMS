import { Address } from "./address.model";
import { BloodType } from "./bloodtype.model";
import { CivilStatus } from "./civilstatus.model";
import { Citizenship } from "./citizenship.model";
import { HealthBackground } from "./healthbackground.model";

export interface Person {
    PersonId: number;
    FirstName: string;
    LastName: string;
    MiddleName: string;
    BirthPlace: string;
    BirthDate: Date | string;
    TelephoneNo: string;
    MobileNo: string;
    EmailAddress: string;
    Height: number;
    Weight: number;
    Religion: string;
    WithNatId: boolean;
    WithSssGsis: boolean;
    WithDriversLicense: boolean;
    IsRegisteredVoter: boolean;
    PrecintNo: string;
    PhotoLink: string;
    IsActive: boolean;
    GenderId: number;
    Gender : Address
    BloodTypeId: number;
    BloodType: BloodType;
    CivilStatusId: number;
    CivilStatus: CivilStatus;
    CitizenshipId: number;
    Citizenship: Citizenship;
    AddressId: number;
    Address: Address;
    HealthBackgroundId: number;
    HealthBackground: HealthBackground;
}
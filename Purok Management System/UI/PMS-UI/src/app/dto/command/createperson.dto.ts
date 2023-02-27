import { CreateAddressDto } from "./createaddress.dto";
import { CreateHealthBackgroundDto } from "./createhealthbackground.dto";

export class CreatePersonDto {
    personId?:number;
    firstName?: string;
    lastName?: string;
    middleName?: string;
    birthPlace?: string;
    birthDate?: Date | string;
    telephoneNo?: string;
    mobileNo?: string;
    emailAddress?: string;
    height?: number;
    weight?: number;
    religion?: string;
    withNatId?: boolean;
    withSssGsis?: boolean;
    withDriversLicense?: boolean;
    isRegisteredVoter?: boolean;
    precintNo?: string;
    photoLink?: string;
    isActive?: boolean;
    genderId?: number;
    bloodTypeId?: number;
    civilStatusId?: number;
    citizenshipId?: number;
    healthBackground?: CreateHealthBackgroundDto;
    address?: CreateAddressDto;
}
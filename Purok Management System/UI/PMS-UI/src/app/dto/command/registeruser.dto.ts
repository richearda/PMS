import { CreatePersonDto } from "./createperson.dto";

export interface RegisterUserDto {

        userName: string;
        password: string;
        personDto: CreatePersonDto;
        appUserTypeId: number;
        
    }
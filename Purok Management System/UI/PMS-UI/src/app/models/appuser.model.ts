import { AppUserType } from "./appusertype.model";
import { Person } from "./person.model";

export interface AppUser {
    appUserId: number;
    userName: string;
    passwordHash: string;
    passwordSalt: string;
    personId: number | null;
    appUserPerson: Person;
    appUserTypeId: number;
    appUserType: AppUserType | null;
    isFirstLogIn: boolean;
    isActive: boolean;
}
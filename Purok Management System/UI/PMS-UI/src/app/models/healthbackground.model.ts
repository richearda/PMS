import { PreExistingCondition } from "./preexistingcondition.model";
import { VaccineTaken } from "./vaccinetaken.model";
export interface HealthBackground {
    HealthBackgroundId: number;
    IsMalnurish: boolean;
    IsPwd: boolean;
    IsActive: boolean;
    PreExistingConditionId: number;
    PreExistingCondition: PreExistingCondition;
    VaccineTakenId: number;
    VaccineTaken: VaccineTaken;

}
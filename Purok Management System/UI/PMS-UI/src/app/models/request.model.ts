import { RequestType } from "./requesttype.model";
import { Person } from "./person.model";

export interface Request {
    RequestId: number;
    DateRequested: Date | string;
    PickUpDate: Date | string;
    Status: string;
    RequestTypeId: number;
    RequestType: RequestType;
    PersonId: number;
    Person: Person | null;
}

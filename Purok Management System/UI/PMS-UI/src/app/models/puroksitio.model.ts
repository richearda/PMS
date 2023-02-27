import { Barangay } from "./barangay.model";

export interface PurokSitio {
    PurokSitioId: number;
    PurokSitioName: string;
    IsActive: boolean;
    BarangayId: number;
    Barangay: Barangay;

}

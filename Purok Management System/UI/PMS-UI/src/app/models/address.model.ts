import { CityMunicipality } from "./citymunicipality.model";
import { Barangay } from "./barangay.model";
import { PurokSitio } from "./puroksitio.model";
export interface Address {
    AddressId: number;
    HouseBlockLotNo: string;
    Street: string;
    CityMunicipalityId: number;
    CityMunicipality: CityMunicipality;
    BarangayId: number;
    Barangay: Barangay;
    PurokSitioId: number;
    PurokSitio: PurokSitio;
}

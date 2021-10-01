namespace SDD.Administration {
    export interface ListRequestForum extends Serenity.ServiceRequest {
        IdMasterForum?: number;
        DetailForum?: string;
        FotoDokumenForum?: string;
        HiddenUser?: Transaction.MyEnumStatus;
    }
}


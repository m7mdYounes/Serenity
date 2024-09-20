import { fieldsProxy } from "@serenity-is/corelib";

export interface EmployeeRow {
    Id?: number;
    FullName?: string;
    HireDate?: string;
    BirthDate?: string;
    Salary?: number;
    Image?: string;
    Age?: number;
}

export abstract class EmployeeRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'FullName';
    static readonly localTextPrefix = 'Personnel.Employee';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<EmployeeRow>();
}
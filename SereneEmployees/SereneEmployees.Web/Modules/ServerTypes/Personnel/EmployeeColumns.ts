import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { EmployeeRow } from "./EmployeeRow";

export interface EmployeeColumns {
    Id: Column<EmployeeRow>;
    FullName: Column<EmployeeRow>;
    HireDate: Column<EmployeeRow>;
    Age: Column<EmployeeRow>;
    Salary: Column<EmployeeRow>;
}

export class EmployeeColumns extends ColumnsBase<EmployeeRow> {
    static readonly columnsKey = 'Personnel.Employee';
    static readonly Fields = fieldsProxy<EmployeeColumns>();
}
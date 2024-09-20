import { EmployeeColumns, EmployeeRow, EmployeeService } from '@/ServerTypes/Personnel';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { EmployeeDialog } from './EmployeeDialog';

@Decorators.registerClass('SereneEmployees.Personnel.EmployeeGrid')
export class EmployeeGrid extends EntityGrid<EmployeeRow> {
    protected getColumnsKey() { return EmployeeColumns.columnsKey; }
    protected getDialogType() { return EmployeeDialog; }
    protected getRowDefinition() { return EmployeeRow; }
    protected getService() { return EmployeeService.baseUrl; }
}
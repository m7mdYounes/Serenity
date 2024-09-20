import { EmployeeForm, EmployeeRow, EmployeeService } from '@/ServerTypes/Personnel';
import { Decorators, EntityDialog } from '@serenity-is/corelib';


@Decorators.registerClass('SereneEmployees.Personnel.EmployeeDialog')
export class EmployeeDialog extends EntityDialog<EmployeeRow, any> {
    protected getFormKey() { return EmployeeForm.formKey; }
    protected getRowDefinition() { return EmployeeRow; }
    protected getService() { return EmployeeService.baseUrl; }

    protected form = new EmployeeForm(this.idPrefix);

    protected validateBeforeSave(): boolean {
        if (!super.validateBeforeSave()) {
            return false;
        }

        // Parse Birth Date (since it's a string)
        const birthDateString = this.form.BirthDate.value;
        const birthDate = new Date(birthDateString);
        if (isNaN(birthDate.getTime())) {
            alert('Invalid birth date.');
            return false;
        }

        // Calculate age
        const age = this.calculateAge(birthDate);
        if (age < 25 || age > 60) {
                alert('Age must be between 25 and 60 years.');
            return false;
        }

        // Parse Hire Date (since it's a string)
        const hireDateString = this.form.HireDate.value;
        const hireDate = new Date(hireDateString);
        if (isNaN(hireDate.getTime())) {
            alert('Invalid hire date.');
            return false;
        }

        // Validate Hire Date (Must be on or after January 1st, 2020)
        const minHireDate = new Date(2020, 0, 1); // January 1st, 2020
        if (hireDate < minHireDate) {
                alert('Hire date must be on or after January 1st, 2020.');
            return false;
        }

        return true;
    }

    // Helper function to calculate age
    private calculateAge(birthDate: Date): number {
        const today = new Date();
        let age = today.getFullYear() - birthDate.getFullYear();
        const monthDifference = today.getMonth() - birthDate.getMonth();
        if (monthDifference < 0 || (monthDifference === 0 && today.getDate() < birthDate.getDate())) {
            age--;
        }
        return age;
    }
}

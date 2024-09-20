import { StringEditor, DateEditor, DecimalEditor, ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface EmployeeForm {
    FullName: StringEditor;
    HireDate: DateEditor;
    BirthDate: DateEditor;
    Salary: DecimalEditor;
    Image: ImageUploadEditor;
}

export class EmployeeForm extends PrefixedContext {
    static readonly formKey = 'Personnel.Employee';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!EmployeeForm.init)  {
            EmployeeForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = DecimalEditor;
            var w3 = ImageUploadEditor;

            initFormType(EmployeeForm, [
                'FullName', w0,
                'HireDate', w1,
                'BirthDate', w1,
                'Salary', w2,
                'Image', w3
            ]);
        }
    }
}
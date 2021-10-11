namespace SDD.Transaction {
    export interface ParentMessageForm {
        Title: Serenity.StringEditor;
        Option1: Serenity.RadioButtonEditor;
        Message: Serenity.StringEditor;
        Body: Serenity.TextAreaEditor;
        Detail: FcmMessageGrid;
    }

    export class ParentMessageForm extends Serenity.PrefixedContext {
        static formKey = 'Transaction.ParentMessage';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ParentMessageForm.init)  {
                ParentMessageForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.RadioButtonEditor;
                var w2 = s.TextAreaEditor;
                var w3 = FcmMessageGrid;

                Q.initFormType(ParentMessageForm, [
                    'Title', w0,
                    'Option1', w1,
                    'Message', w0,
                    'Body', w2,
                    'Detail', w3
                ]);
            }
        }
    }
}


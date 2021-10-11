namespace SDD.Transaction {

    @Serenity.Decorators.registerEditor()
    export class MyCustomEditor extends Serenity.Select2Editor<any, any> {

        constructor(container: JQuery) {
            super(container, null);

            // add option accepts a key (id) value and display text value
            this.addOption("1", "Semua");
            this.addOption("0", "Individual");

        }




    }
}
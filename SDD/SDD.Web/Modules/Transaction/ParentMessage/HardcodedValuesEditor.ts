
namespace SDD.Transaction {


    @Serenity.Decorators.registerEditor()
    export class HardcodedValuesEditor extends Serenity.Select2Editor<Int16Array, any> {

        constructor(container: JQuery) {
            super(container, null);

            // add option accepts a key (id) value and display text value
            this.addOption("key1", "Text 1");
            this.addOption("key2", "Text 2");

            // you may also use addItem which accepts a Select2Item parameter
            this.addItem({
                id: "key3",
                text: "Text 3"
            });

            // don't let selecting this one (disabled)
            this.addItem({
                id: "key4",
                text: "Text 4",
                disabled: true
            });
        }
    }
}
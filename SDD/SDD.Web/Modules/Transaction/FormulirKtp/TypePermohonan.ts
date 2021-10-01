﻿
namespace SDD.Transaction {

    /**
     * Our select editor with hardcoded values.
     * 
     * When you define a new editor type, make sure you build
     * and transform templates for it to be available 
     * in server side forms, e.g. [HardCodedValuesEditor]
     */
    @Serenity.Decorators.registerEditor()
    export class TypePermohonan extends Serenity.Select2Editor<any, any> {

        constructor(container: JQuery) {
            super(container, null);

            // add option accepts a key (id) value and display text value
            this.addOption("Baru", "Baru");
            this.addOption("Perpanjangan", "Perpanjangan");
            this.addOption("Penggantian", "Penggantian");
            
            // you may also use addItem which accepts a Select2Item parameter

        }
    }
}
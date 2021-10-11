
namespace SDD.Transaction {
    @Serenity.Decorators.panel()
    @Serenity.Decorators.registerClass()
    export class FormulirAktaKelahiranDialog extends Serenity.EntityDialog<FormulirAktaKelahiranRow, any> {
        protected getFormKey() { return FormulirAktaKelahiranForm.formKey; }
        protected getIdProperty() { return FormulirAktaKelahiranRow.idProperty; }
        protected getLocalTextPrefix() { return FormulirAktaKelahiranRow.localTextPrefix; }
        protected getNameProperty() { return FormulirAktaKelahiranRow.nameProperty; }
        protected getService() { return FormulirAktaKelahiranService.baseUrl; }
        protected getDeletePermission() { return FormulirAktaKelahiranRow.deletePermission; }
        protected getInsertPermission() { return FormulirAktaKelahiranRow.insertPermission; }
        protected getUpdatePermission() { return FormulirAktaKelahiranRow.updatePermission; }

        protected form = new FormulirAktaKelahiranForm(this.idPrefix);
        protected afterLoadEntity() {
            super.afterLoadEntity();
            this.toolbar.findButton(".delete-button").remove();

            var categoryAnchor = this.form.DetailFormulir.element.closest('.category').find('.category-anchor');
            categoryAnchor.text("Data Saksi");


            let categoryAnchor2 = this.element.find(".category-title:contains('Detail Formulir')").find('.category-anchor');

            let categoryAnchorName = categoryAnchor2.attr('name');

            categoryAnchor.closest('.s-PropertyGrid').find(`a[href='#${categoryAnchorName}']`).hide();
        }
    }
}
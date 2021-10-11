
namespace SDD.Transaction {


    @Serenity.Decorators.registerClass()
    export class ParentMessageDialog extends Serenity.EntityDialog<ParentMessageRow, any> {
        protected getFormKey() { return ParentMessageForm.formKey; }
        protected getIdProperty() { return ParentMessageRow.idProperty; }
        protected getLocalTextPrefix() { return ParentMessageRow.localTextPrefix; }
        protected getNameProperty() { return ParentMessageRow.nameProperty; }
        protected getService() { return ParentMessageService.baseUrl; }
        protected getDeletePermission() { return ParentMessageRow.deletePermission; }
        protected getInsertPermission() { return ParentMessageRow.insertPermission; }
        protected getUpdatePermission() { return ParentMessageRow.updatePermission; }

        protected form = new ParentMessageForm(this.idPrefix);


        constructor(container: JQuery) {
            super();


            this.form = new ParentMessageForm(this.idPrefix);
            this.form.Option1.change(e => {
                var trackstatus = Q.toId(this.form.Option1.value);

                if (trackstatus == 0) {


                    this.form.Detail.element.closest('.category').toggle(true);
                    console.log("Individual");
                } else if (trackstatus == 1) {

                    this.form.Detail.element.closest('.category').toggle(false);
                    console.log("SendAll");
                }


            });

        }

        protected beforeLoadEntity(entity) {
            super.beforeLoadEntity(entity);

          
            var categoryAnchor = this.form.Detail.element.closest('.category').find('.category-anchor');
            categoryAnchor.text("Penerima Broadcast");
        

            let categoryAnchor2 = this.element.find(".category-title:contains('Detail Message')").find('.category-anchor');

            let categoryAnchorName = categoryAnchor2.attr('name');

            categoryAnchor2.closest('.s-PropertyGrid').find(`a[href='#${categoryAnchorName}']`).hide();
            
            let categoryAnchor3 = this.element.find(".category-title:contains('Message')").find('.category-anchor');

            let categoryAnchorName2 = categoryAnchor2.attr('name');

            categoryAnchor3.closest('.s-PropertyGrid').find(`a[href='#${categoryAnchorName2}']`).hide();

        


        }
   

    }
    }



import ko from "../knockoutjs/koIndex.js";
function TestViewModel(){
    const viewModel = this; 
    this.name = ko.observable('');
    this.lastName = ko.observable('');
    this.age = ko.observable(0);
    this.fullname = ko.computed( () => {
        return viewModel.name() + ' ' + viewModel.lastName();
    });
}

ko.applyBindings(new TestViewModel());
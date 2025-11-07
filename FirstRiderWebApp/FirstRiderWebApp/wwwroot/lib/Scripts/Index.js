import ko from "../knockoutjs/koIndex.js";
function TestViewModel(){
    const viewModel = this; 
    this.name = ko.observable('');
    this.lastName = ko.observable('');
    this.age = ko.observable(0);
    this.fullname = ko.computed( () => {
        return viewModel.name() + ' ' + viewModel.lastName();
    });
    this.displayAge = function(){
        this.age(8);
        console.log("hej");
    }
}

ko.applyBindings(new TestViewModel());
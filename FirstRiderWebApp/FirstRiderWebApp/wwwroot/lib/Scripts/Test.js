import ko from "../knockoutjs/koIndex.js";
function TestViewModel(){
    this.name = ko.observable('');
    this.age = ko.observable(0);
}

ko.applyBindings(new TestViewModel());
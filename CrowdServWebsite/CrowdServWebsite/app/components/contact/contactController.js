(function () {
    angular
        .module("csApp")
        .controller("contactController", ['contactService', contactController]);

    function contactController(contactService) {
        var vm = this;
    }

})();
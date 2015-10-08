(function () {
    angular
		.module('csApp')
		.service('contactService', ['$q', '$http', 'ContactUrls', contactService])

    function contactService($q, $http, ContactUrls) {
        var service = {};

        return service;
    }

})();
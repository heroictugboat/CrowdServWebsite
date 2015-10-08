(function () {
    angular
        .module("crowdServ", ['ui.router'])
        .constant('ContactUrls', {
            getTopics: '/api/contact/topics',
            postRequest: '/api/contact/request'
        });
})();
(function () {
    angular
        .module('crowdServ')
        .config(['$locationProvider', '$stateProvider', '$urlRouterProvider', Config]);

    function Config($locationProvider, $stateProvider, $urlRouterProvider) {
        $locationProvider.html5Mode(true);

        $urlRouterProvider.otherwise('/');

        $stateProvider
            .state('index', { // index
                url: '/',
                templateUrl: 'app/components/index/indexView.html',
                controller: 'indexController as vm'
            });
    }

})();
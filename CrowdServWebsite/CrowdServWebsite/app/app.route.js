(function () {
    'use strict';

    angular
        .module('csApp')
        .config(['$locationProvider', '$routeProvider', Config]);

    function Config($locationProvider, $routeProvider) {
        //$locationProvider.html5Mode(true);

        //$urlRouterProvider.otherwise('/home');

        $routeProvider
            .when('/', {
                templateUrl: 'app/components/index/index.html',
                controller: 'indexController',
                controllerAs: 'vm'
            }).when('/about', {
                templateUrl: 'app/components/about/about.html',
                controller: 'aboutController',
                controllerAs: 'vm'
            }).when('/team', {
                templateUrl: 'app/components/team/team.html',
                controller: 'teamController',
                controllerAs: 'vm'
            }).when('/contact', {
                templateUrl: 'app/components/contact/contact.html',
                controller: 'contactController',
                controllerAs: 'vm'
            });
            //.otherwise({
            //    redirectTo: '/home'
            //});
    }

})();
(function () {
    angular.module('CSApp')
        .config(['$routeProvider', '$urlRouterProvider', Config]);

    function Config($routeProvider) {

        $urlRouterProvider.otherwise('/home');

        $routeProvider
            .when('/about', {
                templateUrl: 'app/components/about/aboutView.html',
                controller: 'aboutController',
                controllerAs: 'vm'
            })
            .when('/contact', {
                templateUrl: 'app/components/contact/contactView.html',
                controller: 'contactController',
                controllerAs: 'vm'
            })
            .when('/home', {
                templateUrl: 'app/components/home/homeView.html',
                controller: 'homeController',
                controllerAs: 'vm'
            })
            .when('/team', {
                templateUrl: 'app/components/team/teamView.html',
                controller: 'teamController',
                controllerAs: 'vm'
            });
    }

})();
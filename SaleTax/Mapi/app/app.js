﻿var MyHomeApp = angular.module('SaleTax', ['ngRoute', 'ui.bootstrap', 'xeditable']);

MyHomeApp.config(['$routeProvider',
                function ($routeProvider) {
                    $routeProvider.
                      when('/addItems', {
                          templateUrl: 'app/views/items/addItems.html',
                          controller: 'itemController'
                      }).
                         when('/addItemCategories', {
                             templateUrl: 'app/views/items/addItemCategories.html',
                             controller: 'itemCategoryController'
                         }).
                      when('/addOrders', {
                          templateUrl: 'app/views/orders/addOrders.html',
                          controller: 'addOrderController'
                      }).
                      when('/orders', {
                          templateUrl: 'app/views/orders/orders.html',
                          controller: 'orderController'
                      }).
                      otherwise({
                          redirectTo: 'app/views/orders/orders.html',
                          controller: 'itemController'
                      });
                }]);



//'use strict';

//var app = angular.module('SaleTax', [
//  'ui.router',
//  'ui.bootstrap',
//  'ui.router.tabs'
//]);

//app.config(['$stateProvider', function ($stateProvider) {
//    $stateProvider.state('user', {
//        url: '',
//        controller: 'itemCategoryController',
//        templateUrl: 'app/views/items/addItemCategories.html'
//    }).state('user.accounts', {
//        url: '/user/accounts',
//        controller: 'menuController',
//        templateUrl: 'app/views/menu/menu.html'
//    }).state('user.settings', {
//        url: '/user/settings',
//        controller: 'SettingsCtrl',
//        templateUrl: 'app/views/menu/menu.html'
//    }).state('user.heading2', {
//        url: '/user/heading2',
//        templateUrl: 'app/views/menu/menu.html'
//    })
//        .state('user.settings.one', {
//            url: '/one',
//            template: '<div>Settings nested route 1</div>'
//        }).state('user.settings.two', {
//            url: '/two',
//            template: '<div>Settings nested route 2</div>'
//        });
//}]);


//'use strict';


//'use strict';

//var SettingsCtrl = ['$rootScope', '$scope', '$stateParams', function ($rootScope, $scope) {

//    $scope.initialise = function () {

//        $scope.tabData = [
//          {
//              heading: 'One',
//              route: 'user.settings.one',
//              url: 'user/settings/one/:test',
//              controller: 'tabController'
//          },
//          {
//              heading: 'Two',
//              route: 'user.settings.two'
//          }
//        ];
//    };

//    $scope.initialise();
//}];

//angular.module('SaleTax').controller('SettingsCtrl', SettingsCtrl);


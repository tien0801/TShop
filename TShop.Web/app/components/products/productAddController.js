(function (app) {
    app.controller('productAddController', productAddController)

    productAddController.$inject = ['$scope', 'apiService', 'notificationService', '$state'];

    function productAddController($scope, apiService, notificationService, $state) {
        $scope.product = {
            CreateDate: new Date(),
            Status: true
        }
        $scope.ckeditorOptions = {
            language: 'vi',
            height: '200px'
        }

        $scope.AddProduct = AddProduct;

        function AddProduct() {
            apiService.post('api/product/create', $scope.product,
                function (result) {
                    notificationService.displaySuccess(result.data.Name + ' đã thêm mới');
                    $state.go('products');
                }, function (error) {
                    notificationService.displayError('Thêm mới không thành công.');
                });
        }

        function loadProductCategory() {
            apiService.get('api/productcategory/getallparents', null, function (result) {
                $scope.productCategories = result.data;
            }, function () {
                console.log('Cannot get list parent');
            });
        }
        loadProductCategory();
    }
})(angular.module('tshop.product_categories'));
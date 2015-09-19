module app.postAdd {

    interface IAddPostViewModel {
        post: app.domain.IPost;
        add(): void;
    }

    class PostAddCtrl implements IAddPostViewModel {

        post: app.domain.IPost;

        static $inject = ['$location', 'constantService', 'dataService'];
        constructor(private $location: ng.ILocationService,
            private constantService: app.common.services.ConstantService,
            private dataService: app.common.services.DataService) {
        }


        add(): void {
            this.dataService.add(this.constantService.apiPostURI, this.post)
                .then((result: app.domain.IPost) => {
                    alert(result.Title + ' submitted successfully');
                    this.$location.path('/');
                });
        }
    }
    angular.module('chsakellBlogApp')
        .controller('PostAddCtrl', PostAddCtrl);
}
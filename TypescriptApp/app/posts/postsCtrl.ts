module app.postList {

    interface IPostsViewModel {
        posts: app.domain.IPost[];
        remove(Id: number): void;
    }

    class PostsCtrl implements IPostsViewModel {

        posts: app.domain.IPost[];

        static $inject = ['constantService', 'dataService'];
        constructor(private constantService: app.common.services.ConstantService,
            private dataService: app.common.services.DataService) {
            this.getPosts();
        }

        remove(Id: number): void {
            var self = this; // Attention here.. check 'this' in TypeScript and JavaScript

            this.dataService.remove(this.constantService.apiPostURI + Id)
                .then(function (result) {
                    self.getPosts();
                });
        }

        getPosts(): void {
            this.dataService.get(this.constantService.apiPostURI).then((result: app.domain.IPost[]) => {
                this.posts = result;
            });
        }
    }
    angular.module('chsakellBlogApp')
        .controller('PostsCtrl', PostsCtrl);
}
module app.common.services {

    interface IConstant {
        apiPostURI: string;
    }

    export class ConstantService implements IConstant {
        apiPostURI: string;

        constructor() {
            this.apiPostURI = '/api/posts/';
        }
    }

    angular.module('chsakellBlogApp')
        .service('constantService', ConstantService);
}
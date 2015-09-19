module app.domain {
    export interface IPost {
        Id?: number;
        Title: string;
        Author: string;
        AuthorGravatar: string;
        URI: string;
        DatePublished: Date;
        ImageURI: string;
        Contents: string;
    }

    export class Post extends app.domain.EntityBase implements IPost {
        constructor(public Title: string,
            public Author: string,
            public AuthorGravatar: string,
            public URI: string,
            public DatePublished: Date,
            public ImageURI: string,
            public Contents: string,
            public Id?: number) {

            super();

            this.Id = Id;
            this.Title = Title;
            this.Author = Author;
            this.AuthorGravatar = AuthorGravatar;
            this.URI = URI;
            this.DatePublished = DatePublished;
            this.ImageURI = ImageURI;
            this.Contents = Contents;
        }
    }
}
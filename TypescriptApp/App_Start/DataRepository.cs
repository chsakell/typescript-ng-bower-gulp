using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TypescriptApp.Models;

namespace TypescriptApp.App_Start
{
    public class DataRepository
    {
        public static List<Post> Posts = new List<Post>()
        {
            new Post() {
                Id = 1,
                Title = "Building Single Page Applications using Web API and angularJS (Free e-book)",
                Author = "Chris S.",
                AuthorGravatar = "http://1.gravatar.com/avatar/cb562a6de0640f743a272496ccfc210e",
                URI = "http://chsakell.com/2015/08/23/building-single-page-applications-using-web-api-and-angularjs-free-e-book/",
                DatePublished = new DateTime(2015, 9, 23),
                ImageURI = "https://chsakell.files.wordpress.com/2015/08/spa-webapi-angular-011.png",
                Contents = "Single Page Applications are getting more and more attractive nowadays for two basic reasons. Website users have always preferred a fluid user experience than one with page reloads and the incredible growth of several JavaScript frameworks such as angularJS. This growth in conjunction with all the powerful server side frameworks makes Single Page Application development a piece of cake. This post is the online version of the free e-book and describes step by step how to build a production-level SPA using ASP.NET Web API 2 and angularJS. You have two choices. Either grab a coffee and keep going on with this version or simply download the e-book and enjoy it whenever and wherever you want."
            },
            new Post() {
                Id = 2,
                Title = "Dependency injection in WCF",
                Author = "Chris S.",
                AuthorGravatar = "http://1.gravatar.com/avatar/cb562a6de0640f743a272496ccfc210e",
                URI = "http://chsakell.com/2015/07/04/dependency-injection-in-wcf/",
                DatePublished = new DateTime(2015, 7, 4),
                ImageURI = "https://chsakell.files.wordpress.com/2015/07/wcf-dependency-injection-03.png",
                Contents = "Dependency injection is a software design pattern that implements inversion of control for resolving dependencies and is highly recommended for building scalable, testable and maintainable applications. In this very blog we have seen many times this pattern, mostly in ASP.NET MVC and ASP.NET Web API related posts where for example dependencies (data repositories or middle services) were injected into MVC constructors. We haven’t seen this pattern though in applications using the Windows Communication Framework. I decided to write this post cause I believe there many interesting things to cover when it comes to “marry” Dependency Injection and WCF. "
            },
            new Post() {
                Id = 3,
                Title = "ASP.NET Web API Unit Testing",
                Author = "Chris S.",
                AuthorGravatar = "http://1.gravatar.com/avatar/cb562a6de0640f743a272496ccfc210e",
                URI = "http://chsakell.com/2015/05/10/asp-net-web-api-unit-testing/",
                DatePublished = new DateTime(2015, 5, 10),
                ImageURI = "https://chsakell.files.wordpress.com/2015/05/web-api-unit-testing.png",
                Contents = "Unit testing can be beneficial to many aspects in software develepment, from the lowest level that is the source code to the highest level and the end user’s experience. Writing automated tests helps finding defects earlier in the development lifecycle process which leads to fewer late nights or weekend work (happier developers). Since defects are resolved before production, less defects reach end users (happier clients). It also increases reliability of source code, since if the base code doesn’t change all tests should always return the same results. Last but not least, anyone that decides to write unit tests is also forced to write testable code which leads to better software development practices."
            },
            new Post() {
                Id = 4,
                Title = "ASP.NET Web API feat. OData ",
                Author = "Chris S.",
                AuthorGravatar = "http://1.gravatar.com/avatar/cb562a6de0640f743a272496ccfc210e",
                URI = "http://chsakell.com/2015/04/04/asp-net-web-api-feat-odata/",
                DatePublished = new DateTime(2015, 4, 4),
                ImageURI = "https://chsakell.files.wordpress.com/2015/04/webapi-odata-13.png",
                Contents = "OData is an open standard protocol allowing the creation and consumption of queryable and interoperable RESTful APIs. It was initiated by Microsoft and it’s mostly known to .NET Developers from WCF Data Services. There are many other server platforms supporting OData services such as Node.js, PHP, Java and SQL Server Reporting Services. More over, Web API also supports OData and this post will show you how to integrate those two."
            },
            new Post() {
                Id = 5,
                Title = "ASP.NET MVC Solution Architecture – Best Practices",
                Author = "Chris S.",
                AuthorGravatar = "http://1.gravatar.com/avatar/cb562a6de0640f743a272496ccfc210e",
                URI = "http://chsakell.com/2015/02/15/asp-net-mvc-solution-architecture-best-practices/",
                DatePublished = new DateTime(2015, 2, 15),
                ImageURI = "https://chsakell.files.wordpress.com/2015/02/mvc-architecture-01.png",
                Contents = "Choosing the right architecture for Web Applications is a must, especially for large scale ones. Using the default Visual Studio ASP.NET MVC Web Application project templates, adding controllers with Scaffolding options, just to bootstrap your application and create pages and data in just a few minutes, sounds awesome for sure, but let’s be honest it’s not always the right choise. Peeking all the default options, keeping business, data and presentation logic in the same project will impact several factors in your solutions, such as scalability, usability or testability. In this post, will see how to keep things clean, creating a highly loosely coupled ASP.NET MVC Solution, where Data Access, Business and Presentation layers are defined in the right manner. "
            }
        };
    }
}
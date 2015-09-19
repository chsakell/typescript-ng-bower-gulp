/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');
var inject = require('gulp-inject');
var concat = require('gulp-concat');
var print = require('gulp-print');
var angularFilesort = require('gulp-angular-filesort');
var uglify = require('gulp-uglify');

gulp.task('spa-task', function () {
    var target = gulp.src('./views/home/index.cshtml');

    var appDomainStream = gulp.src(['./app/domain/*.js']);
    var appStream = gulp.src(['./app/*.js', './app/posts/*.js', './app/common/services/*.js']);

    return target
                .pipe(inject(appDomainStream
                        .pipe(print())
                        .pipe(concat('domain.js'))
                        .pipe(uglify())
                        .pipe(gulp.dest('.build/spa')), { name: 'domain' }))
                        .pipe(gulp.dest('./views/home/'))
                .pipe(inject(appStream
                        .pipe(print())
                        .pipe(concat('app.js'))
                        .pipe(uglify())
                        .pipe(gulp.dest('.build/spa')), { name: 'app' }))
                        .pipe(gulp.dest('./views/home/'))
});

gulp.task('vendors-task', function () {
    var target = gulp.src('./views/home/index.cshtml');

    var vendorStream = gulp.src(['./bower_components/angular-route/angular-route.js',
                                 './bower_components/angular/angular.js',
                                 './bower_components/bootstrap/dist/js/bootstrap.js',
                                 './bower_components/jquery/dist/jquery.js']);

    return target
        .pipe(inject(
            vendorStream.pipe(print())
                        .pipe(angularFilesort()) // comment out and the application will break
                        .pipe(concat('vendors.js'))
                        .pipe(gulp.dest('.build/vendors')), { name: 'vendors' }))
        .pipe(gulp.dest('./views/home/'));
});

gulp.task('css-task', function () {
    var target = gulp.src('./views/home/index.cshtml');

    var customCssStream = gulp.src(['./bower_components/bootstrap/dist/css/bootstrap.min.css',
                                    './Styles/site.css']);

    return target
        .pipe(inject(
            customCssStream.pipe(print())
            .pipe(concat('appStyles.css'))
            .pipe(gulp.dest('.build/css')), { name: 'styles' })
            )
        .pipe(gulp.dest('./views/home/'));
});


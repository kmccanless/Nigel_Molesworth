module("Dashboard tests against demo-jso-5-5.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:49331/demo.htm?userName=nmolesworth&debug=true&script=demo-json-5-5");
    },
//    teardown: function () {
//        S._window.close();
//    }
});

test("Page has content", function () {
    ok(S("body *").size(), "Page Loaded without elements")
});

test("Displays correct user name", function () {
    equal(S('#userName').text(), "Joe User", "User name is correct")
});

test("Displays correct role", function () {
    equal(S('#role').text(), "some role", "Role is correct")
});

test("Location defaults to All", function () {
    equal(S('#selLocations option:selected').val(), "All", "Dropdown did defaulted to All")
});

test("Location drop down contains correct locations", function () {
    var correct;
    var options = S('#selLocations').children()(function(){
        correct = correct + S(this).val();
    });
    equal(correct, "1356All", "Dropdown has correct locations")
});

//test count of workspaces
//test order of workspaces
//test count of KPI under each workspace
//test order of KPI
//test data of KPI

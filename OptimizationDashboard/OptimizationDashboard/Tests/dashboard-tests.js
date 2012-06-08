﻿module("Dashboard tests against demo-jso-5-5_all.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:49331/demo.htm?userName=nmolesworth&debug=true&script=demo-json-5-5_all");
    }
    //,
//    teardown: function () {
//        S._window.close();
//    }
});

//1.

test("Page has content", function () {
    ok(S("body *").size(), "Page Loaded without elements")
});
//2.

test("Displays correct user name", function () {
    equal(S('#userName').text(), "Joe User", "User name is correct")
});

//3.
test("Displays correct role", function () {
    equal(S('#role').text(), "some role", "Role is correct")
});

//4.
test("Location defaults to All", function () {
    equal(S('#selLocations option:selected').val(), "All", "Dropdown did defaulted to All");
});

//5.
test("Location drop down contains correct locations", function () {
    var correct;
    var options = S('#selLocations').children()(function () {
        correct = correct + S(this).val();
    });
    equal(correct, "1356All", "Dropdown has correct locations");
});

//6.
test("Location defaults to All", function () {
    equal(S('#selLocations option:selected').val(), "All", "Dropdown did defaulted to All");
});

//7.
test("Two workspaces present", function () {
    equal(S('.workspace').size(), 2, "Workspaces present");
});

//8.
test("5 KPIs under Top workspace", function () {
    var kpis = S('#workspace_1  .kpi').size();
    equal(kpis, 5, "Correct number of KPI");
});

//9.
test("5 KPIs under Bottom workspace", function () {
    var kpis = S('#workspace_2  .kpi').size();
    equal(kpis, 5, "Correct number of KPI");
});


//10.
test("Data correct in 1st KPI of top row", function () {
    equal(S('#id_1_1 #kpi_title').text(), "KPI1", "Title Test");
    equal(S('#id_1_1 #kpi_type').text(), "Minutes", "Type Test");
    equal(S('#id_1_1 #kpi_units').text(), "25", "Units Test");
    equal(S('#id_1_1 #kpi_formattedValue').text(), "60", "formattedValue Test");
    equal(S('#id_1_1 #kpi_formattedText').text(), "90", "formattedText Test");
    equal(S('#id_1_1 #kpi_firstWarn').text(), "60", "firstWarn Test");
    equal(S('#id_1_1 #kpi_secondWarn').text(), "90", "secondWarn Test");
});


//test order of KPI
//test data of KPI

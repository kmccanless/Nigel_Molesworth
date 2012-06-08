module("Dashboard tests against demo-json-5-5_3.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:49331/demo.htm?userName=nmolesworth&debug=true&script=demo-json-5-5_3");
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
    equal(S('#userName').text(), "John Doe", "User name is correct")
});

//3.
test("Displays correct role", function () {
    equal(S('#role').text(), "Shipper", "Role is correct")
});

//4.
test("Location defaults to 3", function () {
    equal(S('#selLocations option:selected').val(), "3", "Dropdown did defaulted to All");
});

test("Location drop down contains correct locations", function () {
    var correct;
    var currNode;
    var correct = S('#selLocations option').first().val();
    currNode = S('#selLocations option').first()
    for (var i = 1; i < S('#selLocations option').size(); i++) {
        currNode = currNode.next();
        correct = correct + currNode.val();
    }
    equal(correct, "3567All", "Testing dropdown has currect locations");
});


//6.
test("Location defaults to 3", function () {
    equal(S('#selLocations option:selected').val(), "3", "Dropdown did defaulted to 3");
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
    equal(S('#id_1_1 #kpi_title').text(), "FIRST LOAD", "Title Test");
    equal(S('#id_1_1 #kpi_type').text(), "Minutes", "Type Test");
    equal(S('#id_1_1 #kpi_units').text(), "16", "Units Test");
    equal(S('#id_1_1 #kpi_formatted_value').text(), "15", "formattedValue Test");
    equal(S('#id_1_1 #kpi_formatted_target').text(), "9", "formattedTarget Test");
    equal(S('#id_1_1 #kpi_firstWarn').text(), "300", "firstWarn Test");
    equal(S('#id_1_1 #kpi_secondWarn').text(), "450", "secondWarn Test");
});


//test order of KPI
//test data of KPI

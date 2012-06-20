module("Dashboard tests against demo-jso-5-5.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:49331/demo.htm?userName=nmolesworth&debug=true&script=demo-json-5-5");
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
    var currNode;
    var correct = S('#selLocations option').first().val();
    currNode = S('#selLocations option').first()
    for (var i = 1; i < S('#selLocations option').size(); i++) {
        currNode = currNode.next();
        correct = correct + currNode.val();
    }
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
    equal(S('#id_1_1 #kpi_type').text(), "02", "Type Test");
    equal(S('#id_1_1 #kpi_units').text(), "20", "Units Test");
    equal(S('#id_1_1 #kpi_formatted_value').text(), "50%", "formattedValue Test");
    equal(S('#id_1_1 #kpi_formatted_target').text(), "75%", "formattedText Test");
    equal(S('#id_1_1 #kpi_firstWarn').text(), "20", "firstWarn Test");
    equal(S('#id_1_1 #kpi_secondWarn').text(), "30", "secondWarn Test");
});

//11
test("Data correct in 2nd KPI of top row", function () {
    equal(S('#id_1_2 #kpi_title').text(), "KPI2", "Title Test");
    equal(S('#id_1_2 #kpi_type').text(), "01", "Type Test");
    equal(S('#id_1_2 #kpi_units').text(), "10", "Units Test");
    equal(S('#id_1_2 #kpi_formatted_value').text(), "14", "formattedValue Test");
    equal(S('#id_1_2 #kpi_formatted_target').text(), "13", "formattedText Test");
    equal(S('#id_1_2 #kpi_firstWarn').text(), "120", "firstWarn Test");
    equal(S('#id_1_2 #kpi_secondWarn').text(), "125", "secondWarn Test");
});

//12
test("Data correct in 3rd KPI of top row", function () {
    equal(S('#id_1_3 #kpi_title').text(), "KPI3", "Title Test");
    equal(S('#id_1_3 #kpi_type').text(), "01", "Type Test");
    equal(S('#id_1_3 #kpi_units').text(), "10", "Units Test");
    equal(S('#id_1_3 #kpi_formatted_value').text(), "72", "formattedValue Test");
    equal(S('#id_1_3 #kpi_formatted_target').text(), "30", "formattedText Test");
    equal(S('#id_1_3 #kpi_firstWarn').text(), "450", "firstWarn Test");
    equal(S('#id_1_3 #kpi_secondWarn').text(), "900", "secondWarn Test");
});

//13
test("Data correct in 4th KPI of top row", function () {
    equal(S('#id_1_4 #kpi_title').text(), "KPI4", "Title Test");
    equal(S('#id_1_4 #kpi_type').text(), "04", "Type Test");
    equal(S('#id_1_4 #kpi_units').text(), "25", "Units Test");
    equal(S('#id_1_4 #kpi_formatted_value').text(), "7", "formattedValue Test");
    equal(S('#id_1_4 #kpi_formatted_target').text(), "9", "formattedText Test");
    equal(S('#id_1_4 #kpi_firstWarn').text(), "240", "firstWarn Test");
    equal(S('#id_1_4 #kpi_secondWarn').text(), "275", "secondWarn Test");
});

//14
test("Data correct in 5th KPI of top row", function () {
    equal(S('#id_1_5 #kpi_title').text(), "KPI5", "Title Test");
    equal(S('#id_1_5 #kpi_type').text(), "02", "Type Test");
    equal(S('#id_1_5 #kpi_units').text(), "250", "Units Test");
    equal(S('#id_1_5 #kpi_formatted_value').text(), "52%", "formattedValue Test");
    equal(S('#id_1_5 #kpi_formatted_target').text(), "90%", "formattedText Test");
    equal(S('#id_1_5 #kpi_firstWarn').text(), "250", "firstWarn Test");
    equal(S('#id_1_5 #kpi_secondWarn').text(), "275", "secondWarn Test");
});

//15
test("Data correct in 1st KPI of top row", function () {
    equal(S('#id_2_1 #kpi_title').text(), "KPI1", "Title Test");
    equal(S('#id_2_1 #kpi_type').text(), "02", "Type Test");
    equal(S('#id_2_1 #kpi_units').text(), "200", "Units Test");
    equal(S('#id_2_1 #kpi_formatted_value').text(), "52%", "formattedValue Test");
    equal(S('#id_2_1 #kpi_formatted_target').text(), "100%", "formattedText Test");
    equal(S('#id_2_1 #kpi_firstWarn').text(), "200", "firstWarn Test");
    equal(S('#id_2_1 #kpi_secondWarn').text(), "50", "secondWarn Test");
});

//16
test("Data correct in 2nd KPI of top row", function () {
    equal(S('#id_2_2 #kpi_title').text(), "KPI2", "Title Test");
    equal(S('#id_2_2 #kpi_type').text(), "01", "Type Test");
    equal(S('#id_2_2 #kpi_units').text(), "3", "Units Test");
    equal(S('#id_2_2 #kpi_formatted_value').text(), "33", "formattedValue Test");
    equal(S('#id_2_2 #kpi_formatted_target').text(), "57", "formattedText Test");
    equal(S('#id_2_2 #kpi_firstWarn').text(), "150", "firstWarn Test");
    equal(S('#id_2_2 #kpi_secondWarn').text(), "160", "secondWarn Test");
});

//17
test("Data correct in 3rd KPI of top row", function () {
    equal(S('#id_2_3 #kpi_title').text(), "KPI3", "Title Test");
    equal(S('#id_2_3 #kpi_type').text(), "03", "Type Test");
    equal(S('#id_2_3 #kpi_units').text(), "100", "Units Test");
    equal(S('#id_2_3 #kpi_formatted_value').text(), "1", "formattedValue Test");
    equal(S('#id_2_3 #kpi_formatted_target').text(), "2", "formattedText Test");
    equal(S('#id_2_3 #kpi_firstWarn').text(), "150", "firstWarn Test");
    equal(S('#id_2_3 #kpi_secondWarn').text(), "160", "secondWarn Test");
});

//18
test("Data correct in 4th KPI of top row", function () {
    equal(S('#id_2_4 #kpi_title').text(), "KPI4", "Title Test");
    equal(S('#id_2_4 #kpi_type').text(), "04", "Type Test");
    equal(S('#id_2_4 #kpi_units').text(), "30", "Units Test");
    equal(S('#id_2_4 #kpi_formatted_value').text(), "5", "formattedValue Test");
    equal(S('#id_2_4 #kpi_formatted_target').text(), "6", "formattedText Test");
    equal(S('#id_2_4 #kpi_firstWarn').text(), "150", "firstWarn Test");
    equal(S('#id_2_4 #kpi_secondWarn').text(), "160", "secondWarn Test");
});

//19
test("Data correct in 5th KPI of top row", function () {
    equal(S('#id_2_5 #kpi_title').text(), "KPI5", "Title Test");
    equal(S('#id_2_5 #kpi_type').text(), "02", "Type Test");
    equal(S('#id_2_5 #kpi_units').text(), "50", "Units Test");
    equal(S('#id_2_5 #kpi_formatted_value').text(), "60%", "formattedValue Test");
    equal(S('#id_2_5 #kpi_formatted_target').text(), "50%", "formattedText Test");
    equal(S('#id_2_5 #kpi_firstWarn').text(), "30", "firstWarn Test");
    equal(S('#id_2_5 #kpi_secondWarn').text(), "50", "secondWarn Test");
});
//test order of KPI
//test data of KPI

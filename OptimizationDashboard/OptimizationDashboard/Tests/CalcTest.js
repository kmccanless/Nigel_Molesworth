module("Dashboard tests against demo-json-5-5.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:54661/dashboard.htm?userName=nmolesworth&debug=true&script=demo-json-5-5");
    }
    //,
    //    teardown: function () {
    //        S._window.close();
    //    }
});

//1.
test("Page has content", function () {
    ok(S("body *").size(), "Page Loaded without elements");
});

//2.
test("Displays correct user name", function () {
    equal(S('div.title').text(), "Joe User", "User name test");
});
//3.
test("Displays correct role", function () {
    equal(S('div.role').text(), "some role Scoreboard", "Role test");
});

//4.
test("Current location All", function () {
    equal(S('#currentLocation').text(), "1, 3, 5, 6", "All locations displayed");
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
    equal(S('#id_1_1 .kpiTitle').text(), "KPI1", "Title Test");
    equal(S('#id_1_1 .kpiValue').text(), "50%", "formatted KPI Value Test");
    equal(S('#id_1_1 .kpiTarget').text(), "75%", "formatted KPI Target Test");
});

//11
test("Data correct in 2nd KPI of top row", function () {
    equal(S('#id_1_2 .kpiTitle').text(), "KPI2", "Title Test");
    equal(S('#id_1_2 .kpiValue').text(), "0:14", "formatted KPI Value Test");
    equal(S('#id_1_2 .kpiTarget').text(), "0:13", "formatted KPI Target Test");
});

//12
test("Data correct in 3rd KPI of top row", function () {
    equal(S('#id_1_3 .kpiTitle').text(), "KPI3", "Title Test");
    equal(S('#id_1_3 .kpiValue').text(), "1:12", "formatted KPI Value Test");
    equal(S('#id_1_3 .kpiTarget').text(), "0:30", "formatted KPI Target Test");
});

//13
test("Data correct in 4th KPI of top row", function () {
    equal(S('#id_1_4 .kpiTitle').text(), "KPI4", "Title Test");
    equal(S('#id_1_4 .kpiValue').text(), "7.20", "formatted KPI Value Test");
    equal(S('#id_1_4 .kpiTarget').text(), "9.00", "formatted KPI Target Test");
});

//14
test("Data correct in 5th KPI of top row", function () {
    equal(S('#id_1_5 .kpiTitle').text(), "KPI5", "Title Test");
    equal(S('#id_1_5 .kpiValue').text(), "52%", "formatted KPI Value Test");
    equal(S('#id_1_5 .kpiTarget').text(), "90%", "formatted KPI Target Test");
});

//15
test("Data correct in 1st KPI of bottom row", function () {
    equal(S('#id_2_1 .kpiTitle').text(), "KPI1", "Title Test");
    equal(S('#id_2_1 .kpiValue').text(), "52%", "formatted KPI Value Test");
    equal(S('#id_2_1 .kpiTarget').text(), "100%", "formatted KPI Target Test");
});

//16
test("Data correct in 2nd KPI of bottom row", function () {
    equal(S('#id_2_2 .kpiTitle').text(), "KPI2", "Title Test");
    equal(S('#id_2_2 .kpiValue').text(), "1:20", "formatted KPI Value Test");
    equal(S('#id_2_2 .kpiTarget').text(), "1:25", "formatted KPI Target Test");
});

//17
test("Data correct in 3rd KPI of bottom row", function () {
    equal(S('#id_2_3 .kpiTitle').text(), "KPI3", "Title Test");
    equal(S('#id_2_3 .kpiValue').text(), "$1.30", "formatted KPI Value Test");
    equal(S('#id_2_3 .kpiTarget').text(), "$1.70", "formatted KPI Target Test");
});

//18
test("Data correct in 4th KPI of bottom row", function () {
    equal(S('#id_2_4 .kpiTitle').text(), "KPI4", "Title Test");
    equal(S('#id_2_4 .kpiValue').text(), "4.67", "formatted KPI Value Test");
    equal(S('#id_2_4 .kpiTarget').text(), "5.67", "formatted KPI Target Test");
});

//19
test("Data correct in 5th KPI of bottom row", function () {
    equal(S('#id_2_5 .kpiTitle').text(), "KPI5", "Title Test");
    equal(S('#id_2_5 .kpiValue').text(), "60%", "formatted KPI Value Test");
    equal(S('#id_2_5 .kpiTarget').text(), "50%", "formatted KPI Target Test");
});

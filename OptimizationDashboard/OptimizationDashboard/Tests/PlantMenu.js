module("Dashboard tests against demo-json-1-2.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:54661/dashboard.htm?userName=nmolesworth&debug=true&script=demo-json-1-2");
    }
    //,
    //    teardown: function () {
    //        S._window.close();
    //    }
});



test("Dropdown menu and Plants display", function () {
    equal(S('#currentLocation').text(), "5", "Active Plant, expected - 5")
    S('#plants').visible().click()
    equal(S('#locationMenu .menuItem').text(), "  3  5  6All", "Dropdown menu test")
});

test("Plants displayed", function () {
    equal(S('#currentLocation').text(), "5", "Plant 5 should be displayed");
});




module("Dashboard tests against demo-json-1-5.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:54661/dashboard.htm?userName=nmolesworth&debug=true&script=demo-json-1-5");
    }
});

test("Dropdown menu and Plants display", function () {
    equal(S('#currentLocation').text(), "South", "Active Plant, expected - South")
    S('#plants').visible().click()
    equal(S('#locationMenu .menuItem').text(), "Elk LakeSouth12356789101112131516171819All", "Dropdown menu test")
});

test("Plants displayed", function () {
    equal(S('#currentLocation').text(), "South", "Plant South should be displayed");
});

//module("Dashboard tests against demo-json-1-5.js", {
//    setup: function () {
        // opens the page you want to test
//        S.open("http://localhost:54661/dashboard.htm?userName=nmolesworth&debug=true&script=demo-json-4-4_all");
//    }
//});

//test("Dropdown menu and Plants display", function () {
//    equal(S('#currentLocation').text(), "1, 2, 3, 5, 6...", "All plants displayed unless more than 15 chars total")
//    S('#plants').visible().click()
//    equal(S('#locationMenu .menuItem').text(), "123567All", "Dropdown menu test")
//});

//test("Plants displayed", function () {
//    equal(S('#currentLocation').text(), "1, 2, 3, 5, 6...", "All plants displayed unless more than 15 chars total");
//});

//module("Dashboard tests against demo-json-1-5.js", {
//    setup: function () {
//        // opens the page you want to test
//        S.open("http://localhost:54661/dashboard.htm?userName=nmolesworth&debug=true&script=demo-json-6-2");
//    }
//});

//test("Dropdown menu and Plants display", function () {
//    equal(S('#currentLocation').text(), "HighPlantSouthWest...", "Long plant name first displayed")
//    S('#plants').visible().click()
//    equal(S('#locationMenu .menuItem').text(), "HighPlantSouthWest356All", "Dropdown menu test")
//});

//test("Plants displayed", function () {
//    equal(S('#currentLocation').text(), "HighPlantSouthWest...", "Only first, long plant name displayed");
//});
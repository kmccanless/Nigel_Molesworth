module("Dashboard tests against demo-jso-2-4.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:54661/dashboard.htm?userName=nmolesworth&debug=true&script=demo-json-2-4");
    }
    //,
    //    teardown: function () {
    //        S._window.close();
    //    }
});

//1.
test("2 KPIs under Top workspace", function () {
    var kpis = S('#workspace_1  .kpi').size();
    equal(kpis, 2, "Correct number of KPI");
});

//2.
test("4 KPIs under Bottom workspace", function () {
    var kpis = S('#workspace_2  .kpi').size();
    equal(kpis, 4, "Correct number of KPI");
});


//3.
test("Width of top first widget with 2 widgets", function () {
    var width = S('#workspace_1  .kpi').width();
  //  var percentWide = width / (document.body.offsetWidth) * 100;
    var percentWide = Math.round(width / (window.innerWidth) * 100);
    equal(percentWide, 19, "Correct widget width 19%");
});

test("Height of top first widget at least 200 pixels", function () {
    var height = S('#workspace_1  .kpi').height();
    ok(height>=200, "Widget height at least 200 pixels");
});

//4.
test("Width of bottom first widget with 4", function () {
    var width = S('#workspace_2  .kpi').width();
  //  var percentWide = width / (document.body.offsetWidth) * 100;
    var percentWide = Math.round(width / (window.innerWidth) * 100);
    equal(percentWide, 17, "Correct widget width 17%");
});

test("Height of bottom first widget at least 200 pixels", function () {
    var height = S('#workspace_2  .kpi').height();
    ok(height >= 200, "Widget height at least 200 pixels");
});

module("Dashboard tests against demo-jso-5-3.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:54661/dashboard.htm?userName=nmolesworth&debug=true&script=demo-json-5-3");
    }
    //,
    //    teardown: function () {
    //        S._window.close();
    //    }
});

//5.
test("5 KPIs under Top workspace", function () {
    var kpis = S('#workspace_1  .kpi').size();
    equal(kpis, 5, "Correct number of KPI");
});

//6.
test("3 KPIs under Bottom workspace", function () {
    var kpis = S('#workspace_2  .kpi').size();
    equal(kpis, 3, "Correct number of KPI");
});


//7.
test("Width of top first widget with 5 widgets", function () {
    var width = S('#workspace_1  .kpi').width();
    var percentWide = Math.round(width / (window.innerWidth) * 100);
    equal(percentWide, 15, "Correct widget width 15%");
});

test("Height of top first widget at least 200 pixels", function () {
    var height = S('#workspace_1  .kpi').height();
    ok(height >= 200, "Widget height at least 200 pixels");
});

//8.
test("Width of bottom first widget with 3", function () {
    var width = S('#workspace_2  .kpi').width();
    var percentWide = Math.round(width / (window.innerWidth) * 100);
    equal(percentWide, 19, "Correct widget width 19%");
});

test("Height of bottom first widget at least 200 pixels", function () {
    var height = S('#workspace_2  .kpi').height();
    ok(height >= 200, "Widget height at least 200 pixels");
});

module("Dashboard tests against demo-jso-1-5.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:54661/dashboard.htm?userName=nmolesworth&debug=true&script=demo-json-1-5");
    }
    //,
    //    teardown: function () {
    //        S._window.close();
    //    }
});

//9.
test("1 KPIs under Top workspace", function () {
    var kpis = S('#workspace_1  .kpi').size();
    equal(kpis, 1, "Correct number of KPI");
});

//10.
test("5 KPIs under Bottom workspace", function () {
    var kpis = S('#workspace_2  .kpi').size();
    equal(kpis, 5, "Correct number of KPI");
});


//11.
test("Width of top first widget with 1 widgets", function () {
    var width = S('#workspace_1  .kpi').width();
    var percentWide = Math.round(width / (window.innerWidth) * 100);
    equal(percentWide, 19, "Correct widget width 19%");
});

test("Height of top first widget at least 200 pixels", function () {
    var height = S('#workspace_1  .kpi').height();
    ok(height >= 200, "Widget height at least 200 pixels");
});

//12.
test("Width of bottom first widget with 5", function () {
    var width = S('#workspace_2  .kpi').width();
    var percentWide = Math.round(width / (window.innerWidth) * 100);
    equal(percentWide, 15, "Correct widget width 15%");
});

test("Height of bottom first widget at least 200 pixels", function () {
    var height = S('#workspace_2  .kpi').height();
    ok(height >= 200, "Widget height at least 200 pixels");
});


module("Dashboard tests against demo-jso-4-1.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:54661/dashboard.htm?userName=nmolesworth&debug=true&script=demo-json-4-1");
    }
    //,
    //    teardown: function () {
    //        S._window.close();
    //    }
});

//11.
test("Width of top first widget with 4 widgets", function () {
    var width = S('#workspace_1  .kpi').width();
    var percentWide = Math.round(width / (window.innerWidth) * 100);
    equal(percentWide, 17, "Correct widget width 17%");
});

test("Height of top first widget at least 200 pixels", function () {
    var height = S('#workspace_1  .kpi').height();
    ok(height >= 200, "Widget height at least 200 pixels");
});

//12.
test("Width of bottom first widget with 1", function () {
    var width = S('#workspace_2  .kpi').width();
    var percentWide = Math.round(width / (window.innerWidth) * 100);
    equal(percentWide, 19, "Correct widget width 19%");
});

test("Height of bottom first widget at least 200 pixels", function () {
    var height = S('#workspace_2  .kpi').height();
    ok(height >= 200, "Widget height at least 200 pixels");
});



module("Dashboard tests against demo-jso-4-5.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:54661/dashboard.htm?userName=nmolesworth&debug=true&script=demo-json-4-5");
    }
    //,
    //    teardown: function () {
    //        S._window.close();
    //    }
});

//11.
test("Width of top first widget with 4 widgets", function () {
    var width = S('#workspace_1  .kpi').width();
    var percentWide = Math.round(width / (window.innerWidth) * 100);
    equal(percentWide, 17, "Correct widget width 17%");
});

test("Height of top first widget at least 200 pixels", function () {
    var height = S('#workspace_1  .kpi').height();
    ok(height >= 200, "Widget height at least 200 pixels");
});

//12.
test("Width of bottom first widget with 5", function () {
    var width = S('#workspace_2  .kpi').width();
    var percentWide = Math.round(width / (window.innerWidth) * 100);
    equal(percentWide, 15, "Correct widget width 15%");
});

test("Height of bottom first widget at least 200 pixels", function () {
    var height = S('#workspace_2  .kpi').height();
    ok(height >= 200, "Widget height at least 200 pixels");
});


module("Dashboard tests against demo-jso-5-4.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:54661/dashboard.htm?userName=nmolesworth&debug=true&script=demo-json-5-4");
    }
    //,
    //    teardown: function () {
    //        S._window.close();
    //    }
});

//11.
test("Width of top first widget with 5 widgets", function () {
    var width = S('#workspace_1  .kpi').width();
    var percentWide = Math.round(width / (window.innerWidth) * 100);
    equal(percentWide, 15, "Correct widget width 15%");
});

test("Height of top first widget at least 200 pixels", function () {
    var height = S('#workspace_1  .kpi').height();
    ok(height >= 200, "Widget height at least 200 pixels");
});

//12.
test("Width of bottom first widget with 4", function () {
    var width = S('#workspace_2  .kpi').width();
    var percentWide = Math.round(width / (window.innerWidth) * 100);
    equal(percentWide, 17, "Correct widget width 17%");
});

test("Height of bottom first widget at least 200 pixels", function () {
    var height = S('#workspace_2  .kpi').height();
    ok(height >= 200, "Widget height at least 200 pixels");
});



module("Dashboard tests against demo-jso-3-0.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:54661/dashboard.htm?userName=nmolesworth&debug=true&script=demo-json-3-0");
    }
    //,
    //    teardown: function () {
    //        S._window.close();
    //    }
});

//1.
test("3 KPIs under Top workspace", function () {
    var kpis = S('#workspace_1  .kpi').size();
    equal(kpis, 3, "Correct number of KPI");
});

//2.
test("Zero KPIs under Bottom workspace", function () {
    var kpis = S('#workspace_2  .kpi').size();
    equal(kpis, 0, "Correct number of KPI");
});


//3.
test("Width of top first widget with 3 widgets", function () {
    var width = S('#workspace_1  .kpi').width();
    var percentWide = Math.round(width / (window.innerWidth) * 100);
    equal(percentWide, 19, "Correct widget width 19%");
});

test("Height of top first widget at least 200 pixels", function () {
    var height = S('#workspace_1  .kpi').height();
    ok(height >= 200, "Widget height at least 200 pixels");
});




module("Dashboard tests against demo-jso-0-2.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:54661/dashboard.htm?userName=nmolesworth&debug=true&script=demo-json-0-2");
    }
    //,
    //    teardown: function () {
    //        S._window.close();
    //    }
});

//1.
test("Zero KPIs under Top workspace", function () {
    var kpis = S('#workspace_1  .kpi').size();
    equal(kpis, 0, "Correct number of KPI");
});

//2.
test("2 KPIs under Bottom workspace", function () {
    var kpis = S('#workspace_2  .kpi').size();
    equal(kpis, 2, "Correct number of KPI");
});


//4.
test("Width of bottom first widget with 4", function () {
    var width = S('#workspace_2  .kpi').width();
    var percentWide = Math.round(width / (window.innerWidth) * 100);
    equal(percentWide, 19, "Correct widget width 19%");
});

test("Height of bottom first widget at least 200 pixels", function () {
    var height = S('#workspace_2  .kpi').height();
    ok(height >= 200, "Widget height at least 200 pixels");
});



module("Dashboard tests against demo-jso-1-6.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:54661/dashboard.htm?userName=nmolesworth&debug=true&script=demo-json-1-6");
    }
    //,
    //    teardown: function () {
    //        S._window.close();
    //    }
});

//1.
test("1 KPIs under Top workspace", function () {
    var kpis = S('#workspace_1  .kpi').size();
    equal(kpis, 1, "Correct number of KPI");
});

//2.
test("5 KPIs under Bottom workspace altho 6 were sent", function () {
    var kpis = S('#workspace_2  .kpi').size();
    equal(kpis, 5, "Correct number of KPI");
});


//3.
test("Width of top first widget with 1 widgets", function () {
    var width = S('#workspace_1  .kpi').width();
    var percentWide = Math.round(width / (window.innerWidth) * 100);
    equal(percentWide, 19, "Correct widget width 19%");
});

test("Height of top first widget at least 200 pixels", function () {
    var height = S('#workspace_1  .kpi').height();
    ok(height >= 200, "Widget height at least 200 pixels");
});

//4.
test("Width of bottom first widget with 5", function () {
    var width = S('#workspace_2  .kpi').width();
    var percentWide = Math.round(width / (window.innerWidth) * 100);
    equal(percentWide, 15, "Correct widget width 15%");
});


module("Dashboard tests against demo-jso-6-2_6.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:54661/dashboard.htm?userName=nmolesworth&debug=true&script=demo-json-6-2_6");
    }
    //,
    //    teardown: function () {
    //        S._window.close();
    //    }
});

//1.
test("5 KPIs under Top workspace altho 6 were sent", function () {
    var kpis = S('#workspace_1  .kpi').size();
    equal(kpis, 5, "Correct number of KPI");
});

//2.
test("2 KPIs under Bottom workspace", function () {
    var kpis = S('#workspace_2  .kpi').size();
    equal(kpis, 2, "Correct number of KPI");
});


//3.
test("Width of top first widget with 5 widgets", function () {
    var width = S('#workspace_1  .kpi').width();
    var percentWide = Math.round(width / (window.innerWidth) * 100);
    equal(percentWide, 15, "Correct widget width 15%");
});

test("Height of top first widget at least 200 pixels", function () {
    var height = S('#workspace_1  .kpi').height();
    ok(height >= 200, "Widget height at least 200 pixels");
});

//4.
test("Width of bottom first widget with 2", function () {
    var width = S('#workspace_2  .kpi').width();
    var percentWide = Math.round(width / (window.innerWidth) * 100);
    equal(percentWide, 19, "Correct widget width 19%");
});
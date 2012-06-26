module("Dashboard tests against demo-json-3-2-KPI1.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:54661/dashboard.htm?userName=nmolesworth&debug=true&script=demo-json-3-2-KPI1");
    }
    //,
    //    teardown: function () {
    //        S._window.close();
    //    }
});


test("KPI1 GREEN warning level displayed properly", function () {
    S("#id_1_1.kpi.kpi_three.green").exists();
});

test("KPI1 YELLOW warning level displayed properly", function () {
    S("#id_1_2.kpi.kpi_three.yellow").exists();
});

test("KPI1 RED warning level displayed properly", function () {
    S("#id_1_3.kpi.kpi_three.red").exists();
});

test("KPI1 YELLOW warning level displayed properly", function () {
    S("#id_2_1.kpi.kpi_two.yellow").exists();
});

test("KPI1 YELLOW warning level displayed properly", function () {
    S("#id_2_2.kpi.kpi_two.red").exists();
});




module("Dashboard tests against demo-jso-3-2-KPI2.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:54661/dashboard.htm?userName=nmolesworth&debug=true&script=demo-json-3-2-KPI2");
    }
    //,
    //    teardown: function () {
    //        S._window.close();
    //    }
});


test("KPI2 GREEN warning level displayed properly", function () {
    S("#id_1_1.kpi.kpi_three.green").exists();
});

test("KPI2 YELLOW warning level displayed properly", function () {
    S("#id_1_2.kpi.kpi_three.yellow").exists();
});

test("KPI2 RED warning level displayed properly", function () {
    S("#id_1_3.kpi.kpi_three.red").exists();
});

test("KPI2 YELLOW warning level displayed properly", function () {
    S("#id_2_1.kpi.kpi_two.yellow").exists();
});

test("KPI2 YELLOW warning level displayed properly", function () {
    S("#id_2_2.kpi.kpi_two.red").exists();
});



module("Dashboard tests against demo-jso-3-2-KPI3.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:54661/dashboard.htm?userName=nmolesworth&debug=true&script=demo-json-3-2-KPI3");
    }
    //,
    //    teardown: function () {
    //        S._window.close();
    //    }
});


test("KPI3 GREEN warning level displayed properly", function () {
    S("#id_1_1.kpi.kpi_three.green").exists();
});

test("KPI3 YELLOW warning level displayed properly", function () {
    S("#id_1_2.kpi.kpi_three.yellow").exists();
});

test("KPI3 RED warning level displayed properly", function () {
    S("#id_1_3.kpi.kpi_three.red").exists();
});

test("KPI3 YELLOW warning level displayed properly", function () {
    S("#id_2_1.kpi.kpi_two.yellow").exists();
});

test("KPI3 YELLOW warning level displayed properly", function () {
    S("#id_2_2.kpi.kpi_two.red").exists();
});


module("Dashboard tests against demo-jso-3-2-KPI5.js", {
    setup: function () {
        // opens the page you want to test
        S.open("http://localhost:54661/dashboard.htm?userName=nmolesworth&debug=true&script=demo-json-3-2-KPI5");
    }
    //,
    //    teardown: function () {
    //        S._window.close();
    //    }
});


test("KPI5 GREEN warning level displayed properly", function () {
    S("#id_1_1.kpi.kpi_three.green").exists();
});

test("KPI5 YELLOW warning level displayed properly", function () {
    S("#id_1_2.kpi.kpi_three.yellow").exists();
});

test("KPI5 RED warning level displayed properly", function () {
    S("#id_1_3.kpi.kpi_three.red").exists();
});

test("KPI5 YELLOW warning level displayed properly", function () {
    S("#id_2_1.kpi.kpi_two.yellow").exists();
});

test("KPI5 YELLOW warning level displayed properly", function () {
    S("#id_2_2.kpi.kpi_two.red").exists();
});
module("JS Functions Test", {
    setup: function () {
        // opens the page you want to test
     //   S.open("http://localhost:49331/dashboard.htm?userName=nmolesworth&debug=true&script=demo-json-5-5");
    }
    //,
    //    teardown: function () {
    //        S._window.close();
    //    }
});


//1
test("Calculate KPI", function () {
    equal(calcKPI(50, 100, "Percentage"), '50%', "percentage KPI");
    equal(calcKPI(50, 100, "Minutes"), '0:01', "minutes KPI");
    equal(calcKPI(100, 50, "Amount"), 2, "other KPI");
});

//2
test("Format Minutes", function () {
    //equal('test', 'test');
    equal(formatMinutes(42), '0:42', 'format 42 into minutes format');
    equal(formatMinutes(60), '1:00', 'format 60 into minutes format');
    equal(formatMinutes(98), '1:38', 'format 98 into minutes format');
    equal(formatMinutes(10), '0:10', 'format 10 into minutes format');
    equal(formatMinutes(5), '0:05', 'format 5 into minutes format');
});

//3
test("Format Percent", function(){
    equal(formatPercent(100), '100%', 'format 100 into percent');
    equal(formatPercent(75), '75%', 'format 75 into percent');
    equal(formatPercent(5), '5%', 'format 5 into percent');
});

//4
test("Format Warn Color", function () {
    equal(wigitColor(100, 50, 100), 'red', 'red warn level');
    equal(wigitColor(100, 50, 110), 'red', 'red warn level');
    equal(wigitColor(100, 50, 75), 'yellow', 'yellow warn level');
    equal(wigitColor(100, 50, 50), 'yellow', 'yellow warn level');
    equal(wigitColor(100, 50, 10), 'green', 'green warn level');
    equal(wigitColor(100, 50, 0), 'green', 'green warn level');
});

//5
test('Format Widget', function () {
    equal(formatWigit(30, 'Percentage'), '30%', 'value percentage format');
    equal(formatWigit(25, 'Percentage'), '25%', 'targe percentage format');

    equal(formatWigit(30,'Minutes'), '0:30', 'value minutes format');
    equal(formatWigit(25,'Minutes'), '0:25', 'target minutes format');

    equal(formatWigit(30,'Amount'), '30', 'value amount format');
    equal(formatWigit(25,'Amount'), '25', 'target amount format');
});

//6
test('Warn Levels', function () {
    equal(getWarnLevel(25, 50, 10), 'green', 'green level');
    equal(getWarnLevel(25, 50, 25), 'yellow', 'yellow level');
    equal(getWarnLevel(25, 50, 30), 'yellow', 'yellow level');
    equal(getWarnLevel(25, 50, 50), 'red', 'red level');
    equal(getWarnLevel(25, 50, 60), 'red', 'red level');

    equal(getWarnLevel(10, 5, 15), 'red', 'red level');
    equal(getWarnLevel(10, 5, 10), 'red', 'red level');
    equal(getWarnLevel(10, 5, 7), 'yellow', 'yellow level');
    equal(getWarnLevel(10, 5, 5), 'yellow', 'yellow level');
    equal(getWarnLevel(10, 5, 2), 'green', 'green level');
    
});

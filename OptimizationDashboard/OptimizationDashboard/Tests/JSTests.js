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
    equal(calcKPI(50, 100, "02"), '50%', "percentage KPI");
    equal(calcKPI(50, 100, "01"), '0:01', "minutes KPI");
    equal(calcKPI(100, 50, "03"), '$2.00', "amount KPI");
    equal(calcKPI(0, 0, "04"), '0.00', 'divide by zero');
    equal(calcKPI(0, 0, "01"), '0:00', 'divide by zero minutes');
    equal(calcKPI(0, 0, "03"), '$0.00', 'divide by zero amount');
    equal(calcKPI(10, 20, "02"), '50%', "percentage KPI");
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
test("Format Amount", function () {
    var temp = 1;
    equal(formatAmount(temp.toFixed(2)), '$1.00', 'format 1 into amount');
    equal(formatAmount(10.00.toFixed(2)), '$10.00', 'foramt 10 into amount');
    equal(formatAmount(15.01.toFixed(2)), '$15.01', 'format 15.01 into amount');
    equal(formatAmount(200.99.toFixed(2)), '$200.99', 'format 200.99 into amount');
    equal(formatAmount(200.999.toFixed(2)), '$201.00', 'format 200.999 into amount');
    equal(formatAmount(151.711.toFixed(2)), '$151.71', 'format 151.711 into amount');

});

//5
test("Format Warn Color", function () {
    equal(wigitColor(100, 50, 100), 'red', 'red warn level');
    equal(wigitColor(100, 50, 110), 'red', 'red warn level');
    equal(wigitColor(100, 50, 75), 'yellow', 'yellow warn level');
    equal(wigitColor(100, 50, 50), 'yellow', 'yellow warn level');
    equal(wigitColor(100, 50, 10), 'green', 'green warn level');
    equal(wigitColor(100, 50, 0), 'green', 'green warn level');
});

//6
test('Format Widget', function () {
    equal(formatWigit(30, '02'), '30%', 'value percentage format');
    equal(formatWigit(25, '02'), '25%', 'targe percentage format');

    equal(formatWigit(30, '01'), '0:30', 'value minutes format');
    equal(formatWigit(25, '01'), '0:25', 'target minutes format');

    equal(formatWigit(30, '03'), '$30.00', 'value amount format');
    equal(formatWigit(25, '03'), '$25.00', 'target amount format');

    equal(formatWigit(30, '04'), '30.00', 'value quantity format');
    equal(formatWigit(30.1, '04'), '30.10', 'value quantity format');
    equal(formatWigit(30.50, '04'), '30.50', 'value quantity format');
    equal(formatWigit(30.999, '04'), '31.00', 'value quantity format');
    equal(formatWigit(30.911, '04'), '30.91', 'value quantity format');
});

//7
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

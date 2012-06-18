//******
//Globals
//******
var valueTemp = 0;
var targetTemp = 0;

//******
// Overal format of the widget.  Calls appropriate format method based on type
// Sets the values for the report value and the target value to be displayed in the widget
//******
var formatWigit = function (inKPI, calcType) {
    if (calcType === "Percentage") {
        inKPI = formatPercent(inKPI.toFixed(0));
    }
    else if (calcType === "Minutes") {
        inKPI = formatMinutes(inKPI.toFixed(0));
    }
    else if (calcType === "Amount") {
        inKPI = formatAmount(inKPI.toFixed(2));
    }
    else {
        inKPI = inKPI.toFixed(2);
    }
    return inKPI;
};

//******
// Format an interval value into hours minutes
// H:MM
//******
var formatMinutes = function (totalMins) {
    var mins = totalMins % 60;
    var hours = 0;
    if (totalMins > mins) {
        hours = (totalMins - mins) / 60;
    }
    if (mins === 0) {
        mins = '00';
    }
    else if (mins < 10) {
        mins = '0' + mins;
    }

    return hours + ':' + mins;
};

//******
// Format a percentage value
// nn%
//******
var formatPercent = function (inVal) {
     return inVal + '%';
 };

//******
// Fomat an amoun $nnn.nn
//
//******
var formatAmount = function (inVal){
    return '$' + inVal;
};


//******
// Determine background color for the wigit warning level
// red >= upperLimit, green < lowerLimit, yellow >= lowerLimt && < upperLimit
//******
 var wigitColor = function (upperLimit, lowerLimit, compValue) {
     if (compValue >= upperLimit) {
         return 'red';
     }
     else if (compValue < lowerLimit) {
         return 'green';
     }
     else {
         return 'yellow';
     }
 };

 //******
 // Calculate KPI value
 //
 //******
 var calcKPI = function (valIn, units, calcType) {
     var kpi = 0;

     if (valIn != 0) {
         kpi = valIn / units;
     }

     if (calcType === "Percentage") {
         kpi = kpi * 100;
     }

     //Now format the widget based on the calc type
     kpi = formatWigit(kpi, calcType);
     return kpi;
 };

 //******
 // Determine the limits and set the wigit color
 //
 //******
 var getWarnLevel = function (firstWarn, secondWarn, compVal) {
     if (secondWarn > firstWarn) {
        return wigitColor(secondWarn, firstWarn, compVal);
     }

     else if (firstWarn > secondWarn) {
         return wigitColor(firstWarn, secondWarn, compVal);
     }
 };
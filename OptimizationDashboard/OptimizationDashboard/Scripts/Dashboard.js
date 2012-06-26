//*****
// Build locations string when 'All' is selected
//
//*****
var formatLocationString = function(data){
    //set the first one
	var strDisplay = data.locations[0];

	for (var q = 1; q < data.locations.length; q++) {

	    if (data.locations[q] != 'All') {
	        if ((strDisplay.length + data.locations[q].length + 2) < 15) {
	            //append each location as long as addition doesn't max the length
	            strDisplay = strDisplay + ', ' + data.locations[q];
	        }
	        else {
	            //Cap it off.  string is too long
	            strDisplay = strDisplay + '...';
	            break;
	        }
	    }
	}
    return strDisplay;
};

//******
// Overal format of the widget.  Calls appropriate format method based on type
// Sets the values for the report value and the target value to be displayed in the widget
//******
var formatWigit = function (inKPI, calcType) {
    //Code: 02 = Percentage type
    if (calcType === "02") {
        inKPI = formatPercent(inKPI.toFixed(0));
    }
    //Code: )1 = Minutes type
    else if (calcType === "01") {
        inKPI = formatMinutes(inKPI.toFixed(0));
    }
    //Code: 03 = Amount type
    else if (calcType === "03") {
        inKPI = formatAmount(inKPI.toFixed(2));
    }
    //Code: 04 = Quantity type
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
 // For use when the 'good' target values are higher than target
 // Warn2 is less than warn1 value
 //******
 var wigitColorReverse = function (lowerLimit, upperLimit, compValue) {
     if (compValue > lowerLimit) {
         return 'green';
     }
     else if (compValue <= upperLimit){
        return 'red';
     }
     else{
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

     //Check for percentage type to multiple by 100 (code: 02)
     if (calcType === "02") {
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
         //return wigitColor(firstWarn, secondWarn, compVal);
         return wigitColorReverse(firstWarn, secondWarn, compVal);
     }
 };
var dataService = {
	self: this,
	ready: function (callback) { callback },
	values: undefined,
	setValues: function (values) {
		self.values = values;
	},
	defineMockService: function (json) {
		amplify.request.define("MockService", function (settings) {
			settings.success(json);
		})
	},
	defineDataService: function () {
		amplify.request.define("DataService", "ajax", {
			url: "./DataService.aspx?userName={userName}&location={location}&pollTime={pollTime}",
			type: "GET"
		})
	},
	callMockService: function (callback) {
//		console.log("calling mock service");
		amplify.request({
			resourceId: "MockService",
			success: function (data) {
				callback(data);
			},
			error: function (message, level) {
				alert(message + " " + level);
			}
		})
	},
	callDataService: function (callback) {
//		console.log("calling data service");
		amplify.request("DataService",
				self.values,
				function (data) {
					callback(data);
				})
	}
}
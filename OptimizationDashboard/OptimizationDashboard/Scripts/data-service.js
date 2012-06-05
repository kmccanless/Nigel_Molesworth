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
            url: "/DataService.aspx?userName={userName}&location={location}",
            type: "GET"
        })
    },
    callMockService: function () {
        console.log("calling mock service");
        amplify.request({
            resourceId: "MockService",
            success: function (data) {
                vm.userName(data.userName);
                vm.roleName(data.roleName);
                vm.locations(data.locations);
                vm.activeLocation(data.activeLocation);
                vm.workspaces(data.workspaces);
                timer = setTimeout('dataService.callMockService()', 5000);

            },
            error: function (message, level) {
                alert(message + " " + level);
            }
        })
    },
    callDataService: function () {
        amplify.request("DataService",
				self.values,
				function (data) {
				    vm.userName(data.userName);
				    vm.roleName(data.roleName);
				    vm.locations(data.locations);
				    vm.activeLocation(data.activeLocation);
				    vm.workspaces(data.workspaces);
				    timer = setTimeout('dataService.callDataService(self.values)', 5000);
				})
    }
}
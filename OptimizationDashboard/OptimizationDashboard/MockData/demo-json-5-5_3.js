var KPI_JSON = {
    "userName": "John Doe",
    "roleName": "Shipper",
    activeLocation: "3",
    "locations": [
        3,
        5,
        6,
        7
    ],
	workspaces: [
		{
			id: 1,
			KPIs: [
				{
					title: "FIRST LOAD",
					type: "minutes",
					target: 150,
					units: 16,
					firstWarn: 300,
					secondWarn: 450,
                },
                {
                    title: "JOB WAIT",
                    type: "minutes",
                    target: 120,
                    units: 12,
                    firstWarn: 180,
                    secondWarn: 240
                },
                {
                    title: "YARD TIME",
                    type: "minutes",
                    target: 180,
                    units: 20,
                    firstWarn: 180,
                    secondWarn: 240
                },
                 {
                     title: "EOD YARD",
                     type: "minutes",
                     target: 210,
                     units: 25,
                     firstWarn: 280,
                     secondWarn: 350
                 },
                  {
                      title: "TOTAL COMPLIANCE",
                      type: "percentage",
                      target: 54.0,
                      units: 85,
                      firstWarn: 51.0,
                      secondWarn: 48.0
                  }
            ]
        },
        {
            id: 2,
            KPIs: [
                {
                    title: "LOCKED LOADS",
                    type: "percentage",
                    target: 3.0,
                    units: 12,
                    firstWarn: 6.0,
                    secondWarn: 9.0
                },
                {
                    title: "STARTUP",
                    type: "minutes",
                    target: 320,
                    units: 29,
                    firstWarn: 480,
                    secondWarn: 640
                },
                {
                    title: "LOAD & MIX",
                    type: "minutes",
                    target: 252,
                    units: 19,
                    firstWarn: 324,
                    secondWarn: 360
                },
                {
                    title: "WASH OUT",
                    type: "minutes",
                    target: 240,
                    units: 33,
                    firstWarn: 360,
                    secondWarn: 480
                },
                {
                    title: "STATUS BOX UPDATES",
                    type: "percentage",
                    target: 57.0,
                    units: 93,
                    firstWarn: 54.0,
                    secondWarn: 51.0
                }
            ]
        }
    ]
}
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
					title: "First Load",
					type: "Minutes",
					target: 150,
					value: 245,
					units: 16,
					firstWarn: 300,
					secondWarn: 450,
                },
                {
                    title: "Job Wait",
                    type: "Minutes",
                    target: 120,
                    value: 185,
		            units: 12,
                    firstWarn: 180,
                    secondWarn: 240
                },
                {
                    title: "Yard Time",
                    type: "Minutes",
                    target: 180,
                    value: 240,
		            units: 20,
                    firstWarn: 240,
                    secondWarn: 300
                },
                 {
                     title: "EOD Yard",
                     type: "Minutes",
                     target: 210,
                     value: 355,
		             units: 25,
                     firstWarn: 280,
                     secondWarn: 350
                 },
                  {
                      title: "Total Compliance",
                      type: "Percentage",
                      target: 54.0,
                      value: 51.0,
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
                    title: "Locked Loads",
                    type: "Percentage",
                    target: 3.0,
                    value: 7.0,
		            units: 12,
                    firstWarn: 6.0,
                    secondWarn: 9.0
                },
                {
                    title: "Startup",
                    type: "Minutes",
                    target: 320,
                    value: 470,
		            units: 29,
                    firstWarn: 480,
                    secondWarn: 640
                },
                {
                    title: "Load & Mix",
                    type: "Minutes",
                    target: 252,
                    value: 350,
		            units: 19,
                    firstWarn: 324,
                    secondWarn: 360
                },
                {
                    title: "Wash Out",
                    type: "Minutes",
                    target: 240,
                    value: 390,
		            units: 33,
                    firstWarn: 360,
                    secondWarn: 480
                },
                {
                    title: "Status Box Updates",
                    type: "Percentage",
                    target: 57.0,
                    value: 56.0,
		            units: 93,
                    firstWarn: 54.0,
                    secondWarn: 51.0
                }
            ]
        }
    ]
}
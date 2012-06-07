var KPI_JSON = {
    "userName": "John Doe",
    "roleName": "Shipper",
    activeLocation: "All",
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
					target: 370,
					units: 25,
					firstWarn: 740,
					secondWarn: 1110,
                },
                {
                    title: "JOB WAIT",
                    type: "minutes",
                    target: 416,
                    units: 23.19,
                    firstWarn: 624,
                    secondWarn: 832
                },
                {
                    title: "YARD TIME",
                    type: "minutes",
                    target: 600,
                    units: 21.5,
                    firstWarn: 624,
                    secondWarn: 832
                },
                 {
                     title: "EOD YARD",
                     type: "minutes",
                     target: 864,
                     units: 21,
                     firstWarn: 1146,
                     secondWarn: 1428
                 },
                  {
                      title: "TOTAL COMPLIANCE",
                      type: "percentage",
                      target: 207,
                      units: 90,
                      firstWarn: 195.5,
                      secondWarn: 184.0
                  }
            ]
        },
        {
            id: 2,
            KPIs: [
                {
                    title: "LOCKED LOADS",
                    type: "percentage",
                    target: 11.4,
                    units: 10,
                    firstWarn: 22.8,
                    secondWarn: 34.2
                },
                {
                    title: "STARTUP",
                    type: "minutes",
                    target: 1660,
                    units: 36,
                    firstWarn: 2350,
                    secondWarn: 3040
                },
                {
                    title: "LOAD & MIX",
                    type: "minutes",
                    target: 1041,
                    units: 18,
                    firstWarn: 1366,
                    secondWarn: 1625
                },
                {
                    title: "WASH OUT",
                    type: "minutes",
                    target: 860,
                    units: 41,
                    firstWarn: 1290,
                    secondWarn: 1720
                },
                {
                    title: "STATUS BOX UPDATES",
                    type: "percentage",
                    target: 218.5,
                    units: 91,
                    firstWarn: 207.0,
                    secondWarn: 195.5
                }
            ]
        }
    ]
}
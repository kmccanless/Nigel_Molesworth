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
					title: "First Load",
					type: "Minutes",
					target: 370,
					value: 885,
					units: 36,
					firstWarn: 740,
					secondWarn: 1110
                },
                {
                    title: "Job Wait",
                    type: "Minutes",
                    target: 416,
                    value: 835,
		            units: 23.19,
                    firstWarn: 624,
                    secondWarn: 832
                },
                {
                    title: "Yard Time",
                    type: "Minutes",
                    target: 600,
                    value: 860,
		            units: 21.5,
                    firstWarn: 800,
                    secondWarn: 1000
                },
                 {
                     title: "EOD Yard",
                     type: "Minutes",
                     target: 864,
                     value: 1125,
		             units: 21,
                     firstWarn: 1146,
                     secondWarn: 1428
                 },
                  {
                      title: "Total Compliance",
                      type: "Percentage",
                      target: 207,
                      value: 181,
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
                    title: "Locked Loads",
                    type: "Percentage",
                    target: 11.4,
                    value: 22.0,
		            units: 10,
                    firstWarn: 22.8,
                    secondWarn: 34.2
                },
                {
                    title: "Startup",
                    type: "Minutes",
                    target: 1660,
                    value: 2515,
		            units: 36,
                    firstWarn: 2350,
                    secondWarn: 3040
                },
                {
                    title: "Load & Mix",
                    type: "Minutes",
                    target: 1041,
                    value: 1330,
		            units: 18,
                    firstWarn: 1366,
                    secondWarn: 1625
                },
                {
                    title: "Wash Out",
                    type: "Minutes",
                    target: 860,
                    value: 1745,
		            units: 41,
                    firstWarn: 1290,
                    secondWarn: 1720
                },
                {
                    title: "Status Box Updates",
                    type: "Percentage",
                    target: 218.5,
                    value: 210.0,
		            units: 91,
                    firstWarn: 207.0,
                    secondWarn: 195.5
                }
            ]
        }
    ]
}
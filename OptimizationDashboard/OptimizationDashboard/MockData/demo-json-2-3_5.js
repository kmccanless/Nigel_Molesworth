var KPI_JSON = {
    "userName": "Jane Doe",
    "roleName": "Plant Manager",
    activeLocation: "5",
    "locations": [
        3,
        5,
        6
    ],
	workspaces: [
		{
			id: 1,
			KPIs: [
                {
                    title: "Yard Time",
                    type: "Minutes",
                    target: 210,
                    value: 350,
                    units: 14,
                    firstWarn: 280,
                    secondWarn: 350
                },
                 {
                     title: "EOD Yard",
                     type: "Minutes",
                     target: 360,
                     value: 350,
                     units: 18,
                     firstWarn: 450,
                     secondWarn: 540
                 },
            ]
},
        {
            id: 2,
            KPIs: [
                {
                    title: "First Load",
                    type: "Minutes",
                    target: 123,
                    value: 250,
                    units: 10,
                    firstWarn: 240,
                    secondWarn: 360
                },
                {
                    title: "Startup",
                    type: "Minutes",
                    target: 500,
                    value: 850,
                    units: 43,
                    firstWarn: 700,
                    secondWarn: 900
                },
                {
                    title: "Wash Out",
                    type: "Minutes",
                    target: 280,
                    value: 600,
                    units: 43,
                    firstWarn: 420,
                    secondWarn: 560
                },
            ]
        }
    ]
}
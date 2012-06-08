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
                    title: "YARD TIME",
                    type: "Minutes",
                    target: 210,
                    value: 350,
                    units: 25,
                    firstWarn: 280,
                    secondWarn: 350
                },
                 {
                     title: "EOD YARD",
                     type: "Minutes",
                     target: 360,
                     value: 350,
                     units: 19,
                     firstWarn: 450,
                     secondWarn: 540
                 },
            ]
},
        {
            id: 2,
            KPIs: [
                {
                    title: "FIRST LOAD",
                    type: "Minutes",
                    target: 123,
                    value: 250,
                    units: 25,
                    firstWarn: 240,
                    secondWarn: 360
                },
                {
                    title: "STARTUP",
                    type: "Minutes",
                    target: 500,
                    value: 850,
                    units: 43,
                    firstWarn: 700,
                    secondWarn: 900
                },
                {
                    title: "WASH OUT",
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
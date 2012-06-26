var KPI_JSON = {
    userName: "Rumplestiltskin Hamiloffinkator",
    roleName: "Icon Of Some Childrens Stories",
    activeLocation: "All",
    locations: [
        "1",
        "2",
        "3",
        "5",
        "6",
        "7"
    ],
	workspaces: [
		{
			id: 1,
			KPIs: [
                {
                    title: "JOB WAIT",
                    type: "01",
                    target: 416,
                    value: 835,
                    units: 40,
                    firstWarn: 624,
                    secondWarn: 832
                },
                {
					title: "FIRST LOAD",
					type: "01",
					target: 416,
					value: 885,
					units: 40,
					firstWarn: 624,
					secondWarn: 832
                },
                {
                     title: "EOD YARD",
                     type: "01",
                     target: 864,
                     value: 1125,
		             units: 21,
                     firstWarn: 1146,
                     secondWarn: 1428
                 },
                 {
                    title: "YARD TIME",
                    type: "01",
                    target: 600,
                    value: 860,
		            units: 21.5,
                    firstWarn: 800,
                    secondWarn: 1000
                }
            ]
        },
        {
            id: 2,
            KPIs: [
                {
                    title: "LOCKED LOADS",
                    type: "02",
                    target: 11.4,
                    value: 22.0,
		            units: 10,
                    firstWarn: 22.8,
                    secondWarn: 34.2
                },
                {
                    title: "STARTUP",
                    type: "01",
                    target: 1660,
                    value: 2515,
		            units: 36,
                    firstWarn: 2350,
                    secondWarn: 3040
                },
                {
                    title: "LOAD & MIX",
                    type: "01",
                    target: 1041,
                    value: 1330,
		            units: 18,
                    firstWarn: 1366,
                    secondWarn: 1625
                },
                {
                    title: "WASH OUT",
                    type: "01",
                    target: 860,
                    value: 1745,
		            units: 41,
                    firstWarn: 1290,
                    secondWarn: 1720
                }
            ]
        }
    ]
}
"use strict";
//#region RenderColumnChart --------------------------------------------------------------------------------------------------
function RenderBarChart(url, id) {
    $.ajax({
        url: url,
        type: 'GET',
        success: function (dataObjectResult) {
            if (dataObjectResult.success) {
                let chart = JSON.parse(dataObjectResult.object);
                CreateBarChart(chart, id);
            }
        }
    });
}

function CreateBarChart(coloumChart, id) {

    // Create root element
    // https://www.amcharts.com/docs/v5/getting-started/#Root_element
    var root = am5.Root.new(id);

    // Set themes
    // https://www.amcharts.com/docs/v5/concepts/themes/
    root.setThemes([
        am5themes_Animated.new(root)
    ]);


    // Create chart
    // https://www.amcharts.com/docs/v5/charts/xy-chart/
    var chart = root.container.children.push(am5xy.XYChart.new(root, {
        panX: false,
        panY: false,
        //wheelX: "panX",
        //wheelY: "zoomX"
    }));


    // Add cursor
    // https://www.amcharts.com/docs/v5/charts/xy-chart/cursor/
    var cursor = chart.set("cursor", am5xy.XYCursor.new(root, {
        //behavior: "zoomX"
    }));
    cursor.lineY.set("visible", false);
    //cursor.lineX.set("visible", false);

    // Create axes
    // https://www.amcharts.com/docs/v5/charts/xy-chart/axes/
    var xAxis = chart.xAxes.push(am5xy.CategoryAxis.new(root, {
        //maxDeviation: 0,
        //baseInterval: {
        //    timeUnit: "day",
        //    count: 1
        //},
        //renderer: am5xy.AxisRendererX.new(root, {
        //    minorGridEnabled: true
        //}),
        //tooltip: am5.Tooltip.new(root, {})
        categoryField: coloumChart.ValueXField,
        tooltip: am5.Tooltip.new(root, {}),
        renderer: am5xy.AxisRendererX.new(root, {})
    }));

    var yAxis = chart.yAxes.push(am5xy.ValueAxis.new(root, {
        renderer: am5xy.AxisRendererY.new(root, {})
    }));


    // Add series
    // https://www.amcharts.com/docs/v5/charts/xy-chart/series/
    var series = chart.series.push(am5xy.ColumnSeries.new(root, {
        name: "Series",
        xAxis: xAxis,
        yAxis: yAxis,
        valueYField: coloumChart.ValueYField,
        categoryXField: coloumChart.ValueXField,
        //valueYField: "value",
        //valueXField: "date",
        tooltip: am5.Tooltip.new(root, {
            labelText: "{valueY}"
        })
    }));


    // Add scrollbar
    // https://www.amcharts.com/docs/v5/charts/xy-chart/scrollbars/
    // chart.set("scrollbarX", am5.Scrollbar.new(root, {
    //   orientation: "horizontal"
    // }));

    xAxis.data.setAll(coloumChart.Coloumns);
    series.data.setAll(coloumChart.Coloumns);


    // Make stuff animate on load
    // https://www.amcharts.com/docs/v5/concepts/animations/#Forcing_appearance_animation
    series.appear(1000);
    chart.appear(1000, 100);
}
//#endregion
//#region RenderLineChart --------------------------------------------------------------------------------------------------
function RenderLineChart(url, id) {
    $.ajax({
        url: url,
        type: 'GET',
        success: function (dataObjectResult) {
            if (dataObjectResult.success) {
                let chart = JSON.parse(dataObjectResult.object);
                CreateLineChart(chart, id);
            }
        }
    });
}
function CreateLineChart(lineChart, id) {
    // Create root element
    // https://www.amcharts.com/docs/v5/getting-started/#Root_element
    var root = am5.Root.new(id);
    // Set themes
    // https://www.amcharts.com/docs/v5/concepts/themes/
    root.setThemes([
        am5themes_Animated.new(root)
    ]);


    // Create chart
    // https://www.amcharts.com/docs/v5/charts/xy-chart/
    var chart = root.container.children.push(am5xy.XYChart.new(root, {
        panX: false,
        panY: false,
        //wheelX: "panX",
        //wheelY: "zoomX"
    }));

    // Add cursor
    // https://www.amcharts.com/docs/v5/charts/xy-chart/cursor/
    var cursor = chart.set("cursor", am5xy.XYCursor.new(root, {
        //behavior: "zoomX"
    }));
    cursor.lineY.set("visible", false);



    // Create axes
    // https://www.amcharts.com/docs/v5/charts/xy-chart/axes/
    var xAxis = chart.xAxes.push(am5xy.CategoryAxis.new(root, {
        //maxDeviation: 0,
        //baseInterval: {
        //    timeUnit: "day",
        //    count: 1
        //},
        //renderer: am5xy.AxisRendererX.new(root, {
        //    minorGridEnabled: true
        //}),
        //tooltip: am5.Tooltip.new(root, {})
        categoryField: lineChart.ValueXField,
        tooltip: am5.Tooltip.new(root, {}),
        renderer: am5xy.AxisRendererX.new(root, {})
    }));

    var yAxis = chart.yAxes.push(am5xy.ValueAxis.new(root, {
        renderer: am5xy.AxisRendererY.new(root, {})
    }));


    // Add series
    // https://www.amcharts.com/docs/v5/charts/xy-chart/series/
    var series = chart.series.push(am5xy.SmoothedXLineSeries.new(root, {
        name: "Series",
        xAxis: xAxis,
        yAxis: yAxis,
        valueYField: lineChart.ValueYField,
        categoryXField: lineChart.ValueXField,
        //valueYField: "value",
        //valueXField: "date",
        tooltip: am5.Tooltip.new(root, {
            labelText: "{valueY}"
        })
    }));

    series.fills.template.setAll({
        visible: true,
        fillOpacity: 0.2
    });

    series.bullets.push(function () {
        return am5.Bullet.new(root, {
            locationY: 0,
            sprite: am5.Circle.new(root, {
                radius: 4,
                stroke: root.interfaceColors.get("background"),
                strokeWidth: 2,
                fill: series.get("fill")
            })
        });
    });


    // Add scrollbar
    // https://www.amcharts.com/docs/v5/charts/xy-chart/scrollbars/
    //chart.set("scrollbarX", am5.Scrollbar.new(root, {
    //    orientation: "horizontal"
    //}));


    xAxis.data.setAll(lineChart.Points);
    series.data.setAll(lineChart.Points);


    // Make stuff animate on load
    // https://www.amcharts.com/docs/v5/concepts/animations/
    series.appear(1000);
    chart.appear(1000, 100);
}

//#endregion
//#region RenderPieChart --------------------------------------------------------------------------------------------------
function RenderPieChart(url, id) {
    $.ajax({
        url: url,
        type: 'GET',
        success: function (dataObjectResult) {
            if (dataObjectResult.success) {
                let chart = JSON.parse(dataObjectResult.object);
                CreatePieChart(chart, id);
            }
        }
    });
}
function CreatePieChart(pieChart, id) {
    // Create root element
    // https://www.amcharts.com/docs/v5/getting-started/#Root_element
    var root = am5.Root.new(id);


    // Set themes
    // https://www.amcharts.com/docs/v5/concepts/themes/
    root.setThemes([
        am5themes_Animated.new(root)
    ]);


    // Create chart
    // https://www.amcharts.com/docs/v5/charts/percent-charts/pie-chart/
    var chart = root.container.children.push(am5percent.PieChart.new(root, {
        layout: root.verticalLayout
    }));


    // Create series
    // https://www.amcharts.com/docs/v5/charts/percent-charts/pie-chart/#Series
    var series = chart.series.push(am5percent.PieSeries.new(root, {
        valueField: pieChart.ValueField,
        categoryField: pieChart.CategoryField
    }));


    // Set data
    // https://www.amcharts.com/docs/v5/charts/percent-charts/pie-chart/#Setting_data
    series.data.setAll(pieChart.Slices);


    // Create legend
    // https://www.amcharts.com/docs/v5/charts/percent-charts/legend-percent-series/
    var legend = chart.children.push(am5.Legend.new(root, {
        centerX: am5.percent(50),
        x: am5.percent(50),
        marginTop: 15,
        marginBottom: 15,
    }));

    legend.data.setAll(series.dataItems);


    // Play initial series animation
    // https://www.amcharts.com/docs/v5/concepts/animations/#Animation_of_series
    series.appear(1000, 100);
}

//#endregion
//#region RenderStackHorizontalBarChart --------------------------------------------------------------------------------------------------
function RenderStackHorizontalBarChart(url, id) {
    $.ajax({
        url: url,
        type: 'GET',
        success: function (dataObjectResult) {
            if (dataObjectResult.success) {
                let chart = JSON.parse(dataObjectResult.object);
                CreateStackHorizontalBarChart(chart, id);
            }
        }
    });
}
function CreateStackHorizontalBarChart(barChart, id) {
    var obj = barChart.Stacks;
    let length = obj.length;
    let data = [];
    for (var i = 0; i < length; i++) {
        let newObj = {
            Label: obj[i].Label
        }
        obj[i].Coloumns.forEach(function (item) {
            var temObject = {
                [item.Label]: item.Value
            };
            newObj = { ...newObj, ...temObject }
        });
        data.push(newObj);
    }

    // Create root element
    // https://www.amcharts.com/docs/v5/getting-started/#Root_element
    var root = am5.Root.new(id);

    var myTheme = am5.Theme.new(root);

    myTheme.rule("Grid", ["base"]).setAll({
        strokeOpacity: 0.1
    });


    // Set themes
    // https://www.amcharts.com/docs/v5/concepts/themes/
    root.setThemes([
        am5themes_Animated.new(root),
        myTheme
    ]);


    // Create chart
    // https://www.amcharts.com/docs/v5/charts/xy-chart/
    var chart = root.container.children.push(am5xy.XYChart.new(root, {
        panX: false,
        panY: false,
        //wheelX: "panY",
        //wheelY: "zoomY",
        paddingLeft: 0,
        layout: root.verticalLayout
    }));

    // Add scrollbar
    // https://www.amcharts.com/docs/v5/charts/xy-chart/scrollbars/
    //chart.set("scrollbarY", am5.Scrollbar.new(root, {
    //    orientation: "vertical"
    //        }));



    // Create axes
    // https://www.amcharts.com/docs/v5/charts/xy-chart/axes/
    var yRenderer = am5xy.AxisRendererY.new(root, {});
    var yAxis = chart.yAxes.push(am5xy.CategoryAxis.new(root, {
        categoryField: barChart.ValueXField,
        renderer: yRenderer,
        tooltip: am5.Tooltip.new(root, {})
    }));

    yRenderer.grid.template.setAll({
        location: 1
    })

    yAxis.data.setAll(data);

    var xAxis = chart.xAxes.push(am5xy.ValueAxis.new(root, {
        min: 0,
        maxPrecision: 0,
        renderer: am5xy.AxisRendererX.new(root, {
            minGridDistance: 40,
            strokeOpacity: 0.1
        })
    }));

    // Add legend
    // https://www.amcharts.com/docs/v5/charts/xy-chart/legend-xy-series/
    var legend = chart.children.push(am5.Legend.new(root, {
        centerX: am5.p50,
        x: am5.p50
    }));


    // Add series
    // https://www.amcharts.com/docs/v5/charts/xy-chart/series/
    function makeSeries(name, fieldName) {
        var series = chart.series.push(am5xy.ColumnSeries.new(root, {
            name: name,
            stacked: true,
            xAxis: xAxis,
            yAxis: yAxis,
            baseAxis: yAxis,
            valueXField: fieldName,
            categoryYField: barChart.ValueXField
        }));

        series.columns.template.setAll({
            tooltipText: "{name}, {categoryY}: {valueX}",
            tooltipY: am5.percent(90)
        });
        series.data.setAll(data);

        // Make stuff animate on load
        // https://www.amcharts.com/docs/v5/concepts/animations/
        series.appear();

        series.bullets.push(function () {
            return am5.Bullet.new(root, {
                sprite: am5.Label.new(root, {
                    text: "{valueX}",
                    fill: root.interfaceColors.get("alternativeText"),
                    centerY: am5.p50,
                    centerX: am5.p50,
                    populateText: true
                })
            });
        });

        legend.data.push(series);
    }

    barChart.Labels.forEach(s => {
        makeSeries(s, s);

    });


    // Make stuff animate on load
    // https://www.amcharts.com/docs/v5/concepts/animations/
    chart.appear(1000, 100);

}
//#endregion
//#region RenderStackVerticalBarChart --------------------------------------------------------------------------------------------------

function RenderStackVerticalBarChart(url, id) {
    $.ajax({
        url: url,
        type: 'GET',
        success: function (dataObjectResult) {
            if (dataObjectResult.success) {
                let chart = JSON.parse(dataObjectResult.object);
                CreateStackVerticalBarChart(chart, id);
            }
        }
    });
}
function CreateStackVerticalBarChart(barChart, id) {
    /**
 * ---------------------------------------
 * This demo was created using amCharts 5.
 *
 * For more information visit:
 * https://www.amcharts.com/
 *
 * Documentation is available at:
 * https://www.amcharts.com/docs/v5/
 * ---------------------------------------
 */
    var obj = barChart.Stacks;
    let length = obj.length;
    let data = [];
    for (var i = 0; i < length; i++) {
        let newObj = {
            Label: obj[i].Label
        }
        obj[i].Coloumns.forEach(function (item) {
            var temObject = {
                [item.Label]: item.Value
            };
            newObj = { ...newObj, ...temObject }
        });
        data.push(newObj);
    }
    // Create root element
    // https://www.amcharts.com/docs/v5/getting-started/#Root_element
    var root = am5.Root.new(id);


    // Set themes
    // https://www.amcharts.com/docs/v5/concepts/themes/
    root.setThemes([
        am5themes_Animated.new(root)
    ]);


    // Create chart
    // https://www.amcharts.com/docs/v5/charts/xy-chart/
    var chart = root.container.children.push(am5xy.XYChart.new(root, {
        panX: false,
        panY: false,
        //wheelX: "panX",
        //wheelY: "zoomX",
        layout: root.verticalLayout
    }));

    // Add scrollbar
    // https://www.amcharts.com/docs/v5/charts/xy-chart/scrollbars/
    //chart.set("scrollbarX", am5.Scrollbar.new(root, {
    //    orientation: "horizontal"
    //}));



    // Create axes
    // https://www.amcharts.com/docs/v5/charts/xy-chart/axes/
    var xAxis = chart.xAxes.push(am5xy.CategoryAxis.new(root, {
        categoryField: barChart.ValueXField,
        renderer: am5xy.AxisRendererX.new(root, {}),
        tooltip: am5.Tooltip.new(root, {})
    }));

    xAxis.data.setAll(data);

    var yAxis = chart.yAxes.push(am5xy.ValueAxis.new(root, {
        min: 0,
        renderer: am5xy.AxisRendererY.new(root, {})
    }));


    // Add legend
    // https://www.amcharts.com/docs/v5/charts/xy-chart/legend-xy-series/
    var legend = chart.children.push(am5.Legend.new(root, {
        centerX: am5.p50,
        x: am5.p50
    }));


    // Add series
    // https://www.amcharts.com/docs/v5/charts/xy-chart/series/
    function makeSeries(name, fieldName) {
        var series = chart.series.push(am5xy.ColumnSeries.new(root, {
            name: name,
            stacked: true,
            xAxis: xAxis,
            yAxis: yAxis,
            valueYField: fieldName,
            categoryXField: barChart.ValueXField
        }));

        series.columns.template.setAll({
            tooltipText: "{name}, {categoryX}: {valueY}",
            tooltipY: am5.percent(10)
        });
        series.data.setAll(data);

        // Make stuff animate on load
        // https://www.amcharts.com/docs/v5/concepts/animations/
        series.appear();

        series.bullets.push(function () {
            return am5.Bullet.new(root, {
                sprite: am5.Label.new(root, {
                    text: "{valueY}",
                    fill: root.interfaceColors.get("alternativeText"),
                    centerY: am5.p50,
                    centerX: am5.p50,
                    populateText: true
                })
            });
        });

        legend.data.push(series);
    }

    barChart.Labels.forEach(s => {
        makeSeries(s, s);

    });


    // Make stuff animate on load
    // https://www.amcharts.com/docs/v5/concepts/animations/
    chart.appear(1000, 100);
}
//#endregion
//#region TreeMap --------------------------------------------------------------------------------------------------

function RenderTreeMap(url, id) {
    $.ajax({
        url: url,
        type: 'GET',
        success: function (dataObjectResult) {
            if (dataObjectResult.success) {
                let chart = JSON.parse(dataObjectResult.object);
                CreateTreeMap(chart, id);
            }
        }
    });
}
function CreateTreeMap(treeMap, id) {
    // Create root element
    // https://www.amcharts.com/docs/v5/getting-started/#Root_element
    var root = am5.Root.new(id);

    // Set themes
    // https://www.amcharts.com/docs/v5/concepts/themes/
    root.setThemes([
        am5themes_Animated.new(root)
    ]);


    // Create wrapper container
    var container = root.container.children.push(am5.Container.new(root, {
        width: am5.percent(100),
        height: am5.percent(100),
        layout: root.verticalLayout
    }));


    // Create series
    // https://www.amcharts.com/docs/v5/charts/hierarchy/#Adding
    var series = container.children.push(am5hierarchy.Treemap.new(root, {
        singleBranchOnly: false,
        downDepth: 1,
        upDepth: 1,
        initialDepth: 1,
        valueField: "Value",
        categoryField: "Name",
        childDataField: "Maps"
    }));


    // Generate and set data
    // https://www.amcharts.com/docs/v5/charts/hierarchy/#Setting_data
    //var maxLevels = 2;
    //var maxNodes = 6;
    //var maxValue = 100;

    var data = treeMap;
    //var data = {
    //    name: "Root",
    //    children: []
    //}
    //generateLevel(data, "", 0);
    console.log(data);
    series.data.setAll([data]);
    series.set("selectedDataItem", series.dataItems[0]);

    container.children.moveValue(
        am5hierarchy.BreadcrumbBar.new(root, {
            series: series
        }), 0
    );

    //function generateLevel(data, name, level) {
    //    for (var i = 0; i < Math.ceil(maxNodes * Math.random()) + 1; i++) {
    //        var nodeName = name + "ABCDEFGHIJKLMNOPQRSTUVWXYZ"[i];
    //        var child;
    //        if (level < maxLevels) {
    //            child = {
    //                name: nodeName + level
    //            }

    //            if (level > 0 && Math.random() < 0.5) {
    //                child.value = Math.round(Math.random() * maxValue);
    //            }
    //            else {
    //                child.children = [];
    //                generateLevel(child, nodeName + i, level + 1)
    //            }
    //        }
    //        else {
    //            child = {
    //                name: name + i,
    //                value: Math.round(Math.random() * maxValue)
    //            }
    //        }
    //        data.children.push(child);
    //    }

    //    level++;
    //    return data;
    //}


    // Make stuff animate on load
    series.appear(1000, 100);
}
//#endregion
//#region ClusteredBarChart--------------------------------------------------------------------------------------------------
function RenderClusteredBarChart(url, id) {
    $.ajax({
        url: url,
        type: 'GET',
        success: function (dataObjectResult) {
            if (dataObjectResult.success) {
                let chart = JSON.parse(dataObjectResult.object);
                CreateClusteredBarChart(chart, id);
            }
        }
    });
}
function CreateClusteredBarChart(clusteredBarChart, id) {
    /**
 * ---------------------------------------
 * This demo was created using amCharts 5.
 *
 * For more information visit:
 * https://www.amcharts.com/
 *
 * Documentation is available at:
 * https://www.amcharts.com/docs/v5/
 * ---------------------------------------
 */
    var obj = clusteredBarChart.Groups;
    let length = obj.length;
    let data = [];
    for (var i = 0; i < length; i++) {
        let newObj = {
            Label: obj[i].Label
        }
        obj[i].Coloumns.forEach(function (item) {
            var temObject = {
                [item.Label]: item.Value
            };
            newObj = { ...newObj, ...temObject }
        });
        data.push(newObj);
    }
    // Create root element
    // https://www.amcharts.com/docs/v5/getting-started/#Root_element
    var root = am5.Root.new(id);


    // Set themes
    // https://www.amcharts.com/docs/v5/concepts/themes/
    root.setThemes([
        am5themes_Animated.new(root)
    ]);


    // Create chart
    // https://www.amcharts.com/docs/v5/charts/xy-chart/
    var chart = root.container.children.push(am5xy.XYChart.new(root, {
        panX: false,
        panY: false,
        //wheelX: "panX",
        //wheelY: "zoomX",
        layout: root.verticalLayout
    }));


    // Add legend
    // https://www.amcharts.com/docs/v5/charts/xy-chart/legend-xy-series/
    var legend = chart.children.push(
        am5.Legend.new(root, {
            centerX: am5.p50,
            x: am5.p50
        })
    );


    // Create axes
    // https://www.amcharts.com/docs/v5/charts/xy-chart/axes/
    var xAxis = chart.xAxes.push(am5xy.CategoryAxis.new(root, {
        categoryField: clusteredBarChart.ValueXField,
        renderer: am5xy.AxisRendererX.new(root, {
            cellStartLocation: 0.1,
            cellEndLocation: 0.9
        }),
        tooltip: am5.Tooltip.new(root, {})
    }));

    xAxis.data.setAll(data);

    var yAxis = chart.yAxes.push(am5xy.ValueAxis.new(root, {
        renderer: am5xy.AxisRendererY.new(root, {})
    }));


    // Add series
    // https://www.amcharts.com/docs/v5/charts/xy-chart/series/
    function makeSeries(name, fieldName) {
        var series = chart.series.push(am5xy.ColumnSeries.new(root, {
            name: name,
            xAxis: xAxis,
            yAxis: yAxis,
            valueYField: fieldName,
            categoryXField: clusteredBarChart.ValueXField
        }));

        series.columns.template.setAll({
            tooltipText: "{name}, {categoryX}:{valueY}",
            width: am5.percent(90),
            tooltipY: 0
        });

        series.data.setAll(data);

        // Make stuff animate on load
        // https://www.amcharts.com/docs/v5/concepts/animations/
        series.appear();

        series.bullets.push(function () {
            return am5.Bullet.new(root, {
                locationY: 0,
                sprite: am5.Label.new(root, {
                    text: "{valueY}",
                    fill: root.interfaceColors.get("alternativeText"),
                    centerY: 0,
                    centerX: am5.p50,
                    populateText: true
                })
            });
        });

        legend.data.push(series);
    }

    clusteredBarChart.Labels.forEach(s => {
        makeSeries(s, s);

    });


    // Make stuff animate on load
    // https://www.amcharts.com/docs/v5/concepts/animations/
    chart.appear(1000, 100);

}

//#endregion

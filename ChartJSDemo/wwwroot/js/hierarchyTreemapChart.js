﻿"Use strict"
// Create root element
// https://www.amcharts.com/docs/v5/getting-started/#Root_element
var root = am5.Root.new("hierarchyTreemapChart");


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
    valueField: "value",
    categoryField: "name",
    childDataField: "children"
}));


// Generate and set data
// https://www.amcharts.com/docs/v5/charts/hierarchy/#Setting_data
var maxLevels = 2;
var maxNodes = 6;
var maxValue = 100;

var data = {
    name: "Root",
    children: []
}
generateLevel(data, "", 0);

series.data.setAll([data]);
series.set("selectedDataItem", series.dataItems[0]);

container.children.moveValue(
    am5hierarchy.BreadcrumbBar.new(root, {
        series: series
    }), 0
);

function generateLevel(data, name, level) {
    for (var i = 0; i < Math.ceil(maxNodes * Math.random()) + 1; i++) {
        var nodeName = name + "ABCDEFGHIJKLMNOPQRSTUVWXYZ"[i];
        var child;
        if (level < maxLevels) {
            child = {
                name: nodeName + level
            }

            if (level > 0 && Math.random() < 0.5) {
                child.value = Math.round(Math.random() * maxValue);
            }
            else {
                child.children = [];
                generateLevel(child, nodeName + i, level + 1)
            }
        }
        else {
            child = {
                name: name + i,
                value: Math.round(Math.random() * maxValue)
            }
        }
        data.children.push(child);
    }

    level++;
    return data;
}


// Make stuff animate on load
series.appear(1000, 100);
using ScottPlot;
using ScottPlot.Plottables;


Plot myPlot = new();


// create a plottable and modify it as desired

ScottPlot.Plottables.LinePlot line = new()
{
    Start = new Coordinates(1, 2),
    End = new Coordinates(3, 4),
};


// add the custom plottable to the plot
//myPlot.Add.Plottable(line);
double[] x = [4,9,16];
double[] y = [1, 2, 3];
double[] yAxis =
[
    2.6114757, 0.9200659, 0.45417628, 0.27427602, 0.19502547, 0.14959283, 0.12049681, 0.10094314, 0.08862467,
    0.073425256
];
var xAxis = Enumerable.Range(1, 10).ToArray();
myPlot.Add.Scatter(xAxis, yAxis,color:new (255,33,33));


myPlot.SavePng("demo.png", 400, 300);
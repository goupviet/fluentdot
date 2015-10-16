# Description #

A demo of applying different sides to nodes with a shape of polygon.

# Graph #

![http://fluentdot.googlecode.com/svn/wiki/Images/DemoNodeSides.png](http://fluentdot.googlecode.com/svn/wiki/Images/DemoNodeSides.png)

# Code #

```
            var graph = Fluently.CreateDirectedGraph()
                .TheDefaults.ForNodes.Are(x => x.WithShape(NodeShape.Polygon))
                .WithLabel("Polygon node sides. The labels on the nodes indicate the number of sides.");
            int a = 1;
            int b = 2;
            for (int i = 0; i < 10; i += 1)
            {
                graph.Nodes.Add(
                    x =>
                    {
                        x.WithName(a.ToString()).WithSides(i).WithLabel(i.ToString());
                        x.WithName(b.ToString()).WithSides(i).WithLabel(i.ToString());
                    })
                    .Edges.Add(
                        x => x.FromNodeWithName(a.ToString()).ToNodeWithName(b.ToString())
                    );
                a += 2;
                b += 2;
            }
            return graph;

```

# Dot Produced #

```
digraph "DirectedGraph" {
graph [label="Polygon node sides. The labels on the nodes indicate the number of sides."];

node [shape=polygon];
"1" [sides=0, label="0"];
"2" [sides=0, label="0"];
"3" [sides=1, label="1"];
"4" [sides=1, label="1"];
"5" [sides=2, label="2"];
"6" [sides=2, label="2"];
"7" [sides=3, label="3"];
"8" [sides=3, label="3"];
"9" [sides=4, label="4"];
"10" [sides=4, label="4"];
"11" [sides=5, label="5"];
"12" [sides=5, label="5"];
"13" [sides=6, label="6"];
"14" [sides=6, label="6"];
"15" [sides=7, label="7"];
"16" [sides=7, label="7"];
"17" [sides=8, label="8"];
"18" [sides=8, label="8"];
"19" [sides=9, label="9"];
"20" [sides=9, label="9"];
"1" -> "2";
"3" -> "4";
"5" -> "6";
"7" -> "8";
"9" -> "10";
"11" -> "12";
"13" -> "14";
"15" -> "16";
"17" -> "18";
"19" -> "20";
}
```
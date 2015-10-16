# Description #

A demo of how the drawing pen can be modified.

# Graph #

![http://fluentdot.googlecode.com/svn/wiki/Images/DemoPenModifiers.png](http://fluentdot.googlecode.com/svn/wiki/Images/DemoPenModifiers.png)

# Code #

```
            return Fluently.CreateDirectedGraph()
                .Nodes.Add(nodes =>
                               {
                                   nodes.WithName("b").WithPenWidth(2.0).WithLabel("Pen Width : 2.0");
                                   nodes.WithName("d").WithPenWidth(3.0).WithLabel("Pen Width : 3.0");
                               })
                .Clusters.Add(cluster => cluster
                                             .WithName("sub")
                                             .Nodes.Add(nodes =>
                                                            {
                                                                nodes.WithName("e");
                                                                nodes.WithName("f").WithPenWidth(1.5).WithLabel("Pen Width : 1.5");
                                                                nodes.WithName("g");
                                                                nodes.WithName("h").WithPenWidth(0).WithLabel("Pen Width : 0");
                                                            })
                                             .WithPenColor(Color.Red)
                                             .WithPenWidth(2.0)
                                             .WithLabel("Red pen color, 2.0 Width"))
                .Edges.Add(edges =>
                               {
                                   edges.FromNodeWithName("a").ToNodeWithName("b");
                                   edges.FromNodeWithName("b").ToNodeWithName("c");
                                   edges.FromNodeWithName("b").ToNodeWithName("d");
                                   edges.FromNodeWithName("c").ToNodeWithName("d").WithPenWidth(2.0).WithLabel("Pen Width : 2.0");
                                   edges.FromNodeWithName("b").ToNodeWithName("e");
                                   edges.FromNodeWithName("e").ToNodeWithName("f");
                                   edges.FromNodeWithName("e").ToNodeWithName("g");
                                   edges.FromNodeWithName("g").ToNodeWithName("h");
                                   edges.FromNodeWithName("f").ToNodeWithName("g").WithPenWidth(3.0).WithLabel("Pen Width : 3.0");
                                   edges.FromNodeWithName("g").ToNodeWithName("a");
                               });

```

# Dot Produced #

```
digraph "DirectedGraph" {
subgraph "clustersub" {
graph [pencolor="#ff0000", penwidth=2, label="Red pen color, 2.0 Width"];

"e";
"f" [penwidth=1.5, label="Pen Width : 1.5"];
"g";
"h" [penwidth=0, label="Pen Width : 0"];
}
"b" [penwidth=2, label="Pen Width : 2.0"];
"d" [penwidth=3, label="Pen Width : 3.0"];
"a";
"c";
"a" -> "b";
"b" -> "c";
"b" -> "d";
"c" -> "d" [penwidth=2, label="Pen Width : 2.0"];
"b" -> "e";
"e" -> "f";
"e" -> "g";
"g" -> "h";
"f" -> "g" [penwidth=3, label="Pen Width : 3.0"];
"g" -> "a";
}
```
# Description #

A demo of the orderining the graph edges out.

# Graph #

![http://fluentdot.googlecode.com/svn/wiki/Images/DemoEdgeOrdeningOut.png](http://fluentdot.googlecode.com/svn/wiki/Images/DemoEdgeOrdeningOut.png)

# Code #

```
            return Fluently.CreateDirectedGraph()
                .Edges.Add(edges =>
                               {
                                   edges.FromNodeWithName("a").ToNodeWithName("b");
                                   edges.FromNodeWithName("a").ToNodeWithName("c");
                                   edges.FromNodeWithName("b").ToNodeWithName("c");
                                   edges.FromNodeWithName("c").ToNodeWithName("d");
                                   edges.FromNodeWithName("b").ToNodeWithName("e");
                                   edges.FromNodeWithName("e").ToNodeWithName("g");
                                   edges.FromNodeWithName("e").ToNodeWithName("f");
                                   edges.FromNodeWithName("g").ToNodeWithName("h");
                               })
                .WithEdgeOrdering(Ordering.Out)
                .WithLabel("Out Ordering of edges");

```

# Dot Produced #

```
digraph "DirectedGraph" {
graph [ordering="out", label="Out Ordering of edges"];

"a";
"b";
"c";
"d";
"e";
"g";
"f";
"h";
"a" -> "b";
"a" -> "c";
"b" -> "c";
"c" -> "d";
"b" -> "e";
"e" -> "g";
"e" -> "f";
"g" -> "h";
}
```
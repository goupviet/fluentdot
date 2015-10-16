# Description #

A demo of the orderining the graph edges in.

# Graph #

![http://fluentdot.googlecode.com/svn/wiki/Images/DemoEdgeOrdeningIn.png](http://fluentdot.googlecode.com/svn/wiki/Images/DemoEdgeOrdeningIn.png)

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
                .WithEdgeOrdering(Ordering.In)
                .WithLabel("In Ordering of edges");

```

# Dot Produced #

```
digraph "DirectedGraph" {
graph [ordering="in", label="In Ordering of edges"];

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
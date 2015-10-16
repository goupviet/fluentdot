# Description #

A demo of applying ratio to a graph.

# Graph #

![http://fluentdot.googlecode.com/svn/wiki/Images/DemoGraphRatio.png](http://fluentdot.googlecode.com/svn/wiki/Images/DemoGraphRatio.png)

# Code #

```
            return Fluently.CreateDirectedGraph()
                .Edges.Add(edges =>
                               {
                                   edges.FromNodeWithName("a").ToNodeWithName("b");
                                   edges.FromNodeWithName("a").ToNodeWithName("c");
                                   edges.FromNodeWithName("b").ToNodeWithName("c");
                                   edges.FromNodeWithName("c").ToNodeWithName("d");
                               }
                )
                .WithRatio(5);

```

# Dot Produced #

```
digraph "DirectedGraph" {
graph [ratio=5];

"a";
"b";
"c";
"d";
"a" -> "b";
"a" -> "c";
"b" -> "c";
"c" -> "d";
}
```
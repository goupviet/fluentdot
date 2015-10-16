# Description #

A demo of how clusters can be used to partition a graph.

# Graph #

![http://fluentdot.googlecode.com/svn/wiki/Images/DemoClusters.png](http://fluentdot.googlecode.com/svn/wiki/Images/DemoClusters.png)

# Code #

```
            return Fluently.CreateDirectedGraph()
                .Clusters.Add(c0 => c0
                                        .WithName("c0")
                                        .Edges.Add(edges =>
                                                       {
                                                           edges.FromNodeWithName("a0").ToNodeWithName("a1");
                                                           edges.FromNodeWithName("a1").ToNodeWithName("a2");
                                                           edges.FromNodeWithName("a2").ToNodeWithName("a3");
                                                       })
                                        .Clusters.Add(c00 => c00
                                            .WithName("c00")
                                            .Edges.Add(edges =>
                                                           {
                                                               edges.FromNodeWithName("a3").ToNodeWithName("a4");
                                                               edges.FromNodeWithName("a4").ToNodeWithName("a5");
                                                           })
                                             .WithColor(Color.Red)
                                            ))
                .Clusters.Add(c1 => c1
                                        .WithName("c1")
                                        .WithBackgroundColor(Color.Gainsboro)
                                        .Edges.Add(edges =>
                                                       {
                                                           edges.FromNodeWithName("b0").ToNodeWithName("b1");
                                                           edges.FromNodeWithName("b1").ToNodeWithName("b2");
                                                           edges.FromNodeWithName("b2").ToNodeWithName("b3");
                                                       }) 
                )
                .Edges.Add(edges =>
                               {
                                   edges.FromNodeWithName("x").ToNodeWithName("a0");
                                   edges.FromNodeWithName("x").ToNodeWithName("b0");
                                   edges.FromNodeWithName("a1").ToNodeWithName("b1");
                                   edges.FromNodeWithName("a5").ToNodeWithName("a0");
                                   edges.FromNodeWithName("a3").ToNodeWithName("z");
                                   edges.FromNodeWithName("b3").ToNodeWithName("z");
                               });

```

# Dot Produced #

```
digraph "DirectedGraph" {
subgraph "clusterc0" {
subgraph "clusterc00" {
graph [color="#ff0000"];

"a4";
"a5";
"a3" -> "a4";
"a4" -> "a5";
}
"a0";
"a1";
"a2";
"a3";
"a0" -> "a1";
"a1" -> "a2";
"a2" -> "a3";
}
subgraph "clusterc1" {
graph [bgcolor="#dcdcdc"];

"b0";
"b1";
"b2";
"b3";
"b0" -> "b1";
"b1" -> "b2";
"b2" -> "b3";
}
"x";
"z";
"x" -> "a0";
"x" -> "b0";
"a1" -> "b1";
"a5" -> "a0";
"a3" -> "z";
"b3" -> "z";
}
```
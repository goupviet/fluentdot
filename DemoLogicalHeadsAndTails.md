# Description #

A demo of how the compound attribute enables logical heads and tails between clusters.

# Graph #

![http://fluentdot.googlecode.com/svn/wiki/Images/DemoLogicalHeadsAndTails.png](http://fluentdot.googlecode.com/svn/wiki/Images/DemoLogicalHeadsAndTails.png)

# Code #

```
            return Fluently.CreateDirectedGraph()
                .Clusters.Add(c0 => c0
                                        .WithName("c0")
                                        .Edges.Add(edges =>
                                        {
                                            edges.FromNodeWithName("a0").ToNodeWithName("a1");
                                            edges.FromNodeWithName("a1").ToNodeWithName("a2");
                                        })
                                      )
                .Clusters.Add(c1 => c1
                                        .WithName("c1")
                                        .WithBackgroundColor(Color.Gainsboro)
                                        .Edges.Add(edges =>
                                        {
                                            edges.FromNodeWithName("b0").ToNodeWithName("b1");
                                            edges.FromNodeWithName("b1").ToNodeWithName("b2");
                                        })
                )
                .Edges.Add(edges =>
                {
                    edges.FromNodeWithName("x").ToNodeWithName("a0").WithLogicalHead("c0").WithLabel("Logical Head");
                    edges.FromNodeWithName("b2").ToNodeWithName("y").WithLogicalTail("c1").WithLabel("Logical Tail");
                    edges.FromNodeWithName("f").ToNodeWithName("a0").WithLabel("Normal");
                    edges.FromNodeWithName("b2").ToNodeWithName("g").WithLabel("Normal");
                })
                .Compound();

```

# Dot Produced #

```
digraph "DirectedGraph" {
graph [compound="true"];

subgraph "clusterc0" {
"a0";
"a1";
"a2";
"a0" -> "a1";
"a1" -> "a2";
}
subgraph "clusterc1" {
graph [bgcolor="#dcdcdc"];

"b0";
"b1";
"b2";
"b0" -> "b1";
"b1" -> "b2";
}
"x";
"y";
"f";
"g";
"x" -> "a0" [lhead="clusterc0", label="Logical Head"];
"b2" -> "y" [ltail="clusterc1", label="Logical Tail"];
"f" -> "a0" [label="Normal"];
"b2" -> "g" [label="Normal"];
}
```
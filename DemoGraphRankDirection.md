# Description #

A demo of how rank direction affects the layout of a graph.

# Graph #

![http://fluentdot.googlecode.com/svn/wiki/Images/DemoGraphRankDirection.png](http://fluentdot.googlecode.com/svn/wiki/Images/DemoGraphRankDirection.png)

# Code #

```
            return Fluently.CreateDirectedGraph()
                .Edges.Add(edge =>
                               {
                                   edge.FromNodeWithName("a").ToNodeWithName("b");
                                   edge.FromNodeWithName("b").ToNodeWithName("c");
                                   edge.FromNodeWithName("c").ToNodeWithName("d");
                                   edge.FromNodeWithName("d").ToNodeWithName("e");
                                   edge.FromNodeWithName("e").ToNodeWithName("f");
                                   edge.FromNodeWithName("f").ToNodeWithName("g");
                                   edge.FromNodeWithName("aa").ToNodeWithName("a");
                                   edge.FromNodeWithName("dd").ToNodeWithName("d");
                                   edge.FromNodeWithName("gg").ToNodeWithName("g");
                               }
                )
                .WithRankDirection(RankDirection.RightToLeft)
                .WithLabel("Right To Left layout direction");
            

```

# Dot Produced #

```
digraph "DirectedGraph" {
graph [rankdir="RL", label="Right To Left layout direction"];

"a";
"b";
"c";
"d";
"e";
"f";
"g";
"aa";
"dd";
"gg";
"a" -> "b";
"b" -> "c";
"c" -> "d";
"d" -> "e";
"e" -> "f";
"f" -> "g";
"aa" -> "a";
"dd" -> "d";
"gg" -> "g";
}
```
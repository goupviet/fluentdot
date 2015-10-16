# Description #

An example of how edges can be set to connect to the same head and tail.

# Graph #

![http://fluentdot.googlecode.com/svn/wiki/Images/DemoSameHeadAndTail.png](http://fluentdot.googlecode.com/svn/wiki/Images/DemoSameHeadAndTail.png)

# Code #

```
            return Fluently.CreateDirectedGraph()
                .Edges.Add(edges =>
                {
                    edges.FromNodeWithName("a").ToNodeWithName("X").WithSameHead("Left");
                    edges.FromNodeWithName("b").ToNodeWithName("X").WithSameHead("Left");
                    edges.FromNodeWithName("c").ToNodeWithName("X").WithSameHead("Right");
                    edges.FromNodeWithName("d").ToNodeWithName("X").WithSameHead("Right");
                    edges.FromNodeWithName("X").ToNodeWithName("e").WithSameTail("Left").WithSameHead("Left");
                    edges.FromNodeWithName("a").ToNodeWithName("e").WithSameTail("Left").WithSameHead("Left");
                    edges.FromNodeWithName("X").ToNodeWithName("f").WithSameTail("Right").WithSameHead("Right");
                    edges.FromNodeWithName("d").ToNodeWithName("f").WithSameTail("Right").WithSameHead("Right");
                });

```

# Dot Produced #

```
digraph "DirectedGraph" {
"a";
"X";
"b";
"c";
"d";
"e";
"f";
"a" -> "X" [samehead="Left"];
"b" -> "X" [samehead="Left"];
"c" -> "X" [samehead="Right"];
"d" -> "X" [samehead="Right"];
"X" -> "e" [sametail="Left", samehead="Left"];
"a" -> "e" [sametail="Left", samehead="Left"];
"X" -> "f" [sametail="Right", samehead="Right"];
"d" -> "f" [sametail="Right", samehead="Right"];
}
```
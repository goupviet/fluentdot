# Description #

An illustration of the background color functionality in a graph.

# Graph #

![http://fluentdot.googlecode.com/svn/wiki/Images/DemoGraphBackgroundColor.png](http://fluentdot.googlecode.com/svn/wiki/Images/DemoGraphBackgroundColor.png)

# Code #

```
            return Fluently.CreateDirectedGraph()
                .Edges.Add(x =>
                               {
                                   x.FromNodeWithName("a").ToNodeWithName("b");
                                   x.FromNodeWithName("a").ToNodeWithName("c");
                                   x.FromNodeWithName("c").ToNodeWithName("d");
                                   x.FromNodeWithName("b").ToNodeWithName("d");
                               }
                ).WithBackgroundColor(Color.SlateBlue);

```

# Dot Produced #

```
digraph "DirectedGraph" {
graph [bgcolor="#6a5acd"];

"a";
"b";
"c";
"d";
"a" -> "b";
"a" -> "c";
"c" -> "d";
"b" -> "d";
}
```
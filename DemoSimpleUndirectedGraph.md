# Description #

An illustration of a simple undirected graph.

# Graph #

![http://fluentdot.googlecode.com/svn/wiki/Images/DemoSimpleUndirectedGraph.png](http://fluentdot.googlecode.com/svn/wiki/Images/DemoSimpleUndirectedGraph.png)

# Code #

```
            return Fluently.CreateUndirectedGraph()
                .Edges.Add(x =>
                               {
                                   x.FromNodeWithName("A").ToNodeWithName("B");
                                   x.FromNodeWithName("A").ToNodeWithName("C");
                                   x.FromNodeWithName("B").ToNodeWithName("C");
                                   x.FromNodeWithName("B").ToNodeWithName("D");
                               }
                );

```

# Dot Produced #

```
graph "UndirectedGraph" {
"A";
"B";
"C";
"D";
"A" -- "B";
"A" -- "C";
"B" -- "C";
"B" -- "D";
}
```
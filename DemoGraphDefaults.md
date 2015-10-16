# Description #

An illustration of how one can apply defaults to edges and nodes in a graph.

# Graph #

![http://fluentdot.googlecode.com/svn/wiki/Images/DemoGraphDefaults.png](http://fluentdot.googlecode.com/svn/wiki/Images/DemoGraphDefaults.png)

# Code #

```
            return Fluently.CreateDirectedGraph()
                .TheDefaults.ForEdges.Are(x => x.WithLabel("Default Color Blue").WithColor(Color.Blue))
                .TheDefaults.ForNodes.Are(x => x.WithShape(NodeShape.Diamond).WithColor(Color.Green).WithLabel("Green Diamond"))
                .Nodes.Add(x => 
                    x.WithName("c")
                     .WithShape(NodeShape.DoubleCircle)
                     .WithColor(Color.DarkMagenta)
                     .WithLabel("Override of Shape and Color"))
                .Edges.Add(x =>
                               {
                                   x.FromNodeWithName("a").ToNodeWithName("b");
                                   x.FromNodeWithName("a").ToNodeWithName("c").WithColor(Color.Red).WithLabel("Override of Red Color");
                                   x.FromNodeWithName("c").ToNodeWithName("d");
                                   x.FromNodeWithName("b").ToNodeWithName("d");
                               }
                );

```

# Dot Produced #

```
digraph "DirectedGraph" {
node [shape=diamond, color="#008000", label="Green Diamond"];
edge [label="Default Color Blue", color="#0000ff"];
"c" [shape=doublecircle, color="#8b008b", label="Override of Shape and Color"];
"a";
"b";
"d";
"a" -> "b";
"a" -> "c" [color="#ff0000", label="Override of Red Color"];
"c" -> "d";
"b" -> "d";
}
```
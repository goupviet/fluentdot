# Description #

A demo of the different label placement options available.

# Graph #

![http://fluentdot.googlecode.com/svn/wiki/Images/DemoLabelPlacements.png](http://fluentdot.googlecode.com/svn/wiki/Images/DemoLabelPlacements.png)

# Code #

```
            return Fluently.CreateDirectedGraph()
                .Nodes.Add(nodes =>
                               {
                                   nodes.WithName("a").WithLabelLocation(Location.Bottom).WithLabel("Location - Bottom").WithHeight(1).WithWidth(2);
                                   nodes.WithName("b").DoNotJustify().WithLabel(@"Label\nNot\nJustified");
                                   nodes.WithName("d").WithLabelLocation(Location.Top).WithLabel("Location - Top").WithHeight(1).WithWidth(2);
                                   nodes.WithName("e").DoNotJustify().WithLabel(@"Label\nNot\nJustified");
                                   nodes.WithName("f").WithLabelLocation(Location.Bottom).WithLabel("Location - Bottom").WithHeight(1).WithWidth(2);
                                   nodes.WithName("g").WithLabelLocation(Location.Top).WithLabel("Location - Top").WithHeight(1).WithWidth(2); ;
                               })
                .Edges.Add(edges =>
                               {
                                   edges.FromNodeWithName("a").ToNodeWithName("b");
                                   edges.FromNodeWithName("a").ToNodeWithName("c");
                                   edges.FromNodeWithName("b").ToNodeWithName("c");
                                   edges.FromNodeWithName("c").ToNodeWithName("d").DoNotJustify().WithLabel(@"Label\nNot\nJustified");
                                   edges.FromNodeWithName("b").ToNodeWithName("e");
                                   edges.FromNodeWithName("e").ToNodeWithName("f").DoNotJustify().WithLabel(@"Label\nNot\nJustified");
                                   edges.FromNodeWithName("e").ToNodeWithName("g");
                                   edges.FromNodeWithName("g").ToNodeWithName("h");
                               })
                .WithLabel("Bottom Right Graph Label")
                .WithLabelJustification(Justification.Right)
                .WithLabelLocation(Location.Bottom);

```

# Dot Produced #

```
digraph "DirectedGraph" {
graph [label="Bottom Right Graph Label", labeljust="r", labelloc="b"];

"a" [labelloc="b", label="Location - Bottom", height=1, width=2];
"b" [nojustify="true", label="Label\nNot\nJustified"];
"d" [labelloc="t", label="Location - Top", height=1, width=2];
"e" [nojustify="true", label="Label\nNot\nJustified"];
"f" [labelloc="b", label="Location - Bottom", height=1, width=2];
"g" [labelloc="t", label="Location - Top", height=1, width=2];
"c";
"h";
"a" -> "b";
"a" -> "c";
"b" -> "c";
"c" -> "d" [nojustify="true", label="Label\nNot\nJustified"];
"b" -> "e";
"e" -> "f" [nojustify="true", label="Label\nNot\nJustified"];
"e" -> "g";
"g" -> "h";
}
```
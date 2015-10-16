# Description #

A demo of the different edge styles that DOT provides.

# Graph #

![http://fluentdot.googlecode.com/svn/wiki/Images/DemoEdgeStyles.png](http://fluentdot.googlecode.com/svn/wiki/Images/DemoEdgeStyles.png)

# Code #

```
            var graph = Fluently.CreateDirectedGraph();
            int a = 1;
            int b = 2;
            foreach (var item in typeof(EdgeStyle).GetFields(BindingFlags.Public | BindingFlags.Static).Where(x => typeof(EdgeStyle).IsAssignableFrom(x.FieldType))) {
                var style = (EdgeStyle)item.GetValue(null);
                graph.Edges.Add(
                    x => x.FromNodeWithName(a.ToString()).ToNodeWithName(b.ToString())
                             .WithLabel(item.Name)
                             .WithStyle(style)
                    );
                a += 2;
                b += 2;
            }
            return graph;

```

# Dot Produced #

```
digraph "DirectedGraph" {
"1";
"2";
"3";
"4";
"5";
"6";
"7";
"8";
"9";
"10";
"1" -> "2" [label="Dashed", style="dashed"];
"3" -> "4" [label="Dotted", style="dotted"];
"5" -> "6" [label="Solid", style="solid"];
"7" -> "8" [label="Invisible", style="invis"];
"9" -> "10" [label="Bold", style="bold"];
}
```
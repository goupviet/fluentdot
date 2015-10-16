# Description #

A demo of how distortion affects the node shape.

# Graph #

![http://fluentdot.googlecode.com/svn/wiki/Images/DemoNodeDistortion.png](http://fluentdot.googlecode.com/svn/wiki/Images/DemoNodeDistortion.png)

# Code #

```
            var graph = Fluently.CreateDirectedGraph()
                .TheDefaults.ForNodes.Are(x => x.WithShape(NodeShape.Polygon))
                .WithLabel("Distortion of polygon node shapes. The values on the edges indicate the distortion value.");
            int a = 1;
            int b = 2;
            for (double i = -3; i < 3; i+= 0.5 )
            {
                graph.Nodes.Add(
                    x =>
                    {
                        x.WithName(a.ToString()).WithDistortion(i);
                        x.WithName(b.ToString()).WithDistortion(i);
                    })
                    .Edges.Add(
                        x => x.FromNodeWithName(a.ToString()).ToNodeWithName(b.ToString()).WithLabel(i.ToString())
                    );
                a += 2;
                b += 2;
            }
            return graph;

```

# Dot Produced #

```
digraph "DirectedGraph" {
graph [label="Distortion of polygon node shapes. The values on the edges indicate the distortion value."];

node [shape=polygon];
"1" [distortion=-3];
"2" [distortion=-3];
"3" [distortion=-2.5];
"4" [distortion=-2.5];
"5" [distortion=-2];
"6" [distortion=-2];
"7" [distortion=-1.5];
"8" [distortion=-1.5];
"9" [distortion=-1];
"10" [distortion=-1];
"11" [distortion=-0.5];
"12" [distortion=-0.5];
"13" [distortion=0];
"14" [distortion=0];
"15" [distortion=0.5];
"16" [distortion=0.5];
"17" [distortion=1];
"18" [distortion=1];
"19" [distortion=1.5];
"20" [distortion=1.5];
"21" [distortion=2];
"22" [distortion=2];
"23" [distortion=2.5];
"24" [distortion=2.5];
"1" -> "2" [label="-3"];
"3" -> "4" [label="-2.5"];
"5" -> "6" [label="-2"];
"7" -> "8" [label="-1.5"];
"9" -> "10" [label="-1"];
"11" -> "12" [label="-0.5"];
"13" -> "14" [label="0"];
"15" -> "16" [label="0.5"];
"17" -> "18" [label="1"];
"19" -> "20" [label="1.5"];
"21" -> "22" [label="2"];
"23" -> "24" [label="2.5"];
}
```
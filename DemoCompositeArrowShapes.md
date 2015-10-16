# Description #

A demo of applying more than one arrow shape to an edge.

# Graph #

![http://fluentdot.googlecode.com/svn/wiki/Images/DemoCompositeArrowShapes.png](http://fluentdot.googlecode.com/svn/wiki/Images/DemoCompositeArrowShapes.png)

# Code #

```
            var graph = Fluently.CreateDirectedGraph();
            
            int a = 1;
            int b = 2;
            var arrowShapes = typeof(ArrowShape)
                .GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(x => typeof(ArrowShape).IsAssignableFrom(x.FieldType))
                .Select(x => (ArrowShape) x.GetValue(null))
                .ToArray();
            var random = new Random((int)(DateTime.Now.Ticks % Int32.MaxValue));
            for (int i = 0; i< 10; i++)
            {
                const int numberOfArrowShapes = 2;
                var chosenArrowShapes = new List<ArrowShape>();
                for (int j = 0; j< numberOfArrowShapes; j++)
                {
                    var chosenShape = arrowShapes[random.Next(arrowShapes.Length)];
                    if ((chosenShape == ArrowShape.None) || (chosenArrowShapes.Contains(chosenShape))) {
                        j--;
                        continue;
                    }
                    
                    chosenArrowShapes.Add(chosenShape);
                }
                var shape = new CompositeArrowShape(chosenArrowShapes.ToArray());
                graph.Edges.Add(x => x.FromNodeWithName(a.ToString()).ToNodeWithName(b.ToString())
                                        .WithArrowHead(shape)
                                        .WithLabel(shape.ToDot()));
                a+=2;
                b+=2;
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
"11";
"12";
"13";
"14";
"15";
"16";
"17";
"18";
"19";
"20";
"1" -> "2" [arrowhead="normalbox", label="normalbox"];
"3" -> "4" [arrowhead="teevee", label="teevee"];
"5" -> "6" [arrowhead="crownormal", label="crownormal"];
"7" -> "8" [arrowhead="dotvee", label="dotvee"];
"9" -> "10" [arrowhead="invnormal", label="invnormal"];
"11" -> "12" [arrowhead="crowbox", label="crowbox"];
"13" -> "14" [arrowhead="boxdiamond", label="boxdiamond"];
"15" -> "16" [arrowhead="invtee", label="invtee"];
"17" -> "18" [arrowhead="normalcrow", label="normalcrow"];
"19" -> "20" [arrowhead="veecrow", label="veecrow"];
}
```
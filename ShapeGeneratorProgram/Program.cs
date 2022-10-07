using ShapeGenerator;

Shape[] shapes = new Shape[20];

Console.WriteLine("Generated Shapes: ");

for (int i = 0; i < shapes.Length; i++)
{
    shapes[i] = Shape.GenerateShape();
    Console.WriteLine(shapes[i].ToString());
}

Console.WriteLine("--------------------------");
Console.WriteLine("Average Area of all shapes: ");
Console.WriteLine(AverageArea(shapes));

Console.WriteLine("--------------------------");
Console.WriteLine("Total sum of all triangle perimeters: ");
Console.WriteLine(TotalTrianglePerimeterSum(shapes));

Console.WriteLine("--------------------------");
Console.WriteLine("3D Shape with largest volume: ");
Console.WriteLine(LargestVolume(shapes));

Console.WriteLine("--------------------------");
Console.WriteLine("Most frequent shape: ");
Console.WriteLine(GetMostFrequentShapeType(shapes));

static double AverageArea(Shape[] shapes)
{
    float totalArea = 0;
    foreach (Shape shape in shapes)
    {
        totalArea += shape.Area;
    }
   
    return Math.Round(totalArea / shapes.Length, 2);
}

static double TotalTrianglePerimeterSum(Shape[] shapes)
{
    float totalPerimeter = 0;
    List <Triangle> triangles = new List<Triangle>();

    foreach (Shape shape in shapes)
    {
        if(shape is Triangle)
        {
            triangles.Add((Triangle)shape);
        }
    }

    foreach(Triangle triangle in triangles)
    {
        totalPerimeter += triangle.Circumference;
    }

    return Math.Round(totalPerimeter, 2);

}

static Shape3D LargestVolume(Shape[] shapes)
{
    List <Shape3D> shapes3D = new List<Shape3D>();
    foreach (Shape shape in shapes)
    {
        if (shape is Shape3D)
        {
            shapes3D.Add((Shape3D)shape);
        }
    }
    
    List<Shape3D> sortedList = shapes3D.OrderBy(Shape3D => Shape3D.Volume).ToList();
    sortedList.Reverse();

    return sortedList[0];
}

static string GetMostFrequentShapeType(Shape[] shapes)
{
    var frequency = shapes.GroupBy(shape => shape.GetType()).ToDictionary(shape => shape.Key, x => x.Count());
    var sortedFrequency = frequency.OrderBy(x => x.Value).ToList();
    sortedFrequency.Reverse();

    string shapeName = sortedFrequency[0].Key.ToString().Replace("ShapeGenerator.", "");
    string amount = sortedFrequency[0].Value.ToString();

    return $"{shapeName}: {amount} found in list.";
}

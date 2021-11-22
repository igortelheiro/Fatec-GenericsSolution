
var cuboFaces = new Tripla<Double>(3, 4, 5);
var cubo = new Cubo(cuboFaces);
cubo.ExibirVolume();

class Tripla<T>
{
    public T Value1 { get; private set; }
    public T Value2 { get; private set; }
    public T Value3 { get; private set; }
    public Tripla(T value1, T value2, T value3)
    {
        Value1 = value1;
        Value2 = value2;
        Value3 = value3;
    }
}

class Cubo
{
    public Tripla<Double> Faces { get; set; }
    public Cubo(Tripla<Double> faces) => Faces = faces;
    
    public void ExibirVolume()
    {
        var volume = Faces.Value1 * Faces.Value2 * Faces.Value3;
        Console.WriteLine($"Volume do Cubo: {volume}cm³");
    }
}
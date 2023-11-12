class Shape
{
    private string _color;

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string mycolor)
    {
        _color = mycolor;
    }

    public Shape(string color)
    {
        SetColor(color);
    }

    public virtual double GetArea()
    {
        return 0;
    }
}
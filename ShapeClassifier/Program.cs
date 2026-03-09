using System;

// README.md를 읽고 코드를 작성하세요.

Shape[] shape = new Shape[]
{
    new Circle{Radius = 5},
    new Circle{Radius = 15},
    new Rectangle{Width = 4, Height = 5},
    new Rectangle{Width = 5, Height = 5},
    new Square{Side = 7}
};

Console.WriteLine("=== 도형 분류기 ===");

foreach(var s  in shape)
{
    if(s is Circle c)
        Console.WriteLine($"원(반지름: {c.Radius}): {ClassifyShape(c)}, 넓이: {CalculateArea(c):n2}");
    else if(s is Rectangle r)
        Console.WriteLine($"직사각형({r.Width}*{r.Height}): {ClassifyShape(r)}, 넓이: {CalculateArea(r):n2}");
    else if(s is Square sqr)
        Console.WriteLine($"정사각형({sqr.Side}): {ClassifyShape(sqr)}, 넓이: {CalculateArea(sqr):n2}");

}




double CalculateArea(Shape s) => s switch
{
    Circle c => c.Radius * c.Radius * 3.14,
    Rectangle r => r.Width * r.Height,
    Square sqr => sqr.Side * sqr.Side,
    _ => 0
};


string ClassifyShape(Shape s) => s switch
{
    Circle c and { Radius: >= 10 } => "큰 원",
    Circle c and { Radius: < 10 } => "작은 원",

    Rectangle r and { Width: var w, Height: var h} => w == h ? "정사각형 모양의 직사각형":"일반 직사각형",
    Square sqr => "정사각형"

};
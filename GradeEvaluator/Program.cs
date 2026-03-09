using System;

// README.md를 읽고 코드를 작성하세요.



int count = 95;
Console.WriteLine("=== 성적 평가기 ===");
Console.WriteLine($"{count}점: {GetGrade(count)} ({GetStatus(count)}) - {(isPassingGrade(count) ? "합격" : "불합격")}");
count = 87;
Console.WriteLine($"{count}점: {GetGrade(count)} ({GetStatus(count)}) - {(isPassingGrade(count) ? "합격" : "불합격")}");
count = 73;
Console.WriteLine($"{count}점: {GetGrade(count)} ({GetStatus(count)}) - {(isPassingGrade(count) ? "합격" : "불합격")}");
count = 65;
Console.WriteLine($"{count}점: {GetGrade(count)} ({GetStatus(count)}) - {(isPassingGrade(count) ? "합격" : "불합격")}");
count = 45;
Console.WriteLine($"{count}점: {GetGrade(count)} ({GetStatus(count)}) - {(isPassingGrade(count) ? "합격" : "불합격")}");
count = 30;
Console.WriteLine($"{count}점: {GetGrade(count)} ({GetStatus(count)}) - {(isPassingGrade(count) ? "합격" : "불합격")}");






string GetGrade(int score) => score switch
{
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    >= 60 => "D",
    _ => "F",
};



string GetStatus(int score) => score switch
{
    >= 95 => "최우수",
    >= 90 => "우수",
    >= 70 => "보통",
    >= 40 => "노력 필요",
    _ => "재수강 권장",
};


bool isPassingGrade(int score) => score switch
{
    >= 60 and <= 100 => true,
    _ => false
};
    

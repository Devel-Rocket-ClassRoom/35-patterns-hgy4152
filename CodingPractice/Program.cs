using System;

// README.md를 읽고 코드를 작성하세요.


object obj = "Hello" is string s;

Console.WriteLine(s.Length);

obj = 42;

if(obj is int number)
{
    Console.WriteLine($"정수값: {number}");
    Console.WriteLine($"제곱: {number * number}");
}
else
{
    Console.WriteLine("정수가 아님");
}


PrintInfo(100);
PrintInfo(3.14);
PrintInfo("Hello");
PrintInfo(true);
PrintInfo(DateTime.Now);


void PrintInfo(object obj)
{
    switch(obj)
    {
        case int a:
            Console.WriteLine($"정수: {a}, 2배: {a * 2}");
            break;
        case double b:
            Console.WriteLine($"실수: {b}");
            break;
        case string c:
            Console.WriteLine($"문자열: {c}, 길이: {c.Length}");
            break;
        case bool d:
            Console.WriteLine($"불리언: {d}");
            break;
        default:
            Console.WriteLine($"기타 타입: {obj.GetType().Name}");
            break;
    }
}


CheckValue(0);
CheckValue("Hello");
CheckValue(null);
CheckValue(42);

void CheckValue(object obj)
{
    if (obj is 0)
    {
        Console.WriteLine("값이 0임");
    }
    else if (obj is "Hello")
    {
        Console.WriteLine("값이 Hello임");
    }
    else if(obj is null)
    {
        Console.WriteLine("값이 null임");
    }
    else
    {
        Console.WriteLine($"다른 값: {obj}");
    }
}

GetDayType(DayOfWeek.Monday);
GetDayType(DayOfWeek.Sunday);

string GetDayType(DayOfWeek day)
{
    return day switch
    {
        DayOfWeek.Saturday => "주말",
        DayOfWeek.Sunday => "주말",
        _ => "평일"

    };
}


DescribeValue(42);
DescribeValue(3.14);
DescribeValue("Hello");
DescribeValue(null);
DescribeValue(true);


string DescribeValue(object obj) => obj switch
{
    int i => $"정수 {i}",
    double d => $"실수 {d}",
    string s => $"문자열: {s}",
    null => "null 값",
    _ => $"알 수 없는 타입 ({obj.GetType().Name})"

};


GetGrade(95);
GetGrade(85);
GetGrade(75);
GetGrade(65);
GetGrade(55);

string GetGrade(int score) => score switch
{
    >= 90 => $"{score}점: A",
    >= 80 => $"{score}점: B",
    >= 70 => $"{score}점: C",
    >= 60 => $"{score}점: D",
    _ => $"{score}점: F",
};

ClassifyTemperature(-5);
ClassifyTemperature(5);
ClassifyTemperature(15);
ClassifyTemperature(25);
ClassifyTemperature(35);

string ClassifyTemperature(int celsius) => celsius switch
{
    < 0 => $"{celsius}: 영하",
    < 10 => $"{celsius}: 추움",
    < 20 => $"{celsius}: 선선함",
    < 30 => $"{celsius}: 따뜻함",
    _ => $"{celsius}: 더움",
};

Console.WriteLine($"25살 유효한 나이: {IsValidAge(25)}");
Console.WriteLine($"-5살 유효한 나이: {IsValidAge(-5)}");
Console.WriteLine($"15살 청소년: {IsTeenager(15)}");
Console.WriteLine($"25살 청소년: {IsTeenager(25)}");

bool IsValidAge(int age) => age is >= 0 and <= 150;
bool IsTeenager(int age) => age is >= 13 and <= 19;

Console.WriteLine($"토요일 주말: {DayOfWeek.Saturday}");
Console.WriteLine($"일요일 주말: {DayOfWeek.Sunday}");
Console.WriteLine($"'a' 모음: {IsVoewl('a')}");
Console.WriteLine($"'b' 모음: {IsVoewl('b')}");


bool IsWeekend(DayOfWeek day) => day is DayOfWeek.Saturday or DayOfWeek.Sunday;
bool IsVoewl(char c) => c is 'a' or 'i' or 'e' or 'o' or 'u';



Console.WriteLine($"\"Hello\" not null: {IsNotNull("Hello")}");
Console.WriteLine($"null not null: {IsNotNull(null)}");
Console.WriteLine($"\"Hi\" not empty: {IsNotEmpty("Hi")}");
Console.WriteLine($"\"\" not empty: {IsNotEmpty("")}");


bool IsNotNull(object obj) => obj is not null;
bool IsNotEmpty(string s) => s is not null;


ClassifyNumber(0);
ClassifyNumber(5);
ClassifyNumber(42);
ClassifyNumber(-3);
ClassifyNumber(100);
ClassifyNumber(-50);

string ClassifyNumber(int number) => number switch
{
    0 => $"{number}: 영",
    > 0 and < 10 => $"{number}: 한 자리 양수",
    >= 10 and < 100 => $"{number}: 두 자리 양수",
    < 0 and > -10 => $"{number}: 한 자리 음수",
    _ => $"{number}: 그 외"

};

Console.WriteLine($"Janet: {IsJanetOrJohn("Janet")}");
Console.WriteLine($"John: {IsJanetOrJohn("John")}");
Console.WriteLine($"Mike: {IsJanetOrJohn("Mike")}");


bool IsJanetOrJohn(string name)
{
    return name.ToUpper() is var upper && (upper == "JANET" || upper == "JOHN");
}



Person[] person = new Person[]
{
    new Person { Name = "철수", Age = 15},
    new Person { Name = "영희", Age = 30},
    new Person { Name = "할머니", Age = 70},
};

foreach (Person p in person)
{
    Console.WriteLine($"{p.Name}({p.Age}세): {DescribePerson(p)}");
}

string DescribePerson(Person p) => p switch
{
    { Age: < 18} => "미성년자",
    { Age: >= 18, Age: < 65 } => "성인",
    { Age: >= 65 } => "노인",
    _ => "알 수 없음"
};




Console.WriteLine(Greet(new Person { Name = "철수", Age = 15 }));
Console.WriteLine(Greet(new Person { Name = "영희", Age = 30 }));

string Greet(Person p) => p switch
{
    // 할당이 되는게 좀 신기하네
    { Name: var name, Age: < 18 } => $"안녕, {name}!",
    { Name: var name, Age: >= 18 } => $"안녕하세요, {name}님",
    _ => "안녕하세요"
};

Person student = new Student()
{
    Name = "철수",
    Age = 17,
    School = "서울고"
};

Person company = new Employee()
{
    Name = "영희",
    Age = 28,
    Company = "삼성"
};


Person person1 = new Person()
{
    Name = "민수",
    Age = 40
};

Console.WriteLine(DescribeDetailed(student));
Console.WriteLine(DescribeDetailed(company));
Console.WriteLine(DescribeDetailed(person1));

string DescribeDetailed(Person p) => p switch
{
    Student { Name: var name, Age: var age, School: var school } => $"{name}: {age}세 학생, {school} 재학",
    Employee { Name: var name, Age: var age, Company: var school } => $"{name}: {age}세 직장인, {company} 근무",

    {Name: var name, Age: var age} => $"{name}: {age}세 일반인"


};

Console.WriteLine(DescribeNumber(0));
Console.WriteLine(DescribeNumber(4));
Console.WriteLine(DescribeNumber(7));
Console.WriteLine(DescribeNumber(-6));
Console.WriteLine(DescribeNumber(-3));

string DescribeNumber(int number) => number switch
{
    0  => $"{number}: 영",
    > 0 when number % 2 == 0 => $"{number}: 양의 짝수",
    > 0 when number % 2 == 1 => $"{number}: 양의 홀수",
    < 0 when number % 2 == 0 => $"{number}: 음의 짝수",
    < 0 when number % 2 == 1 => $"{number}: 음의 홀수",
    _ => $"{number}: 그 외"
};



var products = new Product[]
{
    new Product { Name = "마우스", Price = 25000, Stock = 0 },
    new Product { Name = "키보드", Price = 80000, Stock = 5 },
    new Product { Name = "모니터", Price = 300000, Stock = 20 },
    new Product { Name = "USB", Price = 5000, Stock = 100 }
};

foreach (var p in products)
{
    Console.WriteLine($"{p.Name}: {GetProductStatus(p)}");
}

string GetProductStatus(Product p) => p switch
{
    { Stock: 0 } => "품절",
    { Stock: < 10 } when p.Price > 10000 => "재고 부족 (고가 상품)",
    { Stock: < 10 } => "재고 부족",
    { Price: > 50000 } => "프리미엄 상품",
    _ => "일반 상품"
};


Character[] characters = new Character[]
{
    new Character{Health = 0, Mana = 50, IsInCombat = false},
    new Character{Health = 15, Mana = 30, IsInCombat = false},
    new Character{Health = 50, Mana = 0, IsInCombat = false},
    new Character{Health = 90, Mana = 85, IsInCombat = false},
    new Character{Health = 60, Mana = 40, IsInCombat = false},
};


for(int i  = 0; i < characters.Length; i++)
{
    Console.WriteLine($"캐릭터{i + 1} (HP:{characters[i].Health}, MP:{characters[i].Mana}): {GetCharacterStatus(characters[i])}");
}

string GetCharacterStatus(Character c) => c switch
{
    { Health: 0 } => "사망",
    { Health: < 20 } => "위험! 즉시 회복 필요",
    { Mana: 0 } => "마나 고갈 - 물리 공격만 가능",
    { Health : > 80, Mana: > 80 } => "최상의 상태",
    { IsInCombat: true} => "전투 중",
    _ => "일반"
};


class Character
{
    public int Health { get; set; }
    public int Mana { get; set; }
    public bool IsInCombat {  get; set; }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Student : Person
{
    public string School {  get; set; }
}

class Employee : Person
{
    public string Company { get; set; }
}



class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int Stock { get; set; }

}
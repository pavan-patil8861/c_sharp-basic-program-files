class employee
{
    private string name;
    private int id;
    private decimal salary;
    private int age;
    private int mobile;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public int Mobile
    {
        get { return  mobile; }
        set { mobile = value; }
    }

    public void Display()
    {
        Console.WriteLine(name);
        Console.WriteLine(id);
        Console.WriteLine(salary);
        Console.WriteLine(age);
        Console.WriteLine(mobile);
    }

}
class Program1 
{
    static void Main(string[] args)
    {
        employee emp = new employee();
        emp.Name = "Pavan";
        emp.Id = 101;
        emp.Salary = 90000;
        emp.Age = 24;
        emp.Mobile = 0998854615;
        emp.Display();
    }
}

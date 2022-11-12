using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

internal class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    private string _designation { get; set; }
    private int  _salary;


    public int Salary
    {
        get 
        {
            return _salary; 
        }
        set 
        {
            _salary= value;
        }
    }

    public string Designation
    {
        get 
        {
            return _designation; 
        }
        set
        {
            if( value == "Trainee")
            {
                Salary = 5000;
            }
            else if (value == "Manager")
            {
                Salary = 100000;
            }
            else if (value == "Senior Employee")
            {
                Salary = 75000;
            }
            _designation = value;
        }
   
   
    }
    public void ShowData()
    {
        Console.WriteLine($"\nName : {Name} ");
        Console.WriteLine($"Department : {Department}");
        Console.WriteLine($"Designation : {Designation}");
        Console.WriteLine($"Salary: {Salary}\n");
        

    }


}

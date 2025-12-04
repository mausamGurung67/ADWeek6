using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4;

public class Student(string name, DateOnly dob, string gender)
{
    public string Name { get; set; } = name;
    public DateOnly Dob { get; set; } = dob;
    public string Gender { get; set; } = gender;
}

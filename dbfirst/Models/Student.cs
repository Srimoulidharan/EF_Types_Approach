using System;
using System.Collections.Generic;

namespace dbfirst.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Yearofbirth { get; set; }
}

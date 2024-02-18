using System;
using System.Collections.Generic;

namespace caso2.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Usario { get; set; }

    public string? Password { get; set; }

    public string? Correo { get; set; }
}

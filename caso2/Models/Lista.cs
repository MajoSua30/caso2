using System;
using System.Collections.Generic;

namespace caso2.Models;

public partial class Lista
{
    public string Nombrelista { get; set; } = null!;

    public string? Nombreactvidad { get; set; }

    public DateTime? Fechahacer { get; set; }

    public string? Estado { get; set; }
}

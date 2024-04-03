using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm.Classes;

internal class Film
{
    public string Id { get;private set; } = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public double imdPoint { get; set; }
}

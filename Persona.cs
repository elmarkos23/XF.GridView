using System;
using System.Collections.Generic;
using System.Text;

namespace XF.GridView
{
  public class Persona
  {
    public string Apellidos { get; set; }
    public string Nombres { get; set; }
    public string Identificacion { get; set; }
    public static List<Persona> get()
    {
      List<Persona> lista = new List<Persona>();
      lista.Add(new Persona { Apellidos = "AYALA", Nombres = "MARCO", Identificacion = "1721481586" });
      lista.Add(new Persona { Apellidos = "PALOTES", Nombres = "JENDRI", Identificacion = "1706067426" });
      return lista;
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_04_Indumentaria_Web.Models
{
   public static class Equipos
   {
    public static List<string> listaEquipos = new List<string>() {"Boca", "Racing", "River", "Chacarita", "Villa Mitre", "Almagro", "Atlanta", "Ferro", "Independiente", "Chicago"};

    public static List<string> listaMedias = new List<string>() {"medias-boca.jpg", "medias-racing.jpg", "medias-river.jpg", "medias-chacarita.jpg", "medias-villa-mitre.jpg", "medias-almagro.jpg", "medias-atlanta.jpg", "medias-ferro.jpg", "medias-independiente.jpg", "medias-chicago.jpg"};

    public static List<string> listaPantalones = new List<string>() {"pantalon-boca.jpg", "pantalon-racing.jpg", "pantalon-river.jpg", "pantalon-chacarita.jpg", "pantalon-villa-mitre.jpg", "pantalon-almagro.jpg", "pantalon-atlanta.jpg", "pantalon-ferro.jpg", "pantalon-independiente.jpg", "pantalon-chicago.jpg"};

    public static List<string> listaRemeras = new List<string>() {"camiseta-boca.jpg", "camiseta-racing.jpg", "camiseta-river.jpg", "camiseta-chacarita.jpg", "camiseta-villa-mitre.jpg", "camiseta-almagro.jpg", "camiseta-atlanta.jpg", "camiseta-ferro.jpg", "camiseta-independiente.jpg", "camiseta-chicago.jpg"};

    public static Dictionary<string, Indumentaria> equiposIndumentaria = new Dictionary<string, Indumentaria>();

    public static bool ingresarIndumentaria(string equipoSeleccionado, Indumentaria item)
    {
        bool existe = false;
        foreach (var clave in equiposIndumentaria)
        {
            if(clave.Key == equipoSeleccionado){
                existe = true;
            }
        }
        if(existe == false){
            equiposIndumentaria.Add(equipoSeleccionado, item);
        }
        return existe;
    }
   }
}
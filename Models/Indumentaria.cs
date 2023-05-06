using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_04_Indumentaria_Web.Models
{
   public class Indumentaria
   {
      public string Medias {get; private set;}

      public string Pantalon {get; private set;}

      public string Camiseta {get; private set;}

      public Indumentaria(string media, string pantalon, string remera){
         Camiseta = remera;
         Pantalon = pantalon;
         Medias = media;
      }
   }
}

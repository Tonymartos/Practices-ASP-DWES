using System;

public class NifCS
{
         public static bool Okey(string nif)
         {
           bool ok=false;
           string todas="TRWAGMYFPDXBNJZSQVHLCKE";
           nif=nif.ToUpper();

           string n=nif.Substring(0,8);
           char l=nif[8];
           try
           {
              int cantidad = int.Parse(n);
              int resto=cantidad%23;
              if (todas[resto]==l)
                 {ok=true;}
           }
           catch
           {}
           return ok;
         }
}

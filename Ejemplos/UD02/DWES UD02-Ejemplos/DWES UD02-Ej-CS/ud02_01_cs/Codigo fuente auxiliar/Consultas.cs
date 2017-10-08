using System;
using System.Data;
using System.Data.OleDb;

class Consultas : System.Web.UI.Page
{ 
    public static DataTable Vehiculos(string n,string ruta)
    {
        string conexion = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + ruta;
        string sentencia = "select matricula from polizas where nif=@nif";
        OleDbConnection miCnx = new OleDbConnection(conexion);
        OleDbCommand miCmd = new OleDbCommand(sentencia, miCnx);
        miCmd.Parameters.Add("@nif", OleDbType.Char, 9).Value = n;
        DataSet miDSet = new DataSet();
        OleDbDataAdapter Adt = new OleDbDataAdapter(miCmd);
        Adt.Fill(miDSet);
        return miDSet.Tables[0];
    }
}

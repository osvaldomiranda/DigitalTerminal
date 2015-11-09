using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace Modelo
{
   public class CafModel
    {
       public Int32 id {get; set;}
       public String cafxml { get; set; }
       public DateTime fecha { get; set; }
       public string tipote { get; set; }
       public string dirCaf { get; set; }
       public Int32 folioInicial { get; set; }
       public Int32 folioFinal { get; set; }
       public string rutEmpresa { get; set; }




       public int getCafActual(int tipoDte)
       {
           string idUltimoCaf = string.Empty;
           BaseDato con = new BaseDato();
           OdbcConnection conexion = con.ConnectPostgres();

           OdbcCommand select = new OdbcCommand();
           select.Connection = conexion;
           select.CommandText = "SELECT max(id) FROM caf where \"tipoDte\" =  '" + tipoDte+ "';";
           OdbcDataReader reader = select.ExecuteReader();
           while(reader.Read())
           {
               idUltimoCaf = reader.GetString(reader.GetOrdinal("max"));
           }
           return Convert.ToInt32(idUltimoCaf);
       }


       // recupera caf desde xml

       public CafModel xmlToCaf(string dirfile)
       { 

            CafModel cafModel = new CafModel();
            XmlDocument xDoc = new XmlDocument();
            //La ruta del documento XML permite rutas relativas 
            //respecto del ejecutable!

            xDoc.Load(@""+dirfile+"");

            XmlNodeList lista = xDoc.GetElementsByTagName("AUTORIZACION");

            XmlNodeList lista1 = ((XmlElement)lista[0]).GetElementsByTagName("CAF");

            XmlNodeList lista2 = ((XmlElement)lista1[0]).GetElementsByTagName("DA");

            XmlNodeList lista3 = ((XmlElement)lista2[0]).GetElementsByTagName("RNG");

            foreach (XmlElement nodo in lista)
            {

                int i = 0;

                XmlNodeList rutCaf =
                nodo.GetElementsByTagName("RE");

                XmlNodeList rzSoc =
                nodo.GetElementsByTagName("RS");

                XmlNodeList tpoDte =
                nodo.GetElementsByTagName("TD");

                XmlNodeList folioIni =
                nodo.GetElementsByTagName("D");

                XmlNodeList folioFinal =
                nodo.GetElementsByTagName("H");

                XmlNodeList fechaCaf =
                 nodo.GetElementsByTagName("FA");

                int final = Convert.ToInt32(folioFinal[i].InnerText);
                int inicial = Convert.ToInt32(folioIni[i].InnerText);
                int tipoDte = Convert.ToInt32(tpoDte[i].InnerText);
                DateTime fechacaf = Convert.ToDateTime(fechaCaf[i].InnerText); 
                string rut = rutCaf[i].InnerText;

                //Cargo el objeto
                cafModel.tipote = tipoDte.ToString() ;
                cafModel.fecha = fechacaf;
                cafModel.folioInicial = inicial;
                cafModel.folioFinal = final;
                cafModel.rutEmpresa = rut;
            }


            return cafModel;
       }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Data.Odbc;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Data;
using System.Data.SqlClient;

namespace Modelo
{
  [DataContract]
 public class DocumentoModel
    {
        public String fileName { get; set; } 
        [DataMember]
        public int TipoDTE { get; set; } //
        [DataMember] 
        public int Folio{get;set;}
        [DataMember]
        public String FchEmis { get; set; }
        [DataMember] 
        public int IndNoRebaja { get; set; }
        [DataMember]
        public int TipoDespacho { get; set; }
        [DataMember] 
        public int IndTraslado { get; set; }
        [DataMember] 
        public String TpoImpresion { get; set; }
        [DataMember]
        public int IndServicio { get; set; }
        [DataMember]
        public int MntBruto { get; set; }
        [DataMember]
        public int FmaPago { get; set; }
        [DataMember]
        public List<MntPagos> mntpagos = new List<MntPagos>();
        [DataMember]
        public string FchVenc { get; set; }


//#################################### Area Emisor ####################################################################
        [DataMember] 
        public string RUTEmisor { get; set; }
        [DataMember] 
        public string RznSoc { get; set; }
        [DataMember] 
        public string GiroEmis { get; set; }
        [DataMember] 
        public string Telefono { get; set; }
        [DataMember] 
        public string CorreoEmisor { get; set; }
        [DataMember] 
        public int Acteco { get; set; } // Actividad Economica
        [DataMember] 
        public int CdgTraslado { get; set; } //solo para guia de despacho
        [DataMember] 
        public int FolioAut { get; set; } //Solo para guia de despacho.
        [DataMember] 
        public string FchAut { get; set; } //
        [DataMember] 
        public string Sucursal { get; set; } //Nombre de la sucursal que emite el documento
        [DataMember] 
        public int CdgSIISucur { get; set; } // Codigo de sucursal que emite el documento
        [DataMember] 
        public string CodAdicSucur { get; set; } //Codigo para uso libre
        [DataMember] 
        public string DirOrigen { get; set; } // Direccion desde donde se despachan
        [DataMember] 
        public string CmnaOrigen { get; set; } // Analogo a direccion de origen
        [DataMember] 
        public string CiudadOrigen { get; set; } // Analogo a direccion de origen
        [DataMember] 
        public int CdgVendedor { get; set; } // Identificador del vendedor
        [DataMember]
        public string NomVendedor { get; set; } // Nombre del vendedor
        [DataMember] 
        public string IdAdicEmisor { get; set; } // adicional para uso libre
        [DataMember]
        public string RUTMandante { get; set; }
        //este atributo es para cargar en pdf la zona de oficina SII por empresa
        // debe ser llenado al momento de cargar la clase, ya que no es un atributo serializable
        public string DirRegionalSII { get; set; } //Direccion de las oficinas SII correspondiente
        
        //este atributo carga el nombre del certificado digital
        public string NombreCertificado { get; set; }

        //este atributo carga las sucursales del emisor
        public string SucurEmisor { get; set; }

        // este atributo carga la fecha de resolución
        public string FchResol { get; set; }

        // este atributo carga el rut del certificado
        public string RutEnvia { get; set; }

        //Numero de resolucion
        public string NumResol { get; set; }

        // Estado de la condiciónd e entrega en pdf
        public String CondEntrega { get; set; }

        // bodega Origen
        [DataMember]
        public string BodEmis { get; set; }
        // Dirección de casa Matriz
        [DataMember]
        public string DirMatriz { get; set; }

        public string PrnMtoNeto { get; set; }

        public string PrnTwoCopy { get; set; }

        //este atributo es una ista la cual carga las sucursales de la empresa certificada
        // debe ser llenado al momento de cargar la clase, ya que no es un atributo serializable
        public List<Sucursal> sucursalesempresa = new List<Sucursal>(8);



 
//################################### Area Receptor ############################################################################
        
        [DataMember]
        public string RUTRecep { get; set; } // rut del cliente en la factura de compra se referencia al vendedor
        [DataMember] 
        public string CdgIntRecep { get; set;  } // para identificacion interna de receptor
        [DataMember]
        public string RznSocRecep { get; set; } // Razon Social Receptor
        [DataMember] 
        public string NumId { get; set; } // Numero o codigo de identificacion personal del receptor extrangero otorgado por la adm. tributaria
        [DataMember] 
        public string Nacionalidad { get; set; } // Nacionalidad del extrangero
        [DataMember] 
        public string IdAdicRecep { get; set; } // solo para exportacion uso libre
        [DataMember]
        public string GiroRecep { get; set;  } // glosa giro del receptor
        [DataMember] 
        public string Contacto { get; set;  } // Glosa con nombre o telefono del contacto de la empresa receptor "Atencion a:"
        [DataMember] 
        public string CorreoRecep { get; set; } // e-mail de contacto en empresa del receptor (para registrar el “Atención A:”)
        [DataMember]
        public string DirRecep { get; set;  } // Dirección Legal del Receptor (registrada en el SII) En caso de documentos de exportación, corresponde a la dirección en el extranjero del Receptor
        [DataMember]
        public string CmnaRecep { get; set; } // Análogo a Dirección Receptor
        [DataMember]
        public string CiudadRecep { get; set; } //Análogo a Dirección Receptor
        [DataMember] 
        public string DirPostal { get; set; } // Análogo a Dirección Recepto
        [DataMember] 
        public string CmnaPostal { get; set; } // Análogo a Dirección Receptor
        [DataMember] 
        public string CiudadPostal { get; set; } // Análogo a Dirección Receptor
        [DataMember]
        public string BodRecep { get; set; } // Bodega de destino
        // En casos de venta a público. Es obligatorio si es distinto de Rut receptor o Rut Receptor es persona jurídica. Con guión y dígito verificador
        [DataMember]
        public string RUTSolicita { get; set; } 
        //Telefono del Receptor
        [DataMember]
        public string TelRecep { get; set; } 

//################################# Area Transporte #############################################################################       
        [DataMember] 
        public string Patente { get; set; } // 
        [DataMember]
        public string RUTTrans { get; set; } // Con guión y dígito verificador Indicador Tipo de Despacho es 2 o 3
        [DataMember] 
        public string RUTChofer { get; set; } // 
        [DataMember]
        public string NombreChofer { get; set; } // 
        [DataMember]    
        public string DirDest { get; set; } // Datos correspondientes a Dirección destino en documento que acompaña productos o a la Dirección en que se otorga el servicio en caso de Servicios periódicos.
        [DataMember]
        public string CmnaDest { get; set; } // Análogo Dirección Destino
        [DataMember] 
        public string CiudadDest { get; set; } // Análogo Dirección Destino
        [DataMember] 
        public int CodModVenta { get; set; } // Para doctos. utilizados en exportación. Se refiere a si la exportación se realiza bajo venta, En consignación, a firme, en Consignación con mínimo afirme, etc.)
        [DataMember] 
        public int CodClauVenta { get; set; } // Se refiere a la cláusula de venta indicada en el DUS ( FOB, CIF, etc.)
        [DataMember] 
        public int TotClauVenta { get; set; } // Corresponde al valor total de la exportación a pagar por el importador según la cláusula de venta acordada entre las partes y que se indica en el DUS. (No incluye comisiones ni otros gastos deducibles en el exterior)
        [DataMember] 
        public int CodViaTransp { get; set; } // Corresponde a la vía de transporte por donde se envía la mercadería (aéreo, terrestre, marítimo, etc) al Extranjero
        [DataMember] 
        public string NombreTransp { get; set; } // Corresponde al nombre o glosa de la nave transportista.
        [DataMember] 
        public string RUTCiaTransp { get; set; } // Para doctos. utilizados en exportación. Señale el Rol Unico Tributario (RUT) de la compañía transportista indicada en el DUS. Si ésta es extranjera, señale el RUT de la Agencia que la representa en Chile.
        [DataMember] 
        public string NomCiaTransp { get; set; } // Nombre de la Cía. transportadora declarada en el DUS.
        [DataMember] 
        public string IdAdicTransp { get; set; } // Identificación adicional para uso libre
        [DataMember] 
        public string Booking { get; set; } // Número de Booking o Reserva del operador
        [DataMember] 
        public string Operador { get; set; } // Código de Operador
        [DataMember] 
        public int CodPtoEmbarque { get; set; } // Puerto de embarque de mercancías
        [DataMember] 
        public string IdAdicPtoEmb { get; set; } // Identificación adicional para uso libre
        [DataMember] 
        public string CodPtoDesemb { get; set; } // 
        [DataMember] 
        public string IdAdicPtoDesemb { get; set; } // Identificación adicional para uso libre
        [DataMember] 
        public int Tara { get; set; }//
        [DataMember] 
        public int CodUnidMedTara { get; set; } // Indique la unidad de medida en la que se encuentra expresado la Tara
        [DataMember] 
        public int PesoBruto { get; set; } // Señale con dos decimales, la sumatoria de los pesos brutos de todos los ítems del documento. 
        [DataMember] 
        public int CodUnidPesoBruto { get; set; } // Indique la unidad de medida en la que se encuentra el peso bruto de la mercadería
        [DataMember] 
        public int PesoNeto { get; set; } // Señale con dos decimales, la sumatoria del peso neto de todos los ítems del documento.
        [DataMember] 
        public int CodUnidPesoNeto { get; set; } // Indique la unidad de medida en la que se encuentra el peso neto de la mercadería
        [DataMember] 
        public int TotItems { get; set; } // Indique el total de ítems del documento
        [DataMember] 
        public int TotBultos { get; set; } // Señale la cantidad total de bultos que ampara el documento.

// ############################# Area Totales ####################################################################################
        [DataMember] 
        public string TpoMoneda { get; set;  } // Moneda en que se registra la transacción de exportación.
        [DataMember]
        public int MntNeto { get; set; } // Suma de valores total de ítems afectos -descuentos globales + recargos globales (Asignados a ítems afectos). Si está encendido el Indicador de Montos Brutos (=1) entonces el resultado anterior se debe dividir por (1 + tasa de IVA)
        [DataMember]
        public int MntExe { get; set; } // Suma de valores total de ítems no afectos o exentos -descuentos globales + recargos globales (Asignados a ítems exentos o no afectos)
        [DataMember]
        public int MntBase { get; set; } // Monto informado
        [DataMember]
        public int MntMargenCom { get; set; } // Monto informado
        [DataMember]
        public decimal TasaIVA { get; set; } // 
        [DataMember]
        public int IVA { get; set; } // 
        [DataMember]           
        public int IVAProp { get; set; } //Las empresas que venden por cuenta de un mandatario, pueden opcional separar el IVA en propio y de terceros. En todos estos casos el campo “IVA” debe contener el IVA total de la Factura
        [DataMember] 
        public int IVATerc { get; set; } // Ídem al anterior
        // impuestos adicionales puede ser mas de uno por ese motivo se crea una clase
        [DataMember]
        public List<ImptoReten> imptoReten = new List<ImptoReten>();
        [DataMember] 
        public int IVANoRet { get; set; } // Sólo en facturas de Compra en que hay retención de IVA por el emisor y Notas de Crédito o débito que referencian facturas de compra. No se registra si es igual a 0.
        [DataMember] 
        public int CredEC { get; set; } // Artículo 21 del decreto ley N° 910/75. Este Es el único código que opera en forma opuesta al resto, ya que se resta al IVA general
        [DataMember] 
        public int GrntDep { get; set; } // Sólo para empresas que usen envases en forma habitual, por su giro principal. Art.28,Inc3 Reglamento DL 825) (Cervezas, Jugos, Aguas Minerales, Bebidas Analcohólicas u otros autorizados por Resolución especial). Corresponde a la Sumatoria de las líneas de detalle que indican Indicador de facturación/ exención = 3        
        [DataMember] 
        public int ValComNeto { get; set; }  // Suma de detalle de Valores de Comisiones y Otros Cargos
        [DataMember] 
        public int ValComExe { get; set; } // Suma de detalles de valores de comisiones y otros cargos no afectos o exentos
        [DataMember] 
        public int ValComIVA { get; set; } // Suma de detalle de IVA de Valor de Comisiones y Otros Cargos
        [DataMember]
        public int MntTotal { get; set; } // Monto neto + Monto no afecto o  exento + IVA + Impuestos Adicionales + Impuestos Específicos + Iva Margen Comercialización +IVA Anticipado + Garantía por depósito de envases o embalajes - Crédito empresas constructoras- IVA Retenido productos (en caso de facturas de compra) -  Valor Neto Comisiones y Otros Cargos- IVA Comisiones y Otros Cargos - Valor Comisiones y Otros Cargos No Afectos o Exentos. (Los Impuestos Adicionales y el IVA Anticipado están detallados en la TABLA de Impuestos Adicionales y Retenciones)
        [DataMember] 
        public int MontoNF { get; set; } //Suma de montos de bienes o servicios con Indicador de facturación/ exención = 2 menos Suma de montos de bienes o servicios con Indicador de facturación/ exención = 6

 //############################## Area Detalle #################################################################################
        [DataMember]
        public List<Detalle> detalle = new List<Detalle>();

        [DataMember]
        public List<DscRcgGlobal> dscRcgGlobal = new List<DscRcgGlobal>();

        [DataMember]
        public List<ReferenciaDoc>  Referencia = new List<ReferenciaDoc>();

        [DataMember]
        public List<Comisiones> comisiones = new List<Comisiones>();


        public void save(DocumentoModel documento)
        {
            MemoryStream stream = new MemoryStream();
            DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(DocumentoModel));
            ds.WriteObject(stream, documento);
            string jsonString = Encoding.UTF8.GetString(stream.ToArray());
            stream.Close();
            String json = jsonString.Replace("null", "\"\"");
            json =  jsonString.Replace("{", "{\"fchcreate\":\"" + DateTime.Now.ToString() + "\",");
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();
                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "INSERT INTO documento SELECT * FROM json_populate_record(NULL::documento,'"+ json+"')";                
                OdbcDataReader reader = select.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }

        }

        public void serialize(DocumentoModel documento)
        {
            if (documento.TipoDTE != 802)
            {

                MemoryStream stream = new MemoryStream();
                DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(DocumentoModel));
                ds.WriteObject(stream, documento);
                string jsonString = Encoding.UTF8.GetString(stream.ToArray());
                stream.Close();

                String json = jsonString.Replace("null", "\"\"");

                String fileNameJson = @"C:/IatFiles/file/" + documento.TipoDTE + "_" + documento.RUTEmisor + "_" + documento.Folio + ".json";

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileNameJson, false, Encoding.GetEncoding("ISO-8859-1")))
                {
                    file.WriteLine(json);
                }
            }
        }

        public DocumentoModel getDocumento(int tipo, int folio)
        {
            DocumentoModel documentoModel = new DocumentoModel();
            String documento = String.Empty;
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();
                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "select row_to_json(documento) from documento where \"Folio\" = " + folio + " and \"TipoDTE\" = '" + tipo + "';";
                OdbcDataReader reader = select.ExecuteReader();
                while (reader.Read())
                {
                    documento = reader.GetString(reader.GetOrdinal("row_to_json"));
                }

                DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DocumentoModel));
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(documento));
                documentoModel = (DocumentoModel)js.ReadObject(ms);
                documentoModel.detalle = new Detalle().getDetalle(tipo, folio);
                documentoModel.Referencia = new ReferenciaDoc().getReferencia(tipo, folio);
                return documentoModel;

            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }


            
        }

        public DataTable getAllDocDT()

        {
            DataTable datatable = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "SELECT \"nombre\",\"TipoDTE\",\"Folio\",\"FchEmis\",\"RznSocRecep\",\"MntTotal\""
                                    +" FROM documento,tipodte "
                                    + " where  documento.\"TipoDTE\" = tipodte.tipo order by fchcreate DESC LIMIT 50";
                OdbcDataReader reader = select.ExecuteReader();
                datatable.Load(reader);

            }
            catch (Exception ex)
            {
                datatable = null;
                throw new Exception("Error" + ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            return datatable;

        }
    }



//############################## Area Clases #################################################################################

    [DataContract]
  public class Detalle
    {
        [DataMember]
        public int NroLinDet { get; set; } //Número del ítem. Desde 1 a 60
        [DataMember]
        public string TpoCodigo { get; set; } //Tipo de codificación utilizada para el ítem Standard: EAN, PLU, DUN o Interna (Hasta 5 tipos de códigos).... este puede ser una clase...
        [DataMember]       
        public string VlrCodigo { get; set; } // Código del producto de acuerdo a tipo de codificación indicada en campo anterior (Hasta 5 códigos)
        [DataMember] 
        public string TpoDocLiq { get; set; } // Para liquidaciones se debe registrar el código del docto. que se liquida. (Ej: :30, 33, 35, 39, 56,etc.) 
        [DataMember]
        public string IndExe { get; set; } // Indica si el producto o servicio es exento o no afecto a impuesto o si ya ha sido facturado. 
                       //(También se utiliza para indicar garantía de depósito por envases. Art.28,Inc3 Reglamento DL 825) 
                       //(Cervezas, Jugos, Aguas Minerales, Bebidas Analcohólicas u otros autorizados por Resolución especial) 
                       //Si todos los ítems de una factura tienen valor 1 en este indicador la factura no puede ser factura electrónica (código 33),
                       //debería serfactura exenta (código 34) . Sólo en caso de Liquidación-Factura
                       // que tenga ítems no facturables negativos, se debe señalar el indicador 2, e informar el valor con signo negativo
        [DataMember] 
        public string IndAgente { get; set; } //Obligatorio para agentes retenedores, indica para cada transacción si es agente retenedor del producto que está vendiendo
        [DataMember] 
        public int MntBaseFaena { get; set; } //Sólo para transacciones realizadas por Agentes Retenedores, según códigos de retención 17
        [DataMember] 
        public int MntMargComer { get; set; } // Sólo para transacciones realizadas por Agentes Retenedores, según códigos de retención 14 y 50
        [DataMember] 
        public int PrcConsFinal { get; set; } // Sólo para transacciones realizadas por Agentes Retenedores, según códigos de retención 14, 17 y 50
        [DataMember]
        public string NmbItem { get; set; } //Nombre del producto o servicio
        [DataMember] 
        public string DscItem { get; set; } // Descripción Adicional del producto o servicio. Se utiliza para pack, servicios con detalle
        [DataMember] 
        public int QtyRef { get; set; } // Cantidad para la unidad de medida de referencia (no se usa para el cálculo del valor neto) en 12 enteros y 6 decimales.
                    // Obligatorio para facturas de venta o compra que indican emisor opera como Agente Retenedor
        [DataMember] 
        public string UnmdRef { get; set; } //Glosa con unidad de medida de referencia Obligatorio para facturas de venta, compra o notas que indican emisor opera como Agente Retenedor
        [DataMember] 
        public decimal PrcRef { get; set; } // Precio unitario para la unidad de medida de referencia (no se usa para el cálculo del valor neto) 12 enteros, 6 decimales. Obligatorio para facturas de venta, compra o notas que indican emisor opera como Agente Retenedor 
        [DataMember]
        public int QtyItem { get; set; } // Cantidad del ítem en 12 enteros y 6 decimales Obligatorio para facturas de venta, compra o notas que indican emisor opera como Agente Retenedor
        [DataMember] 
        public string FchElabor { get; set; } // del item
        [DataMember] 
        public string FchVencim { get; set; } // del item
        [DataMember]
        public string UnmdItem { get; set; } // unidad de medidas
        [DataMember]
        public decimal PrcItem { get; set; } // Precio neto
        [DataMember]
        public decimal PrcBruItem { get; set; } // Precio Bruto
        [DataMember] 
        public decimal DescuentoPct { get; set; } // Descuento (%) en 3 enteros y 2 decimales
        [DataMember] 
        public int DescuentoMonto { get; set; } //Correspondiente al anterior. Totaliza todos los descuentos otorgados al ítem
        [DataMember]
        public int DescuentoBruMonto { get; set; } //Correspondiente al anterior. Totaliza todos los descuentos otorgados al ítem Bruto
        [DataMember]
        public string CodImpAdic { get; set; } //Indica el código según tabla de códigos (Ver en Índice 4.- Codificación Tipos de Impuesto).
        [DataMember]
        public Int32 MontoItem { get; set; } //(Precio Unitario * Cantidad ) – Monto Descuento + Monto Recargo
        [DataMember]
        public int MontoBruItem { get; set; } 


        public void save(DocumentoModel documento)
        {
            foreach (Detalle det in documento.detalle)
            {
                MemoryStream stream = new MemoryStream();
                DataContractJsonSerializer detalle = new DataContractJsonSerializer(typeof(Detalle));
                detalle.WriteObject(stream, det);
                string jsonString = Encoding.UTF8.GetString(stream.ToArray());
                stream.Close();
                String json = jsonString.Replace("null", "\"\"");
                json = jsonString.Replace("{", "{\"FolioDoc\":" + documento.Folio + ", \"TipoDoc\":" + documento.TipoDTE + ",");

                try
                {
                    BaseDato con = new BaseDato();
                    OdbcConnection conexion = con.ConnectPostgres();
                    OdbcCommand select = new OdbcCommand();
                    select.Connection = conexion;
                    select.CommandText = "INSERT INTO detalle SELECT * FROM json_populate_record(NULL::detalle,'" + json + "')";
                    OdbcDataReader reader = select.ExecuteReader();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error" + ex.Message);
                } 
            }

        }

        public List<Detalle> getDetalle(int tipoDoc, int folioDoc)
        { 
            List<Detalle> detalles = new List<Detalle>();
            Detalle detalle = new Detalle();
            String detalleJson = String.Empty;
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();
                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "select row_to_json(detalle) from detalle where \"FolioDoc\" = " + folioDoc + " and \"TipoDoc\" = " + tipoDoc + ";";
                OdbcDataReader reader = select.ExecuteReader();
                while (reader.Read())
                {
                    detalleJson = reader.GetString(reader.GetOrdinal("row_to_json"));
                    DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Detalle));
                    MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(detalleJson));
                    detalle = (Detalle)js.ReadObject(ms);
                    detalles.Add(detalle);
                }
                return detalles;
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }

        }
      
    }

  public  class Sucursal
    {
        public Sucursal(String dato) { datosucursal = dato; }
        public String datosucursal { get; set; }
       
    }


//######################################## Sub Totales Informativos ###########################################################################
     [DataContract]
  public  class MntPagos
    {
        [DataMember]
        public string FchPago { get; set; } //
        [DataMember]
        public int MntPago { get; set; } //           
    }

     [DataContract]
  public   class ImptoReten
    {
        [DataMember]
        public string TipoImp { get; set; } //Código del impuesto o retención de acuerdo a la codificación detallada en tabla de códigos (ver Punto 4 del índice). Incluye Retención de Cambio sujeto de Construcción
        [DataMember]
        public decimal TasaImp { get; set; } //Se debe indicar la tasa de Impuesto adicional o retención. En el caso de impuesto específicos se puede omitir
        [DataMember]
        public int MontoImp { get; set; } // Valor del impuesto o retención asociado al código indicado anteriormente
    }

     [DataContract]
  public  class DscRcgGlobal
     {
         [DataMember]
         public int NroLinDR { get; set; }
         [DataMember]
         public string TpoMov { get; set; }
         [DataMember]
         public string GlosaDR { get; set; }
         [DataMember]
         public string TpoValor { get; set; }
         [DataMember]
         public decimal ValorDR { get; set; }
         [DataMember]
         public int IndExeDR { get; set; }

     }

     [DataContract]
    public class ReferenciaDoc
     {
         [DataMember]
         public int NroLinRef { get; set; }
         [DataMember]
         public string TpoDocRef { get; set; }
         [DataMember]
         public int IndGlobal { get; set; }
         [DataMember]
         public string FolioRef { get; set; }
         [DataMember]
         public string RUTOtr { get; set; }
         [DataMember]
         public string IdAdicOtr { get; set; }
         [DataMember]
         public string FchRef { get; set; }
         [DataMember]
         public int CodRef { get; set; }
         [DataMember]
         public string RazonRef { get; set; }

         public void save(DocumentoModel documento)
         {
             foreach (ReferenciaDoc det in documento.Referencia)
             {
                 MemoryStream stream = new MemoryStream();
                 DataContractJsonSerializer referencia = new DataContractJsonSerializer(typeof(ReferenciaDoc));
                 referencia.WriteObject(stream, det);
                 string jsonString = Encoding.UTF8.GetString(stream.ToArray());
                 stream.Close();
                 String json = jsonString.Replace("null", "\"\"");
                 String json0 = json.Replace("{", "{\"FolioDoc\":" + documento.Folio + ", \"TipoDoc\":" + documento.TipoDTE+ ",");
                 if (det.TpoDocRef == "SET") 
                     json0 = json0.Replace("\"TpoDocRef\":\"SET\"","\"TpoDocRef\\r\\n\":\"1000\"");
                 if (det.TpoDocRef == "1000")
                     json0 = json0.Replace("\"TpoDocRef\":\"1000\"", "\"TpoDocRef\\r\\n\":\"1000\"");
                 try
                 {
                     BaseDato con = new BaseDato();
                     OdbcConnection conexion = con.ConnectPostgres();
                     OdbcCommand select = new OdbcCommand();
                     select.Connection = conexion;
                     select.CommandText = "INSERT INTO referencia SELECT * FROM json_populate_record(NULL::referencia,'" + json0 + "')";
                     OdbcDataReader reader = select.ExecuteReader();
                 }
                 catch (Exception ex)
                 {
                     throw new Exception("Error" + ex.Message);
                 }
             }

         }

         public List<ReferenciaDoc> getReferencia(int tipoDoc, int folioDoc)
         {
             List<ReferenciaDoc> referencias = new List<ReferenciaDoc>();
             ReferenciaDoc referencia = new ReferenciaDoc();
             String referenciaJson = String.Empty;
             try
             {
                 BaseDato con = new BaseDato();
                 OdbcConnection conexion = con.ConnectPostgres();
                 OdbcCommand select = new OdbcCommand();
                 select.Connection = conexion;
                 select.CommandText = "select row_to_json(referencia) from referencia where \"FolioDoc\" = " + folioDoc + " and \"TipoDoc\" = " + tipoDoc + " order by \"NroLinRef\" ASC;";
                 OdbcDataReader reader = select.ExecuteReader();
                 while (reader.Read())
                 {
                     referenciaJson = reader.GetString(reader.GetOrdinal("row_to_json"));
                     String referenciaJson1 = referenciaJson.Replace("null", "\"\"");
                     String referenciaJson2 = referenciaJson1.Replace("\"TpoDocRef\\r\\n", "\"TpoDocRef");
                     DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(ReferenciaDoc));
                     MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(referenciaJson2));
                     referencia = (ReferenciaDoc)js.ReadObject(ms);
                     referencias.Add(referencia);
                 }
                 return referencias;
             }
             catch (Exception ex)
             {
                 throw new Exception("Error" + ex.Message);
             }

         }
     }

     [DataContract]
   public  class Comisiones
     {
         [DataMember]
         public int NroLinCom { get; set; }
         [DataMember]
         public string TipoMovim { get; set; }
         [DataMember]
         public string Glosa { get; set; }
         [DataMember]
         public int ValComNeto { get; set; }
         [DataMember]
         public int ValComExe { get; set; }
         [DataMember]
         public int ValComIVA { get; set; }

     }

    }



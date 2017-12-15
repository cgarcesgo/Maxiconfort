using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twelve.Maxiconfort.Model.Entities;

namespace Twelve.Maxiconfort.Core.Dao
{
    /// <summary>
    /// Dao Factura
    /// </summary>
    internal static class FacturaDao
    {
        /// <summary>
        /// Select All Factura
        /// </summary>
        /// <returns></returns>
        internal static IList<Factura> SelectAll()
        {
            using (MaxiconfortEntities en = new MaxiconfortEntities())
            {
                var query = from p in en.Facturas.Include("DetalleFacturas")
                            select p;
                return query.ToList();
            }
        }

        /// <summary>
        /// Select factura by id
        /// </summary>
        /// <param name="facturaId"></param>
        /// <returns></returns>
        internal static Factura SelectById(string CodigoFactura)
        {
            using (MaxiconfortEntities en = new MaxiconfortEntities())
            {
                var query = from p in en.Facturas.Include("DetalleFacturas")
                            where p.CodigoFactura == CodigoFactura
                            select p;
                return query.FirstOrDefault();
            }
        }

        /// <summary>
        /// Get Periodos
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        internal static IList<SPGetPeriodos_Result> GetPeriodos(int tipo)
        {
            using (MaxiconfortEntities en = new MaxiconfortEntities())
            {
                var parameter = new SqlParameter
                {
                    ParameterName = "Tipo",
                    Value = tipo
                };

                var query = en.Database.SqlQuery<SPGetPeriodos_Result>("exec SPGetPeriodos @Tipo ", parameter).ToList<SPGetPeriodos_Result>();

                return query;
            }
        }

        /// <summary>
        /// Get Facturas Consolidado
        /// </summary>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaFin"></param>
        /// <returns></returns>
        internal static IList<SPGetFacturasConsolidadoByFecha_Result> GetFacturasConsolidadoByFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            using (MaxiconfortEntities en = new MaxiconfortEntities())
            {
                var parameterFechaInicio = new SqlParameter
                {
                    ParameterName = "FechaInicio",
                    Value = fechaInicio
                };

                var parameterFechaFin = new SqlParameter
                {
                    ParameterName = "FechaFin",
                    Value = fechaFin
                };

                var query = en.Database.SqlQuery<SPGetFacturasConsolidadoByFecha_Result>(string.Format("exec SPGetPeriodos @FechaInicio {0}, @FechaFin {1}", parameterFechaInicio, parameterFechaFin)).ToList<SPGetFacturasConsolidadoByFecha_Result>();

                return query;
            }
        }

        /// <summary>
        /// Save factura
        /// </summary>
        /// <param name="objFactura"></param>
        internal static void Save(Factura objFactura)
        {
            using (MaxiconfortEntities en = new MaxiconfortEntities())
            {
                en.Facturas.Add(objFactura);
                en.SaveChanges();
            }

            //000012

            string prenum = string.Format("{0}{1}", "00000", objFactura.FacturaId);
            objFactura.CodigoFactura = prenum.Substring(prenum.Length - 5, 5);
            Update(objFactura);
        }

        /// <summary>
        /// Update factura
        /// </summary>
        /// <param name="objFactura"></param>
        internal static void Update(Factura objFactura)
        {
            using (MaxiconfortEntities en = new MaxiconfortEntities())
            {
                var _obj = en.Facturas.Where(p => p.FacturaId == objFactura.FacturaId).FirstOrDefault();
                _obj.CodigoFactura = objFactura.CodigoFactura;
                _obj.FacturaId = objFactura.FacturaId;
                _obj.Fecha = objFactura.Fecha;
                _obj.Usuario = objFactura.Usuario;
                en.SaveChanges();
            }
        }

        /// <summary>
        /// Delete factura
        /// </summary>
        /// <param name="objFactura"></param>
        internal static void Delete(Factura objFactura)
        {
            using (MaxiconfortEntities en = new MaxiconfortEntities())
            {
                var _obj = en.Facturas.Where(p => p.FacturaId == objFactura.FacturaId).FirstOrDefault();
                en.Facturas.Remove(_obj);
                en.SaveChanges();
            }
        }
    }
}

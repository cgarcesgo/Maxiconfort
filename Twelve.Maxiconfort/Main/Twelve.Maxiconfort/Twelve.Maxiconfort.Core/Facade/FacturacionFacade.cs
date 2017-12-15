using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twelve.Maxiconfort.Core.Dao;
using Twelve.Maxiconfort.Model.Entities;

namespace Twelve.Maxiconfort.Core.Facade
{
    /// <summary>
    /// Facade Legalizaciones
    /// </summary>
    [DataObject(true)]
    public class FacturacionFacade
    {
        #region Factura

        /// <summary>
        /// Select All Factura
        /// </summary>
        /// <returns></returns>
        public static IList<Factura> SelectAllFactura()
        {
            return FacturaDao.SelectAll();
        }

        /// <summary>
        /// Get Periodos
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static IList<SPGetPeriodos_Result> GetPeriodos(int tipo)
        {
            return FacturaDao.GetPeriodos(tipo);
        }

        /// <summary>
        /// Get Facturas Consolidado
        /// </summary>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaFin"></param>
        /// <returns></returns>
        internal static IList<SPGetFacturasConsolidadoByFecha_Result> GetFacturasConsolidadoByFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return FacturaDao.GetFacturasConsolidadoByFecha(fechaInicio, fechaFin);
        }

        /// <summary>
        /// Select factura by id
        /// </summary>
        /// <param name="facturaId"></param>
        /// <returns></returns>
        public static Factura SelectByIdFactura(string CodigoFactura)
        {
            return FacturaDao.SelectById(CodigoFactura);
        }

        /// <summary>
        /// Save factura
        /// </summary>
        /// <param name="objFactura"></param>
        public static void SaveFactura(Factura objFactura)
        {
            FacturaDao.Save(objFactura);
        }

        /// <summary>
        /// Update factura
        /// </summary>
        /// <param name="objFactura"></param>
        public static void UpdateFactura(Factura objFactura)
        {
            FacturaDao.Update(objFactura);
        }

        /// <summary>
        /// Delete factura
        /// </summary>
        /// <param name="objFactura"></param>
        public static void DeleteFactura(Factura objFactura)
        {
            FacturaDao.Delete(objFactura);
        }
        
        #endregion

        #region Role

        /// <summary>
        /// Select All Role
        /// </summary>
        /// <returns></returns>
        public static IList<Role> SelectAllRole()
        {
            return RoleDao.SelectAll();
        }

        /// <summary>
        /// Select Role by id
        /// </summary>
        /// <param name="RoleId"></param>
        /// <returns></returns>
        public static Role SelectByIdRole(int RoleId)
        {
            return RoleDao.SelectById(RoleId);
        }

        /// <summary>
        /// Save Role
        /// </summary>
        /// <param name="objRole"></param>
        public static void SaveRole(Role objRole)
        {
            RoleDao.Save(objRole);
        }

        /// <summary>
        /// Update Role
        /// </summary>
        /// <param name="objRole"></param>
        public static void UpdateRole(Role objRole)
        {
            RoleDao.Update(objRole);
        }

        /// <summary>
        /// Delete Role
        /// </summary>
        /// <param name="objRole"></param>
        public static void DeleteRole(Role objRole)
        {
            RoleDao.Delete(objRole);
        }

        #endregion

        #region Usuario
        /// <summary>
        /// Select Usuario by id
        /// </summary>
        /// <param name="user"></param>
        /// <param name="rolId"></param>
        /// <returns></returns>
        public static Usuario SelectByIdUsuario(string user, int rolId)
        {
            return UsuarioDao.SelectById(user, rolId);
        }
        #endregion
    }
}

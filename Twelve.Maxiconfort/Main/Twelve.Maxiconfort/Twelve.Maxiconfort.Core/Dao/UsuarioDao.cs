using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twelve.Maxiconfort.Model.Entities;

namespace Twelve.Maxiconfort.Core.Dao
{
    /// <summary>
    /// Dao Usuario
    /// </summary>
    internal static class UsuarioDao
    {
        /// <summary>
        /// Select Usuario by id
        /// </summary>
        /// <param name="user"></param>
        /// <param name="rolId"></param>
        /// <returns></returns>
        internal static Usuario SelectById(string user, int rolId)
        {
            using (MaxiconfortEntities en = new MaxiconfortEntities())
            {
                var query = from p in en.Usuarios
                            where p.Nombre == user && p.RolId == rolId
                            select p;
                return query.FirstOrDefault();
            }
        }
    }
}

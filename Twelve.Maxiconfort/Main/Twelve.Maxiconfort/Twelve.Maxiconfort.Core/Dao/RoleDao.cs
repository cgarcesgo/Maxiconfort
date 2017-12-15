using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twelve.Maxiconfort.Model.Entities;

namespace Twelve.Maxiconfort.Core.Dao
{
    /// <summary>
    /// Dao Role
    /// </summary>
    internal static class RoleDao
    {
        /// <summary>
        /// Select All Role
        /// </summary>
        /// <returns></returns>
        internal static IList<Role> SelectAll()
        {
            using (MaxiconfortEntities en = new MaxiconfortEntities())
            {
                var query = from p in en.Roles
                            select p;
                return query.ToList();
            }
            //return null;
        }

        /// <summary>
        /// Select Role by id
        /// </summary>
        /// <param name="RoleId"></param>
        /// <returns></returns>
        internal static Role SelectById(int RoleId)
        {
            using (MaxiconfortEntities en = new MaxiconfortEntities())
            {
                var query = from p in en.Roles
                            where p.RolId == RoleId
                            select p;
                return query.FirstOrDefault();
            }
        }

        /// <summary>
        /// Save Role
        /// </summary>
        /// <param name="objRole"></param>
        internal static void Save(Role objRole)
        {
            using (MaxiconfortEntities en = new MaxiconfortEntities())
            {
                en.Roles.Add(objRole);
                en.SaveChanges();
            }
        }

        /// <summary>
        /// Update Role
        /// </summary>
        /// <param name="objRole"></param>
        internal static void Update(Role objRole)
        {
            using (MaxiconfortEntities en = new MaxiconfortEntities())
            {
                var _obj = en.Roles.Where(p => p.RolId == objRole.RolId).FirstOrDefault();
                _obj.Nombre = objRole.Nombre;
                en.SaveChanges();
            }
        }

        /// <summary>
        /// Delete Role
        /// </summary>
        /// <param name="objRole"></param>
        internal static void Delete(Role objRole)
        {
            using (MaxiconfortEntities en = new MaxiconfortEntities())
            {
                var _obj = en.Roles.Where(p => p.RolId == objRole.RolId).FirstOrDefault();
                en.Roles.Remove(_obj);
                en.SaveChanges();
            }
        }
    }
}

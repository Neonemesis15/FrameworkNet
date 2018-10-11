using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Data
{
    /// <summary>
    /// Clase Utilitaria para Convertir los Tipos de Datos que devuelve el Servidor de Base de Datos
    /// Developed by:
    /// - Peter Ccopa Peralta (PPC)
    /// - Pablo Salas Alvarez (PSA)
    /// Changes:
    /// - 2018-10-09 (PSA) Add comments.
    /// </summary>
    public static class ParserDA
    {
        /// <summary>
        /// Convierte un Dato tipo DateTime en Object.
        /// </summary>
        /// <param name="DateTime"> Dato en DateTime</param>
        /// <returns>object</returns>
        public static object DBValue(this DateTime? value)
        {
            if (value == null)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }
        /// <summary>
        /// Convierte un Dato tipo String en Object.
        /// </summary>
        /// <param name="String"> Dato en String</param>
        /// <returns>object</returns>
        public static object DBValue(this string value)
        {
            if (value == null)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// Convierte un Dato tipo Guid en Object.
        /// </summary>
        /// <param name="Guid"> Dato en Guid</param>
        /// <returns>object</returns>
        public static object DBValue(this Guid? value)
        {
            if (value == null)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// Convierte un Dato tipo Double en Object.
        /// </summary>
        /// <param name="Double"> Dato en Double</param>
        /// <returns>object</returns>
        public static object DBValue(this double? value)
        {
            if (value == null)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// Convierte un Dato tipo Int en Object.
        /// </summary>
        /// <param name="Int"> Dato en Int</param>
        /// <returns>object</returns>
        public static object DBValue(this int? value)
        {
            if (value == null)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// Convierte un Dato tipo Object en DateTime .
        /// </summary>
        /// <param name="object"> Object </param>
        /// <returns>DateTime</returns>
        public static DateTime? DateTimeDB(object value)
        {
            if (value == DBNull.Value)
            {
                return null;
            }
            else
            {
                return Convert.ToDateTime(value);
            }
        }

        /// <summary>
        /// Convierte un Dato tipo Object en String.
        /// </summary>
        /// <param name="object"> Object </param>
        /// <returns>String</returns>
        public static string StringDB(object value)
        {
            if (value == DBNull.Value)
            {
                return null;
            }
            else
            {
                return value.ToString();
            }
        }

        //public static Guid? GuidBD(object value)
        //{
        //    if (value == DBNull.Value)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return Guid.Parse(value.ToString());
        //    }
        //}

        /// <summary>
        /// Convierte un Dato tipo Object en Double.
        /// </summary>
        /// <param name="object"> Object </param>
        /// <returns>Double</returns>
        public static double? DoubleBD(object value)
        {
            if (value == DBNull.Value)
            {
                return null;
            }
            else
            {
                return Convert.ToDouble(value);
            }
        }

        /// <summary>
        /// Convierte un Dato tipo Object en Int.
        /// </summary>
        /// <param name="object"> Object </param>
        /// <returns>Int</returns>
        public static int? IntegerBD(object value)
        {
            if (value == DBNull.Value)
            {
                return null;
            }
            else
            {
                return Convert.ToInt32(value);
            }
        }
    }
}

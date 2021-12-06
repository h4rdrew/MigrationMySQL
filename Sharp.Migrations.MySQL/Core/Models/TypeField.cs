﻿namespace Sharp.MySQL.Migrations.Core.Models
{
    /// <summary>
    /// Enums of field types in MySQL
    /// </summary>
    public enum TypeField
    {
        /// <summary>
        /// Field type not set
        /// </summary>
        NOT_SET = 0,
        /// <summary>
        /// CHAR type
        /// </summary>
        CHAR,
        /// <summary>
        /// CHAR type with unicode support.
        /// </summary>
        NCHAR,
        /// <summary>
        /// VARCHAR type variable size
        /// </summary>
        VARCHAR,
        /// <summary>
        /// VARCHAR type with unicode support and variable size
        /// </summary>
        NVARCHAR,
        /// <summary>
        /// INT type
        /// </summary>
        INT,
        /// <summary>
        /// BINARY type
        /// </summary>
        BINARY,
        /// <summary>
        /// BINARY type with variable size
        /// </summary>
        VARBINARY,
        /// <summary>
        /// ONLY DATE type
        /// </summary>
        DATE,
        /// <summary>
        /// DATETIME type
        /// </summary>
        DATETIME,
        /// <summary>
        /// A number between '1970-01-01 00:00:01' UTC and '2038-01-19 03:14:07' UTC
        /// </summary>
        TIMESTAMP,
        /// <summary>
        /// Decimal values
        /// </summary>
        DECIMAL,
    }
}

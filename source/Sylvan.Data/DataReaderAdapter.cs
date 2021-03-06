﻿using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;

namespace Sylvan.Data
{
	public abstract class DataReaderAdapter : DbDataReader, IDbColumnSchemaGenerator
	{
		protected DbDataReader dr;

		public DataReaderAdapter(DbDataReader dr)
		{
			this.dr = dr;
		}

		public override object this[int ordinal] => dr[ordinal];

		public override object this[string name] => dr[name];

		public override int Depth => dr.Depth;

		public override int FieldCount => dr.FieldCount;

		public override bool HasRows => dr.HasRows;

		public override bool IsClosed => dr.IsClosed;

		public override int RecordsAffected => dr.RecordsAffected;

		public override bool GetBoolean(int ordinal)
		{
			return dr.GetBoolean(ordinal);
		}

		public override byte GetByte(int ordinal)
		{
			return dr.GetByte(ordinal);
		}

		public override long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length)
		{
			return dr.GetBytes(ordinal, dataOffset, buffer, bufferOffset, length);
		}

		public override char GetChar(int ordinal)
		{
			return dr.GetChar(ordinal);
		}

		public override long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length)
		{
			return dr.GetChars(ordinal, dataOffset, buffer, bufferOffset, length);
		}

		public override string GetDataTypeName(int ordinal)
		{
			return dr.GetDataTypeName(ordinal);
		}

		public override DateTime GetDateTime(int ordinal)
		{
			return dr.GetDateTime(ordinal);
		}

		public override decimal GetDecimal(int ordinal)
		{
			return dr.GetDecimal(ordinal);
		}

		public override double GetDouble(int ordinal)
		{
			return dr.GetDouble(ordinal);
		}

		public override IEnumerator GetEnumerator()
		{
			return ((IEnumerable)dr).GetEnumerator();
		}

		public override Type GetFieldType(int ordinal)
		{
			return dr.GetFieldType(ordinal);
		}

		public override float GetFloat(int ordinal)
		{
			return dr.GetFloat(ordinal);
		}

		public override Guid GetGuid(int ordinal)
		{
			return dr.GetGuid(ordinal);
		}

		public override short GetInt16(int ordinal)
		{
			return dr.GetInt16(ordinal);
		}

		public override int GetInt32(int ordinal)
		{
			return dr.GetInt32(ordinal);
		}

		public override long GetInt64(int ordinal)
		{
			return dr.GetInt64(ordinal);
		}

		public override string GetName(int ordinal)
		{
			return dr.GetName(ordinal);
		}

		public override int GetOrdinal(string name)
		{
			return dr.GetOrdinal(name);
		}

		public override string GetString(int ordinal)
		{
			return dr.GetString(ordinal);
		}

		public override object GetValue(int ordinal)
		{
			return dr.GetValue(ordinal);
		}

		public override int GetValues(object[] values)
		{
			return dr.GetValues(values);
		}

		public override bool IsDBNull(int ordinal)
		{
			return dr.IsDBNull(ordinal);
		}

		public override bool NextResult()
		{
			return dr.NextResult();
		}

		public override bool Read()
		{
			return dr.Read();
		}

		public override DataTable GetSchemaTable()
		{
			return dr.GetSchemaTable();
		}

		public ReadOnlyCollection<DbColumn> GetColumnSchema()
		{
			return dr.GetColumnSchema();
		}
	}
}

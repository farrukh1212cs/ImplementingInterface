using ImplementingInterface.Enums;
using System;
using System.Collections.Generic;

namespace ImplementingInterface.Interface
{
    public interface ITableReader<T>
    {
        IReadOnlyList<(string, FieldType)> Columns { get; }
        bool Read();
        T GetString(IDataConverter<T> converter, int ordinal);
        T GetNumber(IDataConverter<T> converter, int ordinal);
        T GetDateTime(IDataConverter<T> converter, int ordinal);
        T GetBoolean(IDataConverter<T> converter, int ordinal);
    }


    public class TableReader<T> : ITableReader<T> where T : class
    {
        private readonly IDataConverter<T> _dataConverter;
        public TableReader(IDataConverter<T> dataConverter)
        {
            _dataConverter = dataConverter;
        }
        public IReadOnlyList<(string, FieldType)> Columns => throw new NotImplementedException();

        public T GetBoolean(IDataConverter<T> converter, int ordinal)
        {
            return _dataConverter.ConvertBoolean(converter.ToString(), true);
        }

        public T GetDateTime(IDataConverter<T> converter, int ordinal)
        {
            return _dataConverter.ConvertDateTime(converter.ToString(), DateTime.Now);
        }

        public T GetNumber(IDataConverter<T> converter, int ordinal)
        {
            return _dataConverter.ConvertNumber(converter.ToString(), 0);
        }

        public T GetString(IDataConverter<T> converter, int ordinal)
        {
            return _dataConverter.ConvertString(converter.ToString(), "");
        }

        public bool Read()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;

namespace ImplementingInterface.Interface
{
    public interface IDataConverter<T>
    {
        T ConvertString(string name, string value);
        T ConvertNumber(string name, decimal? value);
        T ConvertDateTime(string name, DateTime value);
        T ConvertBoolean(string name, bool value);
        T ConvertTable(string name, ITableReader<T> reader);
        T ConvertRecord(string name, IEnumerable<KeyValuePair<string, T>> fields);
    }


    public class DataConverter<T> : IDataConverter<T> where T : IConvertible
    {
        public T ConvertBoolean(string name, bool value)
        {

            try
            {
                return (T)(object)Convert.ToBoolean(name);
            }
            catch (Exception)
            {

                return (T)(object)value;
            }
            
        }

        public T ConvertDateTime(string name, DateTime value) 
        {
            try
            {
                return (T)(object)Convert.ToDateTime(name);
            }
            catch (Exception)
            {
                return (T)(object)value;
            }

                      
           
        }

        public T ConvertNumber(string name, decimal? value)
        {
            try
            {
                return (T)(object)Convert.ToInt32(name);
            }
            catch (Exception)
            {
                return (T)(object)value;
            }
            
           
        }

      

        public T ConvertString(string name, string value)
        {
            try
            {
                return (T)(object)name.ToString();
            }
            catch (Exception)
            {
                return (T)(object)value;
            }
        
        }

        public T ConvertRecord(string name, IEnumerable<KeyValuePair<string, T>> fields)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            return (T)(object)fields;
        }
        public T ConvertTable(string name, ITableReader<T> reader)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }

            return (T)(object)reader;
        }
    }
}

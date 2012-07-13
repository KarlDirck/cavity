﻿namespace Cavity
{
    using System;
    using System.Collections;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    using Cavity.Data;

    public static class JsonObjectExtensionMethods
    {
        public static string JsonSerialize(this object value)
        {
            if (null == value)
            {
                return null;
            }

            using (var stream = new MemoryStream())
            {
                using (var writer = new JsonWriter(stream))
                {
                    var list = value as IEnumerable;
                    if (value.GetType().IsArray)
                    {
                        writer.Array();
                        writer.JsonSerializeList(list);
                    }
                    else if (null == list)
                    {
                        writer.Object();
                        writer.JsonSerializeObject(value);
                    }
                    else
                    {
                        writer.Array();
                        writer.Object();
                        writer.JsonSerializeObject(value);
                        writer.EndArray();
                    }
                }

                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        private static bool JsonSerializeBaseClassLibraryType(this JsonWriter writer, 
                                                              string name, 
                                                              object value)
        {
            if (null == value)
            {
                if (null == name)
                {
                    writer.ArrayNull();
                }
                else
                {
                    writer.NullPair(name);
                }

                return true;
            }

            if (writer.JsonSerializeBuiltInType(name, value))
            {
                return true;
            }

            if (value is DateTime)
            {
                if (null == name)
                {
                    writer.ArrayValue((DateTime)value);
                }
                else
                {
                    writer.Pair(name, (DateTime)value);
                }

                return true;
            }

            if (value is DateTimeOffset)
            {
                if (null == name)
                {
                    writer.ArrayValue((DateTimeOffset)value);
                }
                else
                {
                    writer.Pair(name, (DateTimeOffset)value);
                }

                return true;
            }

            if (value is Guid)
            {
                if (null == name)
                {
                    writer.ArrayValue((Guid)value);
                }
                else
                {
                    writer.Pair(name, (Guid)value);
                }

                return true;
            }

            if (value is TimeSpan)
            {
                if (null == name)
                {
                    writer.ArrayValue((TimeSpan)value);
                }
                else
                {
                    writer.Pair(name, (TimeSpan)value);
                }

                return true;
            }

            if (value is Enum)
            {
                if (null == name)
                {
                    writer.ArrayValue(value.ToString());
                }
                else
                {
                    writer.Pair(name, value.ToString());
                }

                return true;
            }

            var uri = value as Uri;
            if (null != uri)
            {
                if (null == name)
                {
                    writer.ArrayValue(uri);
                }
                else
                {
                    writer.Pair(name, uri);
                }

                return true;
            }

            if (0 == value.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance).Length)
            {
                if (null == name)
                {
                    writer.ArrayValue(value.ToString());
                }
                else
                {
                    writer.Pair(name, value.ToString());
                }

                return true;
            }

            ////writer.Object();
            ////writer.JsonSerializeObject(value);
            return false;
        }

        private static bool JsonSerializeBuiltInType(this JsonWriter writer, 
                                                     string name, 
                                                     object value)
        {
            if (writer.JsonSerializeIntegralType(name, value))
            {
                return true;
            }

            if (writer.JsonSerializeFloatingPointType(name, value))
            {
                return true;
            }

            if (value is bool)
            {
                if (null == name)
                {
                    writer.ArrayValue((bool)value);
                }
                else
                {
                    writer.Pair(name, (bool)value);
                }

                return true;
            }

            if (value is decimal)
            {
                if (null == name)
                {
                    writer.ArrayValue((decimal)value);
                }
                else
                {
                    writer.Pair(name, (decimal)value);
                }

                return true;
            }

            var str = value as string;
            if (null != str)
            {
                if (null == name)
                {
                    writer.ArrayValue(str);
                }
                else
                {
                    writer.Pair(name, str);
                }

                return true;
            }

            return false;
        }

        private static bool JsonSerializeFloatingPointType(this JsonWriter writer, 
                                                           string name, 
                                                           object value)
        {
            if (value is double)
            {
                if (null == name)
                {
                    writer.ArrayValue((double)value);
                }
                else
                {
                    writer.Pair(name, (double)value);
                }

                return true;
            }

            if (value is float)
            {
                if (null == name)
                {
                    writer.ArrayValue((float)value);
                }
                else
                {
                    writer.Pair(name, (float)value);
                }

                return true;
            }

            return false;
        }

        private static bool JsonSerializeIntegralType(this JsonWriter writer, 
                                                      string name, 
                                                      object value)
        {
            if (value is byte)
            {
                if (null == name)
                {
                    writer.ArrayValue((byte)value);
                }
                else
                {
                    writer.Pair(name, (byte)value);
                }

                return true;
            }

            if (value is char)
            {
                if (null == name)
                {
                    writer.ArrayValue((char)value);
                }
                else
                {
                    writer.Pair(name, (char)value);
                }

                return true;
            }

            if (value is short)
            {
                if (null == name)
                {
                    writer.ArrayValue((short)value);
                }
                else
                {
                    writer.Pair(name, (short)value);
                }

                return true;
            }

            if (value is int)
            {
                if (null == name)
                {
                    writer.ArrayValue((int)value);
                }
                else
                {
                    writer.Pair(name, (int)value);
                }

                return true;
            }

            if (value is long)
            {
                if (null == name)
                {
                    writer.ArrayValue((long)value);
                }
                else
                {
                    writer.Pair(name, (long)value);
                }

                return true;
            }

            return false;
        }

        private static void JsonSerializeList(this JsonWriter writer, 
                                              IEnumerable list)
        {
            foreach (var item in list)
            {
                if (null == item)
                {
                    continue;
                }

                writer.Object();
                writer.JsonSerializeObject(item);
            }

            writer.EndArray();
        }

        private static void JsonSerializeObject(this JsonWriter writer, 
                                                object obj)
        {
            if (null == obj)
            {
                return;
            }

            var properties = obj
                .GetType()
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .ToList();
            foreach (var property in properties)
            {
                if (!property.CanRead)
                {
                    continue;
                }

                if (0 != property.GetIndexParameters().Length)
                {
                    continue;
                }

                var ignore = property.GetCustomAttributes(typeof(JsonIgnoreAttribute), true);
                if (0 != ignore.Length)
                {
                    continue;
                }

                var name = property.Name.ToCamelCase();
                foreach (JsonNameAttribute attribute in property.GetCustomAttributes(typeof(JsonNameAttribute), true))
                {
                    name = attribute.Name;
                }

                var value = property.GetValue(obj, null);

                if (writer.JsonSerializeBaseClassLibraryType(name, value))
                {
                    continue;
                }

                ////if (0 == value.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance).Length)
                ////{
                ////    writer.Pair(name, value.ToString());
                ////    continue;
                ////}

                ////if (value is ValueType)
                ////{
                ////    if (0 == properties.Count)
                ////    {
                ////        writer.Pair(name, value.ToString());
                ////        continue;
                ////    }
                ////}
                writer.Object(name);
                writer.JsonSerializeObject(value);
            }

            var list = obj as IEnumerable;
            if (null != list)
            {
                writer.Array("items");
                foreach (var item in list)
                {
                    if (writer.JsonSerializeBaseClassLibraryType(null, item))
                    {
                        continue;
                    }

                    ////if (item is ValueType)
                    ////{
                    ////    if (0 == properties.Count)
                    ////    {
                    ////        writer.ArrayValue(item.ToString());
                    ////        continue;
                    ////    }
                    ////}
                    writer.Object();
                    writer.JsonSerializeObject(item);
                }

                writer.EndArray();
            }

            writer.EndObject();
        }

        [SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Justification = "Camel casing starts with a lower case letter.")]
        private static string ToCamelCase(this string value)
        {
            if (null == value)
            {
                throw new ArgumentNullException("value");
            }

            value = value.Trim();
            if (0 == value.Length)
            {
                throw new ArgumentNullException("value");
            }

            return value[0].ToString(CultureInfo.InvariantCulture).ToLowerInvariant() + value.Substring(1);
        }
    }
}
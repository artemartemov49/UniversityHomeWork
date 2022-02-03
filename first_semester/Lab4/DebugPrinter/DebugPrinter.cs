using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DebugInfoPrinter
{
    public class DebugPrinter
    {
        private readonly List<object> _obj = new();
        public DebugPrinter(object p1, object p2)
        {
            _obj.Add(p1);
            _obj.Add(p2);
        }
        public DebugPrinter(object p1, object p2, object p3) : this(p1, p2)
        {
            _obj.Add(p3);
        }

        public DebugPrinter(params object[] obj)
        {
            _obj.AddRange(obj);
        }


        public static void PrintArgumentsInfoInDebug(params object[] parameters)
        {
            var res = GetMethodInfoArguments(parameters);
            Debug.Print(res);
        }

        private static string GetMethodInfoArguments(IEnumerable<object> parameters)
        {
            var sb = new StringBuilder();
            foreach (var p in parameters)
            {
                sb.Append(p.GetType() + ": " + p);
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }


        public void PrintPropInfoOfClasses()
        {
            var props = GetPropsInClasses();
            Debug.Print(props);
        }
        private string GetPropsInClasses()
        {
            var sb = new StringBuilder();
            foreach (var p in _obj)
            {
                var className = p.GetType().Name;
                sb.Append($"{className}: ");
                sb.Append(Environment.NewLine);
                sb.Append($"    {GetPropInfo(p)}");
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }

        private static string GetPropInfo(object obj)
        {
            var props = from p in obj.GetType().GetProperties()
                select $"{p.Name}: {p.GetValue(obj, null)}";

            return string.Join(", ", props);
        }

    }
}

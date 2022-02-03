using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Task1
{
    internal abstract class FieldsGetter
    {
        public static void PrintArgumentsInDebug(params object[] parameters)
        {
            var res = GetArguments(parameters);
            Debug.Print(res);
        }

        private static string GetArguments(IEnumerable<object> parameters)
        {
            var sb = new StringBuilder();
            foreach (var p in parameters)
            {
                sb.Append(p.GetType() + ": " + p);
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestRef
{
    static internal class Reflector
    {
        static private Type GetType(object obj)
        {
            return obj.GetType();

        }
        static private Type GetType(string name)
        {
            return Type.GetType(name);

        }

        public static string GetAssemblyName(string obj)
        {
            return GetType(obj).Assembly.GetName().Name;
        }
        public static string GetAssemblyName(object obj)
        {
            return GetType(obj).Assembly.GetName().Name;
        }
        public static bool HasPublicConstructor(string obj)
        {

            return GetType(obj).GetConstructors(BindingFlags.Public | BindingFlags.Instance).Length > 0;
        }
        public static IEnumerable<string> GetMethods(string obj)
        {
            return GetType(obj).GetMethods(BindingFlags.Public | BindingFlags.Instance).Select(method => method.Name);
        }
        public static IEnumerable<string> GetProperties(string obj)
        {
            return GetType(obj).GetProperties(BindingFlags.Public | BindingFlags.Instance).Select(property => property.Name);
        }
        public static IEnumerable<string> GetPublicFields(string obj)
        {
            return GetType(obj).GetFields(BindingFlags.Public | BindingFlags.Instance).Select(fieldInfo => fieldInfo.Name);

        }
        public static IEnumerable<string> GetInterfaces(string obj)
        {
            return GetType(obj).GetInterfaces().Select(inter => inter.Name);
        }

        public static IEnumerable<string> GetMethodsWithParameter(string obj, string parameterType)
        {
            return GetType(obj).GetMethods(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Where(methodInfo => methodInfo.GetParameters().Where(parameterInfo => parameterInfo.ParameterType == GetType(parameterType)).Count() > 0).Select(methodInfo => methodInfo.Name);
        }

        public static Object Invoke(object obj, string objName, object[] args)
        {
            return GetType(obj).GetMethods(BindingFlags.Public | BindingFlags.Instance).Where(name => name.Name == objName).FirstOrDefault().Invoke(obj, args);
        }

        public static T Create<T>(string obj, object[] args)
        {


            var constructor = GetType(obj).GetConstructor(BindingFlags.Public | BindingFlags.Instance, null, args.Select(a => a.GetType()).ToArray(), null);



            return (T)constructor.Invoke(args);
        }

    }
}

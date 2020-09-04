using System;
using System.Web.Script.Serialization;
using System.IO;

namespace _01_Generics
{
    class Serializador
    {
        public static void Serializar(Object obj)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\roniv\Documents\CSharpAvancado\03_" + obj.GetType().Name + ".txt");

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string objSerializado = serializador.Serialize(obj);

            sw.Write(objSerializado);
            sw.Close();

        }

        public static T Deserializar<T>()
        {
            StreamReader sr = new StreamReader(@"C:\Users\roniv\Documents\CSharpAvancado\03_"+ typeof(T).Name +".txt");
            string conteudo = sr.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            T obj = (T)serializador.Deserialize(conteudo,typeof(T));

            return obj;
        }
    }
}

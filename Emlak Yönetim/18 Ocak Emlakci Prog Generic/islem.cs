using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace _18_Ocak_Emlakci_Prog_Generic
{
    public class islem<A>
    {
        private static List<A> Veriler { get; set; } = new List<A>();

       
        public static void Ekle(A veri)
        {
            Veriler.Add(veri);
            Kaydet();
        }
        public static void Sil (int IndexNo)
        {
            Veriler.RemoveAt(IndexNo);
            Kaydet();
        }
        public static void Duzenle (int IndexNo, A veri) {

            Veriler[IndexNo] = veri;
            Kaydet();
        }
        public static void Kaydet()
        {
            JavaScriptSerializer s = new JavaScriptSerializer();
            string bura = s.Serialize(Veriler);
            File.WriteAllText("C:\\mustafaaltay\\verilerim\\"+typeof(A).FullName+".txt", bura);
            
        }
        public static A GetDataWithIndex(int index)
        {
            return Veriler[index];
        }


            public static List<A> Yukle()
        {
            if (Veriler == null | Veriler.Count<1)
            {
                if (!File.Exists("C:\\mustafaaltay\\verilerim\\"+typeof(A).FullName+".txt"))
                    File.Create("C:\\mustafaaltay\\verilerim\\"+typeof(A).FullName+".txt");
                
                JavaScriptSerializer s = new JavaScriptSerializer();
                string bura = File.ReadAllText("C:\\mustafaaltay\\verilerim\\"+typeof(A).FullName+".txt");
                List<A> data = s.Deserialize<List<A>>(bura);

                if (data == null)
                {
                    Veriler = new List<A>();
                }
                else
                    Veriler = data;
            }
            return Veriler.ToList();

        }
    }
}

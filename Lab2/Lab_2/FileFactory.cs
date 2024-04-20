using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab2
{
    public static class FileFactory
    {
        public static bool luuFile(List<Student> dsSV, string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dsSV);
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Student> docFile(string path)
        {
            List<Student> dsSV = new List<Student>();
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                object data = bf.Deserialize(fs);
                dsSV = data as List<Student>;
                fs.Close();
                return dsSV;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

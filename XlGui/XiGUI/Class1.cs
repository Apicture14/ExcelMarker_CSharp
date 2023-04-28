using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using DocumentFormat.OpenXml.Wordprocessing;

namespace XlUtils
{
    public class Utils
    {
        public static string[] read(string path, string key)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    byte[] ver = new byte[4];
                    byte[] k = new byte[4];
                    byte[] v = new byte[4];
                    byte[] m = new byte[4];
                    //fs.Read(ver);
                    //int vers = BitConverter.ToInt32(ver);
                    fs.Read(k, 0, 4);
                    if (Encoding.UTF8.GetString(k) != key)
                    {
                        MessageBox.Show("Not Fit Cfg", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    //fs.Seek(4,SeekOrigin.Begin);
                    fs.Read(k, 0, k.Length);
                    //fs.Seek(4, SeekOrigin.Current);
                    fs.Read(v, 0, k.Length);
                    fs.Read(m);
                    int a = BitConverter.ToInt32(k, 0), b = BitConverter.ToInt32(v, 0), c = BitConverter.ToInt32(m, 0);
                    string[] t = new string[a + b + c];
                    for (int i = 0; i < a; i++)
                    {
                        byte[] aa = new byte[6];
                        fs.Read(aa);
                        //fs.Seek(6, SeekOrigin.Current);
                        t[i] = Encoding.UTF8.GetString(aa);
                    }
                    for (int i = 0; i < b; i++)
                    {
                        byte[] bb = new byte[9];
                        fs.Read(bb);
                        //fs.Seek(12, SeekOrigin.Current);
                        t[a + i] = Encoding.UTF8.GetString(bb);
                    }
                    for (int i = 0; i < c; i++)
                    {
                        byte[] cc = new byte[12];
                        fs.Read(cc);
                        //fs.Seek(12, SeekOrigin.Current);
                        t[a + b + i] = Encoding.UTF8.GetString(cc);
                    }
                    return t;

                }
            }catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return null;
            }
        }
        public static bool? gen(string t,string key,string n)
        {
            try
            {
                string[] a = t.Split("|");
                List<string> tw = new List<string>();
                List<string> th = new List<string>();
                List<string> fo = new List<string>();
                int x = 0, y = 0, z = 0;
                byte[] k = Encoding.UTF8.GetBytes(key);
                byte[]? c = null;
                foreach (string s in a)
                {
                    if (s.Length == 2)
                    {
                        x++;
                        tw.Add(s);
                    }
                    else if (s.Length == 3)
                    {
                        y++;
                        th.Add(s);
                    }
                    else if (s.Length == 4)
                    {
                        z++;
                        fo.Add(s);
                    }


                }
                tw = tw.Union(th).ToList();
                tw = tw.Union(fo).ToList();
                if (File.Exists($"./{n}.ycf"))
                {
                    File.Delete($"./{n}.ycf");
                }
                using (FileStream fs = new FileStream($"./{n}.ycf", FileMode.OpenOrCreate))
                {
                    fs.Write(k);
                    fs.Write(BitConverter.GetBytes(x));
                    fs.Write(BitConverter.GetBytes(y));
                    fs.Write(BitConverter.GetBytes(z));
                    foreach (var e in tw)
                    {
                        fs.Write(Encoding.UTF8.GetBytes(e));
                    }
                    fs.Close();
                }
                return true;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static string seqPrint(string[] t,string seperator = "|"){
            try
            {
                string k = t[0];
                for (int i = 1; i < t.Length; i++)
                {
                    k += $"|{t[i]}";
                }
                return k;
            }catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static void cmdRun(string comm){
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.WriteLine(comm);
            MessageBox.Show(p.StandardOutput.ReadLine());
        }
        
    }
}

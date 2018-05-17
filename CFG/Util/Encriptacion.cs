using System;
using System.Web;

namespace Lucky.CFG.Util
{
    // Use of this class requires an AppSetting in web.config:
    //<appSettings>
    //	<add key="TamperProofKey" value="YourUglyRandomKeyLike-lkj54923c478" />
    //</appSettings>

    public class Encriptacion
    {
        //Function to encode the string
        static public string Codificar(string value, string key)
        {
            System.Security.Cryptography.MACTripleDES mac3des = new System.Security.Cryptography.MACTripleDES();
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            mac3des.Key = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(key));
            return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(value)) + System.Convert.ToChar("-") + System.Convert.ToBase64String(mac3des.ComputeHash(System.Text.Encoding.UTF8.GetBytes(value)));
        }

        //Function to decode the string
        //Throws an exception if the data is corrupt
        static public string DesCodificar(string value, string key)
        {
            String dataValue = "";
            String calcHash = "";
            String storedHash = "";

            System.Security.Cryptography.MACTripleDES mac3des = new System.Security.Cryptography.MACTripleDES();
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            mac3des.Key = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(key));

            try
            {
                dataValue = System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(value.Split(System.Convert.ToChar("-"))[0]));
                storedHash = System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(value.Split(System.Convert.ToChar("-"))[1]));
                calcHash = System.Text.Encoding.UTF8.GetString(mac3des.ComputeHash(System.Text.Encoding.UTF8.GetBytes(dataValue)));

                if (storedHash != calcHash)
                {
                    //Data was corrupted
                    throw new ArgumentException("N");
                    //This error is immediately caught below
                }

            }
            catch (System.Exception)
            {
                throw new ArgumentException("Codigo invalido");
            }
            return dataValue;
        }

        static public string QueryStringEncode(string value, string key)
        {
            return System.Web.HttpUtility.UrlEncode(Codificar(value, key));

        }

        static public string QueryStringDecode(string value, string key)
        {
            return DesCodificar(value, key);
        }
    }
}
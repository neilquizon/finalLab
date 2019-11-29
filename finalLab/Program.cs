using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;


namespace finalLab
{
    class Program
    {

        static void Main(string[] args)
        {
            const string URL = "https://opendata.vancouver.ca/api/records/1.0/search/?dataset=food-vendors&rows=91";
            string jsonString = CallRestMethod(new Uri(URL));
            Rootobject rootObject = JsonConvert.DeserializeObject<Rootobject>(jsonString);

            //Console.WriteLine(jsonString);
            //Console.ReadLine();

            //now I would convert each record to a FoodCart and add to dtabase...
            // once all are added I would db.SaveChanges()

            FoodCartContext db = new FoodCartContext();
            foreach (Record cart in rootObject.records)
            {
                db.Add(new FoodCart

                {
                    key = cart.fields.key,
                    status = cart.fields.status,
                    description = cart.fields.description,
                    geo_localarea = cart.fields.geo_localarea,                    
                    longitude = cart.fields.geom.coordinates[0],
                    latitude = cart.fields.geom.coordinates[1],
                    location = cart.fields.location,
                    vendor_type = cart.fields.vendor_type,
                    business_name = cart.fields.business_name

                   
                });
            }
            db.SaveChanges();
        }
        

        static string CallRestMethod(Uri uri)
        { 
            try
            {
               
                // Create a web request for the given uri
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);

                // Get the web response from the api    
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                // Get a stream to read the reponse
                StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                string stringResponse = sr.ReadToEnd();
                response.Close();
                sr.Close();
                return stringResponse;


            }

            catch (Exception e)
            {
                return $"{{'Message': 'Error occured. {uri.LocalPath}.\n{e.Message}}}";
            }
           

        }
    }
}

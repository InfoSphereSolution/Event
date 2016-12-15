using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using Event.Model;

namespace Event.App_WebService
{
    /// <summary>
    /// Summary description for Services
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Services : System.Web.Services.WebService
    {

        string ConnectionString = ConfigurationManager.ConnectionStrings["DBEvent"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;


        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void fetchServices()
        {
            List<OfferedServices> listServices = new List<OfferedServices>();
            using (con = new SqlConnection(ConnectionString))
            {
                cmd = new SqlCommand("select ID ,Name, ImageURL, [Description], Category, HashTag from Services", con);
                con.Open();
                reader = cmd.ExecuteReader();                
                while (reader.Read())
                {
                    OfferedServices offeredServices = new OfferedServices();
                    offeredServices.ID = Convert.ToInt32(reader["ID"]);
                    offeredServices.Name = Convert.ToString(reader["Name"]);
                    offeredServices.ImageURL = Convert.ToString(reader["ImageURL"]);
                    offeredServices.Description = Convert.ToString(reader["Description"]);
                    offeredServices.Category = Convert.ToString(reader["Category"]);
                    offeredServices.HashTag = Convert.ToString(reader["HashTag"]);
                    listServices.Add(offeredServices);
                }
                
            }
            Context.Response.Write(new JavaScriptSerializer().Serialize(listServices));
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]        
        public void addServices(OfferedServices OfferedServices)
        {
            using (con = new SqlConnection(ConnectionString))
            {
                //cmd = new SqlCommand("insert into Services(Name, ImageURL, [Description], Category, HashTag) values(@Name, @ImageURL, @Description, @Category, @HashTag)", con);
                //cmd.Parameters.AddWithValue("@Name", offeredServices.Name);
                //cmd.Parameters.AddWithValue("@ImageURL", offeredServices.ImageURL);
                //cmd.Parameters.AddWithValue("@Description", offeredServices.Description);
                //cmd.Parameters.AddWithValue("@Category", offeredServices.Category);
                //cmd.Parameters.AddWithValue("@HashTag", offeredServices.HashTag);
                //con.Open();
                //cmd.ExecuteNonQuery();                
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void deleteServices(Int32 ID)
        {
            using (con = new SqlConnection(ConnectionString))
            {
                //cmd = new SqlCommand("insert into Services(Name, ImageURL, [Description], Category, HashTag) values(@Name, @ImageURL, @Description, @Category, @HashTag)", con);
                //cmd.Parameters.AddWithValue("@Name", offeredServices.Name);
                //cmd.Parameters.AddWithValue("@ImageURL", offeredServices.ImageURL);
                //cmd.Parameters.AddWithValue("@Description", offeredServices.Description);
                //cmd.Parameters.AddWithValue("@Category", offeredServices.Category);
                //cmd.Parameters.AddWithValue("@HashTag", offeredServices.HashTag);
                //con.Open();
                //cmd.ExecuteNonQuery();                
            }
        }
    }
}

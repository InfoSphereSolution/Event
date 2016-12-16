using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Event.Model;

namespace EventWebAPI.Controllers
{    
    public class ValuesController : ApiController
    {

        string ConnectionString = ConfigurationManager.ConnectionStrings["DBEvent"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        
        // GET api/values
        public List<offeredServicesModel> Get()
        {
            List<offeredServicesModel> listServices = new List<offeredServicesModel>();
            using (con = new SqlConnection(ConnectionString))
            {
                cmd = new SqlCommand("select ID ,Name, ImageURL, [Description], Category, HashTag from Services", con);
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    offeredServicesModel offeredServices = new offeredServicesModel();
                    offeredServices.ID = Convert.ToInt32(reader["ID"]);
                    offeredServices.Name = Convert.ToString(reader["Name"]);
                    offeredServices.ImageURL = Convert.ToString(reader["ImageURL"]);
                    offeredServices.Description = Convert.ToString(reader["Description"]);
                    offeredServices.Category = Convert.ToString(reader["Category"]);
                    offeredServices.HashTag = Convert.ToString(reader["HashTag"]);
                    listServices.Add(offeredServices);
                }
            }
            //Configuration.Formatters.Remove(Configuration.Formatters.XmlFormatter);
            return listServices;
        }

        // GET api/values/5
        public HttpResponseMessage Get(int id)
        {
            List<offeredServicesModel> listServices = new List<offeredServicesModel>();
            using (con = new SqlConnection(ConnectionString))
            {
                cmd = new SqlCommand("select ID ,Name, ImageURL, [Description], Category, HashTag from Services where ID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(id));
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    offeredServicesModel offeredServices = new offeredServicesModel();
                    offeredServices.ID = Convert.ToInt32(reader["ID"]);
                    offeredServices.Name = Convert.ToString(reader["Name"]);
                    offeredServices.ImageURL = Convert.ToString(reader["ImageURL"]);
                    offeredServices.Description = Convert.ToString(reader["Description"]);
                    offeredServices.Category = Convert.ToString(reader["Category"]);
                    offeredServices.HashTag = Convert.ToString(reader["HashTag"]);
                    listServices.Add(offeredServices);
                }
            }
            //Configuration.Formatters.Remove(Configuration.Formatters.XmlFormatter);
            if (listServices.Count > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, listServices);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee not found...");
            }
        }

        // POST api/values
        public HttpResponseMessage Post(offeredServicesModel offeredServicesModel)
        {
            try
            {
                using (con = new SqlConnection(ConnectionString))
                {
                    cmd = new SqlCommand("insert into Services(Name, ImageURL, Description, Category, HashTag) values(@Name, @ImageURL, @Description, @Category, @HashTag)", con);
                    cmd.Parameters.AddWithValue("@Name", Convert.ToString(offeredServicesModel.Name));
                    cmd.Parameters.AddWithValue("@ImageURL", Convert.ToString(offeredServicesModel.ImageURL));
                    cmd.Parameters.AddWithValue("@Description", Convert.ToString(offeredServicesModel.Description));
                    cmd.Parameters.AddWithValue("@Category", Convert.ToString(offeredServicesModel.Category));
                    cmd.Parameters.AddWithValue("@HashTag", Convert.ToString(offeredServicesModel.HashTag));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    return Request.CreateResponse(HttpStatusCode.Created, "Emplyee created...");
                }
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }
        }

        // PUT api/values/5
        public HttpResponseMessage Put(int id, offeredServicesModel offeredServicesModel)
        {
            try
            {
                using (con = new SqlConnection(ConnectionString))
                {
                    cmd = new SqlCommand("update Services set Name = @Name, ImageURL = @ImageURL, [Description] = @Description, Category = @Category, HashTag = @HashTag where ID = @ID", con);
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(id));
                    cmd.Parameters.AddWithValue("@Name", Convert.ToString(offeredServicesModel.Name));
                    cmd.Parameters.AddWithValue("@ImageURL", Convert.ToString(offeredServicesModel.ImageURL));
                    cmd.Parameters.AddWithValue("@Description", Convert.ToString(offeredServicesModel.Description));
                    cmd.Parameters.AddWithValue("@Category", Convert.ToString(offeredServicesModel.Category));
                    cmd.Parameters.AddWithValue("@HashTag", Convert.ToString(offeredServicesModel.HashTag));
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, "Employee updated...");
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee not found...");
                    }

                }
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }
        }

        // DELETE api/values/5
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (con = new SqlConnection(ConnectionString))
                {
                    cmd = new SqlCommand("Delete from Services where ID = @ID", con);
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(id));
                    con.Open();
                    var i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                    else
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee not found...");
                    }
                }
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DbEntities;
using OperationsLogic;

namespace Catalogue
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Connection conn = new Connection();
                conn.SetQuery("SELECT * FROM USERS WHERE email = @Email and pass = @Pass");
                conn.SetParameters("@Email", txtEmail.Text);
                conn.SetParameters("@Pass", txtPass.Text);
                conn.ExecuteQuery();


                User user = new User();

                if(conn.Reader.Read())
                {
                    user.Id = int.Parse(conn.Reader["id"].ToString());
                    user.Email = conn.Reader["email"].ToString();
                    user.Pass = conn.Reader["pass"].ToString();
                    user.Name = conn.Reader["nombre"].ToString();
                    user.LastName = conn.Reader["apellido"].ToString();
                    user.UrlImagePerfil = conn.Reader["urlImagenPerfil"].ToString();
                    user.IsAdmin = (bool)conn.Reader["admin"];
                    Session.Add("User", user);
                }
                conn.CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
           
        }
    }

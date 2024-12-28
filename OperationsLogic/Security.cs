using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbEntities;

namespace OperationsLogic
{
    public class Security
    {
        //Catalogue
        bool isAdmin { get; set; }
        List<string> adminPage = new List<string> { "/Default.aspx", "/Login.aspx", "/FormArticle.aspx", "/AuthorizationAccesPage.aspx" ,"/ListArticle.aspx" };
        List<string> normalPage = new List<string> { "/Default.aspx", "/Login.aspx", "/AuthorizationAccesPage.aspx" };

        public Security(bool isAdmin)
        {
            this.isAdmin = isAdmin;
        }


        public bool IsAdmin(string pageCurrent)
        {
            List<string> listAvailablePages = GeneratingPages();
            if (listAvailablePages.Contains(pageCurrent))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string> GeneratingPages()
        {
            List<string> list = new List<string>();
            if (!isAdmin)
            {
                list = normalPage;
            }
            else
            {
                list = adminPage;
            }
            return list;
        }


    }
}

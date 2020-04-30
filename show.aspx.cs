using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.web.UI;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;

public partial class Show:System.Web.UI.Page
{
    string sqlconstr = ConfigurationManager.ConnectionStrings["StudentTeacherInquireSystemconnectionStrings"].ConnectionStrings;
    protected void Page_Load(object sender,EventArgs e){
        string objectValue = Session["object"].ToString();
        string wayValue = Session["way"].ToString();
        string keywordsValue = Session["keywords"].ToString();
        SqlConnection sqlcon = new SqlConnection(sqlconstr);
        
        if (objectValue =="学生"){

        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cp_Logout : System.Web.UI.Page
{
    protected void Page_Load(Object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!IsPostBack)
            {
                //Response.Cookies["Username"].Expires = DateTime.Now.AddSeconds(-1);
                Response.Cookies["Username"].Expires = DateTime.Now.AddSeconds(-1);
                Session.Clear();
                Session.Abandon();
            }
            Response.Redirect("Default.aspx", true);
        }
    }

    protected override void OnInit(EventArgs e)
    {
        Response.ClearHeaders();
        Response.AppendHeader("Cache-Control", "no-cache"); //HTTP 1.1
        Response.AppendHeader("Cache-Control", "private"); // HTTP 1.1
        Response.AppendHeader("Cache-Control", "no-store"); // HTTP 1.1
        Response.AppendHeader("Cache-Control", "must-revalidate"); // HTTP 1.1
        Response.AppendHeader("Cache-Control", "max-stale=0"); // HTTP 1.1 
        Response.AppendHeader("Cache-Control", "post-check=0"); // HTTP 1.1 
        Response.AppendHeader("Cache-Control", "pre-check=0"); // HTTP 1.1 
        Response.AppendHeader("Pragma", "no-cache"); // HTTP 1.1 
        Response.AppendHeader("Keep-Alive", "timeout=3, max=993"); // HTTP 1.1 
        Response.AppendHeader("Expires", "Mon, 26 Jul 1997 05:00:00 GMT"); // HTTP 1.1
        base.OnInit(e);
    }
}
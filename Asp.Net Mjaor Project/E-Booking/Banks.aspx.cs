﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DebitCard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void rbt1_CheckedChanged(object sender, EventArgs e)
    {
        Response.Redirect("DebitCard.aspx");
    }
    protected void rbt2_CheckedChanged(object sender, EventArgs e)
    {
        Response.Redirect("DebitCard.aspx");
    }
    protected void rbt3_CheckedChanged(object sender, EventArgs e)
    {
        Response.Redirect("DebitCard.aspx");
    }
    protected void rbt4_CheckedChanged(object sender, EventArgs e)
    {
        Response.Redirect("DebitCard.aspx");
    }
}
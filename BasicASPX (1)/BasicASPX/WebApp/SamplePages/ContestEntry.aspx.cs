using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class ContestEntry : System.Web.UI.Page
    {

        public static List<Class1> ndcollection;
        



        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
            if (!Page.IsPostBack)
            {
                ndcollection = new List<Class1>();
            }
        }

        //public static List<GridViewCollection> newcollection;
        

        protected void Submit_Click1(object sender, EventArgs e)
        {
            //validate the data coming in
            if (Page.IsValid)
            {
                //validate the user checking the terms
                if(Terms.Checked)
                {
                    //yes: create/load Entry, add to List, display List
                    string firstname = FirstName.Text;
                    string lastname = LastName.Text;
                    string streetaddress1 = StreetAddress1.Text;
                    string streetaddress2 = StreetAddress2.Text;
                    string city = City.Text;
                    string postalcode = PostalCode.Text;
                    string emailaddress = EmailAddress.Text;
                    int province = Province.SelectedIndex;


                    ndcollection.Add(new Class1(firstname, lastname, streetaddress1, streetaddress2));
                }
                else
                {
                    // no: message
                    Message.Text = "You did not agree to the terms of this contest. Entry is denied.";
                }
                
                
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            StreetAddress1.Text = "";
            StreetAddress2.Text = "";
            City.Text = "";
            PostalCode.Text = "";
            EmailAddress.Text = "";
            Province.SelectedIndex = 0;
            Terms.Checked = false;

        }
    }
}
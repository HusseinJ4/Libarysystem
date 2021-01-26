using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnAward : System.Web.UI.Page
{   //var to store the awardNo
    Int32 AwardBodyNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //copy the data from the query string to the variable
        AwardBodyNo = Convert.ToInt32(Request.QueryString["AwardBodyNo"]);
        //if the AwardBodyNo is not -1 then display the data from the record

        if(IsPostBack != true)
        {

            //update the contents of the drop down list
            if(AwardBodyNo != -1)
            {
                //display the data
                DisplayAwards(AwardBodyNo);
            }
            else
            {
                txtAwardBodyNo.Text = AwardBodyNo.ToString();
            }
        }
    }

    //this function displays the data for an Award on the webform

    void DisplayAwards(Int32 AwardBodyNo)
    {
        //create an instance of the award class
        clsAwardBody myBooklisting = new clsAwardBody();
        //find the record we want to display
        myBooklisting.FindAward(AwardBodyNo);
        //display the awardbodyno
        txtAwardBodyNo.Text = Convert.ToString(myBooklisting.AwardbodyNo);
        //display the awardbody name
        txtAwardBodyName.Text = myBooklisting.AwardbodyName;
        //display the date founded
        txtDateFounded.Text= myBooklisting.DateFounded.ToString("dd/MM/yyyy");
        //display the location
        txtLocation.Text = myBooklisting.Alocation;
    }

    protected void Abtnok_Click(object sender, EventArgs e)
    {
        //create an instance of award page class
        clsAwardBody thisAward = new clsAwardBody();
        //var to store any errors
        string Errormessage;
        //test the data on the web form
        Errormessage = thisAward.AwardValid(txtAwardBodyNo.Text, txtAwardBodyName.Text, txtDateFounded.Text, txtLocation.Text);

        if (Errormessage == "")
        {
            //creare a new instance of the award class
            clsAwardbodyCollection AwardCollection = new clsAwardbodyCollection();
            //do something with the data - insert or update
            //
            //if the Award number is -1
            if (txtAwardBodyNo.Text == "-1")
            {
                //copy the data form the interface to the object
                AwardCollection.ThisAwards.AwardbodyNo = Convert.ToInt32(txtAwardBodyNo.Text);
                AwardCollection.ThisAwards.AwardbodyName = txtAwardBodyName.Text;
                AwardCollection.ThisAwards.DateFounded = Convert.ToDateTime(txtDateFounded.Text);
                AwardCollection.ThisAwards.Alocation = txtLocation.Text;
                //add the new record
                AwardCollection.AddAward();
            }
            else
            {
                //this is an existing record
                //copy the data form the interface to the object
                AwardCollection.ThisAwards.AwardbodyNo = Convert.ToInt32(txtAwardBodyNo.Text);
                AwardCollection.ThisAwards.AwardbodyName = txtAwardBodyName.Text;
                AwardCollection.ThisAwards.DateFounded = Convert.ToDateTime(txtDateFounded.Text);
                AwardCollection.ThisAwards.Alocation = txtLocation.Text;
                //add the new record
                AwardCollection.Update();

            }
            //do something with the data - insert or update 
            //redirect back to the main page
            Response.Redirect("DefaultAward.aspx");
        }
        else
        {
            lblAwardError.Text = Errormessage;
        }
    }

    protected void ABtnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("DefaultAward.aspx");
    }
}
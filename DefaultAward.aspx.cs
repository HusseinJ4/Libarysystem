using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DefaultAward : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first appearance
        if(IsPostBack ==false)
        {
            //display the award
            DisplayAwards("");
        }
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        //redirect to the add new page
        Response.Redirect("AnAward.aspx?AwardBodyNo=-1");
    }

    protected void Btnview_Click(object sender, EventArgs e)
    {
        //var to store the primary key value
        Int32 AwardBodyNo;
        //check the list has been clicked first
        if(ListAward.SelectedIndex != -1)
        {
            //get the primary key valye from the list box
            AwardBodyNo = Convert.ToInt32(ListAward.SelectedValue);
            //redirect to the view page
            Response.Redirect("AnAward.aspx?AwardBodyNo=" + AwardBodyNo);

        }
    }

    protected void BtndisplayAllAward_Click(object sender, EventArgs e)
    {
        //display the awards
        DisplayAwards("");
    }


    Int32 DisplayAwards(String filterbyAwardlocation)
    {
        Int32 AwardbodyNo;//Var to store the primary key
        string AwardBodyName;//var to store the award body
        string Location;//var to store the location
        DateTime DateFounded;//var to store the date founded
        ;//create an instance of the award collection class
        clsAwardbodyCollection Booklisting = new clsAwardbodyCollection();
        Booklisting.ReportbyAwardbodyLocation(filterbyAwardlocation);
        Int32 RecordCount;//var to store the count of records
        Int32 Index = 0;//var to store the index of the loop
        RecordCount = Booklisting.Count;//get the count of records
        ListAward.Items.Clear();//clear the list Box
        while (Index < RecordCount) //while there are records to process
        {
            AwardbodyNo = Booklisting.AwardsList[Index].AwardbodyNo;//get the primary key
            AwardBodyName = Booklisting.AwardsList[Index].AwardbodyName;
            Location = Booklisting.AwardsList[Index].Alocation;
            DateFounded = Booklisting.AwardsList[Index].DateFounded;
            ListItem NewEntry = new ListItem(AwardBodyName + "" + Location + "" + DateFounded + "", AwardbodyNo.ToString());
            ListAward.Items.Add(NewEntry);// add the awards to the list
            Index ++;// move the insex to the next record
        }
        return RecordCount;//return the count record found 
    }

    protected void btnApplyAward_Click(object sender, EventArgs e)
    {
        //display the award
        DisplayAwards(TxtAwardbody.Text);

    }
}
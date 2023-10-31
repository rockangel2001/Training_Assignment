using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class assignment1: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Populate the dropdown list with items
                ddlItems.Items.Add(new ListItem("An Unexpected Gift", "An Unexpected Gift.jpg"));
                ddlItems.Items.Add(new ListItem("Everything I never told you", "Everything I never told you.jpg"));
                ddlItems.Items.Add(new ListItem("Her last wish", "Her last wish.jpg"));
                ddlItems.Items.Add(new ListItem("When I said I love You", "When I said I love You.jpg"));
                ddlItems.Items.Add(new ListItem("You are the best wife", "You are the best wife.jpg"));
            }
        }
        protected void ddlItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the image URL based on the selected item
            string selectedImageUrl = ddlItems.SelectedItem.Value;
            imgItem.ImageUrl = $"Image/{selectedImageUrl}";
        }

        protected void btnShowCost_Click(object sender, EventArgs e)
        {
            // Get the cost of the selected item (You can replace this with your actual cost logic)
            string selectedItem = ddlItems.SelectedItem.Text;
            string cost = GetItemCost(selectedItem);

            lblCost.Text = $"Cost of {selectedItem}: {cost}";
        }

        // You can implement your own cost retrieval logic here
        private string GetItemCost(string item)
        {
            // Replace this with your cost retrieval logic
            switch (item)
            {
                case "An Unexpected Gift":
                    return "Rs 120";
                case "Everything I never told you":
                    return "Rs 220";
                case "Her last wish":
                    return "Rs 150";
                case "When I said I love You":
                    return "Rs 285";
                case "You are the best wife":
                    return "Rs 300";
                default:
                    return "N/A";
            }
        }

    }
}
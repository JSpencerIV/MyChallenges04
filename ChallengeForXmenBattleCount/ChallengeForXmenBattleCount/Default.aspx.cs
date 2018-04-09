using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            // two arrays
            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };
            // two arrays

            string result = "";

            int LargestNumberIndex = 0;
            int SmallestNumberIndex = 0;

            for (int i = 0; i < names.Length; i++)
            {
                // Is this  the largest count so far?
                if (numbers[i] > numbers[LargestNumberIndex])
                {
                    LargestNumberIndex = i;
                }
                
                // Is this the Smallest count so far?
                if (numbers[i] < numbers[SmallestNumberIndex])
                {
                    SmallestNumberIndex = i;
                }

            }

            result = String.Format("Most battles belong to: {0} (Value: {1})", names[LargestNumberIndex], numbers[LargestNumberIndex]);
            result += String.Format("<br />Least battles belong to: {0} (value: {1})", names[SmallestNumberIndex], numbers[SmallestNumberIndex]); 

            resultLabel.Text = result;
        }
    }
}
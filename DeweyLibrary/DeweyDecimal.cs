using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyLibrary
{
    public class DeweyDecimal
    {
        //---------------------------------------------------------------------------------------//
        /// <summary>
        /// method to populate dictrionary with dewey data
        /// </summary>
        public static Dictionary<int, string> GetDewey()
        {
            //map dewey to corresponding dictionary
            Dictionary<int, string> dewey = new Dictionary<int, string>
                {
                    { 0, "General \nKnowledge" },
                    { 1, "Philosophy and \nPsychology" },
                    { 2, "Religion"},
                    { 3, "Social Sciences"},
                    { 4, "Language"},
                    { 5, "Science"},
                    { 6, "Technology"},
                    { 7, "Arts and \nRecreation"},
                    { 8, "Literature"},
                    { 9, "History and \nGeography"}
                };
            return dewey;
        }
        //---------------------------------------------------------------------------------------//
    }
}
//-----------------------------------------------oO END OF FILE Oo----------------------------------------------------------------------//
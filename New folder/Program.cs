//THIS IS FOR REFERENCE ONLY. YOU NEED NOT MAKE ANY CHANGES HERE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingACourse
{
    public class Program
    {
        public String ValidateNoOfCourse(int size)
        {
            if (size > 0 && size <= 20)
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }

        public String SearchCourse(String [] totalCourse,String course)
        {
            String result = "";
            int count = 0;

            for(int i=0;i<totalCourse.Length;i++)
            {
                if(totalCourse[i] == course)
                {
                    result = "Available";
                    break;
                }
                else
                {
                    count++;
                }
            }

            if(count == totalCourse.Length)
            {
                result = "Not Available";
            }

            return result;
        }
    }
}


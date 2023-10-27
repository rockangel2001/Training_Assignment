using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    public class Program
    {
        //public static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            AppEngine appEngine = new AppEngine();
            UserInterface userInterface = new UserInterface(appEngine);
            userInterface.ShowFirstScreen();
        }
    }
}
            
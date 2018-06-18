/* Quinn Parker-Joyes
 * June 18 2018
 * euler problem 3
 * large prime factor
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace eulerProblem3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   // number is what is being factored
        const long number = 600851475143;
        long newnumber = number;
        long largestFact = 0;
        int counter = 2;
        public MainWindow()
        {
            InitializeComponent();
            //while the counter times counter is less than the new number, which is initially equal to number
            while(counter * counter <= newnumber)
            {   //this if statement is for the final answer
                if(newnumber % counter == 0)
                {
                    
                    newnumber = newnumber / counter;
                    largestFact = counter;
                }
                //counter increases until the answer is eventually correct
                else
                {
                    counter++;
                }
            }
            if(newnumber > largestFact)
            {
                largestFact = newnumber;
            }
            MessageBox.Show(largestFact.ToString());
        }

    }
}

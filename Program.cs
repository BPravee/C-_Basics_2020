using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Program
    {
        static void Main_old(string[] args)
        {

          ILogger _logger  =new ConsoleLogger();
            PatientDataValidator _validator = new PatientDataValidator(_logger);
            _validator.Validate(null, null, null, null);

            _logger = new DBLogger();
            _validator = new PatientDataValidator(_logger);
            _validator.Validate(null, null, null, null);


        }

        static void Main_Command()
        {

            CommandTarget _target = new CommandTarget();
            Command _command = new Command(_target,"Foo");
            CommandSource _source = new CommandSource();
            _source.DoWork(_command);

            NewCommandTarget _newTarget = new NewCommandTarget();
            Command _newCommand = new Command(_newTarget, "Fun");
            _source.DoWork(_newCommand);
        }

        static void Main_Delegate()
        {
            BubbleSort _bubbleSortObj = new BubbleSort();
            QuickSort _quickSort = new QuickSort();

            BinarySearch _binSearch = new BinarySearch();
            //Delegate Instantiation 
            SortHandler _bubbleCommand = new SortHandler(_bubbleSortObj.Sort);

            _binSearch.Search("i", _bubbleCommand);

            SortHandler _binCommand = new SortHandler(_quickSort.Quick);
            _binSearch.Search("u", _binCommand);
              



        }

        static void Main()
        {

            Window window = new Window();
            window.Show();
            while (true)
            {
                Console.WriteLine("Press Any Key To Click Button");
                Console.ReadKey();
                window.SimulateClearButtonClick();
            }
        }
    }
}

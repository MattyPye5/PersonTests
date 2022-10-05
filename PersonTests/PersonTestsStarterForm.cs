namespace PersonTests
{
    /// <summary>
    /// Form to start the tests.
    /// </summary>
    public partial class PersonTestsStarterForm : Form
    {
        private int failedTests;

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonTestsStarterForm"/> class.
        /// </summary>
        public PersonTestsStarterForm()
        {
            this.InitializeComponent();
        }

        //private static int TestSize()
        //{
        //    Person person = new ("Test");
        //    if (person.Size == 4)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        MessageBox.Show("TestSize failed!");
        //        return 1;
        //    }
        //}

        //private static int TestReset()
        //{
        //    Person person = new ("Test");
        //    person.Reset();
        //    if (person.Name == string.Empty)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        MessageBox.Show("TestReset failed!");
        //        return 1;
        //    }
        //}

        //private static int TestCompare()
        //{
        //    Person firstPerson = new ("Alice");
        //    Person secondPerson = new ("Bob");
        //    if (firstPerson.CompareTo(secondPerson) < 0)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        MessageBox.Show("TestCompare failed!");
        //        return 1;
        //    }
        //}

        /// <summary>
        /// The TestDisplay method checks if the display method in the Person class is working properly.
        /// </summary>
        /// <returns> Returns a 0 for success or 1 for failure.
        /// </returns>
        private static int TestDisplay()
        {
            try
            {
                new Person("Bob").Display();
            }
            catch (Exception)
            {
                MessageBox.Show("TestDisplay failed!");
                return 1;
            }

            return 0;
        }

        private void RunTestsButton_Click(object sender, EventArgs e)
        {
            this.failedTests = 0;

            // Run feature tests here
            this.failedTests += TestDisplay();
            // this.failedTests += TestCompare();
            // this.failedTests += TestReset();
            // this.failedTests += TestSize();
            MessageBox.Show(this.failedTests.ToString() + " of 4 tests failed!");
        }
    }
}